using Pratyaksh_Engine;
using Raylib_cs;

public class TestGame : Game
{
    public TestGame()
    {
        GameObjects.Add(new Box(50, 50, 50, 50, Color.Red));
        GameObjects.Add(new GORect(50, 100, 50, 50, Color.Blue));
    }

    public override void Input()
    {
        base.Input();
    }

    public override void Render()
    {
        base.Render();
    }
}