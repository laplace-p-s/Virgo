using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virgo
{
    class Common
    {
        /// <summary>
        /// Datetime型の時間部分のフォーマットを行う
        /// ※00:00:00でフォーマット
        /// </summary>
        /// <param name="setDatetime">フォーマットを行うDatetime</param>
        /// <returns>フォーマット後のDatetime</returns>
        public static DateTime FormatDatetimeStart(DateTime setDatetime)
        {
            DateTime retDatetime = new DateTime(setDatetime.Year, setDatetime.Month, setDatetime.Day, 0, 0, 0);

            return retDatetime;
        }

        /// <summary>
        /// Datetime型の時間部分のフォーマットを行う
        /// ※23:59:59でフォーマット
        /// </summary>
        /// <param name="setDatetime">フォーマットを行うDatetime</param>
        /// <returns>フォーマット後のDatetime</returns>
        public static DateTime FormatDatetimeEnd(DateTime setDatetime)
        {
            DateTime retDatetime = new DateTime(setDatetime.Year, setDatetime.Month, setDatetime.Day, 23, 59, 59);

            return retDatetime;
        }

        /// <summary>
        /// 出勤/退勤のステータス文字列を対応するコードに変換する
        /// 出勤：1
        /// 退勤：2
        /// ※テキストが条件に入らない場合は0で返す
        /// </summary>
        /// <param name="statusText">ステータス文字列</param>
        /// <returns>ステータスコード</returns>
        public static int GetStatusCodeFromText(string statusText)
        {
            int retCode = 0;
            if (statusText == "出勤")
            {
                retCode = 1;
            }
            else if (statusText == "退勤")
            {
                retCode = 2;
            }

            return retCode;
        }
    }
}
