using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame_SpaceInvaders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Enemy
{
    public class AlienGameObject : GameObject, IDisposable
    {
        public float Speed { get; protected set; }
        protected GraphicsDeviceManager GraphicsDeviceManager { get; }
        //public float alienMovementSpeed = 300f;
        int evenOrOdd = 0;

        public AlienGameObject(Texture2D texture, Vector2 vector, float speed, GraphicsDeviceManager graphics) : base(texture, vector)
        {
            Speed = speed;
            GraphicsDeviceManager = graphics;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(base.texture, base.vector, Color.Wheat);
        }

        public override void Update(GameTime gameTime)
        {
            if (evenOrOdd % 2 == 0)
            {
                base.vector.X += Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (base.vector.X >= 1300)
                {
                    base.vector.Y += 50;
                    evenOrOdd += 1;
                }
            }

            if (evenOrOdd % 2 == 1)
            {
                base.vector.X -= Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (base.vector.X <= 0)
                {
                    base.vector.Y += 50;
                    evenOrOdd += 1;
                }
            }
        }
    }
}
