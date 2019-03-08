using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Timers;

namespace MonoGame_SpaceInvaders
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        public Texture2D backgroundImage;
        public Texture2D warshipTexture;
        public Vector2 warshipPosition;
        public float warshipMovementSpeed;

        Enemy.Alien alien = new Enemy.Alien();
        Player.Movement keyBinds = new Player.Movement();
        Player.Bullet bullet = new Player.Bullet();

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        
        public Game1()
        {
            this.IsFixedTimeStep = true;
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            #region windowSize
            graphics.PreferredBackBufferWidth = 1366;
            graphics.PreferredBackBufferHeight = 768;
            graphics.ApplyChanges();
            #endregion
            #region warshipInfo
            warshipPosition = new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight - 30);
            warshipMovementSpeed = 750f;
            #endregion

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            backgroundImage = Content.Load<Texture2D>("background");
            warshipTexture = Content.Load<Texture2D>("warship");
            alien.alienTexture = Content.Load<Texture2D>("alien");
            bullet.bulletTexture = Content.Load<Texture2D>("bullet");
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            #region warshipKeyBinds
            keyBinds.KBind(ref warshipPosition, warshipMovementSpeed, gameTime, warshipTexture, graphics);

            #endregion

            alien.alienPos(ref alien.alienPosition, alien.alienMovementSpeed, gameTime, alien.alienTexture, graphics);

            bullet.BulletMovement(ref bullet.bulletPosition, bullet.bulletMovementSpeed, gameTime, bullet.bulletTexture, graphics);

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            // TODO: Add your drawing code here
            spriteBatch.Begin();
            spriteBatch.Draw(backgroundImage, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(warshipTexture, warshipPosition, null, Color.White, 0f, new Vector2(warshipTexture.Width / 2, warshipTexture.Height / 2),Vector2.One,SpriteEffects.None, 0f);
            spriteBatch.Draw(alien.alienTexture, alien.alienPosition, Color.White);
            spriteBatch.Draw(bullet.bulletTexture, bullet.bulletPosition, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
