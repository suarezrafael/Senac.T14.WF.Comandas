using System.Drawing.Drawing2D;

namespace Comandas;

public static class FormExtensions
{
    public static void SetRoundedCorners(this Form form, int cornerRadius)
    {
        GraphicsPath path = new GraphicsPath();

        // Cria um caminho para a forma arredondada com arcos maiores
        path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
        path.AddArc(form.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90);
        path.AddArc(form.Width - cornerRadius - 1, form.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90);
        path.AddArc(0, form.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90);

        path.CloseAllFigures();

        form.Region = new Region(path);
    }
}

