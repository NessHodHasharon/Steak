using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steak
{
    public partial class Main : Form
    {
        Random randomLocation = new Random();
        Graphics board;
        SteakEaterManager manager = new SteakEaterManager();
        FoodFactory factory;
        bool left = true;
        bool right = false;
        bool up = false;
        bool down = false;
        int score = 0;

        public Main()
        {
            InitializeComponent();
            factory = new FoodFactory(randomLocation);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Main_Paint(object sender, PaintEventArgs e)
        {
            board = e.Graphics;
            factory.DrawFood(board);
            manager.DrawSteakEater(board);
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                SteakTitleLabel.Visible = false;
                SpaceBarLabel.Visible = false;
                RestartLabel.Visible = false;
                right = true;
                left = false;
                up = false;
                down = false;
                scoreNumber.Text = "0";
            }
            if(e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                up = true;
                down = false;
                left = false;
                right = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                left = true;
                right = false;
                up = false;
                down = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                right = true;
                left = false;
                up = false;
                down = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scoreLabel.Text = Convert.ToString(score);
            if (down == true)
            {
                manager.MoveDown();
            }
            if (up == true)
            {
                manager.MoveUp();
            }
            if (left == true)
            {
                manager.MoveLeft();
            }
            if (right == true)
            {
                manager.MoveRight();
            }
            this.Invalidate();
            Collision();
            if (manager.GetSteakEater()[0].IntersectsWith(factory.Food)) 
            {
                score += 1;
                manager.MakeSteakEaterGrow();
                factory.FoodLocation(randomLocation);
            }
        }
        public void Restart()
        {
            timer1.Enabled = false;
            MessageBox.Show("You ate it!");
            RestartLabel.Visible = true;
            manager = new SteakEaterManager();
        }
        public void Collision()
        {
            if (manager.GetSteakEater()[0].Y < 0 || manager.GetSteakEater()[0].Y < 0) 
            {
                Restart();
            }
            if (manager.GetSteakEater()[0].X < 0 || manager.GetSteakEater()[0].X > 280) 
            {
                Restart();
            }
            for (int i = 1; i < manager.GetSteakEater().Length; i++) 
            {
                if (manager.GetSteakEater()[0].IntersectsWith(manager.GetSteakEater()[i])) 
                {
                    Restart();
                }
            }
        }
    }
}
