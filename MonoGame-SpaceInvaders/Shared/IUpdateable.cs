using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Shared
{
    public interface IUpdateable
    {
        void Update(GameTime gameTime);
    }
}
