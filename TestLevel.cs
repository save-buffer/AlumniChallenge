using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;
using Alumni.MooseStuff;

namespace Alumni
{
    class TestLevel : State
    {
        public Entity player;

        public TestLevel()
        {
            player = new Entity("Test Entity", new Texture("tileDefault.png"));
        }

        public override void Initialize()
        {
            base.Initialize();
            Game.AddElement(player);
            Game.AddElement(new SolidObject("Tile", "tileDefault.png", 32, 32));
        }

        public override void Update()
        {
            base.Update();

            Console.WriteLine("Position: " + player.Position.x + ", " + player.Position.y);

            player.Velocity.Set(0, 0);

            if (Game.IsKeyPressed(Keys.A))
            {
                player.Velocity.Add(new Vector(-1, 0));
            }
            if (Game.IsKeyPressed(Keys.D))
            {
                player.Velocity.Add(new Vector(1, 0));
            }
            if (Game.IsKeyPressed(Keys.W))
            {
                player.Velocity.Add(new Vector(0, 1));
            }
            if (Game.IsKeyPressed(Keys.S))
            {
                player.Velocity.Add(new Vector(0, -1));
            }
        }
    }
}
