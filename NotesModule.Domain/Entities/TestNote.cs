using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotesModule.Domain.Entities
{
    public class TestNote
    {
        [Required]
        public string Title { get; set; } = string.Empty;
    }
}
