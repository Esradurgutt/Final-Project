using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

public class Sprite
{
    public Texture2D texture;
    public Vector2 Position;

    public Sprite(Texture2D texture, Vector2 position)
    {
        this.texture = texture;
        this.Position = position;
    }
    public virtual void Draw(SpriteBatch spriteBatch)
    {
        spriteBatch.Draw(texture,Position,Color.White);
    }
}