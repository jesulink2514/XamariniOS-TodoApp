using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TodoiOS
{
    public partial class ViewController : UIViewController
    {
        public string TodoItem = "";
        public List<TodoItem> Todos { get; set; } = new List<TodoItem>();
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            GuardarButton.TouchUpInside += (s, e) =>
            {
                var todo = new TodoItem()
                {
                    Tarea = TodoEntry.Text,
                    Prioridad = PrioridadEntry.Text,
                    FechaFin = DateTime.Now,
                    Completado = false
                };
                Todos.Add(todo);
                TodoEntry.Text = string.Empty;
                TodoEntry.ResignFirstResponder();
            };

            CancelarButton.TouchUpInside += (s, e) =>
            {
                TodoEntry.Text = string.Empty;
                PrioridadEntry.Text = string.Empty;
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