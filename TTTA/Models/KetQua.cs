using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class KetQua
    {
        [Key, Column(Order = 1)]
        public int IdHocVien { get; set; }

        [Key, Column(Order = 2)]
        public int IdLopHoc { get; set; }

        [Required]
        public string Diem { get; set; }

        [Required]
        public string XepLoai { get; set; }

        [Required]
        public string KetQuas { get; set; }

        [ForeignKey("IdHocVien")]
        public virtual HocVien HocViens { get; set; }

        [ForeignKey("IdLopHoc")]
        public virtual LopHoc LopHocs { get; set; }
    }
}