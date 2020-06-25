using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnJS_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.JScript.Vsa.VsaEngine ve = Microsoft.JScript.Vsa.VsaEngine.CreateEngine();
                labJG.Text = Microsoft.JScript.Eval.JScriptEvaluate(tbNR.Text, ve).ToString();  
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.ToString());
            }

        }


    }
}
