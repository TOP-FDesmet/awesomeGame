using System.Linq.Expressions;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace TheDarkSeries;

public class Game1 : Game
{
    Texture2D pixel;

    Rectangle smallRectangle;
    Rectangle ground;
    
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        pixel = new Texture2D(GraphicsDevice, 1, 1);
        pixel.SetData<Color>(new Color [] { Color.White });

        int smallRectangleWidth = 32;
        int smallRectangleHeight = 32;
        int groundWidth = _graphics.PreferredBackBufferWidth;
        int groundHeight = 50;

        smallRectangle = new Rectangle(
            _graphics.PreferredBackBufferWidth / 2 - smallRectangleWidth / 2, 
            0, 
            smallRectangleWidth, 
            smallRectangleHeight
        );

        ground = new Rectangle(
            0,
            _graphics.PreferredBackBufferHeight - groundHeight,
            groundWidth,
            groundHeight
        );
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        _spriteBatch.Begin();

        _spriteBatch.Draw(pixel, smallRectangle, Color.BlueViolet);
        _spriteBatch.Draw(pixel, ground, Color.Beige);
        
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
