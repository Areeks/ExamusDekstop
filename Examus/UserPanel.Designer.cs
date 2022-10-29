namespace Examus
{
    partial class UserPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPanel));
            this.question_label = new System.Windows.Forms.Label();
            this.question_input = new System.Windows.Forms.TextBox();
            this.question_button = new System.Windows.Forms.Button();
            this.hello_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.noquestion_label = new System.Windows.Forms.Label();
            this.questiontext_label = new System.Windows.Forms.Label();
            this.a_answer_label = new System.Windows.Forms.Label();
            this.b_answer_label = new System.Windows.Forms.Label();
            this.c_answer_label = new System.Windows.Forms.Label();
            this.d_answer_label = new System.Windows.Forms.Label();
            this.e_answer_label = new System.Windows.Forms.Label();
            this.a_answer_bar = new System.Windows.Forms.ProgressBar();
            this.b_answer_bar = new System.Windows.Forms.ProgressBar();
            this.c_answer_bar = new System.Windows.Forms.ProgressBar();
            this.d_answer_bar = new System.Windows.Forms.ProgressBar();
            this.e_answer_bar = new System.Windows.Forms.ProgressBar();
            this.count_a_label = new System.Windows.Forms.Label();
            this.count_b_label = new System.Windows.Forms.Label();
            this.count_c_label = new System.Windows.Forms.Label();
            this.count_d_label = new System.Windows.Forms.Label();
            this.count_e_label = new System.Windows.Forms.Label();
            this.admin_button = new System.Windows.Forms.Button();
            this.next_question_button = new System.Windows.Forms.Button();
            this.prev_question_button = new System.Windows.Forms.Button();
            this.numbertotal_label = new System.Windows.Forms.Label();
            this.categoryname_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamknijToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // question_label
            // 
            this.question_label.AutoSize = true;
            this.question_label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.question_label.Location = new System.Drawing.Point(552, 83);
            this.question_label.Name = "question_label";
            this.question_label.Size = new System.Drawing.Size(260, 35);
            this.question_label.TabIndex = 0;
            this.question_label.Text = "Wprowadź pytanie:";
            // 
            // question_input
            // 
            this.question_input.Location = new System.Drawing.Point(321, 121);
            this.question_input.Name = "question_input";
            this.question_input.Size = new System.Drawing.Size(733, 27);
            this.question_input.TabIndex = 1;
            // 
            // question_button
            // 
            this.question_button.Location = new System.Drawing.Point(631, 154);
            this.question_button.Name = "question_button";
            this.question_button.Size = new System.Drawing.Size(94, 29);
            this.question_button.TabIndex = 2;
            this.question_button.Text = "Szukaj";
            this.question_button.UseVisualStyleBackColor = true;
            this.question_button.Click += new System.EventHandler(this.question_button_Click);
            // 
            // hello_label
            // 
            this.hello_label.AutoSize = true;
            this.hello_label.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hello_label.Location = new System.Drawing.Point(33, 39);
            this.hello_label.Name = "hello_label";
            this.hello_label.Size = new System.Drawing.Size(86, 30);
            this.hello_label.TabIndex = 3;
            this.hello_label.Text = "Witaj";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(114, 39);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(0, 30);
            this.name_label.TabIndex = 4;
            // 
            // noquestion_label
            // 
            this.noquestion_label.AutoSize = true;
            this.noquestion_label.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noquestion_label.ForeColor = System.Drawing.Color.Red;
            this.noquestion_label.Location = new System.Drawing.Point(531, 362);
            this.noquestion_label.Name = "noquestion_label";
            this.noquestion_label.Size = new System.Drawing.Size(283, 29);
            this.noquestion_label.TabIndex = 5;
            this.noquestion_label.Text = "Brak pytania w bazie!";
            this.noquestion_label.Visible = false;
            // 
            // questiontext_label
            // 
            this.questiontext_label.AutoSize = true;
            this.questiontext_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.questiontext_label.Location = new System.Drawing.Point(93, 270);
            this.questiontext_label.MaximumSize = new System.Drawing.Size(1200, 0);
            this.questiontext_label.Name = "questiontext_label";
            this.questiontext_label.Size = new System.Drawing.Size(125, 23);
            this.questiontext_label.TabIndex = 6;
            this.questiontext_label.Text = "Question text";
            this.questiontext_label.Visible = false;
            // 
            // a_answer_label
            // 
            this.a_answer_label.AutoSize = true;
            this.a_answer_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.a_answer_label.Location = new System.Drawing.Point(90, 362);
            this.a_answer_label.Name = "a_answer_label";
            this.a_answer_label.Size = new System.Drawing.Size(105, 26);
            this.a_answer_label.TabIndex = 7;
            this.a_answer_label.Text = "Answer A";
            this.a_answer_label.Visible = false;
            // 
            // b_answer_label
            // 
            this.b_answer_label.AutoSize = true;
            this.b_answer_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_answer_label.Location = new System.Drawing.Point(90, 420);
            this.b_answer_label.Name = "b_answer_label";
            this.b_answer_label.Size = new System.Drawing.Size(104, 26);
            this.b_answer_label.TabIndex = 8;
            this.b_answer_label.Text = "Answer B";
            this.b_answer_label.Visible = false;
            // 
            // c_answer_label
            // 
            this.c_answer_label.AutoSize = true;
            this.c_answer_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.c_answer_label.Location = new System.Drawing.Point(93, 476);
            this.c_answer_label.Name = "c_answer_label";
            this.c_answer_label.Size = new System.Drawing.Size(105, 26);
            this.c_answer_label.TabIndex = 9;
            this.c_answer_label.Text = "Answer C";
            this.c_answer_label.Visible = false;
            // 
            // d_answer_label
            // 
            this.d_answer_label.AutoSize = true;
            this.d_answer_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.d_answer_label.Location = new System.Drawing.Point(90, 532);
            this.d_answer_label.Name = "d_answer_label";
            this.d_answer_label.Size = new System.Drawing.Size(106, 26);
            this.d_answer_label.TabIndex = 10;
            this.d_answer_label.Text = "Answer D";
            this.d_answer_label.Visible = false;
            // 
            // e_answer_label
            // 
            this.e_answer_label.AutoSize = true;
            this.e_answer_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.e_answer_label.Location = new System.Drawing.Point(90, 588);
            this.e_answer_label.Name = "e_answer_label";
            this.e_answer_label.Size = new System.Drawing.Size(103, 26);
            this.e_answer_label.TabIndex = 11;
            this.e_answer_label.Text = "Answer E";
            this.e_answer_label.Visible = false;
            // 
            // a_answer_bar
            // 
            this.a_answer_bar.Location = new System.Drawing.Point(1154, 367);
            this.a_answer_bar.Name = "a_answer_bar";
            this.a_answer_bar.Size = new System.Drawing.Size(125, 29);
            this.a_answer_bar.TabIndex = 12;
            this.a_answer_bar.Visible = false;
            // 
            // b_answer_bar
            // 
            this.b_answer_bar.Location = new System.Drawing.Point(1154, 424);
            this.b_answer_bar.Name = "b_answer_bar";
            this.b_answer_bar.Size = new System.Drawing.Size(125, 29);
            this.b_answer_bar.TabIndex = 13;
            this.b_answer_bar.Visible = false;
            // 
            // c_answer_bar
            // 
            this.c_answer_bar.Location = new System.Drawing.Point(1154, 480);
            this.c_answer_bar.Name = "c_answer_bar";
            this.c_answer_bar.Size = new System.Drawing.Size(125, 29);
            this.c_answer_bar.TabIndex = 14;
            this.c_answer_bar.Visible = false;
            // 
            // d_answer_bar
            // 
            this.d_answer_bar.Location = new System.Drawing.Point(1154, 536);
            this.d_answer_bar.Name = "d_answer_bar";
            this.d_answer_bar.Size = new System.Drawing.Size(125, 29);
            this.d_answer_bar.TabIndex = 15;
            this.d_answer_bar.Visible = false;
            // 
            // e_answer_bar
            // 
            this.e_answer_bar.Location = new System.Drawing.Point(1154, 592);
            this.e_answer_bar.Name = "e_answer_bar";
            this.e_answer_bar.Size = new System.Drawing.Size(125, 29);
            this.e_answer_bar.TabIndex = 16;
            this.e_answer_bar.Visible = false;
            // 
            // count_a_label
            // 
            this.count_a_label.AutoSize = true;
            this.count_a_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_a_label.Location = new System.Drawing.Point(1085, 374);
            this.count_a_label.Name = "count_a_label";
            this.count_a_label.Size = new System.Drawing.Size(47, 22);
            this.count_a_label.TabIndex = 17;
            this.count_a_label.Text = "C_A";
            this.count_a_label.Visible = false;
            // 
            // count_b_label
            // 
            this.count_b_label.AutoSize = true;
            this.count_b_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_b_label.Location = new System.Drawing.Point(1085, 431);
            this.count_b_label.Name = "count_b_label";
            this.count_b_label.Size = new System.Drawing.Size(46, 22);
            this.count_b_label.TabIndex = 18;
            this.count_b_label.Text = "C_B";
            this.count_b_label.Visible = false;
            // 
            // count_c_label
            // 
            this.count_c_label.AutoSize = true;
            this.count_c_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_c_label.Location = new System.Drawing.Point(1085, 487);
            this.count_c_label.Name = "count_c_label";
            this.count_c_label.Size = new System.Drawing.Size(46, 22);
            this.count_c_label.TabIndex = 19;
            this.count_c_label.Text = "C_C";
            this.count_c_label.Visible = false;
            // 
            // count_d_label
            // 
            this.count_d_label.AutoSize = true;
            this.count_d_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_d_label.Location = new System.Drawing.Point(1085, 543);
            this.count_d_label.Name = "count_d_label";
            this.count_d_label.Size = new System.Drawing.Size(47, 22);
            this.count_d_label.TabIndex = 20;
            this.count_d_label.Text = "C_D";
            this.count_d_label.Visible = false;
            // 
            // count_e_label
            // 
            this.count_e_label.AutoSize = true;
            this.count_e_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count_e_label.Location = new System.Drawing.Point(1085, 599);
            this.count_e_label.Name = "count_e_label";
            this.count_e_label.Size = new System.Drawing.Size(45, 22);
            this.count_e_label.TabIndex = 21;
            this.count_e_label.Text = "C_E";
            this.count_e_label.Visible = false;
            // 
            // admin_button
            // 
            this.admin_button.Location = new System.Drawing.Point(1137, 39);
            this.admin_button.Name = "admin_button";
            this.admin_button.Size = new System.Drawing.Size(177, 29);
            this.admin_button.TabIndex = 22;
            this.admin_button.Text = "Panel Administracyjny";
            this.admin_button.UseVisualStyleBackColor = true;
            this.admin_button.Visible = false;
            this.admin_button.Click += new System.EventHandler(this.admin_button_Click);
            // 
            // next_question_button
            // 
            this.next_question_button.Location = new System.Drawing.Point(1154, 687);
            this.next_question_button.Name = "next_question_button";
            this.next_question_button.Size = new System.Drawing.Size(94, 29);
            this.next_question_button.TabIndex = 23;
            this.next_question_button.Text = "Następne";
            this.next_question_button.UseVisualStyleBackColor = true;
            this.next_question_button.Visible = false;
            this.next_question_button.Click += new System.EventHandler(this.next_question_button_Click);
            // 
            // prev_question_button
            // 
            this.prev_question_button.Location = new System.Drawing.Point(90, 687);
            this.prev_question_button.Name = "prev_question_button";
            this.prev_question_button.Size = new System.Drawing.Size(94, 29);
            this.prev_question_button.TabIndex = 24;
            this.prev_question_button.Text = "Poprzednie";
            this.prev_question_button.UseVisualStyleBackColor = true;
            this.prev_question_button.Visible = false;
            this.prev_question_button.Click += new System.EventHandler(this.prev_question_button_Click);
            // 
            // numbertotal_label
            // 
            this.numbertotal_label.AutoSize = true;
            this.numbertotal_label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numbertotal_label.Location = new System.Drawing.Point(1182, 652);
            this.numbertotal_label.Name = "numbertotal_label";
            this.numbertotal_label.Size = new System.Drawing.Size(35, 22);
            this.numbertotal_label.TabIndex = 25;
            this.numbertotal_label.Text = "1/x";
            this.numbertotal_label.Visible = false;
            // 
            // categoryname_label
            // 
            this.categoryname_label.AutoSize = true;
            this.categoryname_label.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.categoryname_label.Location = new System.Drawing.Point(292, 213);
            this.categoryname_label.Name = "categoryname_label";
            this.categoryname_label.Size = new System.Drawing.Size(127, 26);
            this.categoryname_label.TabIndex = 26;
            this.categoryname_label.Text = "Informatyka";
            this.categoryname_label.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1335, 28);
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem1,
            this.wylogujToolStripMenuItem,
            this.zamknijToolStripMenuItem});
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.oProgramieToolStripMenuItem.Text = "Program";
            // 
            // oProgramieToolStripMenuItem1
            // 
            this.oProgramieToolStripMenuItem1.Name = "oProgramieToolStripMenuItem1";
            this.oProgramieToolStripMenuItem1.Size = new System.Drawing.Size(177, 26);
            this.oProgramieToolStripMenuItem1.Text = "O programie";
            this.oProgramieToolStripMenuItem1.Click += new System.EventHandler(this.oProgramieToolStripMenuItem1_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // zamknijToolStripMenuItem
            // 
            this.zamknijToolStripMenuItem.Name = "zamknijToolStripMenuItem";
            this.zamknijToolStripMenuItem.Size = new System.Drawing.Size(177, 26);
            this.zamknijToolStripMenuItem.Text = "Zamknij";
            this.zamknijToolStripMenuItem.Click += new System.EventHandler(this.zamknijToolStripMenuItem_Click);
            // 
            // UserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 737);
            this.Controls.Add(this.categoryname_label);
            this.Controls.Add(this.numbertotal_label);
            this.Controls.Add(this.prev_question_button);
            this.Controls.Add(this.next_question_button);
            this.Controls.Add(this.admin_button);
            this.Controls.Add(this.count_e_label);
            this.Controls.Add(this.count_d_label);
            this.Controls.Add(this.count_c_label);
            this.Controls.Add(this.count_b_label);
            this.Controls.Add(this.count_a_label);
            this.Controls.Add(this.e_answer_bar);
            this.Controls.Add(this.d_answer_bar);
            this.Controls.Add(this.c_answer_bar);
            this.Controls.Add(this.b_answer_bar);
            this.Controls.Add(this.a_answer_bar);
            this.Controls.Add(this.e_answer_label);
            this.Controls.Add(this.d_answer_label);
            this.Controls.Add(this.c_answer_label);
            this.Controls.Add(this.b_answer_label);
            this.Controls.Add(this.a_answer_label);
            this.Controls.Add(this.questiontext_label);
            this.Controls.Add(this.noquestion_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.hello_label);
            this.Controls.Add(this.question_button);
            this.Controls.Add(this.question_input);
            this.Controls.Add(this.question_label);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Examus\'a";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label question_label;
        private TextBox question_input;
        private Button question_button;
        private Label hello_label;
        private Label name_label;
        private Label noquestion_label;
        private Label questiontext_label;
        private Label a_answer_label;
        private Label b_answer_label;
        private Label c_answer_label;
        private Label d_answer_label;
        private Label e_answer_label;
        private ProgressBar a_answer_bar;
        private ProgressBar b_answer_bar;
        private ProgressBar c_answer_bar;
        private ProgressBar d_answer_bar;
        private ProgressBar e_answer_bar;
        private Label count_a_label;
        private Label count_b_label;
        private Label count_c_label;
        private Label count_d_label;
        private Label count_e_label;
        private Button admin_button;
        private Button next_question_button;
        private Button prev_question_button;
        private Label numbertotal_label;
        private Label categoryname_label;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem oProgramieToolStripMenuItem;
        private ToolStripMenuItem oProgramieToolStripMenuItem1;
        private ToolStripMenuItem wylogujToolStripMenuItem;
        private ToolStripMenuItem zamknijToolStripMenuItem;
    }
}