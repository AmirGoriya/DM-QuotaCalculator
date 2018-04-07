using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quota_Calculator
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                RowStyle row = new RowStyle();
                tblQuotaChart.RowStyles.Add(row);
            }
        }
    }
}
