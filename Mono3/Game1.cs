using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono3
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Texture2D tribbleGreyTexture;
        Texture2D tribbleBrownTexture;
        Texture2D tribbleCreamTexture;
        Texture2D tribbleOrangeTexture;
        Rectangle tribbleGreyRect, tribbleBrownRect, tribbleCreamRect, tribbleOrangeRect;
        Vector2 tribbleGreySpeed, tribbleBrownSpeed, tribbleCreamSpeed, tribbleOrangeSpeed, gravity;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
            
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; // Sets the width of the window
            _graphics.PreferredBackBufferHeight = 600; // Sets the height of the window
            _graphics.ApplyChanges(); // Applies the new dimensions


            tribbleGreyRect = new Rectangle(10, 300, 100, 100);
            tribbleGreySpeed = new Vector2(2 ,-2);

            tribbleBrownRect = new Rectangle(75, 75, 100, 100);
            tribbleBrownSpeed = new Vector2(3, -2);

            tribbleCreamRect = new Rectangle(120, 200, 100, 100);
            tribbleCreamSpeed = new Vector2(4, -3);

            tribbleOrangeRect = new Rectangle(200, 170, 100, 100);
            tribbleOrangeSpeed = new Vector2(3, -2);

            gravity = new Vector2(0, 1);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            tribbleBrownTexture = Content.Load<Texture2D>("tribbleBrown");
            tribbleCreamTexture = Content.Load<Texture2D>("tribbleCream");
            tribbleOrangeTexture = Content.Load<Texture2D>("tribbleOrange");
            tribbleGreyTexture = Content.Load<Texture2D>("tribbleGrey");
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            tribbleGreyRect.X += (int)tribbleGreySpeed.X;
            tribbleGreyRect.Y += (int)tribbleGreySpeed.Y;

            tribbleCreamRect.X += (int)tribbleCreamSpeed.X;
            tribbleCreamRect.Y += (int)tribbleCreamSpeed.Y;

            tribbleBrownRect.X += (int)tribbleBrownSpeed.X;
            tribbleBrownRect.Y += (int)tribbleBrownSpeed.Y;

            tribbleOrangeRect.X += (int)tribbleOrangeSpeed.X;
            tribbleOrangeRect.Y += (int)tribbleOrangeSpeed.Y;

            tribbleGreySpeed.Y += (int)gravity.Y;
            tribbleCreamSpeed.Y += (int)gravity.Y;
            tribbleBrownSpeed.Y += (int)gravity.Y;
            tribbleOrangeSpeed.Y += (int)gravity.Y;



            if (tribbleGreyRect.X > 700 || tribbleGreyRect.X <= 0)
                tribbleGreySpeed.X *= -1;
            if (tribbleGreyRect.Y > 500 || tribbleGreyRect.Y <= 0)
            {
                tribbleGreySpeed.Y *= -1;
                tribbleGreyRect.Y =500;
            }

            if (tribbleBrownRect.X > 700 || tribbleBrownRect.X <= 0)
                tribbleBrownSpeed.X *= -1;
            if (tribbleBrownRect.Y > 500 || tribbleBrownRect.Y <= 0)
            {
                tribbleBrownSpeed.Y *= -1;
                tribbleBrownRect.Y = 500;
            }

            if (tribbleCreamRect.X > 700 || tribbleCreamRect.X <= 0)
                tribbleCreamSpeed.X *= -1;
            if (tribbleCreamRect.Y > 500 || tribbleCreamRect.Y <= 0)
            {
                tribbleCreamSpeed.Y *= -1;
                tribbleCreamRect.Y = 500;
            }

            if (tribbleOrangeRect.X > 700 || tribbleOrangeRect.X <= 0)
                tribbleOrangeSpeed.X *= -1;
            if (tribbleOrangeRect.Y > 500 || tribbleOrangeRect.Y <= 0)
            {
                tribbleOrangeSpeed.Y *= -1;
                tribbleOrangeRect.Y = 500;
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(tribbleBrownTexture, tribbleBrownRect, Color.White);
            _spriteBatch.Draw(tribbleGreyTexture, tribbleGreyRect, Color.White);
            _spriteBatch.Draw(tribbleCreamTexture, tribbleCreamRect, Color.White);
            _spriteBatch.Draw(tribbleOrangeTexture, tribbleOrangeRect, Color.White);
            _spriteBatch.End();
            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}