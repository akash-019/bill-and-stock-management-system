using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BillerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BillerService" in both code and config file together.
    public class BillerService : IBillerService
    {
        BSMSEntities e = new BSMSEntities();
        public Biller addBiller(Biller a)
        {
            var data = e.Billers.Add(a);
            e.SaveChanges();
            return data;
        }

        public Billerdata deleteBiller(int id)
        {
            Biller a = e.Billers.Find(id);
            if (a != null)
            {
                e.Billers.Remove(a);
                e.SaveChanges();
                Billerdata d = new Billerdata();
                d.Id = a.Id;
                d.Branch_ID = a.Branch_ID;
                d.Contact = a.Contact;
                d.DOB = a.DOB;
                d.Email = a.Email;
                d.Password = a.Password;
                d.Location ="";
                return d;
            }
            return null;
        }

        public Billerdata getSingle(int i)
        {
            Biller a = e.Billers.Find(i);
            if (a != null)
            {
                Billerdata d = new Billerdata();
                d.Id = a.Id;
                d.Branch_ID = a.Branch_ID;
                d.Contact = a.Contact;
                d.DOB = a.DOB;
                d.Email = a.Email;
                d.Password = a.Password;
                d.Location = a.Branch.Location;
                return d;

            }
            return null;
        }

        public List<Billerdata> selectBiller()
        {
            var a = e.Billers.ToList();
            List<Billerdata> l = new List<Billerdata>();
              foreach (Biller i in a)
            {
                Billerdata d = new Billerdata();

                d.Id = i.Id;
                d.Branch_ID = i.Branch_ID;
                d.Contact = i.Contact;
                d.DOB = i.DOB;
                d.Email = i.Email;
                d.Password = i.Password;
                d.Location = i.Branch.Location;
                l.Add(d);

            }
            return l;

        }

        public List<Billerdata> selectBillerperBranch(int id)
        {
            var a = e.Billers.Where(m => m.Branch_ID==id).ToList();
            List<Billerdata> l = new List<Billerdata>();
             foreach (Biller i in a)
            {
                Billerdata d = new Billerdata();

                d.Id = i.Id;
                d.Branch_ID = i.Branch_ID;
                d.Contact = i.Contact;
                d.DOB = i.DOB;
                d.Email = i.Email;
                d.Password = i.Password;
                d.Location = i.Branch.Location;
                l.Add(d);

            }
            return l;
        }

        public Billerdata updateBiller(Biller a)
        {
            Biller old = e.Billers.Where(
              x => x.Id == a.Id).SingleOrDefault();
            if (old != null)
            {
                e.Entry(old).CurrentValues.SetValues(a);
                e.SaveChanges();
                Billerdata d = new Billerdata();
                d.Id = a.Id;
                d.Branch_ID = a.Branch_ID;
                d.Contact = a.Contact;
                d.DOB = a.DOB;
                d.Email = a.Email;
                d.Password = a.Password;
                d.Location ="";
                return d;
            }
            return null;
        }
    }
}