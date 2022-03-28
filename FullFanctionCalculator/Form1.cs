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

        #region variables
        string buttonNumber;
        bool commaDecimal = true;
        double number;
        string operationStatus;        
        double result;
        int counter=0;
        bool deleteTextbox = true;
        bool doOperate = false;
        bool isFirst = true;

        #endregion

        #region method
        //It adds number to textbox. 
        public void addNumberToTextbox()
        {
            if (isFirst)
            {
                textBox1.Text = buttonNumber;
                isFirst = false;
                sum.BackColor = Color.Peru;
                multiply.BackColor = Color.Peru;
                divide.BackColor = Color.Peru;
                minus.BackColor = Color.Peru;
            }
            else
            {
                if (textBox1.Text == "0")
                {
                    textBox1.Text = buttonNumber;
                }
                else
                {
                   textBox1.Text = textBox1.Text + buttonNumber;
                }
            }
        }

        //It adds comma to textbox.
        public void addCommaToTexbox()
        {
            if (commaDecimal == true)
            {
                textBox1.Text = "0,";
                commaDecimal = false;
            }
        }

        //it prevents that button frame staying blue when the button is clicked
        public void buttonActiveControl()
        {
            this.ActiveControl = null;
        }

        //It clears textbox, stops functions of buttons. 
        public void stopWorking()
        {
            Off.Visible = false;
            button0.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            positiveandnegative.Enabled = false;
            clearOneByOne.Enabled = false;
            clearall.Enabled = false;
            minus.Enabled = false;
            sum.Enabled = false;
            multiply.Enabled = false;
            divide.Enabled = false;
            comma.Enabled = false;
            ac.Enabled = false;
            equal.Enabled = false;
            textBox1.Clear();
            labelData.Text = "";
            textBox1.Enabled = false;
            buttonNumber = "";
            commaDecimal = true;
            number = 0;
            operationStatus = "";
            result = 0;
            counter = 0;
            deleteTextbox = true;
            doOperate = false;
            isFirst = true;
            sum.BackColor = Color.Peru;
            minus.BackColor = Color.Peru;
            multiply.BackColor = Color.Peru;
            divide.BackColor = Color.Peru;
        }

        //Functions of buttons is usable again.
        public void continueWorking()
        {
            Off.Visible = true;
            button0.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            positiveandnegative.Enabled = true;
            clearOneByOne.Enabled = true;
            clearall.Enabled = true;
            minus.Enabled = true;
            sum.Enabled = true;
            multiply.Enabled = true;
            comma.Enabled = true;
            ac.Enabled = true;
            divide.Enabled = true;
            equal.Enabled = true;
            textBox1.Enabled = true;
            textBox1.Text = Convert.ToString(0);
           

        }

        //It blocks keyboard inputs as letter.
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }
        #endregion

        #region buttons
        private void button1_Click(object sender, EventArgs e)
        {
             buttonNumber = "1";
             addNumberToTextbox();
             buttonActiveControl();
        }

        private void button2_Click(object sender, EventArgs e)
        {                  
           buttonNumber = "2";
           addNumberToTextbox();
           buttonActiveControl();
        }

        private void button3_Click(object sender, EventArgs e)
        {                     
           buttonNumber = "3";
           addNumberToTextbox();
           buttonActiveControl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonNumber = "4";
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonNumber = "5";
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button6_Click(object sender, EventArgs e)
        {   
             buttonNumber = "6";
             addNumberToTextbox();
             buttonActiveControl();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonNumber = "7";
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonNumber = "8";
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonNumber = "9";
            addNumberToTextbox();
            buttonActiveControl();
        }

        private void button0_Click(object sender, EventArgs e)
        {
             buttonNumber = "0";
             addNumberToTextbox();
             buttonActiveControl();
        }

        private void ac_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        private void sum_Click(object sender, EventArgs e)
        {
            operationStatus = "+";          
            sum.BackColor = Color.Cornsilk;
            minus.BackColor = Color.Peru;
            multiply.BackColor = Color.Peru;
            divide.BackColor = Color.Peru;
            if (doOperate == false)
            {
                number = long.Parse(textBox1.Text);
                result = number;
                doOperate = true;
                isFirst = true;
            } 
            else if (doOperate==true)
            {
                number = long.Parse(textBox1.Text);
                result = result + number;
                isFirst = true;
            }
            labelData.Text = Convert.ToString(result) + "+";
            textBox1.Text = Convert.ToString(result);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            operationStatus = "-";
            minus.BackColor = Color.Cornsilk;
            sum.BackColor = Color.Peru;
            multiply.BackColor = Color.Peru;
            divide.BackColor = Color.Peru;

            if (doOperate == false)
            {
                number = long.Parse(textBox1.Text);
                result = number;
                doOperate = true;
                isFirst = true;
            }
            else if (doOperate == true)
            {
                number = long.Parse(textBox1.Text);
                result = result - number;
                isFirst = true;
            }
            labelData.Text = Convert.ToString(result) + "-";
            textBox1.Text = Convert.ToString(result);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            operationStatus = "*";
            multiply.BackColor = Color.Cornsilk;
            sum.BackColor = Color.Peru;
            minus.BackColor = Color.Peru;
            divide.BackColor = Color.Peru;
            if (doOperate == false)
            {
                number = long.Parse(textBox1.Text);
                result = number;
                doOperate = true;
                isFirst = true;
            }
            else if (doOperate == true)
            {
                number = long.Parse(textBox1.Text);
                result = result * number;
                isFirst = true;
            }
            labelData.Text = Convert.ToString(result) + "*";
            textBox1.Text = Convert.ToString(result);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            operationStatus = "/";
            divide.BackColor = Color.Cornsilk;
            sum.BackColor = Color.Peru;
            minus.BackColor = Color.Peru;
            multiply.BackColor = Color.Peru;
            if (doOperate == false)
            {
                number = long.Parse(textBox1.Text);
                result = number;
                doOperate = true;
                isFirst = true;
            }
            else if (doOperate == true)
            {
                number = long.Parse(textBox1.Text);
                if (number==0)
                {
                    textBox1.Text = "Hata";
                    labelData.Text = "";
                    isFirst = true;
                }
                else
                {
                    result = result / number;
                    isFirst = true;
                }
               
            }
            labelData.Text = Convert.ToString(result) + "/";
            textBox1.Text = Convert.ToString(result);
        }

        private void equal_Click(object sender, EventArgs e)
        {
            buttonActiveControl();
            if (operationStatus=="+")
            {
                number = long.Parse(textBox1.Text);
                result = result + number;
                textBox1.Text = Convert.ToString(result);
                labelData.Text= Convert.ToString(result);
                sum.BackColor = Color.Peru;
                result = 0;
                isFirst = true;
            }
            if (operationStatus == "-")
            {
                number = long.Parse(textBox1.Text);
                result = result - number;
                textBox1.Text = Convert.ToString(result);
                labelData.Text = Convert.ToString(result);
                minus.BackColor = Color.Peru;
                result = 0;
                isFirst = true;
            }
            if (operationStatus == "*")
            {
                number = long.Parse(textBox1.Text);
                result = result * number;
                textBox1.Text = Convert.ToString(result);
                labelData.Text = Convert.ToString(result);
                multiply.BackColor = Color.Peru;
                result = 0;
                isFirst = true;
            }
            if ( operationStatus == "/")
            {
                number = long.Parse(textBox1.Text);
                if (number==0)
                {
                    textBox1.Text = "Hata";
                    labelData.Text = "";
                    divide.BackColor = Color.Peru;
                    result = 0;
                    isFirst = true;
                }
                else
                {
                    result = result / number;
                    textBox1.Text = Convert.ToString(result);
                    labelData.Text = Convert.ToString(result);
                    divide.BackColor = Color.Peru;
                    result = 0;
                    isFirst = true;
                }
            }
              
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //It is off button.
        private void off_Click(object sender, EventArgs e)
        {
            stopWorking();

        }

        //ıt is on button.
        private void on_Click(object sender, EventArgs e)
        {
            continueWorking();
        }

        //ıt adds comma to make number decimal number.
        private void comma_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Contains(","))
            {
                textBox1.Text = textBox1.Text;
            }
            else
            {
                if (textBox1.Text=="0")
                {
                    addCommaToTexbox();
                }
                else
                {
                    if ( true)
                    {
                        buttonNumber = ",";
                        addNumberToTextbox();
                        buttonActiveControl();
                    }
                    else
                    {
                        if (deleteTextbox == true)
                        {
                            sum.BackColor = Color.Peru;
                            buttonNumber = ",";
                            textBox1.Clear();
                            addNumberToTextbox();
                            buttonActiveControl();
                            deleteTextbox = false;
                        }
                        else
                        {
                            sum.BackColor = Color.Peru;
                            buttonNumber = ",";
                            addNumberToTextbox();
                            buttonActiveControl();
                        }
                    }
                }

            }
                
        }

        //It clears all textbox.
        private void clearall_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text = "0";
        }

        //It clears numbers one by one.
        private void clearOneByOne_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0")//It checks if it is "0". If it is, it does not delete it.
            {
                textBox1.Text = "0";
            }
            else
            {
                if (textBox1.Text.Length==1)//It checks if it has one digit. It deletes it and add 0 to textbox.
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                    textBox1.Text = "0";
                }
                else
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
                
            }
           
        }

        //It makes number positive or negative.
        private void positiveandnegative_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("-"))//If it has "-" already, it deletes it.
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }
            else
            {
                if (textBox1.Text=="0")//If it equals zero it does nothing becouse zero can not be negavitve.
                {
                    textBox1.Text = textBox1.Text;
                }
                else
                {
                    textBox1.Text = "-" + textBox1.Text;//If it does not has "-" it adds one and makes the number negative.
                }
                
            }
            
        }

        
    }

    
}
#endregion
