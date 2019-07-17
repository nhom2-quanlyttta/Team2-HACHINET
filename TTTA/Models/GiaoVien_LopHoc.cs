using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class GiaoVien_LopHoc
    {
        [Key, Column(Order = 1)]
        public int IdGiaoVien { get; set; }

        [Key, Column(Order = 2)]
        public int IdLopHoc { get; set; }

        [ForeignKey("IdGiaoVien")]
        public virtual GiaoVien GiaoViens { get; set; }

        [ForeignKey("IdLopHoc")]
        public virtual LopHoc LopHocs { get; set; }
    }
}