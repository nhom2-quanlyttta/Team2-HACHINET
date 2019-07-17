using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TTTA.Models
{
    public class QuanLyTTTADbContext : DbContext
    {
        public QuanLyTTTADbContext()
            : base("name=QLTTTAConnection")
        {

        }
        public virtual DbSet<HocVien> HocViens { get; set; }
        public virtual DbSet<GiaoVien> GiaoViens { get; set; }
        public virtual DbSet<LopHoc> LopHocs { get; set; }
        public virtual DbSet<LichHoc> LichHocs { get; set; }
        public virtual DbSet<KhoaHoc> KhoaHocs { get; set; }
        public virtual DbSet<NgayHoc> NgayHocs { get; set; }
        public virtual DbSet<CaHoc> CaHocs { get; set; }
        public virtual DbSet<HocVien_LopHoc> HocVien_LopHocs { get; set; }
        public virtual DbSet<GiaoVien_LopHoc> GiaoVien_LopHocs { get; set; }
        public virtual DbSet<KetQua> KetQuas { get; set; }
        public virtual DbSet<BienLai> BienLais { get; set; }
    }
}