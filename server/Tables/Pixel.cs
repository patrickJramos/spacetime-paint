using SpacetimeDB;
using System.Drawing;

public static partial class Module
{
    [Table(Name = "canvas", Public = true)]
    public partial class Canvas
    {
        [PrimaryKey]
        public string Path;
        public int X;
        public int Y;
    }

    [Table(Name = "pixel", Public = true)]
    public partial class Pixel
    {
        public Identity CanvasId;
        public int X;
        public int Y;
        public SmallColor Color = SmallColor.FromColor(System.Drawing.Color.White);
    }
}
