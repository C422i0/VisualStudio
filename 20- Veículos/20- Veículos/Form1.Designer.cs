namespace _20__Veículos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAno = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnResultado = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(50, 9);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(104, 13);
            this.lblAno.TabIndex = 0;
            this.lblAno.Text = "Insira o ano do carro";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(50, 66);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(109, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Insira o valor do carro";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(53, 25);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(101, 20);
            this.txtAno.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(53, 82);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnResultado
            // 
            this.btnResultado.Location = new System.Drawing.Point(53, 128);
            this.btnResultado.Name = "btnResultado";
            this.btnResultado.Size = new System.Drawing.Size(100, 39);
            this.btnResultado.TabIndex = 4;
            this.btnResultado.Text = "Calcule o valor do carro";
            this.btnResultado.UseVisualStyleBackColor = true;
            this.btnResultado.Click += new System.EventHandler(this.btnResultado_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(50, 189);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(152, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Valor do carro com o desconto";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(53, 217);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(502, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnResultado);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblAno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnResultado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
    }
}

