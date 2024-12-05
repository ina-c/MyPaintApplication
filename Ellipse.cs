using Rect = System.Drawing.Rectangle;

namespace FinalPaint;

internal class Ellipse : ToolControl
{
    public Ellipse(Pen p, Tools tool, int size, Color color, Point start, Point end, Graphics g) : base(p, tool,
        size, color, start, end, g)
    {
    }

    public new void Draw()
    {
        var rect = new Rect(Start.X, Start.Y, End.X - Start.X, End.Y - Start.Y);

        // Verificăm dacă Shift este apăsat
        if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
        {
            // Asigurăm că dreptunghiul este pătrat pentru un cerc perfect
            int side = Math.Min(Math.Abs(rect.Width), Math.Abs(rect.Height));

            // Ajustăm coordonatele în funcție de direcție
            if (rect.Width < 0 && rect.Height < 0)
                rect = new Rect(Start.X - side, Start.Y - side, side, side);
            else if (rect.Width < 0)
                rect = new Rect(Start.X - side, Start.Y, side, side);
            else if (rect.Height < 0)
                rect = new Rect(Start.X, Start.Y - side, side, side);
            else
                rect = new Rect(Start.X, Start.Y, side, side);
        }

        G.DrawEllipse(P, rect);
    }
}
