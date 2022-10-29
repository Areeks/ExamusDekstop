using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examus
{
    public partial class adminpanel : Form
    {
        public adminpanel(int permission)
        {
            InitializeComponent();
        }

        private void user_button_Click(object sender, EventArgs e)
        {
            userlist userlist = new userlist();
            userlist.Show();
        }
    }
}
