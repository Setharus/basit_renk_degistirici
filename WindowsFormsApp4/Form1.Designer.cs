namespace WindowsFormsApp4
{
    partial class Form1
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
            this.btnKirmizi = new System.Windows.Forms.Button();
            this.btnMavi = new System.Windows.Forms.Button();
            this.btnSari = new System.Windows.Forms.Button();
            this.btnYesil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKirmizi
            // 
            this.btnKirmizi.BackColor = System.Drawing.Color.Red;
            this.btnKirmizi.Location = new System.Drawing.Point(75, 48);
            this.btnKirmizi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKirmizi.Name = "btnKirmizi";
            this.btnKirmizi.Size = new System.Drawing.Size(208, 68);
            this.btnKirmizi.TabIndex = 0;
            this.btnKirmizi.Text = "Kırmızı";
            this.btnKirmizi.UseVisualStyleBackColor = false;
            this.btnKirmizi.Click += new System.EventHandler(this.btnKirmizi_Click);
            // 
            // btnMavi
            // 
            this.btnMavi.BackColor = System.Drawing.Color.Blue;
            this.btnMavi.Location = new System.Drawing.Point(386, 48);
            this.btnMavi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMavi.Name = "btnMavi";
            this.btnMavi.Size = new System.Drawing.Size(208, 68);
            this.btnMavi.TabIndex = 0;
            this.btnMavi.Text = "Mavi";
            this.btnMavi.UseVisualStyleBackColor = false;
            this.btnMavi.Click += new System.EventHandler(this.btnMavi_Click);
            // 
            // btnSari
            // 
            this.btnSari.BackColor = System.Drawing.Color.Yellow;
            this.btnSari.Location = new System.Drawing.Point(386, 177);
            this.btnSari.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSari.Name = "btnSari";
            this.btnSari.Size = new System.Drawing.Size(208, 68);
            this.btnSari.TabIndex = 0;
            this.btnSari.Text = "Sarı";
            this.btnSari.UseVisualStyleBackColor = false;
            this.btnSari.Click += new System.EventHandler(this.btnSari_Click);
            // 
            // btnYesil
            // 
            this.btnYesil.BackColor = System.Drawing.Color.Lime;
            this.btnYesil.Location = new System.Drawing.Point(75, 177);
            this.btnYesil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYesil.Name = "btnYesil";
            this.btnYesil.Size = new System.Drawing.Size(208, 68);
            this.btnYesil.TabIndex = 0;
            this.btnYesil.Text = "Yeşil";
            this.btnYesil.UseVisualStyleBackColor = false;
            this.btnYesil.Click += new System.EventHandler(this.btnYesil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 295);
            this.Controls.Add(this.btnYesil);
            this.Controls.Add(this.btnSari);
            this.Controls.Add(this.btnMavi);
            this.Controls.Add(this.btnKirmizi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arka Plan Değiştir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKirmizi;
        private System.Windows.Forms.Button btnMavi;
        private System.Windows.Forms.Button btnSari;
        private System.Windows.Forms.Button btnYesil;
    }
}

