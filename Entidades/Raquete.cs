using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Projeto_Jogo_Pong.Entidades
{
    public class Raquete
    {
        public Rectangle retangulo;

        // Metodo Construtor - Metodo que tem o mesmo nome da classe
        // Determina açoes do objeto da classe
        public Raquete()
        {
            retangulo = new Rectangle(0, 140, 30, 180);
        }
        
        public void Update(GameTime gameTime)
        {
            KeyboardState teclado = Keyboard.GetState();

            if (teclado.IsKeyDown(Keys.W) && retangulo.Y > 0)
            {
                // Tempo Delta
                retangulo.Y -= (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            }
            if (teclado.IsKeyDown(Keys.S) && retangulo.Y < Global.ALTURA - retangulo.Height) 
            {
                
                retangulo.Y += (int)(400 * gameTime.ElapsedGameTime.TotalSeconds);
            }
        }

        public void Draw()
        {
            Global.spriteBatch.Draw(Global.textura, retangulo, Color.White);
        }
    }
}
