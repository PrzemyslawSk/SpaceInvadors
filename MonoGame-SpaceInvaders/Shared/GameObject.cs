using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Shared
{
    public abstract class GameObject : IDisposable, IDrawable, IUpdateable
    {
        protected Texture2D texture;
        protected Vector2 vector;

        protected GameObject(Texture2D texture, Vector2 vector)
        {
            this.texture = texture;
            this.vector = vector;
        }

        #region IDisposable Support
        protected bool disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    texture.Dispose();
                }

                disposedValue = true;
            }
        }
        
        void IDisposable.Dispose()
        {
            Dispose(true);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();// :P
        }
        public virtual void Update(GameTime gameTime)
        {
            throw new NotImplementedException();// :P
        }
        #endregion
    }
}
