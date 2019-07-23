using System;
using System.Collections.Generic;
using GCBot.Models;

namespace GCBot.Data.Repositories
{
    public interface IStaffRepository
    {
        /// <summary>
        /// Get rights of specified user.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Enums.UserRights GetRights(ulong userId);

        /// <summary>
        ///  Get Staff Members with Rights.
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        List<User> GetStaffMembers(Enums.UserRights rights);

        /// <summary>
        /// Get all Staff Members.
        /// </summary>
        /// <returns></returns>
        List<User> GetStaffMembers();
    }
}
