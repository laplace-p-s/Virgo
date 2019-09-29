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

        string recordDate;
        string roundRecordDate;
        int    toWork;

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
    }
}
