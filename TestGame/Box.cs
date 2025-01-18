using Raylib_cs;

namespace Pratyaksh_Engine
{
    public class Box : GORect
    {
        private bool test = false;

        public Box(float x, float y, float sizeX, float sizeY, Color color)
        {
            Transform = new Transform(x, y);
            SizeX = sizeX;
            SizeY = sizeY;
            Color = color;
        }

        public override void Input()
        {
            if (Raylib.IsKeyDown(KeyboardKey.Space))
            {
                test = true;
            }

        }

        public override void Update()
        {
            base.Update();

            if (!test) Transform.X += 0.005f;
            else Transform.Y += 0.005f;
        }
    }
}
