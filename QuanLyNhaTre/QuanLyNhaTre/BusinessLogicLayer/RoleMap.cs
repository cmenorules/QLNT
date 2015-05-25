using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanQuyenMenu
{
    //role
    //right
    class RoleMap
    {
        Dictionary<string, bool> functionList = new Dictionary<string, bool>();
        private void Init(DataTable dataSource)
        {
            foreach (DataRow i in dataSource.Rows)
            {
                functionList.Add(i[0].ToString(), false);
            }
        }

        QuanLyNhaTre.DataAccessLayer.PhanQuyenDAL phanQuyen;
        public RoleMap()
        {
            phanQuyen = new QuanLyNhaTre.DataAccessLayer.PhanQuyenDAL();
            Init(phanQuyen.LayDSQuyen());
        }
        
        public void XetQuyen(int maNhanVien)
        {
            foreach(DataRow r in phanQuyen.LayDSQuyen(maNhanVien).Rows)
            {
                SetValue(r[0].ToString(), true);
            }
        }

        public void Add(string fname, bool fvalue)
        {
            this.functionList.Add(fname, fvalue);
        }
        void Remove(string fname)
        {
            this.functionList.Remove(fname);
        }

        public void SetValue(string fname,bool fvalue)
        {
            this.functionList[fname] = fvalue;
        }

        public bool GetUserRight(string fname)
        {
            return this.functionList[fname];
        }


    }
}
