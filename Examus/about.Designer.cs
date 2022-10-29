namespace Examus
{
    partial class about
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(about));
            this.logo_picture = new System.Windows.Forms.PictureBox();
            this.title_label = new System.Windows.Forms.Label();
            this.description_label = new System.Windows.Forms.Label();
            this.about_label = new System.Windows.Forms.Label();
            this.author_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_picture
            // 
            this.logo_picture.Location = new System.Drawing.Point(249, 24);
            this.logo_picture.Name = "logo_picture";
            this.logo_picture.Size = new System.Drawing.Size(127, 89);
            this.logo_picture.TabIndex = 0;
            this.logo_picture.TabStop = false;
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Snap ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(165, 116);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(293, 77);
            this.title_label.TabIndex = 1;
            this.title_label.Text = "Examus";
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description_label.Location = new System.Drawing.Point(194, 193);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(229, 39);
            this.description_label.TabIndex = 2;
            this.description_label.Text = "Dekstop App";
            // 
            // about_label
            // 
            this.about_label.AutoSize = true;
            this.about_label.Location = new System.Drawing.Point(-2, 246);
            this.about_label.Name = "about_label";
            this.about_label.Size = new System.Drawing.Size(629, 160);
            this.about_label.TabIndex = 3;
            this.about_label.Text = resources.GetString("about_label.Text");
            this.about_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // author_label
            // 
            this.author_label.AutoSize = true;
            this.author_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.author_label.Location = new System.Drawing.Point(225, 422);
            this.author_label.Name = "author_label";
            this.author_label.Size = new System.Drawing.Size(170, 25);
            this.author_label.TabIndex = 4;
            this.author_label.Text = "Autor: Areeks®";
            // 
            // about
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 473);
            this.Controls.Add(this.author_label);
            this.Controls.Add(this.about_label);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.title_label);
            this.Controls.Add(this.logo_picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "about";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "O programie";
            ((System.ComponentModel.ISupportInitialize)(this.logo_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox logo_picture;
        private Label title_label;
        private Label description_label;
        private Label about_label;
        private Label author_label;
    }
}