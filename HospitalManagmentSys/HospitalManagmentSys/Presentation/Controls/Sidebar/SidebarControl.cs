using System.Drawing.Drawing2D;

namespace HospitalManagmentSys.Presentation.Controls.Sidebar;

/// <summary>Reusable dark-theme sidebar. Host should size it (e.g. Dock Fill inside a slide drawer).</summary>
public sealed class SidebarControl : UserControl
{
    private const int SidebarWidthPx = 280;

    private static readonly Color NavActiveBack = Color.FromArgb(0, 122, 140);
    private static readonly Color NavIdleBack = Color.Transparent;

    private readonly Label _timeLabel;
    private readonly Label _dateLabel;
    private readonly System.Windows.Forms.Timer _clockTimer;
    private readonly Label _queueBadgeLabel;
    private readonly Label _userNameLabel;
    private readonly Label _userRoleLabel;
    private readonly ContextMenuStrip _profileMenu;
    private readonly Dictionary<SidebarNavigationItem, Panel> _navRows = new();
    private readonly Button _profileButton;

    private SidebarNavigationItem _selectedNavigationItem;

    public SidebarControl()
    {
        Width = SidebarWidthPx;
        MinimumSize = new Size(SidebarWidthPx, 400);
        BackColor = Color.FromArgb(2, 29, 58);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);

        var rootLayout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 5,
            Padding = new Padding(16, 16, 16, 16),
            BackColor = BackColor
        };

        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
        rootLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        rootLayout.CellPaint += (s, e) =>
        {
            if (e.Row < 4) // Add a subtle divider line below the first 4 sections
            {
                using var pen = new Pen(Color.FromArgb(35, 255, 255, 255));
                e.Graphics.DrawLine(pen, e.CellBounds.Left, e.CellBounds.Bottom - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);
            }
        };

        Controls.Add(rootLayout);

        var header = BuildHeaderSection();
        rootLayout.Controls.Add(header, 0, 0);

        var dateTimePanel = BuildDateTimeSection(out _timeLabel, out _dateLabel);
        rootLayout.Controls.Add(dateTimePanel, 0, 1);

        rootLayout.Controls.Add(BuildQuickActionsSection(), 0, 2);

        var navHost = BuildNavigationHost(out _queueBadgeLabel);
        rootLayout.Controls.Add(navHost, 0, 3);
        navHost.Dock = DockStyle.Fill;

        var profileSection = BuildUserProfileSection(
            out _userNameLabel,
            out _userRoleLabel,
            out _profileButton,
            out _profileMenu);
        rootLayout.Controls.Add(profileSection, 0, 4);

        _clockTimer = new System.Windows.Forms.Timer { Interval = 1000 };
        _clockTimer.Tick += (_, _) => UpdateClock();
        _clockTimer.Start();
        UpdateClock();

        SetQueueBadgeCount(0);
        SetSelectedNavigation(SidebarNavigationItem.Dashboard);
    }

    public event EventHandler<SidebarNavigationChangedEventArgs>? NavigationChanged;
    public event EventHandler? NewPatientClicked;
    public event EventHandler? EmergencyClicked;
    public event EventHandler<SidebarProfileActionEventArgs>? ProfileActionTriggered;

    public SidebarNavigationItem SelectedNavigationItem => _selectedNavigationItem;

    public string UserName
    {
        get => _userNameLabel.Text;
        set => _userNameLabel.Text = string.IsNullOrWhiteSpace(value) ? "Admin User" : value.Trim();
    }

    public string UserRole
    {
        get => _userRoleLabel.Text;
        set => _userRoleLabel.Text = string.IsNullOrWhiteSpace(value) ? "Admin" : value.Trim();
    }

    public void SetSelectedNavigation(SidebarNavigationItem item)
    {
        _selectedNavigationItem = item;
        foreach (var (navItem, row) in _navRows)
        {
            bool isSelected = navItem == item;
            row.BackColor = isSelected ? NavActiveBack : NavIdleBack;
            if (row.Controls["navText"] is Label text)
            {
                text.ForeColor = Color.White;
                text.Font = new Font("Segoe UI", 11F, isSelected ? FontStyle.Bold : FontStyle.Regular, GraphicsUnit.Point);
            }

            if (row.Controls["navIcon"] is Label icon)
                icon.ForeColor = Color.White;
        }
    }

    public void SetQueueBadgeCount(int count)
    {
        int safeCount = Math.Max(0, count);
        _queueBadgeLabel.Text = safeCount.ToString();
        _queueBadgeLabel.Visible = safeCount > 0;
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            _clockTimer.Dispose();
            _profileMenu.Dispose();
        }

        base.Dispose(disposing);
    }

    private Panel BuildHeaderSection()
    {
        var wrap = new Panel
        {
            Dock = DockStyle.Top,
            AutoSize = true,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 0, 0, 8)
        };

        var table = new TableLayoutPanel
        {
            AutoSize = true,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = Color.Transparent
        };
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 42F));
        table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

        var logoPanel = new Panel
        {
            Size = new Size(36, 36),
            BackColor = Color.FromArgb(22, 123, 197),
            Margin = new Padding(0, 2, 0, 0)
        };
        logoPanel.Paint += (_, e) => DrawRoundedRectangle(e.Graphics, logoPanel.ClientRectangle, 8, logoPanel.BackColor);

        var logoGlyph = new Label
        {
            Text = "\uEB52",
            ForeColor = Color.White,
            Font = Mdl2(14f),
            AutoSize = false,
            Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter,
            BackColor = Color.Transparent
        };
        logoPanel.Controls.Add(logoGlyph);

        var textStack = new TableLayoutPanel
        {
            AutoSize = true,
            ColumnCount = 1,
            RowCount = 2,
            BackColor = Color.Transparent,
            Padding = new Padding(10, 0, 0, 0)
        };
        textStack.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        textStack.RowStyles.Add(new RowStyle(SizeType.AutoSize));

        var titleLabel = new Label
        {
            Text = "MediCare",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point),
            AutoSize = true,
            Margin = new Padding(0, 0, 0, 0)
        };

        var subtitleLabel = new Label
        {
            Text = "Reception System",
            ForeColor = Color.FromArgb(153, 176, 204),
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
            AutoSize = true,
            Margin = new Padding(0, 0, 0, 0)
        };

        textStack.Controls.Add(titleLabel, 0, 0);
        textStack.Controls.Add(subtitleLabel, 0, 1);

        table.Controls.Add(logoPanel, 0, 0);
        table.Controls.Add(textStack, 1, 0);
        wrap.Controls.Add(table);
        return wrap;
    }

    private Panel BuildDateTimeSection(out Label timeLabel, out Label dateLabel)
    {
        var panel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 60,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 0, 0, 16)
        };

        timeLabel = new Label
        {
            ForeColor = Color.FromArgb(204, 217, 230),
            Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point),
            Location = new Point(0, 0),
            AutoSize = true
        };

        dateLabel = new Label
        {
            ForeColor = Color.FromArgb(153, 176, 204),
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
            Location = new Point(0, 26),
            AutoSize = true
        };

        panel.Controls.Add(timeLabel);
        panel.Controls.Add(dateLabel);
        return panel;
    }

    private Panel BuildQuickActionsSection()
    {
        var panel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 90,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 0, 0, 16)
        };

        var title = CreateSectionTitle("QUICK ACTIONS");
        title.Location = new Point(0, 0);
        panel.Controls.Add(title);

        var row = new TableLayoutPanel
        {
            Top = 30,
            Left = 0,
            Width = 280,
            Height = 44,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = Color.Transparent
        };
        row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        row.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        row.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        var newPatient = CreateQuickActionTile(
            "\uE13D",
            "New Patient",
            Color.FromArgb(16, 49, 84),
            Color.White,
            (_, _) => NewPatientClicked?.Invoke(this, EventArgs.Empty));

        var emergency = CreateQuickActionTile(
            "\uE814",
            "Emergency",
            Color.FromArgb(220, 38, 67),
            Color.White,
            (_, _) => EmergencyClicked?.Invoke(this, EventArgs.Empty));

        newPatient.Margin = new Padding(0, 0, 6, 0);
        emergency.Margin = new Padding(6, 0, 0, 0);
        row.Controls.Add(newPatient, 0, 0);
        row.Controls.Add(emergency, 1, 0);
        panel.Controls.Add(row);
        return panel;
    }

    private Panel BuildNavigationHost(out Label queueBadgeLabel)
    {
        var outer = new Panel
        {
            BackColor = Color.Transparent,
            Padding = new Padding(0, 0, 0, 8)
        };

        var layout = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 1,
            RowCount = 2,
            BackColor = Color.Transparent
        };
        layout.RowStyles.Add(new RowStyle(SizeType.AutoSize));
        layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        var title = CreateSectionTitle("NAVIGATION");
        title.Margin = new Padding(0, 0, 0, 8);
        layout.Controls.Add(title, 0, 0);

        var navItems = new[]
        {
            (SidebarNavigationItem.Dashboard, "\uE80F", "Dashboard"),
            (SidebarNavigationItem.Patients, "\uE716", "Patients"),
            (SidebarNavigationItem.Appointments, "\uE787", "Appointments"),
            (SidebarNavigationItem.Queue, "\uE8EF", "Queue"),
            (SidebarNavigationItem.Reports, "\uE9D2", "Reports"),
            (SidebarNavigationItem.Settings, "\uE713", "Settings")
        };

        queueBadgeLabel = CreateQueueBadge();

        var list = new FlowLayoutPanel
        {
            Dock = DockStyle.Fill,
            FlowDirection = FlowDirection.TopDown,
            WrapContents = false,
            AutoScroll = true,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 0, 0, 0)
        };

        foreach (var (item, icon, label) in navItems)
        {
            var row = CreateNavigationRow(item, icon, label, item == SidebarNavigationItem.Queue ? queueBadgeLabel : null);
            list.Controls.Add(row);
            _navRows[item] = row;
        }

        layout.Controls.Add(list, 0, 1);
        outer.Controls.Add(layout);

        void SyncNavWidths(object? s, EventArgs e)
        {
            int w = Math.Max(200, list.ClientSize.Width - 4);
            foreach (Control c in list.Controls)
                c.Width = w;
        }

        list.SizeChanged += SyncNavWidths;
        SyncNavWidths(list, EventArgs.Empty);
        return outer;
    }

    private Panel CreateNavigationRow(
        SidebarNavigationItem item,
        string iconGlyph,
        string text,
        Label? badge)
    {
        var row = new Panel
        {
            Width = 248,
            Height = 42,
            BackColor = NavIdleBack,
            Cursor = Cursors.Hand,
            Margin = new Padding(0, 0, 0, 6)
        };

        var icon = new Label
        {
            Name = "navIcon",
            Text = iconGlyph,
            Font = Mdl2(15f),
            ForeColor = Color.White,
            TextAlign = ContentAlignment.MiddleCenter,
            AutoSize = false,
            Size = new Size(36, 36),
            Location = new Point(4, 3),
            BackColor = Color.Transparent
        };

        var lbl = new Label
        {
            Name = "navText",
            Text = text,
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point),
            ForeColor = Color.White,
            AutoSize = false,
            Size = new Size(170, 36),
            Location = new Point(42, 3),
            TextAlign = ContentAlignment.MiddleLeft,
            BackColor = Color.Transparent
        };

        row.Controls.Add(icon);
        row.Controls.Add(lbl);
        if (badge != null)
            row.Controls.Add(badge);

        void OnRowClick(object? s, EventArgs e)
        {
            SetSelectedNavigation(item);
            NavigationChanged?.Invoke(this, new SidebarNavigationChangedEventArgs(item));
        }

        row.Click += OnRowClick;
        WireChildClicks(row, OnRowClick);
        return row;
    }

    private static void WireChildClicks(Control root, EventHandler handler)
    {
        foreach (Control c in root.Controls)
        {
            c.Click += handler;
            if (c.HasChildren)
                WireChildClicks(c, handler);
        }
    }

    private Panel BuildUserProfileSection(
        out Label userNameLabel,
        out Label userRoleLabel,
        out Button profileButton,
        out ContextMenuStrip profileMenu)
    {
        var panel = new Panel
        {
            Dock = DockStyle.Top,
            Height = 72,
            BackColor = Color.Transparent,
            Padding = new Padding(0, 12, 0, 0)
        };

        userNameLabel = new Label
        {
            Text = "Admin User",
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point),
            AutoSize = true,
            Location = new Point(0, 8)
        };

        userRoleLabel = new Label
        {
            Text = "Admin",
            ForeColor = Color.FromArgb(153, 176, 204),
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point),
            AutoSize = true,
            Location = new Point(0, 34)
        };

        var profileBtn = new Button
        {
            Text = "\uE70D",
            Font = Mdl2(10f),
            Width = 32,
            Height = 32,
            FlatStyle = FlatStyle.Flat,
            BackColor = Color.Transparent,
            ForeColor = Color.FromArgb(153, 176, 204),
            Location = new Point(216, 16),
            Cursor = Cursors.Hand,
            TabStop = false
        };
        profileBtn.FlatAppearance.BorderSize = 0;
        profileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 50, 80);

        var menu = new ContextMenuStrip
        {
            BackColor = Color.FromArgb(12, 43, 74),
            ForeColor = Color.White
        };

        var settingsItem = new ToolStripMenuItem("Settings");
        settingsItem.Click += (_, _) => ProfileActionTriggered?.Invoke(this, new SidebarProfileActionEventArgs(SidebarProfileAction.Settings));
        var signOutItem = new ToolStripMenuItem("Sign Out");
        signOutItem.Click += (_, _) => ProfileActionTriggered?.Invoke(this, new SidebarProfileActionEventArgs(SidebarProfileAction.SignOut));

        menu.Items.Add(settingsItem);
        menu.Items.Add(signOutItem);

        profileBtn.Click += (_, _) => menu.Show(profileBtn, new Point(0, profileBtn.Height));

        panel.Controls.Add(userNameLabel);
        panel.Controls.Add(userRoleLabel);
        panel.Controls.Add(profileBtn);

        profileButton = profileBtn;
        profileMenu = menu;
        return panel;
    }

    private static Label CreateSectionTitle(string title)
    {
        return new Label
        {
            Text = title,
            ForeColor = Color.FromArgb(112, 141, 176),
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point),
            AutoSize = true
        };
    }

    private static Panel CreateQuickActionTile(string iconGlyph, string caption, Color back, Color fore, EventHandler onClick)
    {
        var tile = new Panel
        {
            Dock = DockStyle.Fill,
            Margin = new Padding(0, 0, 0, 0),
            BackColor = back,
            Cursor = Cursors.Hand,
            Padding = new Padding(8, 6, 8, 6)
        };
        tile.Paint += (_, e) =>
        {
            DrawRoundedRectangle(e.Graphics, tile.ClientRectangle, 8, tile.BackColor);
        };
        var inner = new TableLayoutPanel
        {
            Dock = DockStyle.Fill,
            ColumnCount = 2,
            RowCount = 1,
            BackColor = Color.Transparent
        };
        inner.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 28F));
        inner.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        inner.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

        var icon = new Label
        {
            Text = iconGlyph,
            Font = Mdl2(14f),
            ForeColor = fore,
            TextAlign = ContentAlignment.MiddleCenter,
            Dock = DockStyle.Fill,
            BackColor = Color.Transparent
        };

        var text = new Label
        {
            Text = caption,
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point),
            ForeColor = fore,
            TextAlign = ContentAlignment.MiddleLeft,
            Dock = DockStyle.Fill,
            BackColor = Color.Transparent,
            AutoEllipsis = true
        };

        inner.Controls.Add(icon, 0, 0);
        inner.Controls.Add(text, 1, 0);
        tile.Controls.Add(inner);

        void Handler(object? s, EventArgs e) => onClick(s, e);
        tile.Click += Handler;
        WireChildClicks(tile, Handler);
        return tile;
    }

    private static Label CreateQueueBadge()
    {
        var badge = new Label
        {
            AutoSize = false,
            Size = new Size(26, 22),
            TextAlign = ContentAlignment.MiddleCenter,
            BackColor = Color.FromArgb(22, 123, 197),
            ForeColor = Color.White,
            Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point),
            Anchor = AnchorStyles.Top | AnchorStyles.Right,
            Location = new Point(214, 10),
            Visible = false
        };
        badge.Paint += (_, e) => DrawRoundedRectangle(e.Graphics, badge.ClientRectangle, 11, badge.BackColor);
        return badge;
    }

    private void UpdateClock()
    {
        DateTime now = DateTime.Now;
        _timeLabel.Text = now.ToString("hh:mm tt");
        _dateLabel.Text = now.ToString("ddd, MMM dd");
    }

    private static Font Mdl2(float sizePt) =>
        new("Segoe MDL2 Assets", sizePt, FontStyle.Regular, GraphicsUnit.Point);

    private static void DrawRoundedRectangle(Graphics graphics, Rectangle bounds, int radius, Color color)
    {
        graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = new GraphicsPath();
        int diameter = radius * 2;

        path.AddArc(bounds.X, bounds.Y, diameter, diameter, 180, 90);
        path.AddArc(bounds.Right - diameter, bounds.Y, diameter, diameter, 270, 90);
        path.AddArc(bounds.Right - diameter, bounds.Bottom - diameter, diameter, diameter, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - diameter, diameter, diameter, 90, 90);
        path.CloseFigure();

        using var brush = new SolidBrush(color);
        graphics.FillPath(brush, path);
    }

     

}

