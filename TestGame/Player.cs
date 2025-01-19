using Raylib_cs;

namespace Pratyaksh_Engine
{
    public class Player : GORect
    {
        private float velocityX = 0.0f;
        private float velocityY = 0.0f;

        private int destroyedBoxes = 0;

        public Player()
        {
            Color = Color.White;
            SizeX = SizeY = 50;
            Transform = new Transform(275, 500);
        }

        public void AddDestroyedBox()
        {
            destroyedBoxes++;
        }

        public override void Input()
        {
            base.Input();

            if (Raylib.IsKeyDown(KeyboardKey.W))
            {
                velocityY = -100.0f;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.A))
            {
                velocityX = -100.0f;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.S))
            {
                velocityY = 100.0f;
            }
            else if (Raylib.IsKeyDown(KeyboardKey.D))
            {
                velocityX = 100.0f;
            }
            else
            {
                velocityX = 0.0f;
                velocityY = 0.0f;
            }
        }

        public override void Update()
        {
            base.Update();

            Transform.X += velocityX * Engine.DeltaTime;
            Transform.Y += velocityY * Engine.DeltaTime;
        }

        public override void Render()
        {
            base.Render();
            Raylib.DrawText("Destroyed boxes: " + destroyedBoxes + "!", 10, 10, 20, Color.White);
        }
    }
}
