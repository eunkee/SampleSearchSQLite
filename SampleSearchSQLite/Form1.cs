using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleSearchSQLite
{
    public partial class Form1 : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool HideCaret(IntPtr hWnd);

        private DateTime defaultStartdateTime;
        private DateTime defaultEnddateTime;
        private readonly DatabaseSQLite databaseSQLite = new()

        public Form1()
        {
            InitializeComponent();
        }

        private void UcSearchLog_Load(object sender, EventArgs e)
        {
            ProgressBarLogReport.Minimum = 0;
            ProgressBarLogReport.Maximum = 100;
            ProgressBarLogReport.Step = 1;

            DateTime ToDay = DateTime.Now;
            DateTime YesterDay = ToDay.AddDays(-1);
            defaultStartdateTime = new DateTime(YesterDay.Year, YesterDay.Month, YesterDay.Day, 00, 00, 00);
            DateTimePickerStart.Value = defaultStartdateTime;
            DateTimePickerStart.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            defaultEnddateTime = new DateTime(ToDay.Year, ToDay.Month, ToDay.Day, 23, 59, 59);
            DateTimePickerEnd.Value = defaultEnddateTime;
            DateTimePickerEnd.CustomFormat = "yyyy-MM-dd HH:mm:ss";
        }

        private delegate void CrossThreadSafetyProgress(int rowNum, int rowcount);
        public void SetProgressBarLogReport(int rowNum, int rowcount)
        {
            if (ProgressBarLogReport != null)
            {
                if (ProgressBarLogReport.InvokeRequired)
                {
                    try
                    {
                        if (ProgressBarLogReport != null)
                        {
                            ProgressBarLogReport.Invoke(new CrossThreadSafetyProgress(SetProgressBarLogReport), rowNum, rowcount);
                        }
                    }
                    finally { }
                }
                else
                {
                    try
                    {
                        if (rowcount != 0)
                        {
                            int percent = (int)(rowNum * 100 / rowcount);
                            ProgressBarLogReport.Value = percent;
                            ProgressBarLogReport.Text = $"{percent}% ({rowNum}/{rowcount})";
                        }
                        else
                        {
                            ProgressBarLogReport.Value = 100;
                            ProgressBarLogReport.Text = $"100% (0/0)";
                        }
                    }
                    finally { }
                }
            }
        }

        private CancellationTokenSource cts = null;

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!(CheckCase0.Checked || CheckCase1.Checked || CheckCase2.Checked))
            {
                MessageBox.Show("유형이 선택 되지 않았습니다.");
                return;
            }

            if (ReportList.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("로그를 초기화 합니까?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }

            if (cts != null)
            {
                cts.Cancel();
            }

            ProgressBarLogReport.Value = 0;
            ProgressBarLogReport.Text = "데이터를 로딩중입니다.";
            ReportList.Rows.Clear();

            ButtonClear.Text = "취소";
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            Task.Run(() =>
            {
                databaseSQLite.SelectProgramLog(DateTimePickerStart.Value, DateTimePickerEnd.Value, CheckCase0.Checked, CheckCase1.Checked, CheckCase2.Checked, out List<STRUCT_LOG> userlog);

                if (userlog != null)
                {
                    int rowcount = userlog.Count;

                    foreach (STRUCT_LOG data in userlog)
                    {
                        ReportList.Invoke((MethodInvoker)(() =>
                        {
                            ReportList.Rows.Add();
                        }));
                        int rowNum = ReportList.RowCount - 1;

                        SetProgressBarLogReport(rowNum, rowcount);

                        ReportList.Invoke((MethodInvoker)(() =>
                        {
                            //성능 이슈
                            //if (rowNum % 2 == 1)
                            //{
                            //    ReportList.Rows[rowNum].DefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
                            //}
                            //else
                            //{
                            //    ReportList.Rows[rowNum].DefaultCellStyle.BackColor = Color.White;
                            //}

                            string[] dateTime = data.date.ToString().Split(' ');
                            if (dateTime.Length >= 1)
                            {
                                ReportList[0, rowNum].Value = dateTime[0];
                                ReportList[1, rowNum].Value = dateTime[1];
                            }
                            ReportList[2, rowNum].Value = data.type;
                            ReportList[3, rowNum].Value = data.description;

                        }));

                        token.ThrowIfCancellationRequested();
                    }

                    SetProgressBarLogReport(rowcount, rowcount);
                }
                ButtonClear.Invoke((MethodInvoker)(() =>
                {
                    ButtonClear.Text = "초기화";
                }));
            }, token);
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            if (ButtonClear.Text == "취소")
            {
                DialogResult res = MessageBox.Show("검색을 취소합니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
                if (cts != null)
                {
                    cts.Cancel();
                }
                ButtonClear.Text = "초기화";
            }
            else
            {
                DialogResult res = MessageBox.Show("초기화 합니까?", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    return;
                }
            }

            var task0 = Task<int>.Run(() => Thread.Sleep(500));
            task0.ContinueWith(x =>
            {
                ProgressBarLogReport.Invoke((MethodInvoker)(() =>
                {
                    ProgressBarLogReport.Value = 0;
                    ProgressBarLogReport.Text = "";
                    ProgressBarLogReport.Invalidate();
                }));
                ReportList.Invoke((MethodInvoker)(() =>
                {
                    ReportList.ClearSelection();
                    ReportList.Rows.Clear();
                }));

                DateTimePickerStart.Invoke((MethodInvoker)(() =>
                {
                    DateTimePickerStart.Value = defaultStartdateTime;
                }));

                DateTimePickerEnd.Invoke((MethodInvoker)(() =>
                {
                    DateTimePickerEnd.Value = defaultEnddateTime;
                }));
            });
        }

        //그리드뷰를 선택하지 못하게 처리
        private void ReportList_MouseDown(object sender, MouseEventArgs e)
        {
            HideCaret(ReportList.Handle);
        }

        //그리드뷰를 선택하지 못하게 처리2
        private void ReportList_SelectionChanged(object sender, EventArgs e)
        {
            ReportList.ClearSelection();
        }

        #region 날짜 및 시간 조절 버튼
        private void PictureBoxStartUp_Click(object sender, EventArgs e)
        {
            if (DateTimePickerStart.Focused)
            {
                SendKeys.Send("{UP}");
            }
        }

        private void PictureBoxStartDown_Click(object sender, EventArgs e)
        {
            if (DateTimePickerStart.Focused)
            {
                SendKeys.Send("{DOWN}");
            }
        }

        private void PictureBoxEndUp_Click(object sender, EventArgs e)
        {
            if (DateTimePickerEnd.Focused)
            {
                SendKeys.Send("{UP}");
            }
        }

        private void PictureBoxEndDown_Click(object sender, EventArgs e)
        {
            if (DateTimePickerEnd.Focused)
            {
                SendKeys.Send("{DOWN}");
            }
        }
        #endregion 날짜 및 시간 조절 버튼
    }
}
