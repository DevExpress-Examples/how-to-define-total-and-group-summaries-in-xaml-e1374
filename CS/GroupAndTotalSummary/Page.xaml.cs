using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace GroupAndTotalSummary {
    public partial class Page : UserControl {
        public Page() {
            InitializeComponent();
            AgDataGrid1.DataSource = GetData();
        }

        private List<MyDataObject> GetData() {
            List<MyDataObject> list = new List<MyDataObject>();
            list.Add(new MyDataObject() {
                Item = "SD970 IS",
                Price = 379.99m,
                Discontinued = false,
                Announced = new DateTime(2009, 2, 18)
            });
            list.Add(new MyDataObject() {
                Item = "G10",
                Price = 419.99m,
                Discontinued = false,
                Announced = new DateTime(2008, 9, 17)
            });
            list.Add(new MyDataObject() {
                Item = "A580",
                Price = 118.00m,
                Discontinued = false,
                Announced = new DateTime(2008, 1, 24)
            });
            list.Add(new MyDataObject() {
                Item = "EOS D30",
                Price = 275.00m,
                Discontinued = true,
                Announced = new DateTime(2000, 5, 17)
            });
            return list;
        }
    }

    public class MyDataObject {
        public string Item { get; set; }
        public decimal Price { get; set; }
        public DateTime Announced { get; set; }
        public bool Discontinued { get; set; }
    }
}