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
        }
    }
}
