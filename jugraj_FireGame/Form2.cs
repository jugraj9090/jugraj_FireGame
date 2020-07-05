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
    public partial class Form2 : Form
    {
        Module mod = new Module();
        int chances = 0;
        int finalChance = 0;
        public Form2()
        {
            InitializeComponent();
            //reset the button to create the game working 
            ldbtn.Enabled = false;
            spinbtn.Enabled = false;
            shotbtn.Enabled = false;
            shotawaybtn.Enabled = false;
            reloadbtn.Enabled = false;
        }

        private void stbtn_Click(object sender, EventArgs e)
        {
            //calling the first method to start the game
            mod.StartGame(pb);
            stbtn.Enabled = false;
            ldbtn.Enabled = true;
        }

        private void ldbtn_Click(object sender, EventArgs e)
        {
            //calling the another method to load the bullet in the gun
            mod.LoadGame(pb);
            ldbtn.Enabled = false;
            spinbtn.Enabled = true;
        }

        private void spinbtn_Click(object sender, EventArgs e)
        {
            //this method is used to spin the gun to move the bullet forward backward
            mod.SpinGame(pb);
            spinbtn.Enabled = false;
            shotawaybtn.Enabled = true;
            shotbtn.Enabled = true;
        }

        private void shotbtn_Click(object sender, EventArgs e)
        {
            chances++;
            //this method is used to fire the bullet to kill the enemy 
            mod.fireGun();

            //have only 4 chances to kill 
            if (mod.shotTest(chances)==1 || chances == 4)
            {
                shotbtn.Enabled = false;
                shotawaybtn.Enabled = false;
                reloadbtn.Enabled = true;
            }




        }

        private void shotawaybtn_Click(object sender, EventArgs e)
        {
            //kill using last chance and have only two trigger to kill 
            finalChance++;
            mod.fireGun();
            if (mod.finalTest(finalChance)==1 || finalChance==2) {
                shotbtn.Enabled = false;
                shotawaybtn.Enabled = false;
                reloadbtn.Enabled = true;
            }

        }

        private void reloadbtn_Click(object sender, EventArgs e)
        {

            MessageBox.Show("If, you want to play again then click on the start button ");
            reloadbtn.Enabled = false;
            stbtn.Enabled = true;
        }
    }
}
