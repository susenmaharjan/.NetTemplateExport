using System.Security.Claims;
using Susen.SourceProject.Services.DataAccess.Interfaces;

namespace Susen.SourceProject.Services.DataAccess.Databases
{
    public class UserContext : IUserContext
    {
        public string FullName { get; set; }
        public string Name { get; set; }

        public IUserContext GetContext()
        {
            if (!(System.Threading.Thread.CurrentPrincipal is ClaimsPrincipal user)) return null;
            FullName = user.Identity.Name;
            //split domain and set user name only
            Name = GetShortName(FullName);
            return this;
        }

        private string GetShortName(string fullName)
        {
            var chunks = fullName.Split(new[] { '\\' }, 2);
            if (chunks.Length == 2)
            {
                return chunks[1];
            }
            return chunks[0];
        }
    }
}