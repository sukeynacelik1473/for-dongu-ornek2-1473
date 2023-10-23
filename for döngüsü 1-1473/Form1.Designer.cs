namespace for_döngüsü_1_1473
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
            this.btnGoster = new System.Windows.Forms.Button();
            this.lbSayılar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGoster
            // 
            this.btnGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGoster.Location = new System.Drawing.Point(12, 31);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(94, 48);
            this.btnGoster.TabIndex = 0;
            this.btnGoster.Text = "Göster  ";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // lbSayılar
            // 
            this.lbSayılar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayılar.FormattingEnabled = true;
            this.lbSayılar.ItemHeight = 16;
            this.lbSayılar.Location = new System.Drawing.Point(125, 31);
            this.lbSayılar.Name = "lbSayılar";
            this.lbSayılar.Size = new System.Drawing.Size(137, 292);
            this.lbSayılar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 450);
            this.Controls.Add(this.lbSayılar);
            this.Controls.Add(this.btnGoster);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.ListBox lbSayılar;
    }
}

