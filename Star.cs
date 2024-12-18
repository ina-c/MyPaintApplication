namespace FinalPaint;

internal class Star : ToolControl
{
    public Star(Pen p, Tools tool, int size, Color color, Point start, Point end, Graphics g) : base(p, tool, size,
        color, start, end, g)
    {
    }

    public new void Draw()
    {
        int width = Math.Abs(End.X - Start.X);  // Lățimea
        int height = Math.Abs(End.Y - Start.Y); // Înălțimea
        int cx = (Start.X + End.X) / 2;         // Centrul pe axa X
        int cy = (Start.Y + End.Y) / 2;         // Centrul pe axa Y

        int spikes = 5; // Numărul de vârfuri ale stelei
        double angle = 2 * Math.PI / spikes;

        Point[] points = new Point[2 * spikes];
        for (int i = 0; i < spikes; i++)
        {
            // Punctele exterioare (folosesc lățimea și înălțimea separat)
            int outerX = cx + (int)(width / 2 * Math.Cos(i * angle - Math.PI / 2));
            int outerY = cy + (int)(height / 2 * Math.Sin(i * angle - Math.PI / 2));

            // Punctele interioare (lățimea / 4 și înălțimea / 4 pentru "vârfurile interioare")
            int innerX = cx + (int)(width / 4 * Math.Cos((i + 0.5) * angle - Math.PI / 2));
            int innerY = cy + (int)(height / 4 * Math.Sin((i + 0.5) * angle - Math.PI / 2));

            points[2 * i] = new Point(outerX, outerY);
            points[2 * i + 1] = new Point(innerX, innerY);
        }

        G.DrawPolygon(P, points);
    }

}