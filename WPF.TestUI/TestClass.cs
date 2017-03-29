using System.ComponentModel;

namespace WPF.CommonDataGrid
{
    public class TestClass : ObservableProperty
    {
        private int _testID;
        [DisplayName("Test ID")]
        public int TestID
        {
            get { return _testID; }
            set
            {
                _testID = value;
                SetField(ref _testID, value);
            }
        }
        private string _testStringValue;
        [DisplayName("Test string value")]
        public string TestStringValue
        {
            get { return _testStringValue; }
            set
            {
                _testStringValue = value;
                SetField(ref _testStringValue, value);
            }
        }
    }
}
