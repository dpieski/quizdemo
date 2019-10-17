using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Form1 : Form
    {
        int qNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            // pull random question from file
            lblQNumber.Text = qNumber.ToString();
            lblQuestion.Text = "Example question here as a string?";
            chkResonse01.Text = "This is the first option";
            chkResponse02.Text = "this is the second option";
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // store question with response somewhere, array or list or dictionary of model
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // check answers
        }
    }
}
