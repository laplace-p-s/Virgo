﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Virgo
{
    class DaoSettings
    {
        private const string DB_FILE_NAME = "virgo_settings.db";
        private static string TABLE_NAME = "Settings";

        private string name;
        private string param;

        public DaoSettings()
        {
            //コンストラクタ
        }

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
                        sql.AppendLine(" name TEXT,");
                        sql.AppendLine(" param TEXT");
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
        /// 設定データを全て取得
        /// </summary>
        /// <param name="daoSettingsList">結果受け取りリスト</param>
        /// <returns>エラーメッセージ 正常終了の場合空文字</returns>
        public static string SelectAll(ref List<DaoSettings> daoSettingsList)
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

                        cmd.CommandText = sql.ToString();
                        SQLiteDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            DaoSettings settings = new DaoSettings();
                            settings.name  = reader.GetFieldValue<string>(reader.GetOrdinal("name"));
                            settings.param = reader.GetFieldValue<string>(reader.GetOrdinal("param"));

                            daoSettingsList.Add(settings);
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
    }
}
