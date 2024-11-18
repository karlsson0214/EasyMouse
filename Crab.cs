using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace EasyMouse
{
    internal class Crab : Actor
    {
        public override void Update(GameTime gameTime)
        {
            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            var mouseState = Mouse.GetState();
            TurnTowards(mouseState.X, mouseState.Y);
            Move(100 * deltaTime);
        }
    }
}
