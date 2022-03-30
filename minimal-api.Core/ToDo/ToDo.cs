using minimal_api.Core.Common;
using minimal_api.Core.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.Features.ToDoFeature
{
    [Table("Todos")]
    public class ToDo : AuditableWithBaseEntity<Guid>
    {
        
        [Required]
        [Column(TypeName = "varchar(200")]
        [MaxLength(255)]
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime CreatedAt { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime UpdatedAt { get; set; }

        public ToDo(string name)
        {
            Name = name;
            IsCompleted = false;
        }

        public static void SetComplete(ToDo item)
        {
            item.IsCompleted = true;
        }
    }

   
}
