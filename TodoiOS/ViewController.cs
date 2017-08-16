using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TodoiOS
{
    public partial class ViewController : UIViewController
    {
        public string TodoItem = "";
        public List<string> Todos { get; set; } = new List<string>();
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            GuardarButton.TouchUpInside += (s, e) =>
            {
                Todos.Add(TodoEntry.Text);
                TodoEntry.Text = string.Empty;
                TodoEntry.ResignFirstResponder();
            };
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            var revisarcontroller = segue.DestinationViewController as RevisarTodosViewController;
            if (revisarcontroller == null) return;

            revisarcontroller.Todos = Todos;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}