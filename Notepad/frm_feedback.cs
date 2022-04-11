using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frm_feedback : Form
    {
        public frm_feedback()
        {
            InitializeComponent();
        }

        private void btn_rate_ok_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.UserRate = grs_rating.Value;
          //  Properties.Settings.Default.Save();
            md_confirm.Show();
            this.Close();

        }
    }
}
