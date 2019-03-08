using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoGame_SpaceInvaders.Shared
{
    public abstract class GameObject
    {
        public Texture2D texture;
        public Vector2 position;
        //public float warshipMovementSpeed;

        GameObject(Texture2D texture2D, Vector2D vector2D) {  }

    }
}
