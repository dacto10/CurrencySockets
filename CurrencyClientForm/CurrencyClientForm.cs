using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CurrencyClient;

namespace CurrencyClientForm
{
    public partial class CurrencyClientForm : Form
    {
        private string OriginCurren = "";
        private string FinalCurren = "";
        public CurrencyClientForm()
        {
            InitializeComponent();
        }

        private void OriginCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.OriginCurren = OriginCurrency.Text;
        }

        private void FinalCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FinalCurren = FinalCurrency.Text;
        }

        private void valueInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.OriginCurren != "" && this.FinalCurren != "")
                {
                    ResultLabel.Text = RequestHandler.HandleRequest(XmlConverter.GenerarPaqueteXmlConvertRequest(this.OriginCurren, this.FinalCurren, $"{Decimal.Parse(valueInput.Text)}"));
                }
                else
                {
                    ResultLabel.Text = "0";
                }
            } catch (FormatException ex)
            {

            }
        }
    }
}
