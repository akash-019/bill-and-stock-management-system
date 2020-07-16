using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.BillerService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBillerService" in both code and config file together.
    [ServiceContract]
    public interface IBillerService
    {
        [OperationContract]
        List<Billerdata> selectBiller();
        [OperationContract]
        List<Billerdata> selectBillerperBranch(int id);
        [OperationContract]
        Billerdata getSingle(int i);
        [OperationContract]
        Biller addBiller(Biller a);
        [OperationContract]
        Billerdata updateBiller(Biller a);
        [OperationContract]
        Billerdata deleteBiller(int id);
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
