using System.ComponentModel.DataAnnotations;

namespace DaylyHelper.Data.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required]
        public string MainTask { get; set; }
        public string Description { get; set; }
        public ImportancyType Importancy { get; set; }

    }

}