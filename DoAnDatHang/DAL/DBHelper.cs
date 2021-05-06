using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDatHang.DAL
{
    class DBHelper
    {

        private static DoAnEntities _Instance;
        public static DoAnEntities Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DoAnEntities();
                }
                return _Instance;
            }
        }
    }
}
