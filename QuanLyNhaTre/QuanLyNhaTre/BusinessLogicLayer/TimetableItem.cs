using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre.BusinessLogicLayer
{
    class TimetableItem
    {
        public string hoatDong;
        public string buoi;
        public string tuan;
        public TimetableItem(string _hoatDong, string _buoi, string _tuan)
        {
            hoatDong = _hoatDong;
            tuan = _tuan;
            buoi = _buoi;
        }
    }
}
