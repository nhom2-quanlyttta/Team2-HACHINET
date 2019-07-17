using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class CaHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCaHoc { get; set; }

        [StringLength(20)]
        [Required]
        public string GioHoc { get; set; }
    }
}