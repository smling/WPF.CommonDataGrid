using System;
using System.ComponentModel;
using System.Windows;

namespace WPF.CommonDataGrid
{
    public class TestClass : ObservableProperty
    {
        private int _testID;
        [CommonDataGridDisplayName("Test ID")]
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
        [CommonDataGridDisplayName("Test string value", Visibility.Collapsed)]
        public string TestStringValue
        {
            get { return _testStringValue; }
            set
            {
                _testStringValue = value;
                SetField(ref _testStringValue, value);
            }
        }
        private DateTime _testDateTime;
        [CommonDataGridDisplayName("Test DateTime")]
        public DateTime TestDateTime
        {
            get { return _testDateTime; }
            set
            {
                _testDateTime = value;
                SetField(ref _testDateTime, value);
            }
        }
    }
}
