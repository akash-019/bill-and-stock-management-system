using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BranchAdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BranchAdminService" in both code and config file together.
    public class BranchAdminService : IBranchAdminService
    {
        BSMSEntities e = new BSMSEntities();
        public Branch_Admin addBranchAdmin(Branch_Admin a)
        {
            var data = e.Branch_Admin.Add(a);
            e.SaveChanges();
            return data;
        }

        public BranchAdminData deleteBranchAdmin(int id)
        {
            var a = e.Branch_Admin.Find(id);
            if (a != null)
            {
                e.Branch_Admin.Remove(a);
                e.SaveChanges();
                BranchAdminData d = new BranchAdminData();
                d.Id = a.Id;
                d.Name = a.Name;
                d.Contact = a.Contact;
                d.DOB = a.DOB;
                d.Email = a.Email;
                d.Password = a.Password;
                return d;
            }
            return null;
        }

        public BranchAdminData getSingle(int i)
        {
            var a = e.Branch_Admin.Find(i);
            if (a != null)
            {
                BranchAdminData d = new BranchAdminData();
                d.Id = a.Id;
                d.Name = a.Name;
                d.Contact = a.Contact;
                d.DOB = a.DOB;
                d.Email = a.Email;
                d.Password = a.Password;
                return d;
            }
            return null;
        }

        public List<BranchAdminData> selectBranchAdmin()
        {
            var a = e.Branch_Admin.ToList();
            List<BranchAdminData> l = new List<BranchAdminData>();
           
            foreach (Branch_Admin i in a)
            {
                BranchAdminData d = new BranchAdminData();
                d.Id = i.Id;
                d.Name = i.Name;
                d.Contact = i.Contact;
                d.DOB = i.DOB;
                d.Email = i.Email;
                d.Password = i.Password;
                l.Add(d);

            }
            return l;

        }

        public BranchAdminData updateBranchAdmin(Branch_Admin a)
        {
            Branch_Admin old = e.Branch_Admin.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                BranchAdminData d = new BranchAdminData();
                d.Id = a.Id;
                d.Name = a.Name;
                d.Contact = a.Contact;
                d.DOB = a.DOB;
                d.Email = a.Email;
                d.Password = a.Password;
                return d;
            }
            return null;
        }
    }
}
