using SpacetimeDB;
using System.Drawing;

[Type]
public partial class SmallColor
{
    public byte A;
    public byte R;
    public byte G;
    public byte B;

    private SmallColor(byte a, byte r, byte g, byte b) {
        A = a;
        R = r;
        G = g;
        B = b;
    }

    public static SmallColor FromARGB(byte a, byte r, byte g, byte b)
    {
        return new SmallColor(a, r, g, b);
    }

    public static SmallColor FromRGB(byte r, byte g, byte b)
    {
        return new SmallColor(255, r, g, b);
    }

    public Color ToColor()
    {
        return Color.FromArgb(A, R, G, B);
    }

    public static SmallColor FromColor(Color color)
    {
        return new SmallColor(color.A, color.R, color.G, color.B);
    }
}