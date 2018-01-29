using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Lab05
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public const int WindowWidth = 800;
        public const int WindowHeight = 600;

        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;

        private Texture2D frodo;
        private Rectangle frodoRect;
        private Texture2D gandalf;
        private Rectangle gandalfRect;
        private Texture2D legolas;
        private Rectangle legolasRect;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = WindowWidth;
            graphics.PreferredBackBufferHeight = WindowHeight;
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run. This is
        /// where it can query for any required services and load any non-graphic related content.
        /// Calling base.Initialize will enumerate through any components and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load our LOTR textures.
            frodo = Content.Load<Texture2D>(@"Graphics\frodo");
            frodoRect = new Rectangle(208, 236, frodo.Width, frodo.Height);
            gandalf = Content.Load<Texture2D>(@"Graphics\gandalf");
            gandalfRect = new Rectangle(336, 236, gandalf.Width, gandalf.Height);
            legolas = Content.Load<Texture2D>(@"Graphics\legolas");
            legolasRect = new Rectangle(464, 236, legolas.Width, legolas.Height);
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world, checking for collisions,
        /// gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(frodo, frodoRect, Color.White);
            spriteBatch.Draw(gandalf, gandalfRect, Color.White);
            spriteBatch.Draw(legolas, legolasRect, Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}