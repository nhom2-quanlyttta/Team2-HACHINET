using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class NgayHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdNgayHoc { get; set; }

        [StringLength(30)]
        public string NgayHocs { get; set; }

        public virtual LopHoc LopHocs { get; set; }
    }
}