using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaylyHelper.Data.Models
{
    public class Project
    {
        public Project()
        {
            this.Created = DateTime.Now.Date;
            this.Modified = DateTime.Now.Date;
            Notes = new List<Note>();
        }
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Created { get; private set; }
        [DataType(DataType.Date)]
        public DateTime? Modified { get; set; } 
        public bool Done { get; set; } = false;
        public virtual List<Note> Notes { get; set; }
    }
}
