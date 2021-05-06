using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnDatHang.DAL
{
    class DAL_Login
    {
        private static DAL_Login _Instance;

        public static DAL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_Login();
                }
                return _Instance;
            }
        }
        public List<Login> getAllLogin()
        {
            return DBHelper.Instance.Logins.Select(s => s).ToList();
        }
        public Login getLoginByUsername(string username)
        {
            var logins = DBHelper.Instance.Logins;
            List<Login> user = logins.Where(s => s.Username.Equals(username)).Select(s => s).ToList();
            if (user.Count > 0)
                return user[0];
            else return null;
        }
    }
}
