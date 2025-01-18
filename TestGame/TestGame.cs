using Pratyaksh_Engine;
using Raylib_cs;

public class TestGame : Game
{
    public TestGame()
    {
        GORect floor = new GORect(0, 550, 600, 50);
        GameObjects.Add(floor);
        GameObjects.Add(new Box(50, 50, 50, 50, Color.Red, 100.0f, floor));
        GameObjects.Add(new Box(500, 50, 50, 50, Color.Red, 50.0f, floor));
        //GameObjects.Add(new GORect(50, 100, 50, 50, Color.Blue));
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