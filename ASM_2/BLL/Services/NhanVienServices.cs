using ASM_2.DAL.Models;
using ASM_2.DAL.Repositosies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2.BLL.Services
{
    public class NhanVienServices
    {
        NhanVienRepository repository = new NhanVienRepository();

        public List<NhanVien> GetAllNhanVien()
        {
            return repository.GetAllNhanVien();
        }
        public string ThemNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string MaPB)
        {
            NhanVien nhanVien = new NhanVien()
            {
                MaNv = MaNV,
                HoTen = HoTen,
                NgaySinh = NgaySinh,
                GioiTinh = GioiTinh,
                MaPb = MaPB
            };
            if (repository.createNhanVien(nhanVien))
            {
                return "Thêm thành công :)";
            }
            else
                return "Thêm thất bại";
        }
        public string SuaNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string MaPB)
        {

            if (repository.UpdateNhanVien(MaNV, HoTen, NgaySinh, GioiTinh, MaPB))
            {
                return "Sửa thành công :)";
            }
            else
                return "Sửa thất bại";
        }
        public string XoaNhanVien(string MaNV)
        {

            if (repository.DeleteNhanVien(MaNV))
            {
                return "Xóa thành công :)";
            }
            else
                return "Xóa thất bại";
        }
        public List<NhanVien> TimKiemTheoTen(string HoTen)
        {
            return repository.FindByName(HoTen);
        }

    }
}
