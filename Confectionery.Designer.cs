namespace SnappFood
{
    partial class Confectionery
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
            this.exit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(701, 467);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(97, 57);
            this.exit.TabIndex = 0;
            this.exit.Text = "منو اصلی";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(357, 474);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "open site";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Confectionery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::SnappFood.Properties.Resources.window_display_with_delicious_cakes_bakery_23_2147893055;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 623);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.exit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Confectionery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confectionery";
            this.Load += new System.EventHandler(this.Confectionery_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button button2;
    }
}