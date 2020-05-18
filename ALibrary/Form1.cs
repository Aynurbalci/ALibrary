using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace ALibrary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Sound()
        {
            System.Media.SoundPlayer sound = new System.Media.SoundPlayer();
            sound.SoundLocation = "hauser-adagio-albinoni.wav";
            sound.Play();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

      
       

      

      

        private void buttons_Click_1(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void buttonU_Click_1(object sender, EventArgs e)
        {

            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }
    }
}
