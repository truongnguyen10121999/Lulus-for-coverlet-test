using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Infrastructures
{
    public interface ICurrentUser
    {
        Guid UserId { get; }
    }
}
