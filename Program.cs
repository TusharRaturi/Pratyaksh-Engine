using Raylib_cs;

namespace Pratyaksh_Engine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestGame testGame = new TestGame();
            Engine engine = new Engine(600, 600, "Test", testGame);
            engine.Run();
        }
    }
}
