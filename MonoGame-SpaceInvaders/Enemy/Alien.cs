using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Enemy
{
    public class Alien
    {
        public Vector2 position;
        public Texture2D texture;
        public bool canDraw;
        int positionUpdateCounter=0;


        public Alien()
        {
            position = new Vector2(0,0);
        }
        public void UpdatePosition(GameTime gameTime)
        {
            if(positionUpdateCounter>60)
            {
                position.X += 50;
                positionUpdateCounter = 0;
            }
            else
            {
                positionUpdateCounter++;
            }
        }
    }
}
