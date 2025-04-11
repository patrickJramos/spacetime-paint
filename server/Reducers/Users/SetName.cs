using SpacetimeDB.Internal;
using SpacetimeDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public static partial class Module
{
    [Reducer]
    public static void SetName(ReducerContext ctx, string name)
    {
        name = ValidateName(name);

        var user = ctx.Db.user.Identity.Find(ctx.Sender);
        if (user is not null)
        {
            user.Name = name;
            ctx.Db.user.Identity.Update(user);
        }
    }

    /// Takes a name and checks if it's acceptable as a user's name.
    private static string ValidateName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Names must not be empty");
        }
        return name;
    }
}