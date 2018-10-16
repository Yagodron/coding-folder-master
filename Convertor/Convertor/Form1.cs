using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xNet;
using System.Text.RegularExpressions;


namespace Convertor
{
    public partial class Form1 : Form
    {
        string[,] MoneyValues = new string[25, 3];
        decimal[] value_format = new decimal[24];
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            GetNames(ref MoneyValues);
            for (int i = 0; i < 25; i++)
            {
                ToBox.Items.Add(MoneyValues[i,0]);
            }

        }

        private void GetNames(ref string[,] MoneyValues)
        {
            string b = string.Empty;
            try
            {
                using (var Request = new HttpRequest())
                {
                    string SourcePage;
                    SourcePage = Request.Get("http://www.bank.gov.ua/control/uk/curmetal/detail/currency?period=daily").ToString();
                    for (int i = 0; i < 25; i++)
                    {
                        b = string.Empty;
                        MoneyValues[i,0] = Convert.ToString(SourcePage.Substrings("<td class=\"cell\">", "</td>", 0)[i]);
                        MoneyValues[i,1] = Convert.ToString(SourcePage.Substrings("</td>\r\n\r\n          <td class=\"cell_c\">", "</td>", 0)[i]);
                        MoneyValues[i,2] = Convert.ToString(SourcePage.Substrings("</td>\r\n          <td class=\"cell_c\">", "</td>\r\n          <td class=\"cell\">", 0)[i]);
                        MoneyValues[i,1] = MoneyValues[i,1].Replace(".", ",");
                        for (int l = 0; l < MoneyValues[i, 2].Length; l++)
                        {
                            if (Char.IsDigit(MoneyValues[i, 2][l]))
                                b += MoneyValues[i, 2][l];
                        }
                        if (b.Length > 0)
                            value_format[i] = decimal.Parse(b);
                    }
                   
                }
            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                if (MoneyValues[i, 0] == ToBox.Text)
                {
                    decimal result = (numericUpDownAmount.Value * decimal.Parse(MoneyValues[i, 1]))/value_format[i];
                    resultTextBox.Text = result.ToString();
                }
            }

        }
    }
}
