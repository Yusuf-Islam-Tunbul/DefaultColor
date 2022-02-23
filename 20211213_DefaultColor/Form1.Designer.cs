
namespace _20211213_DefaultColor
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.change_color_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // change_color_button
            // 
            this.change_color_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.change_color_button.Location = new System.Drawing.Point(68, 45);
            this.change_color_button.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.change_color_button.Name = "change_color_button";
            this.change_color_button.Size = new System.Drawing.Size(231, 123);
            this.change_color_button.TabIndex = 0;
            this.change_color_button.Text = "RENK DEĞİŞTİR";
            this.change_color_button.UseVisualStyleBackColor = true;
            this.change_color_button.Click += new System.EventHandler(this.change_color_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 216);
            this.Controls.Add(this.change_color_button);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button change_color_button;
    }
}

