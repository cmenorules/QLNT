using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhaTre
{
    class LoginCtrl
    {
        public bool UserPassExam(String user, String pass)
        {
            // load du lieu len
            // kiem tra du user,pass voi du lieu
            // dung thi retrun tru
            if (user == "thao" && pass == "123") return true;
            return false;
        }
    }
}
