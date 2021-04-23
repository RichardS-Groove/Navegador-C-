using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q=" + tBuscar.Text + "&sxsrf=ALeKk01gI0283zoM3QOUq7-XI97jtHdyig%3A1619195400465&source=hp&ei=CPaCYIuVGorR1sQPo72QwAw&iflsig=AINFCbYAAAAAYIMEGMtNc53Y-v9yo6qA60RoEbBFWt_Q&oq=" + tBuscar.Text + "&gs_lcp=Cgdnd3Mtd2l6EAMyBAgjECcyBQguELEDMgUILhCxAzIICAAQsQMQgwEyBQgAELEDMggIABCxAxCDATIFCC4QsQMyAggAMgUILhCxAzIICAAQsQMQgwE6CwgAELEDEMcBEKMCOggILhCxAxCDAVC4qAJY26wCYLGuAmgAcAB4AIABkgGIAbUEkgEDMS40mAEAoAEBqgEHZ3dzLXdpeg&sclient=gws-wiz&ved=0ahUKEwiLuaj15JTwAhWKqJUCHaMeBMgQ4dUDCAk&uact=5");
        }

    }
}
