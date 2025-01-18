using Raylib_cs;

namespace Pratyaksh_Engine
{
    public class Box : GORect
    {
        private float velocityY = 0.0f;
        private float mass = 1.0f;

        private GORect collider;

        public Box(float x, float y, float sizeX, float sizeY, Color color, float mass, GORect collider)
        {
            Transform = new Transform(x, y);
            SizeX = sizeX;
            SizeY = sizeY;
            Color = color;

            this.collider = collider;
            this.mass = mass;
        }

        public override void Input()
        {
        }

        public override void Update()
        {
            base.Update();

            velocityY += 9.8f * mass * Engine.DeltaTime;

            if (Physics.CheckRectCollision(collider, this) && velocityY > 0)
                velocityY = -velocityY * 0.75f;
            
            Transform.Y += velocityY * Engine.DeltaTime;
        }
    }
}
