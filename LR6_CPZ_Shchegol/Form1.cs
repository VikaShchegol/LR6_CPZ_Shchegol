using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR6_CPZ_Shchegol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbX1.Text) || (String.IsNullOrEmpty(tbX2.Text)))
            {
                tbY.Text = "Не введено даних!"; return;
            }

            double x1 = double.Parse(tbX1.Text); 
            double x2 = double.Parse(tbX2.Text);

            double y = x1 * x2;

            tbY.Text = y.ToString("E6");

            double max = Math.Max(x1, x2);

            tbMax.Text = max.ToString("E6");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbX1.Text = string.Empty;
            tbX2.Text = string.Empty;
            tbY.Text = string.Empty;
            tbMax.Text = string.Empty;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
