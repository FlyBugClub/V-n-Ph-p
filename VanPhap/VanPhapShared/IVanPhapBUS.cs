using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VanPhapShared
{
    public interface IVanPhapBUS
    {
        List<ChiTietSo> GetAll();
        ChiTietSo GetDetails(int code);
        List<ChiTietSo> SearchByKeyWord(String keyword);
        bool AddNew(ChiTietSo newhuman);
        bool Update(ChiTietSo newhuman);
        bool Delete(int code);
    }
}
