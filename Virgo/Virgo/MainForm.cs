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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DBSetup();
            CountTimer.Start();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            //読み込み時のフォームセットアップ
        }

        private void CountTimer_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            TimerDayLabel.Text  = nowTime.ToString("yyyy年 MM月 dd日 (ddd)");
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
            }
        }
    }
}
