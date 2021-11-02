
namespace CurrencyClientForm
{
    partial class CurrencyClientForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.OriginCurrency = new System.Windows.Forms.ComboBox();
            this.FinalCurrency = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OriginValue = new System.Windows.Forms.NumericUpDown();
            this.ResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OriginValue)).BeginInit();
            this.SuspendLayout();
            // 
            // OriginCurrency
            // 
            this.OriginCurrency.FormattingEnabled = true;
            this.OriginCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.OriginCurrency.Location = new System.Drawing.Point(33, 87);
            this.OriginCurrency.Name = "OriginCurrency";
            this.OriginCurrency.Size = new System.Drawing.Size(230, 21);
            this.OriginCurrency.TabIndex = 0;
            this.OriginCurrency.SelectedIndexChanged += new System.EventHandler(this.OriginCurrency_SelectedIndexChanged);
            // 
            // FinalCurrency
            // 
            this.FinalCurrency.FormattingEnabled = true;
            this.FinalCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.FinalCurrency.Location = new System.Drawing.Point(33, 153);
            this.FinalCurrency.Name = "FinalCurrency";
            this.FinalCurrency.Size = new System.Drawing.Size(230, 21);
            this.FinalCurrency.TabIndex = 1;
            this.FinalCurrency.SelectedIndexChanged += new System.EventHandler(this.FinalCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moneda Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Destino";
            // 
            // OriginValue
            // 
            this.OriginValue.Location = new System.Drawing.Point(33, 203);
            this.OriginValue.Name = "OriginValue";
            this.OriginValue.Size = new System.Drawing.Size(120, 20);
            this.OriginValue.TabIndex = 4;
            this.OriginValue.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(30, 261);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(13, 13);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "0";
            // 
            // CurrencyClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.OriginValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinalCurrency);
            this.Controls.Add(this.OriginCurrency);
            this.Name = "CurrencyClientForm";
            this.Text = "Currency Converter";
            ((System.ComponentModel.ISupportInitialize)(this.OriginValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OriginCurrency;
        private System.Windows.Forms.ComboBox FinalCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown OriginValue;
        private System.Windows.Forms.Label ResultLabel;
    }
}

