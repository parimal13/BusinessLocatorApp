// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BusinessLocator.iOS
{
    [Register ("MapListViewController")]
    partial class MapListViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView MapListView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView UsersTableView { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MapListView != null) {
                MapListView.Dispose ();
                MapListView = null;
            }

            if (UsersTableView != null) {
                UsersTableView.Dispose ();
                UsersTableView = null;
            }
        }
    }
}