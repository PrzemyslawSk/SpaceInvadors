using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Player
{
    class Movement
    {
        public void KBind(ref Vector2 warshipPosition, float warshipMovementSpeed, GameTime gameTime, Texture2D warshipTexture, GraphicsDeviceManager graphics)
        {
            var keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Left))
                warshipPosition.X -= warshipMovementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (keyboardState.IsKeyDown(Keys.Right))
                warshipPosition.X += warshipMovementSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            warshipPosition.X = Math.Min(Math.Max(warshipTexture.Width / 2, warshipPosition.X), graphics.PreferredBackBufferWidth - warshipTexture.Width / 2);
            //if (keyboardState.IsKeyDown(Keys.Space))
        }
    }
}
