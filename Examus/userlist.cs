﻿using System;
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
    public partial class userlist : Form
    {
        public userlist()
        {
            InitializeComponent();
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void usersgridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
