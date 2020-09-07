using Pokeplace.Core;

namespace Pokeplace.AppService
{
    public class BaseAppService
    {
    }

    public class BaseAppService<T> : BaseAppService where T : BaseDbEntity<T>
    {
    }
}