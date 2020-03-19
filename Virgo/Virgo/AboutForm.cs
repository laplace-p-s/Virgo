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
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            //アセンブリ取得
            Assembly assembly = Assembly.GetExecutingAssembly();
            //バージョン取得・表示
            Version version = assembly.GetName().Version;
            VersionLabel.Text = "Version " + version.ToString();
            //コピーライト取得・表示
            string copyRight = assembly.GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;
            CopyRightLabel.Text = copyRight;
        }

        private void GitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //リンク先を定義する
            //参考：https://dobon.net/vb/dotnet/control/linklabel.html
            System.Diagnostics.Process.Start("https://github.com/laplace-p-s/Virgo");
        }
    }
}
