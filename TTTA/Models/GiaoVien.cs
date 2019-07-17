using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class GiaoVien
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdGiaoVien { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar")]
        [Required]
        public string HoTenGV { get; set; }

        public DateTime NgaySinhGV { get; set; }

        [StringLength(255)]
        [Column(TypeName = "nvarchar")]
        public string DiaChiGV { get; set; }

        [StringLength(20)]
        public string SDTGV { get; set; }
    }
}