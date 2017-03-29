using System.Collections.ObjectModel;
using WPF.CommonDataGrid;

namespace WPF.TestUI
{
    public class MainWindowViewModel
    {
        public ObservableCollection<TestClass> TestClasses { get; set; }
        public MainWindowViewModel()
        {
            TestClasses = new ObservableCollection<TestClass>();
            TestClasses.Add(new TestClass() { TestID = 1, TestStringValue = "aaa" });
            TestClasses.Add(new TestClass() { TestID = 2, TestStringValue = "bbb" });
        }
    }
}
