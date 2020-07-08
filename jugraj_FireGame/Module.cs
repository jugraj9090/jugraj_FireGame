using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jugraj_FireGame
{
  public  class Module
    {
        int rnd = 0,rndm=0;
        Random obj_rnd = new Random();

        public void StartGame(PictureBox pb) {
            //method to load the first image to start the game 
            pb.Image = jugraj_FireGame.Properties.Resources.st1;
            rnd = obj_rnd.Next(1,6);
            rndm = obj_rnd.Next(1, 3);
        }

        public void LoadGame(PictureBox pb)
        {
            //method to load the 2nd image to load the bullet in the gun 
            pb.Image = jugraj_FireGame.Properties.Resources.st2;
        }

        public void SpinGame(PictureBox pb)
        {
            //method to load the 3rd image to spin  the gun 
            pb.Image = jugraj_FireGame.Properties.Resources.st3;
        }

        public void ShotGame(PictureBox pb)
        {
            //method to load the 4th  image to shoot  the gun 
            pb.Image = jugraj_FireGame.Properties.Resources.st4;
        }
        //this method is used to generate the sound of the fire 
        public void fireGun() {
            System.Media.SoundPlayer objSound = new System.Media.SoundPlayer(jugraj_FireGame.Properties.Resources.fire);
            objSound.Play();
        }

        //this method is used to check the fire is killed or not 
        public int shotTest(int chk) {
            if (chk == rnd)
            {
                MessageBox.Show("Allas, you die !");
                return 1;
            }
            else {
                MessageBox.Show("Better Luck Next Time ! ");
                return 0;
            }
        }

        public int finalTest(int chk) {
            if (chk == rndm)
            {
                MessageBox.Show("Task Completed");
                return 1;
            }
            else {
                MessageBox.Show("last Chance to Kill ");
                return 0;
            }
        }




    }
}
