using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Virgo
{
    public partial class SearchForm : Form
    {
        private DataTable Table;

        public SearchForm()
        {
            InitializeComponent();
            InitDataTable();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// DataTableの初期セットアップを行う
        /// </summary>
        private void InitDataTable()
        {
            Table = new DataTable();
            Table.Columns.Add("RecordDate", typeof(string));
            //Table.Columns.Add("RoundRecordDate", typeof(string));
            Table.Columns.Add("ToWork", typeof(string));
            ResultDataGridView.DataSource = Table;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string errMes = "";
            //検索条件の取得
            DateTime searchFormDate = FromDateTimePicker.Value;
            DateTime searchToDate   = ToDateTimePicker.Value;

            //FromToの整合性チェック

            //検索処理
            List<DaoAttendance> daoAttendanceList = new List<DaoAttendance>();
            if (errMes == "")
            {
                errMes = DaoAttendance.SelectFromTo(ref daoAttendanceList, searchFormDate, searchToDate);
            }
            //検索結果処理
            if (errMes == "")
            {
                //検索結果を使ってDataGridに値を反映させる
                SetDataTable(daoAttendanceList);
            }
            //エラーメッセージ
            if (errMes != "")
            {
                MessageBox.Show(errMes, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        /// <summary>
        /// DataGridViewに受け取ったリストを反映する
        /// </summary>
        /// <param name="daoAttendanceList">勤怠テーブルのデータリスト</param>
        private void SetDataTable(List<DaoAttendance> daoAttendanceList)
        {
            Table.Clear();
            foreach (DaoAttendance attendance in daoAttendanceList)
            {
                DataRow row = Table.NewRow();
                row["RecordDate"]      = attendance.recordDate;
                //row["RoundRecordDate"] = attendance.roundRecordDate;
                row["ToWork"]          = GetRecordStatus(attendance.toWork);
                Table.Rows.Add(row);
            }
        }

        /// <summary>
        /// ToWorkの数値ステータスをラベルに変換する
        /// </summary>
        /// <param name="statusCode">数値ステータス</param>
        /// <returns>対応するラベルテキスト</returns>
        private string GetRecordStatus(long statusCode)
        {
            string retStr = "";
            if (statusCode == 1)
            {
                retStr = "出勤";
            }
            else if (statusCode == 2)
            {
                retStr = "退勤";
            }
            return retStr;
        }
    }
}
