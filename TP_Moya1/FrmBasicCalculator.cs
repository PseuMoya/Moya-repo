using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculate;

namespace TP_Moya1
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(num1.Text);
            int b = Convert.ToInt32(num2.Text);
            string total = cbop.Text;

            if(total == "+")
            {
                total_num.Text = BasicComputation.add(a, b).ToString();
            }
            if (total == "-")
            {
                total_num.Text = BasicComputation.sub(a, b).ToString();
            }
            if (total == "*")
            {
                total_num.Text = BasicComputation.multi(a, b).ToString();
            }
            if (total == "/")
            {
                total_num.Text = BasicComputation.div(a, b).ToString();
            }



        }
    }
}
