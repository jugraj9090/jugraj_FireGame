using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jugraj_FireGame
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

        private void play_btn_Click(object sender, EventArgs e)
        {
            //when ever we want to play then we have to click on the play button 
            Form2 play = new Form2();
            play.Visible=true;
            ///hide the current screen 
            this.Visible = false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            //when the user doesn't want to play then he can click on the exit button 
            Application.Exit();


        }
    }
}
