using Raylib_cs;

namespace Pratyaksh_Engine
{
    public class GORect : GameObject
    {
        private float sizeX;
        private float sizeY;

        private Color color;

        public float SizeX { get => sizeX; protected set => sizeX = value; }
        public float SizeY { get => sizeY; protected set => sizeY = value; }
        public Color Color { get => color; protected set => color = value; }

        public GORect()
        {
            Transform = new Transform();
            sizeX = sizeY = 5.0f;
            color = Color.White;
        }

        public GORect(float x, float y, float sizeX, float sizeY)
        {
            Transform = new Transform(x, y);
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            color = Color.White;
        }

        public GORect(float x, float y, float sizeX, float sizeY, Color color)
        {
            Transform = new Transform(x, y);
            this.sizeX = sizeX;
            this.sizeY = sizeY;
            this.color = color;
        }

        public override void Render()
        {
            Raylib.DrawRectangle((int)Transform.X, (int)Transform.Y, (int)sizeX, (int)sizeY, color);
        }

        public override void Update() { }

        public override void Input() { }
    }
}
