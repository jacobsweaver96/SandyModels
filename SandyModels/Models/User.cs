using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SandyModels.Models
{
    [DataContract]
    public class User
    {
        /// <summary>
        /// The user's Identifier
        /// </summary>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// The user's Email
        /// </summary>
        [DataMember]
        public string Email { get; set; }

        /// <summary>
        /// The user's salted password 
        /// </summary>
        [DataMember]
        public string Password { get; set; }

        /// <summary>
        /// The user's salt
        /// </summary>
        [DataMember]
        public string Salt { get; set; }

        /// <summary>
        /// The user's roles
        /// </summary>
        [DataMember]
        public List<Role> Roles { get; set; } = new List<Role>();

        /// <summary>
        /// Whether or not the user has been deleted
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
