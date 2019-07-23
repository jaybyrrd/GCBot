using System;
using System.Collections.Generic;
using System.Text;
using GCBot.Models;

namespace GCBot.Data.Entities
{
    public class StaffMemberEntity
    {
        /// <summary>
        /// Snowflake ID of admin
        /// </summary>
        public ulong Id { get; set; }
        
        /// <summary>
        /// Rights (Moderator/Admin) of staff member.
        /// </summary>
        public Enums.UserRights Rights { get; set; }
    }
}
