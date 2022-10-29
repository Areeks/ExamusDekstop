using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text;
using XSystem.Security.Cryptography;

namespace Examus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(login_textbox.Text))
                {
                    MessageBox.Show("Wprowadü login", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    login_textbox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(pass_textbox.Text))
                {
                    MessageBox.Show("Wprowadü has≥o", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    pass_textbox.Focus();
                    return;
                }
                string name = login_textbox.Text;
                string password = MD5Hash(pass_textbox.Text);
                var json = new WebClient().DownloadString("https://areeks.pl/getdata.php?userlogin="+name+"&userpass="+password);
                if (json != "[]")
                {
                    dynamic res = Newtonsoft.Json.JsonConvert.DeserializeObject(json);

                    int id = res[0]["id"];
                    string user = res[0]["name"];
                    var expire = DateTime.Parse((string)res[0]["date_expire"]);
                    int active = res[0]["active"];
                    int permission = res[0]["permission"];
                    DateTime today = DateTime.Today;

                    if (active > 0 && expire >= today)
                    {
                        UserPanel userpanel = new UserPanel(user, permission);
                        userpanel.Show();
                        this.Hide();
                        userpanel.Closed += (s, args) => this.Close();
                        userpanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Twoje konto jest nieaktywne bπdü wygas≥o!");
                    }
                }
                else
                {
                    MessageBox.Show("B≥Ídny login bπdü has≥o!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        // funkcje
        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }
    }
}