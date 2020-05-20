using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALibrary
{
    public partial class Facebooklogin : Form
    {
        public Facebooklogin()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (webBrowser1.Url.ToString() == "https://www.facebook.com/")
            {
                timer1.Stop();
                webBrowser1.Navigate("https://www.facebook.com/settings");
                timer3.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            timer1.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            foreach(HtmlElement element in webBrowser1.Document.All)
            {
                if(element.GetAttribute("classname") == "fbSettingsListItemContent fcg")
                {
                }
            }
            

        }
        bool move;
        int mouse_x;
        int mouse_y;

        private void button1_Click(object sender, EventArgs e)
        {
           
                Application.Exit();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void Facebooklogin_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Facebooklogin_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;

        }

        private void Facebooklogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);

            }
        }

       
    }
}
