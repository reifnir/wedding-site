using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace maryplusjim.ui
{
    public interface IHaveDefaultState<T>
    {
        int Id { get; }
        T DefaultState { get; }
    }
}
