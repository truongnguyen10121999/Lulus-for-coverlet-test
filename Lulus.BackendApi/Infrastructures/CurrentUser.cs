using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Lulus.BackendApi.Infrastructures
{
    public class CurrentUser: ICurrentUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CurrentUser(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public Guid UserId { get => new Guid(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.PrimarySid)); }
    }
}
