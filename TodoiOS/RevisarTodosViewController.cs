using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace TodoiOS
{
    public partial class RevisarTodosViewController : UITableViewController
    {
        public List<string> Todos { get; set; }

        public RevisarTodosViewController (IntPtr handle) : base (handle)
        {
        }
    }
}