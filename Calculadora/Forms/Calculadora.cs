﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora.Classes;
using Calculadora.Classes.Calculadora;

using System.Globalization;



namespace Calculadora
{
    public partial class Calculadora : Form
    {
        private string resultScreen;
        private float result;
        private float sizeFont;
        Operations oper = new Operations();
        Sum sum = new Sum();
        Subtraction sub = new Subtraction();
        Multiplication mul = new Multiplication();
        Division div = new Division();
        Percentage per = new Percentage(new Operations());

        public Calculadora()
        {
            InitializeComponent();
            this.resultScreen = "0";
            this.result = 0;
            this.sizeFont = 51.75f;
        }

        #region Numbers Buttons
        private void zeroButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.resultScreen.Contains(".")) || (this.resultScreen.Contains('+')) ||
                                                      (this.resultScreen.Contains('-')) ||
                                                      (this.resultScreen.Contains('x')) ||
                                                      (this.resultScreen.Contains('÷')))
                {
                    this.resultScreen = this.resultScreen + "0";
                }
                if (this.resultScreen.Equals("0"))
                {
                    this.resultScreen = "0";
                }
                if (!this.resultScreen.Equals("0") && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = this.resultScreen + "0";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "1";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "1";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "2";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "2";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "3";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "3";
                }
                this.resultLabel.Text = this.resultScreen;    
            }
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "4";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "4";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "5";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "5";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "6";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "6";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "7";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "7";
                }
                this.resultLabel.Text = this.resultScreen;    
            }
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "8";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "8";
                }
                this.resultLabel.Text = this.resultScreen;    
            }
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if ((this.result == 0) && (!this.resultScreen.Contains(".")))
                {
                    this.resultScreen = "9";
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
                else
                {
                    this.resultScreen = this.resultScreen + "9";
                }
                this.resultLabel.Text = this.resultScreen;
            }
        }

        private void commaButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
                if (this.resultScreen.Contains('.'))
                {
                    if ((this.resultScreen.Contains('+')) || (this.resultScreen.Contains('-')) ||
                        (this.resultScreen.Contains('x')) || (this.resultScreen.Contains('÷')))
                    {
                        if (this.countChar(this.resultScreen, '.') == 2)
                        {//Não coloca o ponto, pois já temos 2 pontos. Um antes e um depois da operação

                        }
                        else
                        {
                            this.resultScreen = this.resultScreen + ".";
                            this.resultLabel.Text = this.resultScreen;
                        }
                    }
                }
                else
                {
                    this.resultScreen = this.resultScreen + ".";
                    this.resultLabel.Text = this.resultScreen;
                }
            }
        }
        #endregion

        #region Operations Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            if ((this.resultScreen.Contains('+')) || (this.resultScreen.Contains('-')) ||
                (this.resultScreen.Contains('x')) || (this.resultScreen.Contains('÷')))
            {
                this.equalButton_Click(sender, e);
            }
            if (this.resultLabel.Text.Length <= 14)
            {
                if (!this.resultScreen.Contains('+'))
                {
                    this.oper = new Sum();
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                    this.oper.setResult(this.result);
                    this.resultScreen = this.resultScreen + "+";
                    this.resultLabel.Text = this.resultScreen;
                }
            }
        }
        private void subtractButton_Click(object sender, EventArgs e)
        {
            if ((this.resultScreen.Contains('+')) || (this.resultScreen.Contains('-')) ||
               (this.resultScreen.Contains('x')) || (this.resultScreen.Contains('÷')))
            {
                this.equalButton_Click(sender, e);
            }
            if (this.resultLabel.Text.Length <= 14)
            {
                this.oper = new Subtraction();
                this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                this.oper.setResult(this.result);
                this.resultScreen = this.resultScreen + "-";
                this.resultLabel.Text = this.resultScreen;
            }
        }
        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if ((this.resultScreen.Contains('+')) || (this.resultScreen.Contains('-')) ||
               (this.resultScreen.Contains('x')) || (this.resultScreen.Contains('÷')))
            {
                this.equalButton_Click(sender, e);
            }
            if (this.resultLabel.Text.Length <= 14)
            {
                this.oper = new Multiplication();
                this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                this.oper.setResult(this.result);
                this.resultScreen = this.resultScreen + "x";
                this.resultLabel.Text = this.resultScreen;
            }
        }
        private void divideButton_Click(object sender, EventArgs e)
        {
            if ((this.resultScreen.Contains('+')) || (this.resultScreen.Contains('-')) ||
               (this.resultScreen.Contains('x')) || (this.resultScreen.Contains('÷')))
            {
                this.equalButton_Click(sender, e);
            }
            if (this.resultLabel.Text.Length <= 14)
            {
                this.oper = new Division();
                this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                this.oper.setResult(this.result);
                this.resultScreen = this.resultScreen + "÷";
                this.resultLabel.Text = this.resultScreen;
            }
        }
        private void equalButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.resultLabel.Text.Length <= 14)
                {
                    this.resultScreen = Convert.ToString(this.oper.operate(this.oper.getNumber(this.resultScreen)));
                    this.resultScreen = this.resultScreen.Replace(',', '.');
                    this.resultLabel.Text = this.resultScreen;
                    this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            catch (CalculatorException)
            {
                this.resultLabel.Text = "Error";
            }
            catch (Exception)
            {
            }
        }
        private void percentageButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            { 
            }

        }
        private void inverterButton_Click(object sender, EventArgs e)
        {
            if (this.resultLabel.Text.Length <= 14)
            {
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            this.sum.setResult(0);
            this.sub.setResult(0);
            this.mul.setResult(0);
            this.div.setResult(0);
            this.per.setResult(0);
            this.resultScreen = "0";
            this.resultLabel.Text = this.resultScreen;
            this.resultLabel_TextChanged(sender,e);
            this.result = 0;
        }
        public void backButton_Click(object sender, EventArgs e)
        {
            this.eraser(1);
        }
        #endregion

        # region KeyDown
        private void keyDown(object sender, KeyEventArgs e)
       {
            if ((e.KeyCode == Keys.D0) || (e.KeyCode == Keys.NumPad0))
            {
                this.zeroButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D1) || (e.KeyCode == Keys.NumPad1))
            {
                this.oneButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D2) || (e.KeyCode == Keys.NumPad2))
            {
                this.twoButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D3) || (e.KeyCode == Keys.NumPad3))
            {
                this.threeButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D4) || (e.KeyCode == Keys.NumPad4))
            {
                this.fourButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D5) || (e.KeyCode == Keys.NumPad5))
            {
                this.fiveButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D6) || (e.KeyCode == Keys.NumPad6))
            {
                this.sixButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D7) || (e.KeyCode == Keys.NumPad7))
            {
                this.sevenButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D8) || (e.KeyCode == Keys.NumPad8))
            {
                this.eightButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.D9) || (e.KeyCode == Keys.NumPad9))
            {
                this.nineButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.Oemcomma) || (e.KeyValue == 194))
            {
                this.commaButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.OemPeriod)|| (e.KeyCode == Keys.Decimal))
            {
                this.commaButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.Oemplus) || (e.KeyCode == Keys.Add))
            {
                this.addButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.OemMinus) || (e.KeyCode == Keys.Subtract))
            {
                this.subtractButton_Click(sender, e);
            }
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                this.backButton_Click(sender, e);
            }
            if (e.KeyCode == Keys.Delete)
            {
                this.clearButton_Click(sender, e);
            }
        }
        private void clearButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void inverterButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void percentageButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void divideButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void multiplyButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void subtractButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void addButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void equalButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void commaButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void zeroButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void oneButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void twoButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void threeButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void fourButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void fiveButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void sixButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void sevenButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void eightButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void nineButton_KeyDown(object sender, KeyEventArgs e)
        {
            this.keyDown(sender, e);
        }
        private void Calculadora_KeyDown(object sender, KeyEventArgs e)
        {

        }
        #endregion

        #region Changed
        
        private void resultLabel_TextChanged(object sender, EventArgs e)
        {
            this.screenControler(sender, e);
        }

        #endregion

        #region Business Functions
        private void screenControler(object sender, EventArgs e)
        {   //Fonte 52 Normal
            if (this.resultLabel.Text.Length <= 9)
            {
                if (this.resultLabel.Text.Length <= 5)
                {
                    this.sizeFont = 52;
                }
                if (this.resultLabel.Text.Length == 6)
                {
                    this.sizeFont = 44;
                }
                if (this.resultLabel.Text.Length == 7)
                {
                    this.sizeFont = 40;
                }
                if (this.resultLabel.Text.Length == 8)
                {
                    this.sizeFont = 34;
                }
                if (this.resultLabel.Text.Length == 9)
                {
                    this.sizeFont = 30;
                }
            }
            else if (this.resultLabel.Text.Length >= 10)
            {
                if (this.resultLabel.Text.Length == 10)
                {
                    this.sizeFont = 28;
                }
                if (this.resultLabel.Text.Length == 11)
                {
                    this.sizeFont = 26;
                }
                if (this.resultLabel.Text.Length == 12)
                {
                    this.sizeFont = 24;
                }
                if (this.resultLabel.Text.Length == 13)
                {
                    this.sizeFont = 22;
                }
                if (this.resultLabel.Text.Length == 14)
                {
                    this.sizeFont = 20;
                }
                if (this.resultLabel.Text.Length == 15)
                {
                    this.sizeFont = 18;
                }
            }
            this.resultLabel.Font = new Font("Arial Unicode MS", this.sizeFont);
        }
        private void eraser(int quant)
        {
            if (resultLabel.Text.Length == 1)
            {
                this.resultLabel.Text = "0";
                this.resultScreen = this.resultLabel.Text;
                this.result = float.Parse(this.resultScreen, CultureInfo.InvariantCulture.NumberFormat);
            }
            else 
            {
                this.resultLabel.Text = this.resultLabel.Text.Substring(0, resultLabel.Text.Length - quant);
                this.resultScreen = this.resultLabel.Text;
            }
        }
        private int countChar(string word, char c)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word.ToCharArray(0,word.Length)[i].Equals(c))
                {
                    count++;
                }
            }
            return count;
        }
        #endregion

    }
}
