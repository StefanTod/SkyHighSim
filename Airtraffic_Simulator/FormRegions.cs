using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airtraffic_Simulator
{
    public partial class FormRegions : Form
    {
        Form1 f1;
        public FormRegions()
        {
            InitializeComponent();
        }

        private void btnEurope_Click(object sender, EventArgs e)
        {           
            f1 = new Form1(Regions.EUROPE);
            f1.Show();
            this.Hide(); 
           
                       
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            f1 = new Form1(Regions.AUSTRALIA);
            f1.Show();
            this.Hide();
        }

        

       
    }
}
