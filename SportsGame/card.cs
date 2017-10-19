using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PWDCARDCOLLECTOR
{
    public class Card
    {
        private Texture2D card1;
        Rectangle rect;
        Game1 game;
        private Rectangle box;
        private Texture2D solidTexture;
        private Game1 game1;
        public Card(Game1 g, String imgname, SpriteBatch sb)
        {
            game1 = g;
            card1 = game1.Content.Load<Texture2D>(imgname);
            SpriteBatch spritebatch = sb;
            
        }
        public void Draw(SpriteBatch sb)
        {
            sb.Draw(card1, new Rectangle(0, 0, 320, 568), Color.White);
        }
        
     


 

    }
}
