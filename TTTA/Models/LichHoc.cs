using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class LichHoc
    {
        [Key, Column(Order = 1)]
        public int IdNgayHoc { get; set; }
        [Key, Column(Order = 2)]
        public int IdCaHoc { get; set; }

        [ForeignKey("IdNgayHoc")]
        public virtual NgayHoc NgayHocs { get; set; }

        [ForeignKey("IdCaHoc")]
        public virtual CaHoc CaHocs { get; set; }
    }
}