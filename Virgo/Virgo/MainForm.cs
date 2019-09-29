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
            CountTimer.Start();
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
    }
}
