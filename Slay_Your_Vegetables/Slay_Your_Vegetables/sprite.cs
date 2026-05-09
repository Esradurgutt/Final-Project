using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Sprite
{
    public Texture2D Texture;
    public Vector2 Position;

    public Sprite(Texture2D texture, Vector2 position)
    {
        Texture = texture;
        Position = position;
    }

    public virtual void Update(GameTime gameTime)
    {
    }

    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(Texture, new Rectangle((int)Position.X, (int)Position.Y, 50, 50), Color.Red);
    }
}