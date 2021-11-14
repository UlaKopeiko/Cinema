using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace БилетыВКинотеатр
{
    public partial class MenuWindow : Form
    {
        public MenuWindow()
        {
            InitializeComponent();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            HelpWindow f2 = new HelpWindow();
            f2.Show();
        }

        private void btnRage_Click(object sender, EventArgs e)
        {
            RageWindow f3 = new RageWindow();
            f3.Show();
            this.Hide();

        }

        private void btnSaw_Click(object sender, EventArgs e)
        {
            SawWindow f4 = new SawWindow();
            f4.Show();
            this.Hide();
        }

        private void btnGodzilla_Click(object sender, EventArgs e)
        {
            GodzillaWindow f5 = new GodzillaWindow();
            f5.Show();
            this.Hide();
        }

        private void MenuWindow_Load(object sender, EventArgs e)
        {
            
        }

        

        private void lblSaw_Click(object sender, EventArgs e)
        {

        }

        private void lblRage_Click(object sender, EventArgs e)
        {
            
        }
    }
}
