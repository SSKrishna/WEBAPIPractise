using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WEBAPIPractise.Models
{
    public class Log
    {
        [Key] // Specifies that this property is the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Specifies that the database generates a value for this property
        public int Id { get; set; }

        public string LogLevel { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
