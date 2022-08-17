namespace _19_
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.btnCalcule = new System.Windows.Forms.Button();
            this.lblH = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.txtSexoH = new System.Windows.Forms.TextBox();
            this.txtSexoM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(196, 122);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(121, 158);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(110, 13);
            this.lblSexo.TabIndex = 1;
            this.lblSexo.Text = "Sexo (homem/mulher)";
            this.lblSexo.Click += new System.EventHandler(this.lblSexo_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(249, 115);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(249, 151);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(121, 20);
            this.txtSexo.TabIndex = 3;
            // 
            // btnCalcule
            // 
            this.btnCalcule.Location = new System.Drawing.Point(249, 186);
            this.btnCalcule.Name = "btnCalcule";
            this.btnCalcule.Size = new System.Drawing.Size(121, 23);
            this.btnCalcule.TabIndex = 4;
            this.btnCalcule.Text = "CALCULE";
            this.btnCalcule.UseVisualStyleBackColor = true;
            this.btnCalcule.Click += new System.EventHandler(this.btnCalcule_Click);
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Location = new System.Drawing.Point(114, 244);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(117, 13);
            this.lblH.TabIndex = 5;
            this.lblH.Text = "Quantidade de homens";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Location = new System.Drawing.Point(109, 287);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(122, 13);
            this.lblM.TabIndex = 6;
            this.lblM.Text = "Quantidade de mulheres";
            // 
            // txtSexoH
            // 
            this.txtSexoH.Location = new System.Drawing.Point(249, 237);
            this.txtSexoH.Name = "txtSexoH";
            this.txtSexoH.Size = new System.Drawing.Size(121, 20);
            this.txtSexoH.TabIndex = 7;
            // 
            // txtSexoM
            // 
            this.txtSexoM.Location = new System.Drawing.Point(249, 284);
            this.txtSexoM.Name = "txtSexoM";
            this.txtSexoM.Size = new System.Drawing.Size(121, 20);
            this.txtSexoM.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSexoM);
            this.Controls.Add(this.txtSexoH);
            this.Controls.Add(this.lblM);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.btnCalcule);
            this.Controls.Add(this.txtSexo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Button btnCalcule;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.TextBox txtSexoH;
        private System.Windows.Forms.TextBox txtSexoM;
    }
}

