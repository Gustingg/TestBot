// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Bot.Connector
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Mention information (entity type: "mention")
    /// </summary>
    public partial class Mention : Entity
    {
        /// <summary>
        /// Initializes a new instance of the Mention class.
        /// </summary>
        public Mention()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Mention class.
        /// </summary>
        /// <param name="mentioned">The mentioned user</param>
        /// <param name="text">Sub Text which represents the mention (can be
        /// null or empty)</param>
        /// <param name="type">Entity Type (typically from schema.org
        /// types)</param>
        public Mention(ChannelAccount mentioned = default(ChannelAccount), string text = default(string), string type = default(string))
        {
            Mentioned = mentioned;
            Text = text;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the mentioned user
        /// </summary>
        [JsonProperty(PropertyName = "mentioned")]
        public ChannelAccount Mentioned { get; set; }

        /// <summary>
        /// Gets or sets sub Text which represents the mention (can be null or
        /// empty)
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets entity Type (typically from schema.org types)
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}
