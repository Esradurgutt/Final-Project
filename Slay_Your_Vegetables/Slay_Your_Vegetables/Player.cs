using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input; 

namespace Slay_Your_Vegetables
{
    internal class Player : Sprite
    {
        private int Speed = 5; 

        public Rectangle Rect
        {
            get
            {
                return new Rectangle((int)Position.X + 35, (int)Position.Y + 50, 90, 90);
            }
        }

        public Player(Texture2D texture, Vector2 position) : base(texture, position)
        {
            
        }
        //Movement Controls
        public void Update(GameTime gameTime)
        {
            KeyboardState state = Keyboard.GetState();

            
            if (state.IsKeyDown(Keys.W)) Position.Y -= Speed;
            if (state.IsKeyDown(Keys.S)) Position.Y += Speed;
            if (state.IsKeyDown(Keys.A)) Position.X -= Speed;
            if (state.IsKeyDown(Keys.D)) Position.X += Speed;
        }
    }
}
