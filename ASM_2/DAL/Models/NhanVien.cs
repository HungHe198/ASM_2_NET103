using System;
using System.Collections.Generic;

namespace ASM_2.DAL.Models
{
    public partial class NhanVien
    {
        public string MaNv { get; set; } = null!;
        public string? HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? GioiTinh { get; set; }
        public string? MaPb { get; set; }

        public virtual PhongBan? MaPbNavigation { get; set; }
    }
}
