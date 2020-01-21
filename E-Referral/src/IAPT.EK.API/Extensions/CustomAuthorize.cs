using System;
using System.Linq;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IAPT.EK.API.Extensions
{
    public class CustomAuthorization
    {
        public static bool CheckUserClaims(HttpContext context, string claimName, string claimValue)
        {
            return context.User.Identity.IsAuthenticated &&
                    context.User.Claims.Any(c => c.Type == claimName && c.Value.Contains(claimValue));
        }
    }


    public class ClaimsAuthorizeAttribute : TypeFilterAttribute
    {
        public ClaimsAuthorizeAttribute(string claimName, string claimValue) : base(typeof(RequisitorClaimFilter))
        {
            Arguments = new object[] { new Claim ( claimName, claimValue ) };
        }

    }


    public class RequisitorClaimFilter : IAuthorizationFilter
    {
        private readonly Claim _claim;

        public RequisitorClaimFilter(Claim claim)
        {
            _claim = claim;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                // I don't know who you are.
                context.Result = new StatusCodeResult(401);
            }

            if (!CustomAuthorization.CheckUserClaims(context.HttpContext, _claim.Type, _claim.Value))
            {
                // I know who you are but you are not allowed.
                context.Result = new StatusCodeResult(403);
            }
        }
    }
}
