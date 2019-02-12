using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitingTheInput
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {            StringBuilder alpha = new StringBuilder();
            StringBuilder num = new StringBuilder();
            StringBuilder special = new StringBuilder();

            string str = textBox1.Text;
            foreach (var ch in str)
            {
                if (char.IsUpper(ch) || char.IsLower(ch))
                {
                    alpha.Append(ch);
                }
                else if(char.IsNumber(ch))
                {
                    num.Append(ch);
              }
                else if(char.IsSymbol(ch) || char.IsPunctuation(ch))
                {
                    special.Append(ch);
                }
            }
            label5.Text = Convert.ToString(alpha);
            label6.Text = Convert.ToString(num);
            label7.Text = Convert.ToString(special);

        }
    }


  }
   

