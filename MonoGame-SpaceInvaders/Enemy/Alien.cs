using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Enemy
{
    public class Alien
    {
        public Texture2D alienTexture;
        public Vector2 alienPosition;
        public float alienMovementSpeed = 300f;
        int evenOrOdd=0;

        public void alienPos(ref Vector2 alienPosition, float alienMovementSpeed, GameTime gameTime, Texture2D alienTexture, GraphicsDeviceManager graphics)
        {
            if (evenOrOdd % 2 == 0)
            {
                alienPosition.X += alienMovementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (alienPosition.X >= 1300)
                {
                    alienPosition.Y += 50;
                    evenOrOdd += 1;
                }
            }

            if (evenOrOdd % 2 == 1)
            {
                alienPosition.X -= alienMovementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (alienPosition.X <= 0)
                {
                    alienPosition.Y += 50;
                    evenOrOdd += 1;
                }
            }
        }


    }
}
