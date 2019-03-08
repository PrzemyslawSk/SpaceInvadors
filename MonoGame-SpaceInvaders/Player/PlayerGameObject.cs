using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame_SpaceInvaders.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Player
{
    public class PlayerGameObject : GameObject, IDisposable, Shared.IUpdateable, Shared.IDrawable
    {
        public float Speed { get; protected set; }
        protected GraphicsDeviceManager GraphicsDeviceManager { get; }

        public PlayerGameObject(Texture2D texture, Vector2 vector, float speed, GraphicsDeviceManager graphics) : base(texture, vector)
        {
            Speed = speed;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(base.texture, base.vector, null, Color.Wheat, 0f, new Vector2(texture.Width, texture.Height), Vector2.One, SpriteEffects.None, 0f);
        }

        public void Update(GameTime gameTime)
        {
            var keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Left))
                base.vector.X -= Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Right))
                base.vector.X += Speed * (float)gameTime.ElapsedGameTime.TotalSeconds;

            base.vector.X = Math.Min(
                Math.Max(base.texture.Width / 2, base.vector.X), 
                GraphicsDeviceManager.PreferredBackBufferWidth - texture.Width / 2
            );
        }

        #region IDisposable Support
        protected override void Dispose(bool disposing)
        {
            if (!base.disposedValue)
            {
                if (disposing)
                {
                    base.Dispose(disposing);//dispose base
                }

                base.disposedValue = true;
            }
        }
        #endregion
    }
}
