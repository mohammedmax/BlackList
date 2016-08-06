<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSqlAuthintication = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpretion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuIdentityKind = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCardIdentity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCardSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuBlackList = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعليماتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tslLabTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLabTimeVal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLabDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tslLabDateVal = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuOpretion, Me.تعليماتToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(990, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSqlAuthintication, Me.ToolStripSeparator2, Me.mnuClose})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(42, 20)
        Me.mnuFile.Text = "ملف"
        '
        'mnuSqlAuthintication
        '
        Me.mnuSqlAuthintication.Name = "mnuSqlAuthintication"
        Me.mnuSqlAuthintication.Size = New System.Drawing.Size(182, 22)
        Me.mnuSqlAuthintication.Text = "ضبط اعدادات الاتصال"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(179, 6)
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(182, 22)
        Me.mnuClose.Text = "اغلاق البرنامج"
        '
        'mnuOpretion
        '
        Me.mnuOpretion.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIdentityKind, Me.mnuCardIdentity, Me.mnuCardSearch, Me.ToolStripSeparator1, Me.mnuBlackList})
        Me.mnuOpretion.Name = "mnuOpretion"
        Me.mnuOpretion.Size = New System.Drawing.Size(62, 20)
        Me.mnuOpretion.Text = "العمليات"
        Me.mnuOpretion.Visible = False
        '
        'mnuIdentityKind
        '
        Me.mnuIdentityKind.Name = "mnuIdentityKind"
        Me.mnuIdentityKind.Size = New System.Drawing.Size(195, 22)
        Me.mnuIdentityKind.Text = "اضافة نوع تعريف"
        '
        'mnuCardIdentity
        '
        Me.mnuCardIdentity.Name = "mnuCardIdentity"
        Me.mnuCardIdentity.Size = New System.Drawing.Size(195, 22)
        Me.mnuCardIdentity.Text = "اضافة بطاقة تعريف"
        '
        'mnuCardSearch
        '
        Me.mnuCardSearch.Name = "mnuCardSearch"
        Me.mnuCardSearch.Size = New System.Drawing.Size(195, 22)
        Me.mnuCardSearch.Text = "استعلام بطاقات التعريف"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(192, 6)
        '
        'mnuBlackList
        '
        Me.mnuBlackList.Name = "mnuBlackList"
        Me.mnuBlackList.Size = New System.Drawing.Size(195, 22)
        Me.mnuBlackList.Text = "القائمة السوداء"
        '
        'تعليماتToolStripMenuItem
        '
        Me.تعليماتToolStripMenuItem.Name = "تعليماتToolStripMenuItem"
        Me.تعليماتToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.تعليماتToolStripMenuItem.Text = "تعليمات"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslLabTime, Me.tslLabTimeVal, Me.ToolStripStatusLabel1, Me.tslLabDate, Me.tslLabDateVal})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 410)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(990, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslLabTime
        '
        Me.tslLabTime.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLabTime.Image = CType(resources.GetObject("tslLabTime.Image"), System.Drawing.Image)
        Me.tslLabTime.Name = "tslLabTime"
        Me.tslLabTime.Size = New System.Drawing.Size(61, 17)
        Me.tslLabTime.Text = "الساعة:"
        '
        'tslLabTimeVal
        '
        Me.tslLabTimeVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLabTimeVal.ForeColor = System.Drawing.Color.Blue
        Me.tslLabTimeVal.Name = "tslLabTimeVal"
        Me.tslLabTimeVal.Size = New System.Drawing.Size(35, 17)
        Me.tslLabTimeVal.Text = "----    "
        '
        'tslLabDate
        '
        Me.tslLabDate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLabDate.Image = CType(resources.GetObject("tslLabDate.Image"), System.Drawing.Image)
        Me.tslLabDate.Name = "tslLabDate"
        Me.tslLabDate.Size = New System.Drawing.Size(55, 17)
        Me.tslLabDate.Text = "التاريخ:"
        '
        'tslLabDateVal
        '
        Me.tslLabDateVal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tslLabDateVal.ForeColor = System.Drawing.Color.Blue
        Me.tslLabDateVal.Name = "tslLabDateVal"
        Me.tslLabDateVal.Size = New System.Drawing.Size(23, 17)
        Me.tslLabDateVal.Text = "----"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(11, 17)
        Me.ToolStripStatusLabel1.Text = "|"
        '
        'Timer1
        '
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(990, 432)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الشاشة الرئيسية"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOpretion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCardIdentity As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCardSearch As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBlackList As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعليماتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIdentityKind As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSqlAuthintication As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslLabTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslLabTimeVal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslLabDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tslLabDateVal As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
