using System.Collections.Generic;
using System.Media;
using System.IO;

namespace Schlange
{
    class Ball
    {
        private int directionX = 1; // 1 = nach rechts, -1 = nach links
        private int directionY = 1; // 1 = nach unten, -1 = nach oben
        Dictionary<int, int> balllocation = new Dictionary<int, int>();
        protected int y = 0;
        protected int x = 0;
        public Ball()
        {
            this.x = 0;
            this.y = 469;
        }
        public void Move_1()
        {
            while (true)
            {
                if (x >= 500 )
                    directionX = -1;
                if (x <= 0)
                    directionX = 1;
                if (y >= 300)
                    directionY = -1;
                if (y <= 0)
                    directionY = 1;
                if (directionY == 1)
                    Y += 10;
                if (directionY == -1)
                    Y -= 10;
                if (directionX == 1)
                    X += 10;
                if (directionX == -1)
                    X -= 10;
            }
        }
        public void PlaySuond()
        {
            //SoundPlayer player = new SoundPlayer(@"C:\Users\n.meassar\Music.wav");
            //player.Play();
        }

        public int X
        {
            get
            { return x; }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            { return y; }
            set
            {
                y = value;
            }
        }

        public void Ball3Move()
        {
            for (int i = 0; i >= 0;)
            {
                //System.Threading.Thread.Sleep(50);
                X += 2;
                if (X >= 429 && Y >= 0)
                {
                    X = 0;

                }

                break;
            }



            //while (true)
            //{



            //    //if (Y >= 300) // Ball ist unten
            //    //{
            //    //    directionY = -1; // Ball soll nach oben
            //    //}
            //    //if (Y <= 0)
            //    //{
            //    //    directionY = 1;
            //    //}

            //    //if (X <= 0)
            //    //{
            //    //    directionX = 1;
            //    //}
            //    //if (X >= 400)
            //    //{
            //    //    directionX = -1;
            //    //}
            //    //if (directionX == 1)
            //    //    X += 10;
            //    //if (directionX == -1)
            //    //    X -= 5;
            //    //if (directionY == 1)
            //    //    Y += 5;
            //    //if (directionY == -1)
            //    //    Y -= 5;
            //    //balllocation.Add(X, Y);


            //}
        }






    }

    class MediaPlayer
    {
        public MediaPlayer()
        {
        }
    }
}
