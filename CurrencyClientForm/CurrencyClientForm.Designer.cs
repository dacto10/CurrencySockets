
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
            this.ResultLabel = new System.Windows.Forms.Label();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OriginCurrency
            // 
            this.OriginCurrency.BackColor = System.Drawing.Color.White;
            this.OriginCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OriginCurrency.FormattingEnabled = true;
            this.OriginCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.OriginCurrency.Location = new System.Drawing.Point(44, 107);
            this.OriginCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.OriginCurrency.Name = "OriginCurrency";
            this.OriginCurrency.Size = new System.Drawing.Size(305, 24);
            this.OriginCurrency.TabIndex = 0;
            this.OriginCurrency.SelectedIndexChanged += new System.EventHandler(this.OriginCurrency_SelectedIndexChanged);
            // 
            // FinalCurrency
            // 
            this.FinalCurrency.BackColor = System.Drawing.Color.White;
            this.FinalCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FinalCurrency.ForeColor = System.Drawing.SystemColors.MenuText;
            this.FinalCurrency.FormattingEnabled = true;
            this.FinalCurrency.Items.AddRange(new object[] {
            "USD",
            "EUR"});
            this.FinalCurrency.Location = new System.Drawing.Point(44, 188);
            this.FinalCurrency.Margin = new System.Windows.Forms.Padding(4);
            this.FinalCurrency.Name = "FinalCurrency";
            this.FinalCurrency.Size = new System.Drawing.Size(305, 24);
            this.FinalCurrency.TabIndex = 1;
            this.FinalCurrency.SelectedIndexChanged += new System.EventHandler(this.FinalCurrency_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Moneda Origen";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Moneda Destino";
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(41, 354);
            this.ResultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(15, 16);
            this.ResultLabel.TabIndex = 5;
            this.ResultLabel.Text = "0";
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(43, 270);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(168, 22);
            this.valueInput.TabIndex = 6;
            this.valueInput.TextChanged += new System.EventHandler(this.valueInput_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor a convertir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 322);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Resultado";
            // 
            // CurrencyClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(393, 554);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FinalCurrency);
            this.Controls.Add(this.OriginCurrency);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrencyClientForm";
            this.Text = "Currency Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OriginCurrency;
        private System.Windows.Forms.ComboBox FinalCurrency;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

