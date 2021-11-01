
namespace SampleSearchSQLite
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        ///
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ProgressBarLogReport = new SampleSearchSQLite.CustomProgressBar();
            this.ReportList = new System.Windows.Forms.DataGridView();
            this.CDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxStartDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxStartUp = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxEndDown = new System.Windows.Forms.PictureBox();
            this.pictureBoxEndUp = new System.Windows.Forms.PictureBox();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.CheckCase0 = new System.Windows.Forms.CheckBox();
            this.CheckCase1 = new System.Windows.Forms.CheckBox();
            this.CheckCase2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReportList)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartUp)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndUp)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgressBarLogReport
            // 
            this.ProgressBarLogReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(179)))), ((int)(((byte)(226)))));
            this.ProgressBarLogReport.Location = new System.Drawing.Point(27, 71);
            this.ProgressBarLogReport.Name = "ProgressBarLogReport";
            this.ProgressBarLogReport.Size = new System.Drawing.Size(402, 40);
            this.ProgressBarLogReport.TabIndex = 36;
            this.ProgressBarLogReport.Text = null;
            this.ProgressBarLogReport.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.ProgressBarLogReport.TextColor = System.Drawing.SystemColors.ControlText;
            this.ProgressBarLogReport.TextFont = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgressBarLogReport.TextMargin = new System.Drawing.Point(1, 1);
            // 
            // ReportList
            // 
            this.ReportList.AllowUserToAddRows = false;
            this.ReportList.AllowUserToDeleteRows = false;
            this.ReportList.AllowUserToResizeColumns = false;
            this.ReportList.AllowUserToResizeRows = false;
            this.ReportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ReportList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ReportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(101)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(150)))), ((int)(((byte)(0)))));
            this.ReportList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ReportList.ColumnHeadersHeight = 45;
            this.ReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ReportList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CDate,
            this.CTime,
            this.CType,
            this.CDesc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ReportList.DefaultCellStyle = dataGridViewCellStyle4;
            this.ReportList.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ReportList.EnableHeadersVisualStyles = false;
            this.ReportList.Location = new System.Drawing.Point(0, 120);
            this.ReportList.Margin = new System.Windows.Forms.Padding(2);
            this.ReportList.MultiSelect = false;
            this.ReportList.Name = "ReportList";
            this.ReportList.ReadOnly = true;
            this.ReportList.RowHeadersVisible = false;
            this.ReportList.RowHeadersWidth = 38;
            this.ReportList.RowTemplate.Height = 40;
            this.ReportList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReportList.Size = new System.Drawing.Size(1006, 365);
            this.ReportList.TabIndex = 0;
            this.ReportList.SelectionChanged += new System.EventHandler(this.ReportList_SelectionChanged);
            this.ReportList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ReportList_MouseDown);
            // 
            // CDate
            // 
            this.CDate.FillWeight = 20F;
            this.CDate.HeaderText = "날짜";
            this.CDate.Name = "CDate";
            this.CDate.ReadOnly = true;
            this.CDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CTime
            // 
            this.CTime.FillWeight = 20F;
            this.CTime.HeaderText = "시간";
            this.CTime.Name = "CTime";
            this.CTime.ReadOnly = true;
            this.CTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CType
            // 
            this.CType.FillWeight = 15F;
            this.CType.HeaderText = "타입";
            this.CType.Name = "CType";
            this.CType.ReadOnly = true;
            this.CType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CDesc
            // 
            this.CDesc.FillWeight = 70F;
            this.CDesc.HeaderText = "설명";
            this.CDesc.Name = "CDesc";
            this.CDesc.ReadOnly = true;
            this.CDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CDesc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateTimePickerEnd
            // 
            this.DateTimePickerEnd.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerEnd.Location = new System.Drawing.Point(601, 14);
            this.DateTimePickerEnd.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerEnd.Name = "DateTimePickerEnd";
            this.DateTimePickerEnd.ShowUpDown = true;
            this.DateTimePickerEnd.Size = new System.Drawing.Size(313, 39);
            this.DateTimePickerEnd.TabIndex = 25;
            // 
            // DateTimePickerStart
            // 
            this.DateTimePickerStart.CalendarFont = new System.Drawing.Font("맑은 고딕", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerStart.Font = new System.Drawing.Font("맑은 고딕", 18.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateTimePickerStart.Location = new System.Drawing.Point(95, 14);
            this.DateTimePickerStart.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.DateTimePickerStart.Name = "DateTimePickerStart";
            this.DateTimePickerStart.ShowUpDown = true;
            this.DateTimePickerStart.Size = new System.Drawing.Size(313, 40);
            this.DateTimePickerStart.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label7.Location = new System.Drawing.Point(32, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 31);
            this.label7.TabIndex = 28;
            this.label7.Text = "시작";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(540, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 31);
            this.label1.TabIndex = 29;
            this.label1.Text = "종료";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxStartDown);
            this.panel1.Controls.Add(this.pictureBoxStartUp);
            this.panel1.Location = new System.Drawing.Point(389, 14);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 40);
            this.panel1.TabIndex = 35;
            // 
            // pictureBoxStartDown
            // 
            this.pictureBoxStartDown.BackColor = System.Drawing.Color.White;
            this.pictureBoxStartDown.BackgroundImage = global::SampleSearchSQLite.Properties.Resources.icon_pre;
            this.pictureBoxStartDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxStartDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStartDown.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxStartDown.Name = "pictureBoxStartDown";
            this.pictureBoxStartDown.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStartDown.TabIndex = 38;
            this.pictureBoxStartDown.TabStop = false;
            this.pictureBoxStartDown.Click += new System.EventHandler(this.PictureBoxStartDown_Click);
            // 
            // pictureBoxStartUp
            // 
            this.pictureBoxStartUp.BackColor = System.Drawing.Color.White;
            this.pictureBoxStartUp.BackgroundImage = global::SampleSearchSQLite.Properties.Resources.icon_next;
            this.pictureBoxStartUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxStartUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxStartUp.Location = new System.Drawing.Point(39, 0);
            this.pictureBoxStartUp.Name = "pictureBoxStartUp";
            this.pictureBoxStartUp.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxStartUp.TabIndex = 37;
            this.pictureBoxStartUp.TabStop = false;
            this.pictureBoxStartUp.Click += new System.EventHandler(this.PictureBoxStartUp_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxEndDown);
            this.panel2.Controls.Add(this.pictureBoxEndUp);
            this.panel2.Location = new System.Drawing.Point(894, 14);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(80, 40);
            this.panel2.TabIndex = 37;
            // 
            // pictureBoxEndDown
            // 
            this.pictureBoxEndDown.BackColor = System.Drawing.Color.White;
            this.pictureBoxEndDown.BackgroundImage = global::SampleSearchSQLite.Properties.Resources.icon_pre;
            this.pictureBoxEndDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxEndDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEndDown.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxEndDown.Name = "pictureBoxEndDown";
            this.pictureBoxEndDown.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxEndDown.TabIndex = 38;
            this.pictureBoxEndDown.TabStop = false;
            this.pictureBoxEndDown.Click += new System.EventHandler(this.PictureBoxEndDown_Click);
            // 
            // pictureBoxEndUp
            // 
            this.pictureBoxEndUp.BackColor = System.Drawing.Color.White;
            this.pictureBoxEndUp.BackgroundImage = global::SampleSearchSQLite.Properties.Resources.icon_next;
            this.pictureBoxEndUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxEndUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxEndUp.Location = new System.Drawing.Point(39, 0);
            this.pictureBoxEndUp.Name = "pictureBoxEndUp";
            this.pictureBoxEndUp.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxEndUp.TabIndex = 37;
            this.pictureBoxEndUp.TabStop = false;
            this.pictureBoxEndUp.Click += new System.EventHandler(this.PictureBoxEndUp_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ButtonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClear.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ButtonClear.Image = global::SampleSearchSQLite.Properties.Resources.icon_init;
            this.ButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonClear.Location = new System.Drawing.Point(857, 71);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Padding = new System.Windows.Forms.Padding(10, 0, 6, 0);
            this.ButtonClear.Size = new System.Drawing.Size(117, 40);
            this.ButtonClear.TabIndex = 32;
            this.ButtonClear.Text = "초기화";
            this.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonClear.UseVisualStyleBackColor = false;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.ButtonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(151)))), ((int)(((byte)(151)))));
            this.ButtonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(126)))), ((int)(((byte)(199)))));
            this.ButtonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSearch.Font = new System.Drawing.Font("맑은 고딕", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ButtonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.ButtonSearch.Image = global::SampleSearchSQLite.Properties.Resources.icon_search;
            this.ButtonSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonSearch.Location = new System.Drawing.Point(728, 71);
            this.ButtonSearch.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Padding = new System.Windows.Forms.Padding(10, 0, 13, 0);
            this.ButtonSearch.Size = new System.Drawing.Size(117, 40);
            this.ButtonSearch.TabIndex = 23;
            this.ButtonSearch.Text = "검색";
            this.ButtonSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonSearch.UseVisualStyleBackColor = false;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // CheckCase0
            // 
            this.CheckCase0.AutoSize = true;
            this.CheckCase0.Checked = true;
            this.CheckCase0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCase0.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCase0.ForeColor = System.Drawing.Color.Black;
            this.CheckCase0.Location = new System.Drawing.Point(453, 77);
            this.CheckCase0.Name = "CheckCase0";
            this.CheckCase0.Size = new System.Drawing.Size(78, 29);
            this.CheckCase0.TabIndex = 103;
            this.CheckCase0.Text = "case0";
            this.CheckCase0.UseVisualStyleBackColor = true;
            // 
            // CheckCase1
            // 
            this.CheckCase1.AutoSize = true;
            this.CheckCase1.Checked = true;
            this.CheckCase1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCase1.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCase1.ForeColor = System.Drawing.Color.Black;
            this.CheckCase1.Location = new System.Drawing.Point(540, 77);
            this.CheckCase1.Name = "CheckCase1";
            this.CheckCase1.Size = new System.Drawing.Size(78, 29);
            this.CheckCase1.TabIndex = 104;
            this.CheckCase1.Text = "case1";
            this.CheckCase1.UseVisualStyleBackColor = true;
            // 
            // CheckCase2
            // 
            this.CheckCase2.AutoSize = true;
            this.CheckCase2.Checked = true;
            this.CheckCase2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckCase2.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckCase2.ForeColor = System.Drawing.Color.Black;
            this.CheckCase2.Location = new System.Drawing.Point(627, 77);
            this.CheckCase2.Name = "CheckCase2";
            this.CheckCase2.Size = new System.Drawing.Size(78, 29);
            this.CheckCase2.TabIndex = 105;
            this.CheckCase2.Text = "case2";
            this.CheckCase2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1006, 485);
            this.Controls.Add(this.CheckCase2);
            this.Controls.Add(this.CheckCase1);
            this.Controls.Add(this.CheckCase0);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ReportList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.DateTimePickerEnd);
            this.Controls.Add(this.DateTimePickerStart);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ProgressBarLogReport);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Sample Search SQLite";
            this.Load += new System.EventHandler(this.UcSearchLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ReportList)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartUp)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEndUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.DataGridView ReportList;
        private System.Windows.Forms.DateTimePicker DateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker DateTimePickerStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxStartUp;
        private System.Windows.Forms.PictureBox pictureBoxStartDown;
        private CustomProgressBar ProgressBarLogReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxEndDown;
        private System.Windows.Forms.PictureBox pictureBoxEndUp;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDesc;
        private System.Windows.Forms.CheckBox CheckCase0;
        private System.Windows.Forms.CheckBox CheckCase1;
        private System.Windows.Forms.CheckBox CheckCase2;
    }
}

