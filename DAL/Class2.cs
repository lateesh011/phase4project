using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustInfoLogMethods
    {
        CustUserEntities context = null;
        public CustInfoLogMethods()
        {
            context = new CustUserEntities();
        }
        public List<CustLoginfo> GetCustLogInfos()
        {
            return context.CustLoginfoes.ToList();
        }
        public bool SaveCustLog(CustLoginfo t)
        {
            try
            {
                context.CustLoginfoes.Add(t);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
    public class UserInfomethods
    {
        CustUserEntities user = null;
        public UserInfomethods()
        {
            user = new CustUserEntities();
        }
        public UserInfo Checklogin(int kp, string p)
        {
            UserInfo k = null;
            foreach (var item in user.UserInfoes.ToList())
            {
                if (kp == item.UserId && p == item.password)
                {
                    k = item;
                }
            }
            return k;
        }
    }
}
