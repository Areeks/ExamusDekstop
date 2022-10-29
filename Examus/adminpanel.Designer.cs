namespace Examus
{
    partial class adminpanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adminpanel));
            this.user_button = new System.Windows.Forms.Button();
            this.question_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_button
            // 
            this.user_button.Location = new System.Drawing.Point(181, 122);
            this.user_button.Name = "user_button";
            this.user_button.Size = new System.Drawing.Size(113, 123);
            this.user_button.TabIndex = 0;
            this.user_button.Text = "Użytkownicy";
            this.user_button.UseVisualStyleBackColor = true;
            this.user_button.Click += new System.EventHandler(this.user_button_Click);
            // 
            // question_button
            // 
            this.question_button.Location = new System.Drawing.Point(475, 122);
            this.question_button.Name = "question_button";
            this.question_button.Size = new System.Drawing.Size(113, 123);
            this.question_button.TabIndex = 1;
            this.question_button.Text = "Pytania";
            this.question_button.UseVisualStyleBackColor = true;
            // 
            // adminpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.question_button);
            this.Controls.Add(this.user_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "adminpanel";
            this.Text = "Panel Administracyjny";
            this.ResumeLayout(false);

        }

        #endregion

        private Button user_button;
        private Button question_button;
    }
}