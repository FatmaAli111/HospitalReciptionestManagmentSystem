namespace HospitalManagmentSys.Presentation.Controls.Sidebar;

public sealed class SidebarProfileActionEventArgs : EventArgs
{
    public SidebarProfileActionEventArgs(SidebarProfileAction action)
    {
        Action = action;
    }

    public SidebarProfileAction Action { get; }
}
