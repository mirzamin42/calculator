using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApp3
{
    public partial class Form1 : Form
    {
        string operation = "";
        decimal ilkDeyer;
        decimal ikinciDeyer;
        decimal textBoxResult;

        bool value = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            if (textBox_Result.Text == "0"||value)
            {
                textBox_Result.Clear();
            }
            value = false;
            Button btn = new Button();
            btn = (Button)sender;
            if (btn.Text==".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text += btn.Text;
                }
            }
            else
            {
                    textBox_Result.Text += btn.Text;

            }
        }

        private void operationClick(object sender, EventArgs e)
        {
            Button button =  new Button();
            button = (Button)sender;
            operation = button.Text;
            textBoxResult = Convert.ToDecimal(textBox_Result.Text);
            label1.Text = textBoxResult + " " + operation;
            value = true;
            ilkDeyer = Convert.ToDecimal(textBox_Result.Text);
            //operation = button.Text;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            textBoxResult = 0;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            ikinciDeyer = Convert.ToDecimal(textBox_Result.Text);
            
            switch (operation)
            {
                case "+":
                    textBox_Result.Text = (ilkDeyer + ikinciDeyer).ToString();
                    //ilkDeyer = Convert.ToDouble(textBox_Result.Text);
                    break;
                case "-":
                    textBox_Result.Text = (ilkDeyer - ikinciDeyer).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (ilkDeyer * ikinciDeyer).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (ilkDeyer / ikinciDeyer).ToString();
                    break;
                default:
                    break;
            }
            
        }
    }
}
