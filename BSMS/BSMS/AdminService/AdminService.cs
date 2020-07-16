using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.AdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AdminService" in both code and config file together.
    public class AdminService : IAdminService
    {
        BSMSEntities e = new BSMSEntities();
        public Admin addAdmin(Admin a)
        {
            var data = e.Admins.Add(a);
            e.SaveChanges();
            return data;
        }

        public Admin deleteAdmin(int id)
        {
            Admin a = e.Admins.Find(id);
            if (a != null)
            {
                e.Admins.Remove(a);
                e.SaveChanges();
                return a;
            }
            return null;
        }

        public Admindata getSingle(int i)
        {
            Admin a = e.Admins.Find(i);
            if (a != null)
            {
                Admindata d = new Admindata();
                d.Id = a.Id;
                d.UserName = a.UserName;
                d.Password = a.Password;
                d.Email = a.Email;
                return d;
            }
            return null;
        }

        public List<Admindata> selectAdmin()
        {
            var a = e.Admins.ToList();
            List<Admindata> l = new List<Admindata>();
          
            foreach (Admin i in a)
            {
                Admindata d = new Admindata();
                d.Id = i.Id;
                d.UserName = i.UserName;
                d.Password = i.Password;
                d.Email = i.Email;
                l.Add(d);

            }
            return l;
        }

        public Admindata updateAdmin(Admin a)
        {
            Admin old = e.Admins.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                Admindata d = new Admindata();
                d.Id = a.Id;
                d.UserName = a.UserName;
                d.Password = a.Password;
                d.Email = a.Email;
                return d;
            }
            return null;
        }
    }
}
