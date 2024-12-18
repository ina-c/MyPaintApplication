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
        // Verifică dacă tasta Shift este apăsată
        if (Control.ModifierKeys.HasFlag(Keys.Shift))
        {
            End = ConstrainToAngles(Start, End);
        }

        // Desenează linia
        G.DrawLine(P, Start, End);
    }

    private Point ConstrainToAngles(Point start, Point end)
    {
        int dx = end.X - start.X;
        int dy = end.Y - start.Y;

        // Calculează lungimea liniei
        double length = Math.Sqrt(dx * dx + dy * dy);

        // Dacă lungimea este zero, nu putem determina unghiul
        if (length == 0)
            return end;

        // Calculează unghiul curent în radiani
        double angle = Math.Atan2(dy, dx);
        double angleDeg = angle * (180.0 / Math.PI);

        // Ajustează punctul final în funcție de unghiul apropiat
        if (Math.Abs(angleDeg) <= 22.5 || Math.Abs(angleDeg) > 157.5) // Aproape orizontal
        {
            end.Y = start.Y; // Constrângere orizontală
        }

        //dreapta
        else if (Math.Abs(angleDeg + 45) <= 22.5) // Aproape 45 de grade stânga sus
        {
            int signX = dx < 0 ? -1 : 1;  // Semnul pe axa X
            int signY = dy < 0 ? -1 : 1;  // Semnul pe axa Y

            end.X = start.X + signX * (int)(length / Math.Sqrt(2));
            end.Y = start.Y + signY * (int)(length / Math.Sqrt(2));
        }
        else if (Math.Abs(angleDeg - 45) <= 22.5) // Aproape 45 de grade dreapta jos
        {
            int signX = dx >= 0 ? 1 : 1;
            int signY = dy >= 0 ? 1 : 1;

            end.X = start.X + signX * (int)(length / Math.Sqrt(2));
            end.Y = start.Y + signY * (int)(length / Math.Sqrt(2));
        }


        //stanga
        else if (Math.Abs(angleDeg - 135) <= 22.5) 
        {
            int signX = dx >= 0 ? 1 : -1;
            int signY = dy >= 0 ? 1 : -1;

            end.X = start.X + signX * (int)(length / Math.Sqrt(2));
            end.Y = start.Y + signY * (int)(length / Math.Sqrt(2));
        }
        else if (Math.Abs(angleDeg + 135) <= 22.5) 
        {
            int signX = dx < 0 ? -1 : 1;
            int signY = dy < 0 ? -1 : 1;

            end.X = start.X + signX * (int)(length / Math.Sqrt(2));
            end.Y = start.Y + signY * (int)(length / Math.Sqrt(2));
        }
        else // Aproape vertical sau în alte direcții
        {
            end.X = start.X; // Constrângere verticală
        }

        return end;
    }

}