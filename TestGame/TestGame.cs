using Pratyaksh_Engine;
using Raylib_cs;

public class TestGame : Game
{
    public TestGame()
    {
        GORect floor = new GORect(0, 550, 600, 50);
        GameObjects.Add(floor);

        Player player = new Player();
        GameObjects.Add(player);

        GameObjects.Add(new Box(50, 50, 50, 50, 10, Color.Red, 100.0f, floor, player));
        GameObjects.Add(new Box(500, 50, 50, 50, 35, Color.Red, 50.0f, floor, player));

        GameObjects.Add(new BoxSpawner(3.0f, floor, player));
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