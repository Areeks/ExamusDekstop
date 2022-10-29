using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examus
{
    public partial class UserPanel : Form
    {
        private int get_permission;
        private int now_question = 0;
        private int maxn_questions = 0;
        private string temp_question = "";
        public UserPanel(string name, int permission)
        {
            InitializeComponent();
            name_label.Text = name;
            is_admin(permission);
            get_permission = permission;
        }

        private void question_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(question_input.Text))
            {
                MessageBox.Show("Wprowadź pytanie", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                question_input.Focus();
                return;
            }
            if (temp_question != question_input.Text)
            {
                temp_question = question_input.Text;
                now_question = 0;
                maxn_questions = 0;
                next_question_button.Enabled = true;
            }
            var json = new WebClient().DownloadString("https://areeks.pl/getdata.php?question="+question_input.Text);
            if (json != "[]")
            {
                no_question();
                noquestion_label.Visible = false;
                dynamic res = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
                maxn_questions = 0;
                foreach (dynamic item in res)
                {
                    maxn_questions++;
                }
                if(maxn_questions > 1)
                {
                    next_question_button.Visible = true;
                    prev_question_button.Visible = true;
                    if(now_question==0) prev_question_button.Enabled = false;
                }
                int id = res[now_question]["id"];
                string text = res[now_question]["text"];
                string answer_a = res[now_question]["answer_a"];
                string answer_b = res[now_question]["answer_b"];
                string answer_c = res[now_question]["answer_c"];
                string answer_d = res[now_question]["answer_d"];
                string answer_e = res[now_question]["answer_e"];
                int count_a = res[now_question]["count_a"];
                int count_b = res[now_question]["count_b"];
                int count_c = res[now_question]["count_c"];
                int count_d = res[now_question]["count_d"];
                int count_e = res[now_question]["count_e"];
                string category = res[now_question]["category_id"];
                int max = Math.Max(count_a, Math.Max(count_b, Math.Max(count_c, Math.Max(count_d, count_e))));
                
                
                questiontext_label.Text = text;
                a_answer_label.Text = answer_a;
                b_answer_label.Text = answer_b;
                c_answer_label.Text = answer_c;
                d_answer_label.Text = answer_d;
                e_answer_label.Text = answer_e;
                count_a_label.Text = count_a.ToString();
                count_b_label.Text = count_b.ToString();
                count_c_label.Text = count_c.ToString();
                count_d_label.Text = count_d.ToString();
                count_e_label.Text = count_e.ToString();
                categoryname_label.Text = category;
                reset_question();
                green_question(max, count_a, count_b, count_c, count_d, count_e);
                yes_question();
            }
            else
            {
                no_question();
                noquestion_label.Visible = true;
            }
        }

        void is_admin(int permission)
        {
            if (permission > 0) admin_button.Visible = true;
        }

        void reset_question()
        {
            a_answer_label.ForeColor = Color.Black;
            b_answer_label.ForeColor = Color.Black;
            c_answer_label.ForeColor = Color.Black;
            d_answer_label.ForeColor = Color.Black;
            e_answer_label.ForeColor = Color.Black;
        }

        void green_question(int max, double a, double b, double c, double d, double e)
        {
            if (a == max) a_answer_label.ForeColor = Color.Green;
            else if (b == max) b_answer_label.ForeColor = Color.Green;
            else if (c == max) c_answer_label.ForeColor = Color.Green;
            else if (d == max) d_answer_label.ForeColor = Color.Green;
            else if (e == max) e_answer_label.ForeColor = Color.Green;

            double total = a + b + c + d + e;
            a_answer_bar.Value = (int)((a / total) * 100);
            b_answer_bar.Value = (int)((b / total) * 100);
            c_answer_bar.Value = (int)((c / total) * 100);
            d_answer_bar.Value = (int)((d / total) * 100);
            e_answer_bar.Value = (int)((e / total) * 100);
        }


        void yes_question()
        {
            questiontext_label.Visible = true;
            a_answer_label.Visible = true;
            b_answer_label.Visible = true;
            c_answer_label.Visible = true;
            d_answer_label.Visible = true;
            e_answer_label.Visible = true;
            categoryname_label.Visible = true;
            if(a_answer_label.Text!="") count_a_label.Visible = true;
            if (b_answer_label.Text != "") count_b_label.Visible = true;
            if (c_answer_label.Text != "") count_c_label.Visible = true;
            if (d_answer_label.Text != "") count_d_label.Visible = true;
            if (e_answer_label.Text != "") count_e_label.Visible = true;
            if (a_answer_label.Text != "") a_answer_bar.Visible = true;
            if (b_answer_label.Text != "") b_answer_bar.Visible = true;
            if (c_answer_label.Text != "") c_answer_bar.Visible = true;
            if (d_answer_label.Text != "") d_answer_bar.Visible = true;
            if (e_answer_label.Text != "") e_answer_bar.Visible = true;
            if (maxn_questions > 0)
            {
                numbertotal_label.Text = ((now_question + 1).ToString() + "/" + maxn_questions.ToString());
                numbertotal_label.Visible = true;
            }
        }

        void no_question()
        {
            questiontext_label.Visible = false;
            a_answer_label.Visible = false;
            b_answer_label.Visible = false;
            c_answer_label.Visible = false;
            d_answer_label.Visible = false;
            e_answer_label.Visible = false;
            count_a_label.Visible = false;
            count_b_label.Visible = false;
            count_c_label.Visible = false;
            count_d_label.Visible = false;
            count_e_label.Visible = false;
            a_answer_bar.Visible = false;
            b_answer_bar.Visible = false;
            c_answer_bar.Visible = false;
            d_answer_bar.Visible = false;
            e_answer_bar.Visible = false;
            numbertotal_label.Visible = false;
            next_question_button.Visible = false;
            prev_question_button.Visible = false;
            categoryname_label.Visible = false;
        }

        private void admin_button_Click(object sender, EventArgs e)
        {
            adminpanel adminpanel = new adminpanel(get_permission);
            adminpanel.Show();
        }

        private void next_question_button_Click(object sender, EventArgs e)
        {
            if (now_question < maxn_questions - 1)
            {
                now_question++;
                prev_question_button.Enabled = true;
            }
            else next_question_button.Enabled = false;
            if (now_question == maxn_questions - 1) next_question_button.Enabled = false;
            question_button_Click(sender, e);
        }

        private void prev_question_button_Click(object sender, EventArgs e)
        {
            if (now_question > 0)
            {
                now_question--;
                next_question_button.Enabled = true;
            }
            else prev_question_button.Enabled = false;
            question_button_Click(sender, e);
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
            form1.Closed += (s, args) => this.Close();
            form1.Show();
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oProgramieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            about about = new about();
            about.Show();
        }
    }
}
