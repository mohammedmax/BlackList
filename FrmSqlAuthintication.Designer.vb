<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSqlAuthintication
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSqlAuthintication))
        Me.cmbserver = New SQL_Express_DropListBox.SQLExpressCombo()
        Me.gbxServerInfo = New System.Windows.Forms.GroupBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.lblusername = New System.Windows.Forms.Label()
        Me.lblpassword = New System.Windows.Forms.Label()
        Me.RadWinAuthin = New System.Windows.Forms.RadioButton()
        Me.RadSqlAuthin = New System.Windows.Forms.RadioButton()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnTest = New System.Windows.Forms.Button()
        Me.BtnOk = New System.Windows.Forms.Button()
        Me.gbxServerInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbserver
        '
        Me.cmbserver.DropDownHeight = 106
        Me.cmbserver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cmbserver.DropDownWidth = 181
        Me.cmbserver.DroppedDown = False
        Me.cmbserver.Enable_Timer = False
        Me.cmbserver.Interval = 60000
        Me.cmbserver.Location = New System.Drawing.Point(10, 20)
        Me.cmbserver.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbserver.Name = "cmbserver"
        Me.cmbserver.SelectedIndex = -1
        Me.cmbserver.SelectedItem = Nothing
        Me.cmbserver.SelectedText = ""
        Me.cmbserver.SelectionLength = 0
        Me.cmbserver.SelectionStart = 0
        Me.cmbserver.Servers = SQL_Express_DropListBox.SQLExpressCombo.Server_Types.Both_Local_and_Network
        Me.cmbserver.Size = New System.Drawing.Size(196, 22)
        Me.cmbserver.Sorted = False
        Me.cmbserver.TabIndex = 3
        '
        'gbxServerInfo
        '
        Me.gbxServerInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbxServerInfo.Controls.Add(Me.cmbserver)
        Me.gbxServerInfo.Controls.Add(Me.txtpassword)
        Me.gbxServerInfo.Controls.Add(Me.txtusername)
        Me.gbxServerInfo.Controls.Add(Me.lblusername)
        Me.gbxServerInfo.Controls.Add(Me.lblpassword)
        Me.gbxServerInfo.Controls.Add(Me.RadWinAuthin)
        Me.gbxServerInfo.Controls.Add(Me.RadSqlAuthin)
        Me.gbxServerInfo.Controls.Add(Me.lblServer)
        Me.gbxServerInfo.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.gbxServerInfo.ForeColor = System.Drawing.Color.DarkBlue
        Me.gbxServerInfo.Location = New System.Drawing.Point(6, 12)
        Me.gbxServerInfo.Name = "gbxServerInfo"
        Me.gbxServerInfo.Size = New System.Drawing.Size(302, 153)
        Me.gbxServerInfo.TabIndex = 7
        Me.gbxServerInfo.TabStop = False
        Me.gbxServerInfo.Text = "مخدم قواعد البيانات"
        '
        'txtpassword
        '
        Me.txtpassword.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtpassword.Location = New System.Drawing.Point(10, 124)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtpassword.Size = New System.Drawing.Size(196, 20)
        Me.txtpassword.TabIndex = 7
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtusername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList
        Me.txtusername.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtusername.Location = New System.Drawing.Point(10, 98)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtusername.Size = New System.Drawing.Size(196, 20)
        Me.txtusername.TabIndex = 6
        '
        'lblusername
        '
        Me.lblusername.AutoSize = True
        Me.lblusername.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblusername.Location = New System.Drawing.Point(208, 101)
        Me.lblusername.Name = "lblusername"
        Me.lblusername.Size = New System.Drawing.Size(85, 13)
        Me.lblusername.TabIndex = 12
        Me.lblusername.Text = "اسم المستخدم:"
        '
        'lblpassword
        '
        Me.lblpassword.AutoSize = True
        Me.lblpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblpassword.Location = New System.Drawing.Point(222, 127)
        Me.lblpassword.Name = "lblpassword"
        Me.lblpassword.Size = New System.Drawing.Size(63, 13)
        Me.lblpassword.TabIndex = 11
        Me.lblpassword.Text = "كلمة المرور:"
        '
        'RadWinAuthin
        '
        Me.RadWinAuthin.AutoSize = True
        Me.RadWinAuthin.Checked = True
        Me.RadWinAuthin.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.RadWinAuthin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadWinAuthin.Location = New System.Drawing.Point(10, 49)
        Me.RadWinAuthin.Name = "RadWinAuthin"
        Me.RadWinAuthin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadWinAuthin.Size = New System.Drawing.Size(141, 17)
        Me.RadWinAuthin.TabIndex = 4
        Me.RadWinAuthin.TabStop = True
        Me.RadWinAuthin.Text = "Windows Authentication"
        Me.RadWinAuthin.UseVisualStyleBackColor = True
        '
        'RadSqlAuthin
        '
        Me.RadSqlAuthin.AutoSize = True
        Me.RadSqlAuthin.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.RadSqlAuthin.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadSqlAuthin.Location = New System.Drawing.Point(10, 72)
        Me.RadSqlAuthin.Name = "RadSqlAuthin"
        Me.RadSqlAuthin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadSqlAuthin.Size = New System.Drawing.Size(152, 17)
        Me.RadSqlAuthin.TabIndex = 5
        Me.RadSqlAuthin.Text = "SQL Server Authentication"
        Me.RadSqlAuthin.UseVisualStyleBackColor = True
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblServer.Location = New System.Drawing.Point(222, 20)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(44, 13)
        Me.lblServer.TabIndex = 8
        Me.lblServer.Text = "المخدم:"
        '
        'BtnCancel
        '
        Me.BtnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.BtnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnCancel.Location = New System.Drawing.Point(228, 169)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(80, 25)
        Me.BtnCancel.TabIndex = 6
        Me.BtnCancel.Text = "إلغاء الأمر"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnTest
        '
        Me.BtnTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnTest.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.BtnTest.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnTest.Location = New System.Drawing.Point(117, 169)
        Me.BtnTest.Name = "BtnTest"
        Me.BtnTest.Size = New System.Drawing.Size(80, 25)
        Me.BtnTest.TabIndex = 4
        Me.BtnTest.Text = "إختبار"
        Me.BtnTest.UseVisualStyleBackColor = True
        '
        'BtnOk
        '
        Me.BtnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BtnOk.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.BtnOk.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnOk.Location = New System.Drawing.Point(6, 169)
        Me.BtnOk.Name = "BtnOk"
        Me.BtnOk.Size = New System.Drawing.Size(80, 25)
        Me.BtnOk.TabIndex = 5
        Me.BtnOk.Text = "موافق"
        Me.BtnOk.UseVisualStyleBackColor = True
        '
        'FrmSqlAuthintication
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 201)
        Me.Controls.Add(Me.gbxServerInfo)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnTest)
        Me.Controls.Add(Me.BtnOk)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSqlAuthintication"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اعدادت الاتصال"
        Me.gbxServerInfo.ResumeLayout(False)
        Me.gbxServerInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmbserver As SQL_Express_DropListBox.SQLExpressCombo
    Friend WithEvents gbxServerInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents lblusername As System.Windows.Forms.Label
    Friend WithEvents lblpassword As System.Windows.Forms.Label
    Friend WithEvents RadWinAuthin As System.Windows.Forms.RadioButton
    Friend WithEvents RadSqlAuthin As System.Windows.Forms.RadioButton
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnTest As System.Windows.Forms.Button
    Friend WithEvents BtnOk As System.Windows.Forms.Button
End Class
