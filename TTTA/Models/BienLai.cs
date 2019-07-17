using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class BienLai
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdBienLai { get; set; }

        [StringLength(30)]
        [Required]
        public string ThanhTien { get; set; }

        [StringLength(30)]
        public string MienGiam { get; set; }

    }
}