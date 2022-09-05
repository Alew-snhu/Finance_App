using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finance_App
{
    public class MauiSampleViewModel
    {

        public List<Sales> Data { get; set; }

        public MauiSampleViewModel()
        {
            Data = new List<Sales>()
            {

            new Sales(){Product = "iPad", SalesRate = 25},
            new Sales(){Product = "iPhone", SalesRate = 35},
            new Sales(){Product = "MacBook", SalesRate = 15},
            new Sales(){Product = "Mac", SalesRate = 5},
            new Sales(){Product = "Others", SalesRate = 10},

            };

        }
        public class Sales
        {
            public string Product { get; set; }
            public double SalesRate { get; set; }
        }
        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        public class OrderInfo
        {
            private string orderID;
            private string customerID;
            private string customer;
            

            public string OrderID
            {
                get { return orderID; }
                set { this.orderID = value; }
            }

            public string Name
            {
                get { return customerID; }
                set { this.customerID = value; }
            }

            

            public string Customer
            {
                get { return this.customer; }
                set { this.customer = value; }
            }

            

            public OrderInfo(string orderId, string customerId, string customer)
            {
                this.OrderID = orderId;
                this.Name = customerId;
                this.Customer = customer;
                
                
            }
        }
        public class OrderInfoRepository
        {
            private ObservableCollection<OrderInfo> orderInfo;
            public ObservableCollection<OrderInfo> OrderInfoCollection
            {
                get { return orderInfo; }
                set { this.orderInfo = value; }
            }

            public OrderInfoRepository()
            {
                orderInfo = new ObservableCollection<OrderInfo>();
                this.GenerateOrders();
            }

            public void GenerateOrders()
            {
                orderInfo.Add(new OrderInfo("1001", "Maria Anders", "Germany"));
                orderInfo.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico"));
                orderInfo.Add(new OrderInfo("1003", "Ant Fuller", "Mexico"));
                orderInfo.Add(new OrderInfo("1004", "Thomas Hardy", "UK"));
                orderInfo.Add(new OrderInfo("1005", "Tim Adams", "Sweden"));
                orderInfo.Add(new OrderInfo("1006", "Hanna Moos", "Germany"));
                orderInfo.Add(new OrderInfo("1007", "Maria Anders", "Germany"));
                orderInfo.Add(new OrderInfo("1008", "Ana Trujillo", "Mexico"));
                orderInfo.Add(new OrderInfo("1009", "Ant Fuller", "Mexico"));
                orderInfo.Add(new OrderInfo("1010", "Thomas Hardy", "UK"));
                orderInfo.Add(new OrderInfo("1011", "Tim Adams", "Sweden"));
                orderInfo.Add(new OrderInfo("1012", "Hanna Moos", "Germany"));
            }
        }
    }
}
