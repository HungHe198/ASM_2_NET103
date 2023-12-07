using ASM_2.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2.DAL.Repositosies
{
    public class PhongBanRepository
    {
        QLNhanVienContext context = new QLNhanVienContext();

        public List<PhongBan> GetAllPhongBan()
        { 
            return context.PhongBans.ToList();

        }
    }
}
