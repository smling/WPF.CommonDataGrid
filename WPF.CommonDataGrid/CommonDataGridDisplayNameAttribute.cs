using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.CommonDataGrid
{
    public class CommonDataGridDisplayNameAttribute: DisplayNameAttribute
    {
        public Visibility Visible { get; set; }

        public CommonDataGridDisplayNameAttribute():base()
        {
            Initialize();
        }

        public CommonDataGridDisplayNameAttribute(string displayName) : base(displayName)
        {
            Initialize();
        }

        public CommonDataGridDisplayNameAttribute(string displayName, Visibility visible) : base(displayName)
        {
            Initialize(visible);
        }

        private bool Initialize(Visibility visible=Visibility.Visible)
        {
            this.Visible = visible;
            return true;
        }
    }
}
