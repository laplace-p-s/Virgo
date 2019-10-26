using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Virgo
{
    public partial class MainForm : Form
    {
        private DataTable Table;

        public MainForm()
        {
            InitializeComponent();
            DBSetup();
            InitDataTable();
            CountTimer.Start();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetLastedRecord();
            //バージョン情報を取得してウィンドウに表示
            Assembly assembly = Assembly.GetExecutingAssembly();
            Version version = assembly.GetName().Version;
            this.Text = "Virgo " + version.ToString();
        }

        private void CountTimer_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            TimerDayLabel.Text = nowTime.ToString("yyyy年 MM月 dd日 (ddd)");
            TimerTimeLabel.Text = nowTime.ToLongTimeString();
        }

        private void StartWorkButton_Click(object sender, EventArgs e)
        {
            RecordWorkTime(DateTime.Now, 1);
        }

        private void FinishWorkButton_Click(object sender, EventArgs e)
        {
            RecordWorkTime(DateTime.Now, 2);
        }

        /// <summary>
        /// DBの初期セットアップを行う
        /// </summary>
        private void DBSetup()
        {
            string errMes = "";
            errMes = DaoAttendance.Setup();
            if (errMes != "")
            {
                MessageBox.Show(errMes);
            }
        }

        /// <summary>
        /// DataTableの初期セットアップを行う
        /// </summary>
        private void InitDataTable()
        {
            Table = new DataTable();
            Table.Columns.Add("RecordDate"     , typeof(string));
            Table.Columns.Add("RoundRecordDate", typeof(string));
            Table.Columns.Add("ToWork"         , typeof(string));
            Lasted20DataGridView.DataSource = Table;
        }

        /// <summary>
        /// 勤怠テーブルデータの最新20件を取得する
        /// </summary>
        private void GetLastedRecord()
        {
            string errMes = "";
            List<DaoAttendance> daoAttendanceList = new List<DaoAttendance>();
            errMes = DaoAttendance.SelectAll(ref daoAttendanceList, 20);
            if (errMes == "")
            {
                SetDataTable(daoAttendanceList);
            }
            else
            {
                MessageBox.Show(errMes);
            }
        }

        /// <summary>
        /// 勤怠記録テーブルへの書き込み処理を呼び出す
        /// </summary>
        /// <param name="recordDateTime">記録対象日時</param>
        /// <param name="status">出勤(1)/退勤(2)</param>
        private void RecordWorkTime(DateTime recordDateTime, int status)
        {
            string errMes = "";
            DaoAttendance daoAttendance = new DaoAttendance();
            daoAttendance.recordDate = recordDateTime.ToString();
            daoAttendance.roundRecordDate = recordDateTime.ToString(); //TODO:丸め設定によって値を変える
            daoAttendance.toWork = status;
            errMes = daoAttendance.Insert();
            if (errMes != "")
            {
                MessageBox.Show(errMes);
            }
            else
            {
                MessageBox.Show("登録を完了しました。", "勤怠登録");
                GetLastedRecord();                
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
                row["RoundRecordDate"] = attendance.roundRecordDate;
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

        private void SearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new SearchForm();
            form.Show();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new AboutForm();
            form.ShowDialog();
        }
    }
}
