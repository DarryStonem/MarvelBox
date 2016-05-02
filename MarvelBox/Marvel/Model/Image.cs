using Newtonsoft.Json;

namespace MarvelBox.Marvel
{
    /// <summary>
    /// Images are represented as a partial path and an extension. See the guide to images for information about how to construct 
    /// full paths to image files. 
    /// </summary>
    public class Image
    {
        /// <summary>
        /// Gets or sets the directory path of to the image
        /// </summary>
        [JsonProperty("path")]
        public string Path { get; set; }

        /// <summary>
        /// Gets or sets the file extension for the image
        /// </summary>
        [JsonProperty("extension")]
        public string Extension { get; set; }

        private string _url;

        public string Url
        {
            get { return Path + "." + Extension; }
            set { _url = value; }
        }
    }
}
