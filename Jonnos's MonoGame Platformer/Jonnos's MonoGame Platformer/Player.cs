using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;


namespace Jonnos_s_MonoGame_Platformer
{
    class Player
    {
        Sprite playerSprite = new Sprite();
      

        public Player()
        {

        }

        public void Load(ContentManager content)
        {
            playerSprite.Load(content, "hero");
        }

        public void Update(float deltaTime)
        {
            playerSprite.Update(deltaTime);

           
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            playerSprite.Draw(spriteBatch);
        }
    }
}
