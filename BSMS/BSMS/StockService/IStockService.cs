using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BSMS.StockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStockService" in both code and config file together.
    [ServiceContract]
    public interface IStockService
    {
        [OperationContract]
        List<StockData> selectStock();
        [OperationContract]
        List<StockData> selectStockperBranch(int id);
        [OperationContract]
        StockData getSingle(int i);
        [OperationContract]
        Stock addStock(Stock a);
        [OperationContract]
        StockData updateStock(Stock a);
        [OperationContract]
        StockData deleteStock(int id);
    }
    [DataContract]
    public class StockData
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public System.DateTime DOM { get; set; }
        [DataMember]
        public int Available { get; set; }
        [DataMember]
        public int Branch_Id { get; set; }
        [DataMember]
        public string Branch_Location { get; set; }
    }


}
