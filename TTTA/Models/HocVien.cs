using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class HocVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdHocVien { get; set; }

        [StringLength(50)]
        [Required]
        public string HoTenHV { get; set; }

        public DateTime NgaySinhHV { get; set; }

        [StringLength(255)]
        [Required]
        public string DiaChiHV { get; set; }

        public string SDTHV { get; set; }

        public string GioiTinh { get; set; }

        public int IdLopHoc { get; set; }

        public int IdBienLai { get; set; }

        public virtual BienLai BienLais { get; set; }
    }
    
}