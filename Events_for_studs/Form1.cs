using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_for_studs
{
    public partial class Form1 : Form
    {
        private Summator sm = new Summator();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sm.Start();
            lblResult.Text = sm.Result.ToString();
        }
    }
}
