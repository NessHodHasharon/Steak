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
            foreach (Rectangle link in SteakEater); board.FillRectangle(brush, x, y, width, height);
        }
        public void DrawSteakEaterProgress()
        {
            for (int i = SteakEater.Length - 1; i > 0; i-- , SteakEater[ i ] = SteakEater[i=1]) ;
        }
        public void MoveDown()
        {
            DrawSteakEaterProgress();
            SteakEater[0].Y += 10;
        }
        public void MoveUp()
        {
            DrawSteakEaterProgress();
            SteakEater[0].Y -= 10;
        }
        public void MoveRight()
        {
            DrawSteakEaterProgress();
            SteakEater[0].X += 10;
        }
        public void MoveLeft()
        {
            DrawSteakEaterProgress();
            SteakEater[0].X -= 10;
        }
        public void MakeSteakEaterGrow()
        {
            Rectangle[] NewSteakEater = new Rectangle[SteakEater.Length + 1];
            for (int i = 0; i < SteakEater.Length; i++, NewSteakEater[i] = SteakEater[i] ) ;
            int LastX = NewSteakEater[NewSteakEater.Length - 1].X;
            int LastY = NewSteakEater[NewSteakEater.Length - 1].Y;
            NewSteakEater[NewSteakEater.Length - 1] = new Rectangle(LastX, LastY, width, height);
        }
    }
}
