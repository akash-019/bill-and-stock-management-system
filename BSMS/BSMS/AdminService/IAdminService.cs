using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.AdminService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IAdminService" in both code and config file together.
    [ServiceContract]
    public interface IAdminService
    {
        [OperationContract]
        List<Admindata> selectAdmin();
        [OperationContract]
        Admindata getSingle(int i);
        [OperationContract]
        Admin addAdmin(Admin a);
        [OperationContract]
        Admindata updateAdmin(Admin a);
        [OperationContract]
        Admin deleteAdmin(int id);
    }
    [DataContract]
    public class Admindata
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string Email { set; get; }
    }

}
