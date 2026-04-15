namespace HospitalManagmentSys.Presentation.Controls.Sidebar;

public sealed class SidebarNavigationChangedEventArgs : EventArgs
{
    public SidebarNavigationChangedEventArgs(SidebarNavigationItem item)
    {
        Item = item;
    }

    public SidebarNavigationItem Item { get; }

    public string PageName => Item.ToString();
}
