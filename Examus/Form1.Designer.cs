namespace Examus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.footer = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.login_textbox = new System.Windows.Forms.TextBox();
            this.pass_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.description_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.AutoSize = true;
            this.footer.Location = new System.Drawing.Point(287, 421);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(175, 20);
            this.footer.TabIndex = 0;
            this.footer.Text = "Copyright © 2022 Areeks";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Snap ITC", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.Location = new System.Drawing.Point(266, 24);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(237, 61);
            this.title.TabIndex = 1;
            this.title.Text = "Examus";
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.login_label.Location = new System.Drawing.Point(323, 135);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(112, 36);
            this.login_label.TabIndex = 2;
            this.login_label.Text = "Login:";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Font = new System.Drawing.Font("Snap ITC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pass_label.Location = new System.Drawing.Point(323, 253);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(116, 36);
            this.pass_label.TabIndex = 3;
            this.pass_label.Text = "Hasło:";
            // 
            // login_textbox
            // 
            this.login_textbox.Location = new System.Drawing.Point(274, 174);
            this.login_textbox.Name = "login_textbox";
            this.login_textbox.PlaceholderText = "login";
            this.login_textbox.Size = new System.Drawing.Size(199, 27);
            this.login_textbox.TabIndex = 4;
            // 
            // pass_textbox
            // 
            this.pass_textbox.Location = new System.Drawing.Point(274, 292);
            this.pass_textbox.Name = "pass_textbox";
            this.pass_textbox.PasswordChar = '*';
            this.pass_textbox.PlaceholderText = "hasło";
            this.pass_textbox.Size = new System.Drawing.Size(199, 27);
            this.pass_textbox.TabIndex = 5;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(323, 340);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(94, 29);
            this.login_button.TabIndex = 6;
            this.login_button.Text = "Zaloguj";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // description_label
            // 
            this.description_label.AutoSize = true;
            this.description_label.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.description_label.Location = new System.Drawing.Point(229, 85);
            this.description_label.Name = "description_label";
            this.description_label.Size = new System.Drawing.Size(319, 30);
            this.description_label.TabIndex = 7;
            this.description_label.Text = "Twoje centrum wiedzy!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.description_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.pass_textbox);
            this.Controls.Add(this.login_textbox);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.login_label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.footer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Examus - Twoje centrum wiedzy!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label footer;
        private Label title;
        private Label login_label;
        private Label pass_label;
        private TextBox login_textbox;
        private TextBox pass_textbox;
        private Button login_button;
        private Label description_label;
    }
}