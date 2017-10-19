using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace PWDCARDCOLLECTOR
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Card cOne,cTwo;
        Pack pack1;
        private MouseState oldState;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            graphics.PreferredBackBufferWidth = 1920;  // set this value to the desired width of your window
            graphics.PreferredBackBufferHeight = 1080;   // set this value to the desired height of your window
            graphics.ApplyChanges();
            this.IsMouseVisible = true;

        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }


        protected override void LoadContent()
        {
            cOne = new Card(this,"img/Donald", spriteBatch);
            cTwo = new Card(this, "img/Zack", spriteBatch);

            spriteBatch = new SpriteBatch(GraphicsDevice);
            

           

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            MouseState mouseState = Mouse.GetState();
            MouseState newState = Mouse.GetState();
            int x = mouseState.X;
            int y = mouseState.Y;
            
            oldState = newState;

            
         

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();
            base.Draw(gameTime);
            cOne.Draw(spriteBatch);
            cTwo.Draw(spriteBatch);


            spriteBatch.End();
        }
    }
}
