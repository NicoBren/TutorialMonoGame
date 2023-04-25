using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TutorialMonoGame
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        private List<Texture2D> texBgs = new List<Texture2D>();
        private Texture2D texBtnPlay;
        private Texture2D texBtnPlayDown;
        private Texture2D texBtnPlayHover;
        private Texture2D texBtnRestart;
        private Texture2D texBtnRestartDown;
        private Texture2D texBtnRestartHover;
        private Texture2D texPlayer;
        private Texture2D texPlayerLaser;
        private Texture2D texEnemyLaser;
        private List<Texture2D> texEnemies = new List<Texture2D>();
        private Texture2D texExplosion;

        public SoundEffect sndBtnDown;
        public SoundEffect sndBtnOver;
        public List<SoundEffect> sndExplode = new List<SoundEffect>();
        public SoundEffect sndLaser;

        private SpriteFont fontArial;

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

            // TODO: use this.Content to load your game content here
            // Load textures

            for (int i = 0; i < 2; i++)
            {
                texBgs.Add(Content.Load<Texture2D>("sprBg" + i));
            }

            texBtnPlay = Content.Load<Texture2D>("sprBtnPlay");
            texBtnPlayDown = Content.Load<Texture2D>("sprBtnPlayDown");
            texBtnPlayHover = Content.Load<Texture2D>("sprBtnPlayHover");

            texBtnRestart = Content.Load<Texture2D>("sprBtnRestart");
            texBtnRestartDown = Content.Load<Texture2D>("sprBtnRestartDown");
            texBtnRestartHover = Content.Load<Texture2D>("sprBtnRestartHover");

            texPlayer = Content.Load<Texture2D>("sprPlayer");
            texPlayerLaser = Content.Load<Texture2D>("sprLaserPlayer");
            texEnemyLaser = Content.Load<Texture2D>("sprLaserEnemy0");

            for (int i = 0; i < 3; i++)
            {
                texEnemies.Add(Content.Load<Texture2D>("sprEnemy" + i));
            }

            texExplosion = Content.Load<Texture2D>("sprExplosion");
            // Load sounds
            sndBtnDown = Content.Load<SoundEffect>("sndBtnDown");
            sndBtnOver = Content.Load<SoundEffect>("sndBtnOver");
            for (int i = 0; i < 2; i++)
            {
                sndExplode.Add(Content.Load<SoundEffect>("sndExplode" + i));
            }
            sndLaser = Content.Load<SoundEffect>("sndLaser");
            // Load sprite fonts

            fontArial = Content.Load<SpriteFont>("arialHeading");
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

            base.Draw(gameTime);
        }
    }
}