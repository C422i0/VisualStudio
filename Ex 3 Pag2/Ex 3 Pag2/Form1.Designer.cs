namespace Ex_3_Pag2
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
            this.lblDist = new System.Windows.Forms.Label();
            this.txtDist = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.txtConsMed = new System.Windows.Forms.TextBox();
            this.lblConsMed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDist
            // 
            this.lblDist.AutoSize = true;
            this.lblDist.Location = new System.Drawing.Point(52, 82);
            this.lblDist.Name = "lblDist";
            this.lblDist.Size = new System.Drawing.Size(101, 13);
            this.lblDist.TabIndex = 0;
            this.lblDist.Text = "Distancia percorrida";
            // 
            // txtDist
            // 
            this.txtDist.Location = new System.Drawing.Point(53, 98);
            this.txtDist.Name = "txtDist";
            this.txtDist.Size = new System.Drawing.Size(100, 20);
            this.txtDist.TabIndex = 1;
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(52, 121);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(118, 13);
            this.lblCon.TabIndex = 2;
            this.lblCon.Text = "Consumo do automovel";
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(53, 137);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(100, 20);
            this.txtCon.TabIndex = 3;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(206, 116);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 23);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Resultado";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // txtConsMed
            // 
            this.txtConsMed.Location = new System.Drawing.Point(324, 121);
            this.txtConsMed.Name = "txtConsMed";
            this.txtConsMed.Size = new System.Drawing.Size(100, 20);
            this.txtConsMed.TabIndex = 5;
            // 
            // lblConsMed
            // 
            this.lblConsMed.AutoSize = true;
            this.lblConsMed.Location = new System.Drawing.Point(321, 90);
            this.lblConsMed.Name = "lblConsMed";
            this.lblConsMed.Size = new System.Drawing.Size(82, 13);
            this.lblConsMed.TabIndex = 6;
            this.lblConsMed.Text = "Consumo médio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 338);
            this.Controls.Add(this.lblConsMed);
            this.Controls.Add(this.txtConsMed);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.txtDist);
            this.Controls.Add(this.lblDist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDist;
        private System.Windows.Forms.TextBox txtDist;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.TextBox txtConsMed;
        private System.Windows.Forms.Label lblConsMed;
    }
}

