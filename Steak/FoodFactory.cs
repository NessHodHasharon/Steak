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
            x = randomFood.Next(0, 280);
            y = randomFood.Next(0, 290);
            new SolidBrush(Color.Black);
            width = 10;
            height = 10;
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