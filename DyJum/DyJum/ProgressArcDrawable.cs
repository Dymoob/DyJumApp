namespace DyJum;

public class ProgressArcDrawable : IDrawable
{
    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        float centerX = dirtyRect.Center.X;
        float centerY = dirtyRect.Bottom - 20;
        float radius = 120;

        canvas.StrokeColor = Color.FromArgb("#2D1F3D");
        canvas.StrokeSize = 8;
        canvas.DrawArc(centerX - radius, centerY - radius,
                       radius * 2, radius * 2, 180, 180, false, false);

        canvas.StrokeColor = Color.FromArgb("#D870FB");
        canvas.StrokeSize = 10;
        canvas.DrawArc(centerX - radius, centerY - radius,
                       radius * 2, radius * 2, 180, 45, false, false);
    }
}