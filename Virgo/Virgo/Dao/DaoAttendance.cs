using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Virgo
{
    class DaoAttendance
    {
        private const string DB_FILE_NAME = "virgo.db";
        private static string TABLE_NAME = "Attendance";

        public string recordDate;
        public string roundRecordDate;
        public long   toWork;

        public DaoAttendance()
        {
            //コンストラクタ
        }

        /// <summary>
        /// Attendanceテーブルが存在しない場合CREATE TABLEを行う
        /// </summary>
        /// <returns>エラーメッセージ 正常終了の場合空文字</returns>
        public static string Setup()
        {
            string errMes = "";
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + DB_FILE_NAME))
                {
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("CREATE TABLE IF NOT EXISTS " + TABLE_NAME);
                        sql.AppendLine("(");
                        sql.AppendLine(" record_date TEXT,");
                        sql.AppendLine(" round_record_date TEXT,");
                        sql.AppendLine(" to_work INTEGER");
                        sql.AppendLine(")");

                        cmd.CommandText = sql.ToString();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errMes = e.ToString();
            }

            return errMes;
        }

        /// <summary>
        /// 記録日付の新しいデータを上限付きで取得
        /// </summary>
        /// <param name="daoAttendanceList">結果受け取りリスト</param>
        /// <param name="limit">LIMIT句で指定する行数</param>
        /// <returns>エラーメッセージ 正常終了の場合空文字</returns>
        public static string SelectAll(ref List<DaoAttendance> daoAttendanceList, int limit)
        {
            string errMes = "";
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + DB_FILE_NAME))
                {
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("SELECT");
                        sql.AppendLine(" *");
                        sql.AppendLine("FROM " + TABLE_NAME);
                        sql.AppendLine("ORDER BY");
                        sql.AppendLine(" DATE(record_date) DESC,");
                        sql.AppendLine(" TIME(record_date) DESC");
                        sql.AppendLine("LIMIT " + limit);

                        cmd.CommandText = sql.ToString();
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DaoAttendance attendance = new DaoAttendance();
                            attendance.recordDate      = reader.GetFieldValue<string>(reader.GetOrdinal("record_date"));
                            attendance.roundRecordDate = reader.GetFieldValue<string>(reader.GetOrdinal("round_record_date"));
                            attendance.toWork          = reader.GetFieldValue<long>  (reader.GetOrdinal("to_work"));

                            daoAttendanceList.Add(attendance);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                errMes = e.ToString();
            }

            return errMes;
        }

        /// <summary>
        /// 日付範囲による検索
        /// </summary>
        /// <param name="daoAttendanceList">検索結果格納用変数</param>
        /// <param name="fromDate">検索開始範囲</param>
        /// <param name="toDate">検索終了範囲</param>
        /// <returns>エラーメッセージ 正常終了の場合空文字</returns>
        public static string SelectFromTo(ref List<DaoAttendance> daoAttendanceList, DateTime fromDate, DateTime toDate)
        {
            string errMes = "";
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + DB_FILE_NAME))
                {
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("SELECT");
                        sql.AppendLine(" *");
                        sql.AppendLine("FROM " + TABLE_NAME);
                        sql.AppendLine("WHERE 1=1");
                        sql.AppendLine(" AND REPLACE([record_date],'/','-') >= @startDate");
                        sql.AppendLine(" AND REPLACE([record_date],'/','-') <= @endDate");
                        //MEMO:データの投入形式がyyyy/MM/ddとなっているため、REPLACEしないとWHERE文にマッチしない

                        cmd.Parameters.Add(new SQLiteParameter("startDate", fromDate));
                        cmd.Parameters.Add(new SQLiteParameter("endDate"  , toDate));

                        cmd.CommandText = sql.ToString();
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DaoAttendance attendance = new DaoAttendance();
                            attendance.recordDate      = reader.GetFieldValue<string>(reader.GetOrdinal("record_date"));
                            attendance.roundRecordDate = reader.GetFieldValue<string>(reader.GetOrdinal("round_record_date"));
                            attendance.toWork          = reader.GetFieldValue<long>  (reader.GetOrdinal("to_work"));

                            daoAttendanceList.Add(attendance);
                        }

                    }
                }
            }
            catch (Exception e)
            {
                errMes = e.ToString();
            }

            return errMes;
        }

        /// <summary>
        /// メンバ変数の値を使ってINSERTを行う
        /// </summary>
        /// <returns>エラーメッセージ 正常終了の場合空文字</returns>
        public string Insert()
        {
            string errMes = "";
            try
            {
                using (SQLiteConnection con = new SQLiteConnection("Data Source=" + DB_FILE_NAME))
                {
                    con.Open();
                    using (SQLiteCommand cmd = con.CreateCommand())
                    {
                        StringBuilder sql = new StringBuilder();
                        sql.AppendLine("INSERT INTO " + TABLE_NAME);
                        sql.AppendLine("(");
                        sql.AppendLine(" record_date,");
                        sql.AppendLine(" round_record_date,");
                        sql.AppendLine(" to_work");
                        sql.AppendLine(")");
                        sql.AppendLine("VALUES");
                        sql.AppendLine("(");
                        sql.AppendLine(" @RecordDate,");
                        sql.AppendLine(" @RoundRecordDate,");
                        sql.AppendLine(" @ToWork");
                        sql.AppendLine(")");

                        cmd.Parameters.Add(new SQLiteParameter("RecordDate"     , recordDate));
                        cmd.Parameters.Add(new SQLiteParameter("RoundRecordDate", roundRecordDate));
                        cmd.Parameters.Add(new SQLiteParameter("ToWork"         , toWork));

                        cmd.CommandText = sql.ToString();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                errMes = e.ToString();
            }

            return errMes;
        }
    }
}
