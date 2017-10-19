using System.Runtime.Serialization;

namespace SandyModels.Models
{
    /// <summary>
    /// A serializable class for representing a link that is to be displayed on a user's profile page
    /// </summary>
    [DataContract]
    public class RelevantLink
    {
        /// <summary>
        /// The relevant link id
        /// </summary>
        [DataMember]
        public int RelevantLinkId { get; set; }

        /// <summary>
        /// The link uri
        /// </summary>
        [DataMember]
        public string LinkUri { get; set; }

        /// <summary>
        /// The id of the associated user
        /// </summary>
        [DataMember]
        public int UserId { get; set; }

        /// <summary>
        /// Whether or not this link has been removed
        /// </summary>
        [DataMember]
        public bool IsDeleted { get; set; }

        /// <summary>
        /// The link text to be displayed
        /// </summary>
        [DataMember]
        public string UrlText { get; set; }
    }
}
