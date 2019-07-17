using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class KhoaHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdKhoaHoc { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string TenKH { get; set; }

    }
}