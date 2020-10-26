using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace game1.ExpressedEngine
{
    class Canvas : Form { 
        public Canvas()
        {
            this.DoubleBuffered = true;
        }
    }

    public abstract class ExpressedEngine
    {
        public Vector2 ScreenSize = new Vector2(512, 512);
        private string Title;

        public ExpressedEngine(Vector2 ScreenSize, string Title)
        {
            this.ScreenSize = ScreenSize;
            this.Title = Title;


        }
    }
}
