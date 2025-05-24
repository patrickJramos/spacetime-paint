
using SpacetimeDB;
using SpacetimeDB.Internal;
public static partial class Module
{

    [Reducer]
    public static void EnsureCanvasExists(ReducerContext ctx, string canvas)
    {
        var found = ctx.Db.canvas.Path.Find(canvas);

        if (found is null)
        {
            ctx.Db.canvas.Insert(
                new Canvas()
                {
                    Path = canvas,
                }
            );
        }
    }

}
