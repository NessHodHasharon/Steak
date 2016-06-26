using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Steak
{
    class SteakEaterManager
    {
        private Rectangle[] SteakEater;
        private SolidBrush brush;
        private int x, y, width, height;
        public SteakEaterManager()
        {
            SteakEater = new Rectangle[3];
            brush = new SolidBrush(Color.White);
            x = 20;
            y = 0;
            height = 10;
            for (int i = 0; i < SteakEater.Length; i++, SteakEater[i] = new Rectangle(x, y, width, height)) ;
            x -= 10;
        }
        public Rectangle[] GetSteakEater()
        {
            return SteakEater;
        }
        public void DrawSteakEater(Graphics board)
        {
            foreach (Rectangle link in SteakEater);
        }
    }
}
