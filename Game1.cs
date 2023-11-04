using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame.Extended.BitmapFonts;
using sEngine;

namespace GameOff
{
    public class Game1 : Engine
    {
        public Game1() : base(1920, 1080, 1280, 720, "GameOff", false)
        {
            ClearColor = Color.CornflowerBlue;
            Content.RootDirectory = "Content";
            ViewPadding = -32;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            base.LoadContent();

            DebugFont = Content.Load<BitmapFont>("debug2");
        }

        protected override void Update(GameTime gameTime)
        {
            ActorManager.Update(DeltaTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);

            SpriteBatch.Begin();

            DrawDebugText("X  : 15", Vector2.Zero, Color.White);

            ActorManager.Draw();

            SpriteBatch.End();
        }
    }
}