using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

internal class Player : Sprite
{
    public int Speed = 5;
    public int Width = 50;  
    public int Height = 50; 

    public Player(Texture2D texture, Vector2 position) : base(texture, position) { }

    public override void Update(GameTime gameTime)
    {
        KeyboardState state = Keyboard.GetState();
        Vector2 movement = Vector2.Zero;

        if (state.IsKeyDown(Keys.W)) movement.Y -= 1;
        if (state.IsKeyDown(Keys.S)) movement.Y += 1;
        if (state.IsKeyDown(Keys.A)) movement.X -= 1;
        if (state.IsKeyDown(Keys.D)) movement.X += 1;

        if (movement != Vector2.Zero)
        {
            movement.Normalize();
            Position += movement * Speed;
        }
    }

    public override void Draw(SpriteBatch spriteBatch)
    {
        Rectangle destinationRect = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
        spriteBatch.Draw(Texture, destinationRect, Color.White);
    }
}