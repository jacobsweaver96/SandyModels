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
        /// The first name of the user
        /// </summary>
        [DataMember]
        public string FirstName { get; set; }

        /// <summary>
        /// The middle name of the user
        /// </summary>
        [DataMember]
        public string MiddleName { get; set; }

        /// <summary>
        /// The last name of the user
        /// </summary>
        [DataMember]
        public string LastName { get; set; }

        /// <summary>
        /// The uri to the profile picture used by the user in their profile page
        /// </summary>
        [DataMember]
        public string ProfilePictureUri { get; set; }

        /// <summary>
        /// A link to the user's resume
        /// </summary>
        [DataMember]
        public string ResumeLink { get; set; }

        /// <summary>
        /// The user's biography summary
        /// </summary>
        [DataMember]
        public string Biography { get; set; }

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
        public List<Role> Roles { get; set; }

        /// <summary>
        /// A list of github user accounts associated with this portfolio user
        /// </summary>
        [DataMember]
        public List<GithubUser> GithubUsers { get; set; }

        /// <summary>
        /// A list of links that are to be displayed on this user's profile page
        /// </summary>
        [DataMember]
        public List<RelevantLink> RelevantLinks { get; set; }

        /// <summary>
        /// Whether or not the user has been deleted
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
