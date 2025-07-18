using CrestApps.OrchardCore.AI.Models;
using CrestApps.OrchardCore.Services;

namespace CrestApps.OrchardCore.AI.Core;

public static class CatalogExtensions
{
    public static async ValueTask<IEnumerable<AIProfile>> GetAsync(this ICatalog<AIProfile> store, AIProfileType type)
    {
        return (await store.GetAllAsync()).Where(x => x.Type == type);
    }
}
