using System.Runtime.Serialization;

namespace SandyModels.Models
{
    [DataContract]
    public class Role
    {
        /// <summary>
        /// The role id
        /// </summary>
        [DataMember]
        public int RoleId { get; set; }

        /// <summary>
        /// The name of the role
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// A description of the role
        /// </summary>
        [DataMember]
        public string Description { get; set; }

        /// <summary>
        /// Whether or not the role is deleted
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }
    }
}
