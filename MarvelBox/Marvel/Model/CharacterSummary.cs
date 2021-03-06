﻿using Newtonsoft.Json;

namespace MarvelBox.Marvel
{
    /// <summary>
    /// The summary view of a Character
    /// </summary>
    public class CharacterSummary
    {
        /// <summary>
        /// Gets or sets the path to the individual character resource
        /// </summary>
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        /// <summary>
        /// Gets or sets the full name of the character
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role of the character in the parent entity
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
