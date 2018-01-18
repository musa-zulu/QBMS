using System;
using System.Collections.Generic;
using System.Linq;
using QBMS.Core.Domain;
using QBMS.Core.Interfaces.Repositories;

namespace QBMS.DB.Repositories
{
    public class RoleRepository : IRolesRepository
    {
        private readonly IQBMSDbContext _qBMSDbContext;

        public RoleRepository(IQBMSDbContext qBMSDbContext)
        {
            _qBMSDbContext = qBMSDbContext ?? throw new ArgumentNullException(nameof(qBMSDbContext));
        }
        
        public Roles GetRoleById(string roleId) => _qBMSDbContext.Roles.FirstOrDefault(roles => roles.Id == roleId);        
        public List<Roles> GetAllRoles() => _qBMSDbContext.Roles.ToList();        
    }
}