using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace TodoiOS
{
    public partial class RevisarTodosViewController : UITableViewController
    {
        public List<TodoItem> Todos { get; set; }

        public const string TodoCellId = "TodoCell";

        public RevisarTodosViewController (IntPtr handle) : base (handle)
        {
            TableView.RegisterClassForCellReuse(typeof(UITableViewCell), TodoCellId);

            TableView.Source = new TodoDataSource(this);

            Todos = new List<TodoItem>();
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);

            foreach (var item in Database.GetConnection().Table<TodoItem>())
            {
                Todos.Add(item);
            }

            TableView.ReloadData();
        }

    }

    public class TodoDataSource: UITableViewSource
    {
        private RevisarTodosViewController controller;
        public TodoDataSource(RevisarTodosViewController controller)
        {
            this.controller = controller;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return controller.Todos.Count;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = tableView.DequeueReusableCell(RevisarTodosViewController.TodoCellId);

            var rowIndex = indexPath.Row;

            var todo = controller.Todos[rowIndex];

            cell.TextLabel.Text = $"{todo.Tarea} - {todo.Prioridad} - {todo.FechaFin}";

            return cell;
        }
    }
}