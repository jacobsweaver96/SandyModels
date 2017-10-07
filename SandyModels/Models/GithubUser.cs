using System.Runtime.Serialization;

namespace SandyModels.Models
{
    [DataContract]
    public class GithubUser
    {
        /// <summary>
        /// The github user's identifier
        /// </summary>
        [DataMember]
        public int GithubUserId { get; set; }

        /// <summary>
        /// The github user's application UserId 
        /// </summary>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// The user's username
        /// </summary>
        [DataMember]
        public string Username { get; set; }

        /// <summary>
        /// Whether or not this github user is deleted
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
