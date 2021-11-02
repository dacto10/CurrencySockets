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

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (this.OriginCurren != "" && this.FinalCurren != "")
            {
                ResultLabel.Text = RequestHandler.HandleRequest(XmlConverter.GenerarPaqueteXmlConvertRequest(this.OriginCurren, this.FinalCurren, $"{OriginValue.Value}"));
            }
            else
            {
                ResultLabel.Text = "0";
            }
        }
    }
}
