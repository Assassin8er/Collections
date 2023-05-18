using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Mono1
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D circleTexture;
        Texture2D rectangleTexture;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 800; 
            _graphics.PreferredBackBufferHeight = 500;
            _graphics.ApplyChanges();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            circleTexture = Content.Load<Texture2D>("circle");
            rectangleTexture = Content.Load<Texture2D>("rectangle");
            // TODO: use this.Content to load your game content here
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

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            _spriteBatch.Draw(circleTexture, new Vector2(130, 0), Color.Yellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(400, 110, 160, 50), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(200, 110, 160, 50), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(450, 150, 60, 50), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(250, 150, 60, 50), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(350, 270, 160, 100), Color.Black);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(430, 320, 300, 50), Color.Brown);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(480, 320, 30, 50), Color.LightGoldenrodYellow);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(680, 320, 30, 50), Color.Red);
            _spriteBatch.Draw(rectangleTexture, new Rectangle(710, 320, 20, 50), Color.Black);
            _spriteBatch.Draw(circleTexture, new Rectangle(710, 280, 20, 50), Color.Gray);
            _spriteBatch.Draw(circleTexture, new Rectangle(690, 260, 20, 50), Color.Gray);
            _spriteBatch.Draw(circleTexture, new Rectangle(730, 240, 20, 50), Color.Gray);

            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}