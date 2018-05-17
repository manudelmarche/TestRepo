using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TestRepo
{
    public partial class ManuForm : Form
    {
        public ManuForm()
        {
            InitializeComponent();
        }

        private void ManuForm_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            MessageBox.Show(string.Format("{0}X, {1}Y",me.X,me.Y));
        }

        private void ManuForm_MouseMove(object sender, MouseEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("{0}X, {1}Y", e.X, e.Y);
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show(string.Format("Vacations start on {0} and end on {1}",e.Start,e.End));
        }
    }
}
