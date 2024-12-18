namespace FinalPaint;

internal class Typography : ToolControl
{
    public static TextBox activeTextBox = null;
    public static Typography activeTypography = null;

    private readonly Control control;
    private readonly Font Font;
    private string text;

    private bool isDragging = false;
    private Point dragStartPoint;

    public Typography(Pen p, Tools tool, int size, Color color, Point start, Point end, Graphics g, Control control,
        Font font) : base(p, tool, size, color, start, end, g)
    {
        Font = font;
        this.control = control;
    }

    public new void Draw(Color backgroundColor)
    {
        if (activeTextBox != null)
        {
            if (string.IsNullOrEmpty(activeTextBox.Text))
            {
                activeTextBox.Dispose();
                activeTextBox = null;
                activeTypography = null;
            }
            else
            {
                activeTextBox.BorderStyle = BorderStyle.None;
                activeTextBox.ReadOnly = true;
                activeTextBox = null;
                activeTypography = null;
            }
        }

        var textBox = new TextBox
        {
            Location = Start,
            Font = Font,
            BorderStyle = BorderStyle.FixedSingle,
            BackColor = backgroundColor
        };

        control.Controls.Add(textBox);
        textBox.BringToFront();
        textBox.Focus();

        activeTextBox = textBox;
        activeTypography = this;

        textBox.TextChanged += textBox_TextChanged;
        textBox.Leave += textBox_Leave;

        textBox.MouseDown += textBox_MouseDown;
        textBox.MouseMove += textBox_MouseMove;
        textBox.MouseUp += textBox_MouseUp;
    }

    private void textBox_Leave(object sender, EventArgs e)
    {
        FinalizeTextBox();
    }

    private void FinalizeTextBox()
    {
        if (activeTextBox != null)
        {
            var tb = activeTextBox;
            if (!string.IsNullOrEmpty(tb.Text))
            {
                tb.BorderStyle = BorderStyle.None;
                tb.ReadOnly = true;
            }
            else
            {
                tb.Dispose();
                activeTextBox = null;
                activeTypography = null;
            }
        }
    }

    private void textBox_TextChanged(object sender, EventArgs e)
    {
        var textBox = (TextBox)sender;
        textBox.Width = TextRenderer.MeasureText(textBox.Text, Font).Width + 10;
        textBox.Height = TextRenderer.MeasureText(textBox.Text, Font).Height + 4;
        text = textBox.Text;
    }

    private void textBox_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isDragging = true;
            dragStartPoint = e.Location;
            ((TextBox)sender).Capture = true;
        }
    }

    private void textBox_MouseMove(object sender, MouseEventArgs e)
    {
        if (isDragging)
        {
            var tb = (TextBox)sender;
            var newX = tb.Left + e.X - dragStartPoint.X;
            var newY = tb.Top + e.Y - dragStartPoint.Y;
            tb.Location = new Point(newX, newY);
        }
    }

    private void textBox_MouseUp(object sender, MouseEventArgs e)
    {
        if (isDragging)
        {
            isDragging = false;
            ((TextBox)sender).Capture = false;
        }
    }
}