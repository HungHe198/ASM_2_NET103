using System;
using System.Collections.Generic;

namespace ASM_2.DAL.Models
{
    public partial class PhongBan
    {
        public PhongBan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        public string MaPb { get; set; } = null!;
        public string? TenPb { get; set; }

        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
