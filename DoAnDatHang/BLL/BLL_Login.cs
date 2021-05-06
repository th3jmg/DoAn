using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnDatHang.DAL;

namespace DoAnDatHang.BLL
{
    class BLL_Login
    {
        private static BLL_Login _Instance;
        public static BLL_Login Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Login();
                }
                return _Instance;
            }
        }
        public Login getLoginByUsername(string username)
        {
            Login user = DAL_Login.Instance.getLoginByUsername(username);
            return user;
        }
        public int checkUsernameAndPassword(string username, string password)
        {
            Login user = DAL_Login.Instance.getLoginByUsername(username);
            if (user != null && user.Password.Equals(password)) return user.ID;
            else return -1;
        }
    }
}
