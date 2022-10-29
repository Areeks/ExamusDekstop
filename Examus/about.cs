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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
            using (var client = new WebClient())
            {
                var imageData = client.DownloadData("https://areeks.pl/assets/img/logo128x128.png");

                var converter = new ImageConverter();
                var image = (Image)converter.ConvertFrom(imageData);

                logo_picture.Image = image;
            }
        }
    }
}
