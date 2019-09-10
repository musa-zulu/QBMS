using System.Collections.Generic;
using QBMS.Core.Domain;

namespace QBMS.Core.Interfaces.Repositories
{
    public interface IRolesRepository
    {
        Roles  GetRoleById(string roleId);
        List<Roles> GetAllRoles();
    }
}