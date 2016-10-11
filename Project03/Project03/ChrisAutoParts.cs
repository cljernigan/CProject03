using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project03
{
    public partial class ChrisAutoParts : Form
    {
        public ChrisAutoParts()
        {
            InitializeComponent();
        }

        private void ChrisAutoParts_Load(object sender, EventArgs e)
        {
    

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PartTotalOut.Text = "";
            TaxOut.Text = "";
            GrandOut.Text = "";
            LaborOut.Text="";
           //if(ServiceCLB.CheckedItems.Count > 0)
          //  {
          //      for
          //  }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
