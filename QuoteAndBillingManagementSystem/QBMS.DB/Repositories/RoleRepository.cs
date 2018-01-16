using System;
using System.Collections.Generic;
using System.Linq;
using QBMS.Core.Domain;
using QBMS.Core.Interfaces.Repositories;

namespace QBMS.DB.Repositories
{
    public class RoleRepository : IRolesRepository
    {
        private readonly IQBMSDbContext _iQBMSDbContext;

        public RoleRepository(IQBMSDbContext iQBMSDbContext)
        {
            _iQBMSDbContext = iQBMSDbContext ?? throw new ArgumentNullException(nameof(iQBMSDbContext));
        }
        
        public Roles GetRoleById(string roleId) =>  _iQBMSDbContext.Roles.FirstOrDefault(roles => roles.Id == roleId);        
        public List<Roles> GetAllRoles() => _iQBMSDbContext.Roles.ToList();        
    }
}