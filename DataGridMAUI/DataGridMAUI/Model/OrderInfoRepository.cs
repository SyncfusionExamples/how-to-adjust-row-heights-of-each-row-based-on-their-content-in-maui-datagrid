using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridMAUI
{
    public class OrderInfoRepository
    {
        ObservableCollection<OrderInfo> orderDetails;

        public OrderInfoRepository()
        {
            orderDetails = new ObservableCollection<OrderInfo>();
        }

        #region private variables

        private Random random = new Random();

        #endregion

        #region GetOrderDetails

        public ObservableCollection<OrderInfo> GetOrderDetails(int count)
        {
            for (int i = 10001; i <= count + 10000; i++)
            {
                var ord = new OrderInfo()
                {
                    OrderId = i,
                    CustomerId = CustomerID[random.Next(15)],
                    CustomerQuery = CustomerQuery[random.Next(8)],
                    Country = country[random.Next(15)]
                };
                orderDetails.Add(ord);
            }
            return orderDetails;
        }

        #endregion

        string[] CustomerID = new string[] {
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves ",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves",
            "Furib Merep Linod Seves"
        };

        string[] country = new string[]
        {
            "US",
            "Australia",
            "Canada",
            "UK",
            "India",
            "Italy",
            "China",
            "Japan",
            "Belgium",
            "Mexico",
            "Brazil",
            "Singapore",
            "North Korea",
            "Greece",
            "Norway",
            "Netherland",
            "Austria",
            "Sweden",
            "Poland",
            "Hungary",
            "Russia"
        };

        string[] CustomerQuery = new string[]
        {
            "How to specify the height and width of sfDataGrid in different layout",
            "How to add SfDataGrid in ViewPager",
            "How to add SDataGrid in Fragment",
            "How to display busy Indicator while loading dat in SfDataGrid",
            "How to export a SfDataGrid to excel or PDF using ToolBarItems of a Page",
            "How to apply sorting for the new items added in SfDataGrid",
            "How to clear selection in a button click using MVVM in SfDataGrid",
            "How to display an animation while loading the data in the SfDataGrid"

        };

    }
}
