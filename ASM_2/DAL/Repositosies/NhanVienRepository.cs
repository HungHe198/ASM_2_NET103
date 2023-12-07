using ASM_2.BLL.Services;
using ASM_2.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2.DAL.Repositosies
{
    public class NhanVienRepository
    {
        QLNhanVienContext context = new QLNhanVienContext();
        public List<NhanVien> GetAllNhanVien()
        {
            return context.NhanViens.ToList();

        }
        public bool createNhanVien(NhanVien nhanVien)
        {
            context.NhanViens.Add(nhanVien);
            return context.SaveChanges() > 0;
        }
        //public bool Find(string MaNV)
        //{
        //    var query = context.NhanViens.Find(MaNV);
        //    return query
        //}
        public bool UpdateNhanVien(string MaNV, string HoTen, DateTime NgaySinh, string GioiTinh, string MaPB)
        {
            var NhanVienDangTim = context.NhanViens.Find(MaNV);
            NhanVienDangTim.HoTen =HoTen;
            NhanVienDangTim.NgaySinh = NgaySinh;
            NhanVienDangTim.GioiTinh = GioiTinh;
            NhanVienDangTim.MaPb = MaPB;
            context.NhanViens.Update(NhanVienDangTim);
            
            return context.SaveChanges() > 0;


        }
        public bool DeleteNhanVien(string MaNV)
        {
            var NhanVienXoa = context.NhanViens.Find(MaNV);
            context.NhanViens.Remove(NhanVienXoa);
            return context.SaveChanges() > 0;   
        }
        public List<NhanVien> FindByName(string HoTen)
        {
            return context.NhanViens.Where(x=>x.HoTen.Contains(HoTen)).ToList();
        }

    }
}
