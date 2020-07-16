using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        Admin Admin_login(string UserName,string Password);

        [OperationContract]
        Billerdata Biller_login(string UserName, string Password);

        [OperationContract]
        BranchAdminData Branch_Admin_login(string UserName, string Password);

    }

    [DataContract]
    public class BranchAdminData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Contact { get; set; }
        [DataMember]
        public DateTime DOB { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }

    }
    [DataContract]
    public class Billerdata
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int Branch_ID { get; set; }
        [DataMember]
        public string Contact { get; set; }
        [DataMember]
        public DateTime DOB { set; get; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Location { get; set; }

    }

}
