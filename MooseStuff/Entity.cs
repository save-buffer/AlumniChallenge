using Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumni.MooseStuff
{
    class Entity : Element
    {
        public Vector Position;
        public Vector Velocity;
        public Texture Texture;

        public Entity(string Name, Texture Texture) :
            this(Name, new Vector(), new Vector(), Texture)
        {
        }

        public Entity(string Name, Vector Position, Vector Velocity, Texture Texture) :
            base(Name)
        {
            this.Position = Position;
            this.Velocity = Velocity;
            this.Texture = Texture;
            Console.WriteLine("Entity: " + Name + " initialized.");
        }

        public virtual void Initialize()
        {

        }

        public override void Update()
        {
            Position.Add(Velocity);
        }

        public override void Draw(Graphics g, Engine.PointF Dimensions)
        {
            if (Texture.Image != null)
            {
                g.DrawImage(Texture.Image, Dimensions); //Draw the image
            }
        }

        public virtual void Destroy()
        {

        }
    }
}
