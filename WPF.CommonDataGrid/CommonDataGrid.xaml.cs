using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.CommonDataGrid
{
    /// <summary>
    /// Interaction logic for CommonDataGrid.xaml
    /// </summary>
    public partial class CommonDataGrid : DataGrid
    {
        public CommonDataGrid()
        {
            InitializeComponent();
        }

        private void OnAutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            CommonDataGridDisplayNameAttribute displayNameAttr = GetAttribute(e.PropertyDescriptor);
            //string displayName = GetPropertyDisplayName(e.PropertyDescriptor);
            if (displayNameAttr != null)
            {
                e.Column.Header = !String.IsNullOrEmpty(displayNameAttr.DisplayName) ? displayNameAttr.DisplayName : "";
                e.Column.Visibility = displayNameAttr.Visible;
            }
        }

        public static CommonDataGridDisplayNameAttribute GetAttribute(object descriptor)
        {
            PropertyDescriptor pd = descriptor as PropertyDescriptor;
            if (pd != null)
            {
                // Check for DisplayName attribute and set the column header accordingly
                CommonDataGridDisplayNameAttribute displayName = pd.Attributes[typeof(CommonDataGridDisplayNameAttribute)] as CommonDataGridDisplayNameAttribute;
                return displayName;
            }
            else
            {
                PropertyInfo pi = descriptor as PropertyInfo;
                if (pi != null)
                {
                    // Check for DisplayName attribute and set the column header accordingly
                    Object[] attributes = pi.GetCustomAttributes(typeof(CommonDataGridDisplayNameAttribute), true);
                    for (int i = 0; i < attributes.Length; ++i)
                    {
                        CommonDataGridDisplayNameAttribute displayName = attributes[i] as CommonDataGridDisplayNameAttribute;
                        if (displayName != null && displayName != CommonDataGridDisplayNameAttribute.Default)
                        {
                            return displayName;
                        }
                    }
                }
            }
            return null;
        }

        //public static string GetPropertyDisplayName(object descriptor)
        //{
        //    PropertyDescriptor pd = descriptor as PropertyDescriptor;
        //    if (pd != null)
        //    {
        //        // Check for DisplayName attribute and set the column header accordingly
        //        DisplayNameAttribute displayName = pd.Attributes[typeof(DisplayNameAttribute)] as DisplayNameAttribute;

        //        if (displayName != null && displayName != DisplayNameAttribute.Default)
        //        {
        //            return displayName.DisplayName;
        //        }

        //    }
        //    else
        //    {
        //        PropertyInfo pi = descriptor as PropertyInfo;
        //        if (pi != null)
        //        {
        //            // Check for DisplayName attribute and set the column header accordingly
        //            Object[] attributes = pi.GetCustomAttributes(typeof(DisplayNameAttribute), true);
        //            for (int i = 0; i < attributes.Length; ++i)
        //            {
        //                DisplayNameAttribute displayName = attributes[i] as DisplayNameAttribute;
        //                if (displayName != null && displayName != DisplayNameAttribute.Default)
        //                {
        //                    return displayName.DisplayName;
        //                }
        //            }
        //        }
        //    }
        //    return null;
        //}
    }
}
