
namespace Lab006.LabCalculos
{
    partial class btnMaior
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnFrete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu Principal de Atividades";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(81, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(575, 112);
            this.button1.TabIndex = 1;
            this.button1.Text = "Maior Numero de Três";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFrete
            // 
            this.btnFrete.BackColor = System.Drawing.Color.Red;
            this.btnFrete.Location = new System.Drawing.Point(81, 267);
            this.btnFrete.Name = "btnFrete";
            this.btnFrete.Size = new System.Drawing.Size(575, 123);
            this.btnFrete.TabIndex = 2;
            this.btnFrete.Text = "Cálculo Frete";
            this.btnFrete.UseVisualStyleBackColor = false;
            this.btnFrete.Click += new System.EventHandler(this.btnFrete_Click);
            // 
            // btnMaior
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFrete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "btnMaior";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuPrincipal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFrete;
    }
}