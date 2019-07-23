using System.Collections.Generic;
using GCBot.Models;

namespace GCBot.Data.Repositories
{
    public class StaffRepository : IStaffRepository
    {
        public Enums.UserRights GetRights(ulong userId)
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetStaffMembers(Enums.UserRights rights)
        {
            throw new System.NotImplementedException();
        }

        public List<User> GetStaffMembers()
        {
            throw new System.NotImplementedException();
        }
    }
}
