using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Player
{
    public class Bullet
    {
        public Texture2D bulletTexture;
        public Vector2 bulletPosition;
        public float bulletMovementSpeed = 300f;

        public void BulletMovement(ref Vector2 bulletPosition, float bulletMovementSpeed, GameTime gameTime, Texture2D bulletTexture, GraphicsDeviceManager graphics)
        {
            bulletPosition.Y += bulletMovementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
        }
    }
}
