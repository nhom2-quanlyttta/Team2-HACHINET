using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class LopHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdLopHoc { get; set; }

        [Required]
        public string TenLop { get; set; }

        [Required]
        public string Phong { get; set; }

        public DateTime NgayBD { get; set; }

        public DateTime NgayKT { get; set; }
        public int IdNgayHoc { get; set; }

        public int IdKhoaHoc { get; set; }
    }
}