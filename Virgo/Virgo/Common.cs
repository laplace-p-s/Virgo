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
    }
}
