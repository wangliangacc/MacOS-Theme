using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MacOS_Theme
{
    public partial class LightTheme : Form
    {
        public LightTheme()
        {
            InitializeComponent();
        }
        #region BorderMover
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        #endregion

        #region TrafficLightButtonChanges

        private void ExitButton_MouseEnter_1(object sender, EventArgs e)
        {
            this.ExitButton.Image = Properties.Resources.redmacexit;
        }

        private void ExitButton_MouseLeave_1(object sender, EventArgs e)
        {
            this.ExitButton.Image = Properties.Resources.redmacnoexit;
        }

        private void MaxButton_MouseEnter_1(object sender, EventArgs e)
        {
            this.MaxButton.Image = Properties.Resources.maximizemax;
        }

        private void MaxButton_MouseLeave_1(object sender, EventArgs e)
        {
            this.MaxButton.Image = Properties.Resources.maximize;
        }

        private void MinButton_MouseEnter_1(object sender, EventArgs e)
        {
            this.MinButton.Image = Properties.Resources.minwithexit;
        }

        private void MinButton_MouseLeave_1(object sender, EventArgs e)
        {
            this.MinButton.Image = Properties.Resources.minnoexit;
        }

        #endregion

        #region TrafficLightButtonFunctions
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaxButton_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void MinButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
