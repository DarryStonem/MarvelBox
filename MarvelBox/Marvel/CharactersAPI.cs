using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarvelBox.Marvel
{
    public class CharactersAPI
    {
        public Marvelpi Client { get; set; }

        public CharactersAPI()
        {
            Client = new Marvelpi("7467e9ccf4f4b657404c45b59d750469", "874a53534cdaaa5938bc642d68620936c1356ffc");
        }

        /// <summary>
        /// API: /v1/public/characters.
        /// Fetches lists of comic characters with optional filters.
        /// </summary>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of characters</returns>
        public async Task<Wrapper<Character>> GetAllAsync(int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await Client.ExecuteRequestAsync<Character>("/v1/public/characters", limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}.
        /// This method fetches a single character resource. It is the canonical URI for any character resource provided by the API.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <returns>The character</returns>
        public async Task<Wrapper<Character>> GetOneAsync(int characterId)
        {
            return await Client.ExecuteRequestAsync<Character>(string.Format("/v1/public/characters/{0}", characterId));
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/comics.
        /// Fetches lists of comics containing a specific character, with optional filters.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of comics</returns>
        public async Task<Wrapper<Comic>> GetComicsAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await Client.ExecuteRequestAsync<Comic>(string.Format("/v1/public/characters/{0}/comics", characterId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/events.
        /// Fetches lists of events in which a specific character appears, with optional filters.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of events</returns>
        public async Task<Wrapper<Event>> GetEventsAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await Client.ExecuteRequestAsync<Event>(string.Format("/v1/public/characters/{0}/events", characterId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/series.
        /// Fetches lists of comic series in which a specific character appears, with optional filters.
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of series</returns>
        public async Task<Wrapper<Series>> GetSeriesAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await Client.ExecuteRequestAsync<Series>(string.Format("/v1/public/characters/{0}/series", characterId), limit, offset, filters);
        }

        /// <summary>
        /// API: /v1/public/characters/{characterId}/stories.
        /// Fetches lists of comic stories featuring a specific character with optional filters. 
        /// </summary>
        /// <param name="characterId">The id of the character</param>
        /// <param name="limit">Limit the result set to the specified number of resources</param>
        /// <param name="offset">Skip the specified number of resources in the result set</param>
        /// <param name="filters">The optional filters</param>
        /// <returns>The list of stories</returns>
        public async Task<Wrapper<Story>> GetStoriesAsync(int characterId, int? limit = null, int? offset = null, params APIFilter[] filters)
        {
            return await Client.ExecuteRequestAsync<Story>(string.Format("/v1/public/characters/{0}/stories", characterId), limit, offset, filters);
        }
    }
}
