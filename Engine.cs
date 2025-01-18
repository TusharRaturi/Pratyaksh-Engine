using Raylib_cs;

namespace Pratyaksh_Engine
{
    internal class Engine
    {
        public static int Width { get; private set; }
        public static int Height { get; private set; }

        private Game gameRef;

        public Engine(int width, int height, string title, Game game)
        {
            Width = width;
            Height = height;

            gameRef = game;

            Raylib.InitWindow(width, height, title);
        }

        public void Run()
        {
            while (!Raylib.WindowShouldClose())
            {
                Input();
                Update();
                Render();
            }

            Cleanup();
        }

        private void Input()
        {
            gameRef.Input();
        }

        private void Update()
        {
            gameRef.Update();
        }

        private void Render()
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.DarkGray);

            gameRef.Render();

            Raylib.EndDrawing();
        }

        private void Cleanup()
        {
            Raylib.CloseWindow();
        }
    }
}
