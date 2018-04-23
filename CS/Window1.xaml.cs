using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;

namespace BindComboBoxEdit {

    public partial class Window1 : Window {

        public Window1() {
            InitializeComponent();

            List<TestData> list = new List<TestData>();
            for (int i = 0; i < 100; i++) {
                list.Add(new TestData() { Text = "row " + i, DetailId = i % 5, 
                    DetailSource = GetDetailSource(i % 5) });
            }

            grid.DataSource = list;
        }

        IList<DetailData> GetDetailSource(int i) {
            List<DetailData> detailSource = new List<DetailData>();
            for (int j = 0; j < 10; j++) {
                detailSource.Add(new DetailData() { Id = i + j, 
                    Value = "value " + (i + j) + " kind  " + i });
            }
            return detailSource;
        }
    }

    public class TestData {
        public string Text { get; set; }
        public int DetailId { get; set; }
        public object DetailSource { get; set; }
    }

    public class DetailData {
        public int Id { get; set; }
        public string Value { get; set; }
    }
}
