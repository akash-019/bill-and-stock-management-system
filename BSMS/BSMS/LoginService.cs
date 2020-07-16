using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS
{
    public class LoginService : ILoginService
    { BSMSEntities bs = new BSMSEntities();

        //admin login
        public Admin Admin_login(string UserName, string Password)
        {
            Console.Write(UserName + "  " + Password);
            Admin a = null;
            a = bs.Admins.FirstOrDefault(m=>(m.UserName==UserName || m.Email==UserName) && m.Password==Password);
            if(a==null)
            {
                return null;
            }
            return a;
        }

        //branch admin login
        public BranchAdminData Branch_Admin_login(string UserName, string Password)
        {
            Console.Write(UserName + "  " + Password);
            Branch_Admin a = null;
            a = bs.Branch_Admin.FirstOrDefault(m => (m.Contact == UserName || m.Email == UserName) && m.Password == Password);
            if (a == null)
            {
                return null;
            }
            BranchAdminData d = new BranchAdminData();
            d.Id = a.Id;
            d.Name = a.Name;
            d.Password = a.Password;
            d.Email = a.Email;
            return d;
        }


        //biller login
        public Billerdata Biller_login(string UserName, string Password)
        {
            Console.Write(UserName + "  " + Password);
            Biller a = null;
            a = bs.Billers.FirstOrDefault(m => (m.Email == UserName || m.Contact == UserName) && m.Password == Password);
            if (a == null)
            {
                return null;
            }
            Billerdata d = new Billerdata();
            d.Id = a.Id;
            d.Branch_ID = a.Branch_ID;
            d.Contact = a.Contact;
            d.DOB = a.DOB;
            d.Email = a.Email;
            d.Password = a.Password;
            d.Location = "";
            return d;
        }
    }
}
