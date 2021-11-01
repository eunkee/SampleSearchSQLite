using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace SampleSearchSQLite
{
    class DatabaseSQLite
    {
        private static SQLiteConnection conn;
        private readonly string dBpath = @"C:\Users\Public\SampleSearchSQLite\DB";
        private readonly string filePath = @"C:\Users\Public\SampleSearchSQLite\DB\ccas2.db";

        private readonly object lockObject = new();

        public DatabaseSQLite()
        {
            Directory.CreateDirectory(dBpath);
            if (!File.Exists(filePath))
            {
                SQLiteConnection.CreateFile(filePath);
            }

            this.Open();
            this.CreateLogTbl();
        }

        private void Open()
        {
            conn = new SQLiteConnection($"Data Source={filePath};Version=3;Journal Mode=WAL;");
            conn.Open();
        }

        //Creat 프로그램 로그
        private void CreateLogTbl()
        {
            lock (lockObject)
            {
                SQLiteCommand cmd = new("SELECT COUNT(*) cnt FROM sqlite_master WHERE name = 'log'", conn);

                if (Convert.ToInt32(cmd.ExecuteScalar()) <= 0)
                {
                    cmd.CommandText = "CREATE TABLE log (timestamp DATETIME DEFAULT CURRENT_TIMESTAMP, type VARCHAR(10), log VARCHAR(254), sub1 VARCHAR(254), sub2 VARCHAR(254), sub3 VARCHAR(254));";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //INSERT 프로그램 로그
        public void InsertLogDB(string message, string type = "0", string sub1 = "", string sub2 = "", string sub3 = "")
        {
            //문자 길이가 DB제한보다 길 경우 예외처리
            if (message.Length > 254)
            {
                message = message.Substring(0, 250);
            }
            if (sub1.Length > 254)
            {
                sub1 = sub1.Substring(0, 250);
            }
            if (sub2.Length > 254)
            {
                sub2 = sub2.Substring(0, 250);
            }
            if (sub3.Length > 254)
            {
                sub3 = sub3.Substring(0, 250);
            }

            lock (lockObject)
            {
                using var cmd = new SQLiteCommand(conn);
                using var transaction = conn.BeginTransaction();
                try
                {
                    cmd.CommandText = $"INSERT INTO log VALUES(DATETIME('now', 'localtime'), '{type}' , '{message}' , '{sub1}' , '{sub2}' , '{sub3}');";
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        //SELECT 프로그램 LOG
        public void SelectProgramLog(DateTime sdateTime, DateTime edateTime, bool isCase0, bool isCase1, bool isCase2, out List<STRUCT_LOG> SearchUserLog)
        {
            lock (lockObject)
            {
                SearchUserLog = new List<STRUCT_LOG>();

                string stimestamp = string.Format("{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2}", sdateTime.Year, sdateTime.Month, sdateTime.Day, sdateTime.Hour, sdateTime.Minute, sdateTime.Second);
                string etimestamp = string.Format("{0:D4}-{1:D2}-{2:D2} {3:D2}:{4:D2}:{5:D2}", edateTime.Year, edateTime.Month, edateTime.Day, edateTime.Hour, edateTime.Minute, edateTime.Second);

                string sql = $"SELECT * FROM log WHERE (timestamp >='{stimestamp}' AND timestamp <= '{etimestamp}') ";

                //where 처리
                string whereSql = "AND (";
                int firstLength = whereSql.Length;
                //타입 0을 선택했다면
                if (isCase0)
                {
                    whereSql += "type == '0' ";
                }

                //타입 1을 선택했다면
                if (isCase1)
                {
                    //처음 길이와 같지 않으면
                    if (firstLength != whereSql.Length)
                    {
                        whereSql += "OR ";
                    }

                    whereSql += "type == '1' ";
                }

                //타입 2를 선택했다면
                if (isCase2)
                {
                    //처음 길이와 같지 않으면
                    if (firstLength != whereSql.Length)
                    {
                        whereSql += "OR ";
                    }
                    whereSql += "type == '2' ";
                }
                //처음 길이와 같지 않으면
                if (firstLength != whereSql.Length)
                {
                    whereSql += ")";
                    sql += whereSql;
                }

                Console.WriteLine(sql);
                SQLiteCommand cmd = new(sql, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        STRUCT_LOG sTRUCT = new()
                        {
                            date = DateTime.Parse(reader["timestamp"].ToString()).ToString("yyyy-MM-dd HH:mm:ss"),
                            type = reader["type"].ToString(),
                            description = reader["log"].ToString()
                        };
                        SearchUserLog.Add(sTRUCT);
                    }
                    reader.Close();
                }
            }
        }

        //DELETE 프로그램 로그
        //day 날짜 이전의 로그를 삭제
        public void DeleteLogDB(int day = -31)
        {
            lock (lockObject)
            {
                using var cmd = new SQLiteCommand(conn);
                using var transaction = conn.BeginTransaction();
                try
                {
                    cmd.CommandText = $"DELETE FROM log WHERE timestamp <= date('now', '{day} days');";
                    Console.WriteLine(cmd.CommandText);
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }
    }
}
