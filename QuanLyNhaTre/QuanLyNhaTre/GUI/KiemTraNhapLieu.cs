using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaTre.GUI
{
    class KiemTraNhapLieu
    {
        private static KiemTraNhapLieu instance = new KiemTraNhapLieu();

        public static KiemTraNhapLieu getInstance()
        {
            return instance;
        }

        public KiemTraNhapLieu() { }

        public bool KiemTraDuLieuRong(Form f)
        {
            foreach (Control control in f.Controls)
            {
                if (!KiemTraDuLieuRong(control))
                    return false;
            }
            return true;
        }

        private bool KiemTraDuLieuRong(Control control)
        {
            if (!(control is TextBox))
                foreach (Control c in control.Controls)
                {
                    if (c is TextBox)
                    {
                        if (c.Text == "")
                            return false;
                    }
                    else
                        KiemTraDuLieuRong(c);
                }
            else
                if (control.Text == "")
                    return false;
            return true;
        }

        public bool KiemTraEmailHopLe(string email)
        {          
            const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
     + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
     + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
				[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
     + @"([a-zA-Z0-9]+[\w-]+\.)+[a-zA-Z]{1}[a-zA-Z0-9-]{1,23})$";
            if (email != null) return Regex.IsMatch(email, MatchEmailPattern);
            else return false;
        }
    }
}
