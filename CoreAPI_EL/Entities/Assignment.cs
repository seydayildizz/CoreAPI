using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreAPI_EL.Entities
{
    [Table("Assignments")]
    public class Assignment
    {
        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(Order = 2)]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(500,MinimumLength =2,ErrorMessage =("Görev tanımı en az 2 en fazla 500 karakter olmalıdır!"))]
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
    }
}
