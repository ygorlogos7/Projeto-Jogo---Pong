using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Projeto_Jogo_Pong;
using Projeto_Jogo_Pong.Entidades;

namespace Projeto_Jogo___Pong
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private Raquete raquete1;
           public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = Global.LARGURA;
            _graphics.PreferredBackBufferHeight = Global.ALTURA;
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            raquete1 = new Raquete();

            base.Initialize();
        }
            
        protected override void LoadContent()
        {
            Global.spriteBatch = new SpriteBatch(GraphicsDevice);

            Global.textura = new Texture2D(GraphicsDevice, 1, 1);

            Global.textura.SetData < Color >([Color.White]);

        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            raquete1.Update(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            Global.spriteBatch.Begin();

            raquete1.Draw();

           Global.spriteBatch.End();

            base.Draw(gameTime);

        }
    }
}
