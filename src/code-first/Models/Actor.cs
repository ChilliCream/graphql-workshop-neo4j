using System.Collections.Generic;
using HotChocolate.Data.Neo4J;

namespace MoviesAPI.Models
{
    public class Actor
    {
        public string Name { get; set; }

        [Neo4JRelationship("ACTED_IN")]
        public List<Movie> ActedIn { get; set; }
    }
}