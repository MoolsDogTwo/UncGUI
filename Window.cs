namespace UncGUI;

internal abstract class Window
{
    private readonly int _id;
    private int _x;
    private int _y;
    private int _width;
    private int _height;
    public string Title;

    public Window(int x, int y, int width, int height, string title)
    {
        _x = x;
        _y = y;
        _width = width;
        _height = height;
    }
}

public class BasicWindow
{
}