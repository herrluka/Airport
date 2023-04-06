#nullable disable


using System.ComponentModel.DataAnnotations;

namespace Persistence.Configuration
{
    public class DatabaseSettings
    {
        [Required]
        [MinLength(1)]
        public string ConnectionString { get; set; }
        [Required]
        [MinLength(1)]
        public string DatabaseName { get; set; }
        [Required]
        [MinLength(1)]
        public string CollectionName { get; set; }

    }
}
