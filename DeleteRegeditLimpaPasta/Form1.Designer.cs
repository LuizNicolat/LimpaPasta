namespace DeleteRegeditLimpaPasta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDelReg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcaminho = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblExecOpen = new System.Windows.Forms.Label();
            this.lblExecClose = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDelReg
            // 
            this.btnDelReg.Location = new System.Drawing.Point(13, 13);
            this.btnDelReg.Name = "btnDelReg";
            this.btnDelReg.Size = new System.Drawing.Size(454, 50);
            this.btnDelReg.TabIndex = 0;
            this.btnDelReg.Text = "Limpar Regedit";
            this.btnDelReg.UseVisualStyleBackColor = true;
            this.btnDelReg.Click += new System.EventHandler(this.btnDelReg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caminho:";
            // 
            // lblcaminho
            // 
            this.lblcaminho.AutoSize = true;
            this.lblcaminho.Location = new System.Drawing.Point(153, 76);
            this.lblcaminho.Name = "lblcaminho";
            this.lblcaminho.Size = new System.Drawing.Size(13, 17);
            this.lblcaminho.TabIndex = 2;
            this.lblcaminho.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Executar ao Abrir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fechar ao Executar:";
            // 
            // lblExecOpen
            // 
            this.lblExecOpen.AutoSize = true;
            this.lblExecOpen.Location = new System.Drawing.Point(153, 102);
            this.lblExecOpen.Name = "lblExecOpen";
            this.lblExecOpen.Size = new System.Drawing.Size(13, 17);
            this.lblExecOpen.TabIndex = 4;
            this.lblExecOpen.Text = "-";
            // 
            // lblExecClose
            // 
            this.lblExecClose.AutoSize = true;
            this.lblExecClose.Location = new System.Drawing.Point(153, 130);
            this.lblExecClose.Name = "lblExecClose";
            this.lblExecClose.Size = new System.Drawing.Size(13, 17);
            this.lblExecClose.TabIndex = 5;
            this.lblExecClose.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 180);
            this.Controls.Add(this.lblExecClose);
            this.Controls.Add(this.lblExecOpen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblcaminho);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelReg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Limpar Regedit - LimpaPasta";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelReg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblcaminho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblExecOpen;
        private System.Windows.Forms.Label lblExecClose;
    }
}

