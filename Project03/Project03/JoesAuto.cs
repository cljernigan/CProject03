/*Christopher Jernigan
 * 9/23/2016 
 * Project 3   ITE 136 HP86 
 * Starting out with Visual C# 4E Gaddis pg 391 Joes Automotive
 */

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
    public partial class JoesAuto : Form
    {
        public JoesAuto()
        {
            
           
            InitializeComponent();
            decimal partstotal = 0.00m;


        }

        

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();//Close Form
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            
            //Clears Output labels
            TotalOutLabel.Text = ""; 
            TaxOutLabel.Text = "";
            PartsOutLabel.Text = "";
            ServiceLaborOutLabel.Text = "";
            LaborHoursTextBox.Text = "";


        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal servicetotal = 0.00m;
            decimal subtotal = 0.00m;
           
            decimal labortotal = 0.00m;
            decimal laborrate = 40.00m;
            decimal taxrate = 0.06m;
            if (OilChangeCheckBox.Checked == true) { servicetotal += 26.00m; } ;
            if (LubeCheckBox.Checked == true) { servicetotal += 18.00m; } ;
            if (RadFlushCheckBox.Checked == true) { servicetotal += 30.00m;  };
            if (TranFlushCheckBox.Checked == true) { servicetotal += 80.00m; };
            if (InspectionCheckBox.Checked == true) { servicetotal += 15.00m; };
            if (ReplaceMuffCheckBox.Checked == true) { servicetotal += 100.00m;  };
            if (TireRotationCheckBox.Checked == true) { servicetotal += 20.00m;  };


            ServiceLaborOutLabel .Text = subtotal.ToString("C");
        }
    }
}
