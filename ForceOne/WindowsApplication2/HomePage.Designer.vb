<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHomePage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MembersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InquiriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MembershipInquiriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DietPlanInquiriesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SupplementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegularToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DefaultersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(771, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembersToolStripMenuItem, Me.InquiriesToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "&Menu"
        '
        'MembersToolStripMenuItem
        '
        Me.MembersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegularToolStripMenuItem, Me.DefaultersToolStripMenuItem})
        Me.MembersToolStripMenuItem.Name = "MembersToolStripMenuItem"
        Me.MembersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.MembersToolStripMenuItem.Text = "Members"
        '
        'InquiriesToolStripMenuItem
        '
        Me.InquiriesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MembershipInquiriesToolStripMenuItem, Me.DietPlanInquiriesToolStripMenuItem, Me.SupplementToolStripMenuItem})
        Me.InquiriesToolStripMenuItem.Name = "InquiriesToolStripMenuItem"
        Me.InquiriesToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.InquiriesToolStripMenuItem.Text = "Inquiries"
        '
        'MembershipInquiriesToolStripMenuItem
        '
        Me.MembershipInquiriesToolStripMenuItem.Name = "MembershipInquiriesToolStripMenuItem"
        Me.MembershipInquiriesToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.MembershipInquiriesToolStripMenuItem.Text = "Membership Inquiries"
        '
        'DietPlanInquiriesToolStripMenuItem
        '
        Me.DietPlanInquiriesToolStripMenuItem.Name = "DietPlanInquiriesToolStripMenuItem"
        Me.DietPlanInquiriesToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.DietPlanInquiriesToolStripMenuItem.Text = "Diet Plan Inquiries"
        '
        'SupplementToolStripMenuItem
        '
        Me.SupplementToolStripMenuItem.Name = "SupplementToolStripMenuItem"
        Me.SupplementToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.SupplementToolStripMenuItem.Text = "Supplements Inquiries"
        '
        'RegularToolStripMenuItem
        '
        Me.RegularToolStripMenuItem.Name = "RegularToolStripMenuItem"
        Me.RegularToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RegularToolStripMenuItem.Text = "Regular"
        '
        'DefaultersToolStripMenuItem
        '
        Me.DefaultersToolStripMenuItem.Name = "DefaultersToolStripMenuItem"
        Me.DefaultersToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.DefaultersToolStripMenuItem.Text = "Defaulters"
        '
        'FrmHomePage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 456)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmHomePage"
        Me.Text = "HomePage"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InquiriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MembershipInquiriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DietPlanInquiriesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SupplementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegularToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefaultersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
