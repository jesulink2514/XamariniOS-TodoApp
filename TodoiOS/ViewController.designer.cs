// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TodoiOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CancelarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField FechaFinEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton GuardarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField PrioridadEntry { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton RevisarButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TodoEntry { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CancelarButton != null) {
                CancelarButton.Dispose ();
                CancelarButton = null;
            }

            if (FechaFinEntry != null) {
                FechaFinEntry.Dispose ();
                FechaFinEntry = null;
            }

            if (GuardarButton != null) {
                GuardarButton.Dispose ();
                GuardarButton = null;
            }

            if (PrioridadEntry != null) {
                PrioridadEntry.Dispose ();
                PrioridadEntry = null;
            }

            if (RevisarButton != null) {
                RevisarButton.Dispose ();
                RevisarButton = null;
            }

            if (TodoEntry != null) {
                TodoEntry.Dispose ();
                TodoEntry = null;
            }
        }
    }
}