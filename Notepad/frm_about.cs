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
    public partial class frm_about : Form
    {
        string name = "";
        string text = "Developer  : Mxqius";
        public frm_about()
        {
            InitializeComponent();
        }

        private void frm_about_Load(object sender, EventArgs e)
        {
            SetRgb();
        }
        private Task<string> SetRgb()
        {
            Random RandomClass = new Random();
            return Task.Run<string>(() =>
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(1000);
                    int rndRed = RandomClass.Next(0, 255);
                    int rndGreen = RandomClass.Next(0, 255);
                    int rndBlue = RandomClass.Next(0, 255);
                    shape.FillColor = Color.FromArgb(rndRed, rndGreen, rndBlue);

                }
                return String.Empty;
            });
        }
    }
}
