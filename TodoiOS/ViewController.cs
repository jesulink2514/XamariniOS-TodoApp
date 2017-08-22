using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using DT.iOS.DatePickerDialog;
using SQLite;

namespace TodoiOS
{
    public partial class ViewController : UIViewController
    {
        private DateTime _fechafin;
        private readonly SQLiteConnection _db;
        public ViewController(IntPtr handle) : base(handle)
        {
            _db = Database.GetConnection();
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
                    FechaFin = _fechafin,
                    Completado = false
                };

                _db.Insert(todo);

                TodoEntry.Text = string.Empty;
                PrioridadEntry.Text = string.Empty;
                FechaFinEntry.Text = string.Empty;

                PrioridadEntry.ResignFirstResponder();
                TodoEntry.ResignFirstResponder();
            };

            CancelarButton.TouchUpInside += (s, e) =>
            {
                TodoEntry.Text = string.Empty;
                PrioridadEntry.Text = string.Empty;
                FechaFinEntry.Text = string.Empty;
            };

            FechaFinEntry.ShouldBeginEditing += OnFechaBeginEditing;
        }

        private bool OnFechaBeginEditing(UITextField textField)
        {
            var dialog = new DatePickerDialog();
            var fechaPorDefecto = DateTime.Now;
            dialog.Show("Elige la fecha fin", "Ok", "Cancelar", UIDatePickerMode.Date, (dt) =>
            {
                _fechafin = dt;
                FechaFinEntry.Text = dt.ToShortDateString();
            },fechaPorDefecto);
            return false;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}