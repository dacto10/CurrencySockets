using CurrencyClientForm.CurrencyService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyClientForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        private string OriginCurren = "";
        private string FinalCurren = "";
        public Form()
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.OriginCurren != "" && this.FinalCurren != "")
                {
                    CurrencyRequest request = new CurrencyRequest()
                    {
                        originCurrency = this.OriginCurren,
                        originValue = this.valueInput.Text,
                        destinationCurrency = this.FinalCurren
                    };

                    CurrencyService.CurrencyClient client = new CurrencyService.CurrencyClient();

                    CurrencyResponse response = client.ConvertCurrency(request);

                    ResultLabel.Text = $"{response.destinationValue} {response.destinationCurrency}";
                }
                else
                {
                    ResultLabel.Text = "0";
                }
            }
            catch (FormatException ex)
            {

            }
        }
    }
}
