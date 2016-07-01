using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Steak
{
    class FoodFactory
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle Food;

        public FoodFactory(Random randomFood)
        {
            
            brush = new SolidBrush(Color.White);
            x = randomFood.Next(0, 280);
            y = randomFood.Next(0, 290);
            width = 10;
            height = 10;
            Food = new Rectangle(x, y, width, height);
        }
        public void FoodLocation(Random randomFood)
        {
            x = randomFood.Next(0, 280);
            y = randomFood.Next(0, 290);
        }
        public void DrawFood(Graphics board)
        {
            
            Food.X = x;
            Food.Y = y;
            
            board.FillRectangle(brush, Food);
        }
    }
}