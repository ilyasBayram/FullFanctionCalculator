using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FullFanctionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int buttonNumber;
        int addFirst;
        int addSecond;
        int addSum;
        int addsayaç=0;

        public void addNumberToTextbox()
        {
            if (addsayaç==1)
            {
                textBox1.Text = Convert.ToString(buttonNumber);
                addsayaç = 0;
            }
            else
            {
                int number = Convert.ToInt32(textBox1.Text);
                int number2;
                if (number == 0)
                {
                    number2 = number + buttonNumber;
                    textBox1.Text = Convert.ToString(number2);
                }
                else
                {
                    number2 = (number * 10) + buttonNumber;
                    textBox1.Text = Convert.ToString(number2);
                }
            }
        }

        //it prevents that button frame stays blue when it is clicked
        public void buttonActiveControl()
        {
            this.ActiveControl = null;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(0);
        }

        #region buttons

        private void button1_Click(object sender, EventArgs e)
        {
            buttonNumber = 1;
            addNumberToTextbox();
            buttonActiveControl();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonNumber = 2;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonNumber = 3;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumber = 4;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonNumber = 5;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonNumber = 6;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonNumber = 7;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonNumber = 8;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            buttonNumber = 9;
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==Convert.ToString(0))
            {
                textBox1.Text = Convert.ToString(0);
            }
            else
            {
                buttonNumber = 0;
                addNumberToTextbox();
            }
           
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            addsayaç++;
            
            if (addsayaç==1)
            {
              addFirst = Convert.ToInt32(textBox1.Text);
              
            }
            if (addsayaç ==2)
            {   
                addSecond = Convert.ToInt32(textBox1.Text);
                addSum = addFirst + addSecond;   
            }
           
        }

        private void equal_Click(object sender, EventArgs e)
        {
            addsayaç = 0;          
            textBox1.Text = Convert.ToString(addSum);
           
        }
    }
}
#endregion
