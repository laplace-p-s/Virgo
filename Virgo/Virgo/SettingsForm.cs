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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            //再起動確認ダイアログ
            DialogResult result = MessageBox.Show(
                "設定を反映するためにアプリケーションを再起動します。よろしいですか？",
                "設定の反映",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);

            if (result == DialogResult.OK)
            {
                // 設定を反映(DBに書き込み)した後にアプリケーションを再起動
                Application.Restart();
            }
        }
    }
}
