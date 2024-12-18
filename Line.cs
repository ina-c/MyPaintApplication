using System.Drawing.Drawing2D;

namespace FinalPaint;

internal class Line : ToolControl
{
    public Line(Pen p, Tools tool, int size, Color color, Point start, Point end, Graphics g) : base(p, tool, size,
        color, start, end, g)
    {
        g.SmoothingMode = SmoothingMode.AntiAlias;
    }

    public new void Draw()
    {
        G.DrawLine(P, Start, End);
    }
}