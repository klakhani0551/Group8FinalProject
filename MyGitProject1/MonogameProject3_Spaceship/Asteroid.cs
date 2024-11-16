﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace MonogameProject3_Spaceship
{
    internal class Asteroid
    {
        public Vector2 position = new Vector2(1300, 300);
        public int speed;
        static public int radius = 60;

        public Asteroid(int speed)
        {
            this.speed = speed;
        }

        public void updateAsteroid()
        {
           this.position.X -= this.speed;
        }
    }
}
