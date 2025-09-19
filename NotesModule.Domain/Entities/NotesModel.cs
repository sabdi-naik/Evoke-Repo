using System;
using System.ComponentModel.DataAnnotations;

namespace NotesModule.Domain.Entities
{
    public class NotesModel
    {
        [Key]
        public int NotesId { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [MaxLength(100)]
        public string? Title { get; set; }

        [MaxLength(500)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Priority is required")]
        [MaxLength(25)]
        public string? Priority { get; set; }

        [MaxLength(100)]
        public string? CreatedBy { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.UtcNow;

        [MaxLength(100)]
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDateTime { get; set; } = null;
        public bool IsDeleted { get; set; } = true;
    }
}
