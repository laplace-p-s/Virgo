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
        public int    toWork;

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
