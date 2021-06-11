using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Moraes.Infra
{
    public interface IUser
    {
        int Id { get; }
        string Nome { get; }
        int IdLicenca { get; }
    }
    public class IUserAuth : IUser
    {
        #region Construtor
        private readonly IHttpContextAccessor _HttpContextAccessor;
        public IUserAuth(IHttpContextAccessor httpContextAccessor)
        {
            _HttpContextAccessor = httpContextAccessor;
        }
        #endregion
        #region Propriedades
        public int Id => GetClaimValue<int>("Id");
        public string Nome => GetClaimValue<string>("Nome");
        public int IdLicenca => GetClaimValue<int>("IdLicenca");

        #endregion
        private T GetClaimValue<T>(string claimType)
        {
            if (_HttpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                IEnumerable<Claim> claims = _HttpContextAccessor.HttpContext.User.Claims;
                var claimValue = claims.Where(c => c.Type == claimType).SingleOrDefault()?.Value;
                    return (T)Convert.ChangeType(claimValue, typeof(T));
            }
            else
                return default(T);
        }
    }
}
