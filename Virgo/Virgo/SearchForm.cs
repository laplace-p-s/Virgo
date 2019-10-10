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
            Table.Columns.Add("RoundRecordDate", typeof(string));
            Table.Columns.Add("ToWork", typeof(string));
            ResultDataGridView.DataSource = Table;
        }
    }
}
