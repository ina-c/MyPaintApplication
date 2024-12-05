using Rect = System.Drawing.Rectangle;

namespace FinalPaint;

internal class Rectangle : ToolControl
{
    public Rectangle(Pen p, Tools tool, int size, Color color, Point start, Point end, Graphics g) : base(p, tool, size,
        color, start, end, g)
    {
    }

    public new void Draw()
    {
        // Calculăm poziția de început
        var StartPosition = new Point(Math.Min(Start.X, End.X), Math.Min(Start.Y, End.Y));
        var size = new Size(Math.Abs(Start.X - End.X), Math.Abs(Start.Y - End.Y));

        // Verificăm dacă Shift este apăsat
        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
        {
            // Asigurăm că dimensiunea este pătrată
            int side = Math.Min(size.Width, size.Height);
            size = new Size(side, side);
        }

        var rect = new Rect(StartPosition, size);
        G.DrawRectangle(P, rect);
    }
}
