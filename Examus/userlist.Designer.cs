namespace Examus
{
    partial class userlist
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
            this.usersgridview = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersgridview)).BeginInit();
            this.SuspendLayout();
            // 
            // usersgridview
            // 
            this.usersgridview.AllowUserToOrderColumns = true;
            this.usersgridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersgridview.Location = new System.Drawing.Point(40, 44);
            this.usersgridview.Name = "usersgridview";
            this.usersgridview.RowHeadersWidth = 51;
            this.usersgridview.RowTemplate.Height = 29;
            this.usersgridview.Size = new System.Drawing.Size(768, 426);
            this.usersgridview.TabIndex = 0;
            this.usersgridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersgridview_CellContentClick);
            // 
            // userlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 522);
            this.Controls.Add(this.usersgridview);
            this.Name = "userlist";
            this.Text = "Lista użytkowników";
            ((System.ComponentModel.ISupportInitialize)(this.usersgridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView usersgridview;
    }
}