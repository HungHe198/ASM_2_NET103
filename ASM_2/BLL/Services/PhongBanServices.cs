using ASM_2.DAL.Models;
using ASM_2.DAL.Repositosies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM_2.BLL.Services
{
    public class PhongBanServices
    {
        PhongBanRepository repository = new PhongBanRepository();
        public List<PhongBan> GetAllPhongBan()
        { 
            return repository.GetAllPhongBan();

        }
    }
}
