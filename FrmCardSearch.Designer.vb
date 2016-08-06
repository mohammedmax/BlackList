<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCardSearch
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCardSearch))
        Me.GrdResults = New System.Windows.Forms.DataGridView()
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColSerialNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBranchId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColBranchName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColLaBranchName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCardAddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdentityKind = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColIdentityNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCardPhone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCardMob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BlackList = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identity_Kind = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PnlAdvanced = New System.Windows.Forms.Panel()
        Me.ChkPrivetCard = New System.Windows.Forms.CheckBox()
        Me.ChkBlacklist = New System.Windows.Forms.CheckBox()
        Me.CmbIdentityKind = New System.Windows.Forms.ComboBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtMobile = New System.Windows.Forms.TextBox()
        Me.TxtPhone = New System.Windows.Forms.TextBox()
        Me.TxtIdentityNO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblBranch = New System.Windows.Forms.Label()
        Me.TxtSerialNumber = New System.Windows.Forms.TextBox()
        Me.lblAccount = New System.Windows.Forms.Label()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.TxtFullName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LnkAdvanced = New System.Windows.Forms.LinkLabel()
        CType(Me.GrdResults, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.PnlAdvanced.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrdResults
        '
        Me.GrdResults.AllowUserToAddRows = False
        Me.GrdResults.AllowUserToDeleteRows = False
        Me.GrdResults.AllowUserToResizeRows = False
        Me.GrdResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdResults.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrdResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdResults.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColID, Me.ColSerialNumber, Me.ColFullName, Me.ColBranchId, Me.ColBranchName, Me.ColLaBranchName, Me.ColCardAddress, Me.ColIdentityKind, Me.ColIdentityNo, Me.ColCardPhone, Me.ColCardMob, Me.BlackList, Me.Identity_Kind})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdResults.DefaultCellStyle = DataGridViewCellStyle5
        Me.GrdResults.Location = New System.Drawing.Point(6, 152)
        Me.GrdResults.MultiSelect = False
        Me.GrdResults.Name = "GrdResults"
        Me.GrdResults.ReadOnly = True
        Me.GrdResults.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Tahoma", 8.0!)
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrdResults.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.GrdResults.RowHeadersVisible = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.DarkBlue
        Me.GrdResults.RowsDefaultCellStyle = DataGridViewCellStyle7
        Me.GrdResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdResults.Size = New System.Drawing.Size(717, 235)
        Me.GrdResults.TabIndex = 0
        '
        'ColID
        '
        Me.ColID.DataPropertyName = "id"
        Me.ColID.HeaderText = "ID"
        Me.ColID.Name = "ColID"
        Me.ColID.ReadOnly = True
        Me.ColID.Visible = False
        '
        'ColSerialNumber
        '
        Me.ColSerialNumber.DataPropertyName = "SerialNumber"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DarkBlue
        Me.ColSerialNumber.DefaultCellStyle = DataGridViewCellStyle2
        Me.ColSerialNumber.HeaderText = "الرقم التسلسلي"
        Me.ColSerialNumber.Name = "ColSerialNumber"
        Me.ColSerialNumber.ReadOnly = True
        Me.ColSerialNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColSerialNumber.Width = 70
        '
        'ColFullName
        '
        Me.ColFullName.DataPropertyName = "FullName"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkBlue
        Me.ColFullName.DefaultCellStyle = DataGridViewCellStyle3
        Me.ColFullName.HeaderText = "الاسم الثلاثي"
        Me.ColFullName.Name = "ColFullName"
        Me.ColFullName.ReadOnly = True
        Me.ColFullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColFullName.Width = 120
        '
        'ColBranchId
        '
        Me.ColBranchId.DataPropertyName = "branch_id"
        Me.ColBranchId.HeaderText = "رمز الفرع"
        Me.ColBranchId.Name = "ColBranchId"
        Me.ColBranchId.ReadOnly = True
        Me.ColBranchId.Visible = False
        '
        'ColBranchName
        '
        Me.ColBranchName.DataPropertyName = "ar_branch_name"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkBlue
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkBlue
        Me.ColBranchName.DefaultCellStyle = DataGridViewCellStyle4
        Me.ColBranchName.HeaderText = "الفرع"
        Me.ColBranchName.Name = "ColBranchName"
        Me.ColBranchName.ReadOnly = True
        Me.ColBranchName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColBranchName.Width = 75
        '
        'ColLaBranchName
        '
        Me.ColLaBranchName.DataPropertyName = "la_branch_name"
        Me.ColLaBranchName.HeaderText = "Branch"
        Me.ColLaBranchName.Name = "ColLaBranchName"
        Me.ColLaBranchName.ReadOnly = True
        Me.ColLaBranchName.Visible = False
        '
        'ColCardAddress
        '
        Me.ColCardAddress.DataPropertyName = "Card_Address"
        Me.ColCardAddress.HeaderText = "العنوان"
        Me.ColCardAddress.Name = "ColCardAddress"
        Me.ColCardAddress.ReadOnly = True
        '
        'ColIdentityKind
        '
        Me.ColIdentityKind.DataPropertyName = "Identity_Kind"
        Me.ColIdentityKind.HeaderText = "نوع التعريف"
        Me.ColIdentityKind.Name = "ColIdentityKind"
        Me.ColIdentityKind.ReadOnly = True
        Me.ColIdentityKind.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColIdentityKind.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ColIdentityKind.Width = 65
        '
        'ColIdentityNo
        '
        Me.ColIdentityNo.DataPropertyName = "Identity_No"
        Me.ColIdentityNo.HeaderText = "رقم التعريف"
        Me.ColIdentityNo.Name = "ColIdentityNo"
        Me.ColIdentityNo.ReadOnly = True
        '
        'ColCardPhone
        '
        Me.ColCardPhone.DataPropertyName = "Card_Phone"
        Me.ColCardPhone.HeaderText = "رقم الهاتف"
        Me.ColCardPhone.Name = "ColCardPhone"
        Me.ColCardPhone.ReadOnly = True
        Me.ColCardPhone.Width = 70
        '
        'ColCardMob
        '
        Me.ColCardMob.DataPropertyName = "Card_Mob"
        Me.ColCardMob.HeaderText = "رقم الجوال"
        Me.ColCardMob.Name = "ColCardMob"
        Me.ColCardMob.ReadOnly = True
        Me.ColCardMob.Width = 70
        '
        'BlackList
        '
        Me.BlackList.HeaderText = "القائمة السوداء"
        Me.BlackList.Name = "BlackList"
        Me.BlackList.ReadOnly = True
        Me.BlackList.Visible = False
        '
        'Identity_Kind
        '
        Me.Identity_Kind.DataPropertyName = "Identity_Kind"
        Me.Identity_Kind.HeaderText = "Identity_Kind"
        Me.Identity_Kind.Name = "Identity_Kind"
        Me.Identity_Kind.ReadOnly = True
        Me.Identity_Kind.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PnlAdvanced)
        Me.GroupBox1.Controls.Add(Me.BtnNew)
        Me.GroupBox1.Controls.Add(Me.TxtFullName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LnkAdvanced)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(715, 140)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "خيارات البحث"
        '
        'PnlAdvanced
        '
        Me.PnlAdvanced.Controls.Add(Me.ChkPrivetCard)
        Me.PnlAdvanced.Controls.Add(Me.ChkBlacklist)
        Me.PnlAdvanced.Controls.Add(Me.CmbIdentityKind)
        Me.PnlAdvanced.Controls.Add(Me.BtnSearch)
        Me.PnlAdvanced.Controls.Add(Me.TxtMobile)
        Me.PnlAdvanced.Controls.Add(Me.TxtPhone)
        Me.PnlAdvanced.Controls.Add(Me.TxtIdentityNO)
        Me.PnlAdvanced.Controls.Add(Me.Label5)
        Me.PnlAdvanced.Controls.Add(Me.Label4)
        Me.PnlAdvanced.Controls.Add(Me.Label3)
        Me.PnlAdvanced.Controls.Add(Me.LblBranch)
        Me.PnlAdvanced.Controls.Add(Me.TxtSerialNumber)
        Me.PnlAdvanced.Controls.Add(Me.lblAccount)
        Me.PnlAdvanced.Location = New System.Drawing.Point(6, 54)
        Me.PnlAdvanced.Name = "PnlAdvanced"
        Me.PnlAdvanced.Size = New System.Drawing.Size(703, 82)
        Me.PnlAdvanced.TabIndex = 2
        Me.PnlAdvanced.Visible = False
        '
        'ChkPrivetCard
        '
        Me.ChkPrivetCard.AutoSize = True
        Me.ChkPrivetCard.Location = New System.Drawing.Point(26, 30)
        Me.ChkPrivetCard.Name = "ChkPrivetCard"
        Me.ChkPrivetCard.Size = New System.Drawing.Size(79, 17)
        Me.ChkPrivetCard.TabIndex = 52
        Me.ChkPrivetCard.Tag = "ActiveStat"
        Me.ChkPrivetCard.Text = "الغير مكتملة"
        Me.ChkPrivetCard.UseVisualStyleBackColor = True
        '
        'ChkBlacklist
        '
        Me.ChkBlacklist.AutoSize = True
        Me.ChkBlacklist.Location = New System.Drawing.Point(12, 10)
        Me.ChkBlacklist.Name = "ChkBlacklist"
        Me.ChkBlacklist.Size = New System.Drawing.Size(93, 17)
        Me.ChkBlacklist.TabIndex = 51
        Me.ChkBlacklist.Tag = "ActiveStat"
        Me.ChkBlacklist.Text = "القائمة السوداء"
        Me.ChkBlacklist.UseVisualStyleBackColor = True
        '
        'CmbIdentityKind
        '
        Me.CmbIdentityKind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbIdentityKind.FormattingEnabled = True
        Me.CmbIdentityKind.Items.AddRange(New Object() {"رقم وطني", "رقم الجواز", "رقم بطاقة إقامة", "رقم بطاقة أسرية", "رقم هوية عسكرية ", "إجازة سوق", "سجل تجاري", "سجل جمعيات - منظمات", "رقم بيان صادر عن منظمات ", "أخرى"})
        Me.CmbIdentityKind.Location = New System.Drawing.Point(455, 33)
        Me.CmbIdentityKind.Name = "CmbIdentityKind"
        Me.CmbIdentityKind.Size = New System.Drawing.Size(160, 21)
        Me.CmbIdentityKind.TabIndex = 1
        '
        'BtnSearch
        '
        Me.BtnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnSearch.Location = New System.Drawing.Point(12, 46)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(71, 29)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtMobile
        '
        Me.TxtMobile.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtMobile.ForeColor = System.Drawing.Color.DarkBlue
        Me.TxtMobile.Location = New System.Drawing.Point(155, 60)
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.Size = New System.Drawing.Size(160, 20)
        Me.TxtMobile.TabIndex = 5
        '
        'TxtPhone
        '
        Me.TxtPhone.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtPhone.ForeColor = System.Drawing.Color.DarkBlue
        Me.TxtPhone.Location = New System.Drawing.Point(155, 34)
        Me.TxtPhone.Name = "TxtPhone"
        Me.TxtPhone.Size = New System.Drawing.Size(160, 20)
        Me.TxtPhone.TabIndex = 4
        '
        'TxtIdentityNO
        '
        Me.TxtIdentityNO.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtIdentityNO.ForeColor = System.Drawing.Color.DarkBlue
        Me.TxtIdentityNO.Location = New System.Drawing.Point(455, 60)
        Me.TxtIdentityNO.Name = "TxtIdentityNO"
        Me.TxtIdentityNO.Size = New System.Drawing.Size(160, 20)
        Me.TxtIdentityNO.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(321, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "رقم الجوال :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label4.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label4.Location = New System.Drawing.Point(321, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "رقم الهاتف :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(627, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "نوع التعريف :"
        '
        'LblBranch
        '
        Me.LblBranch.AutoSize = True
        Me.LblBranch.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.LblBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblBranch.Location = New System.Drawing.Point(627, 63)
        Me.LblBranch.Name = "LblBranch"
        Me.LblBranch.Size = New System.Drawing.Size(68, 13)
        Me.LblBranch.TabIndex = 27
        Me.LblBranch.Text = "رقم التعريف :"
        '
        'TxtSerialNumber
        '
        Me.TxtSerialNumber.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtSerialNumber.ForeColor = System.Drawing.Color.DarkBlue
        Me.TxtSerialNumber.Location = New System.Drawing.Point(155, 7)
        Me.TxtSerialNumber.Name = "TxtSerialNumber"
        Me.TxtSerialNumber.Size = New System.Drawing.Size(160, 20)
        Me.TxtSerialNumber.TabIndex = 3
        '
        'lblAccount
        '
        Me.lblAccount.AutoSize = True
        Me.lblAccount.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.lblAccount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblAccount.Location = New System.Drawing.Point(321, 10)
        Me.lblAccount.Name = "lblAccount"
        Me.lblAccount.Size = New System.Drawing.Size(91, 13)
        Me.lblAccount.TabIndex = 23
        Me.lblAccount.Text = "الرقم التسلسلي:"
        '
        'BtnNew
        '
        Me.BtnNew.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BtnNew.Location = New System.Drawing.Point(18, 22)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(71, 29)
        Me.BtnNew.TabIndex = 3
        Me.BtnNew.Text = "جديد"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'TxtFullName
        '
        Me.TxtFullName.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.TxtFullName.ForeColor = System.Drawing.Color.DarkBlue
        Me.TxtFullName.Location = New System.Drawing.Point(143, 29)
        Me.TxtFullName.Name = "TxtFullName"
        Me.TxtFullName.Size = New System.Drawing.Size(478, 20)
        Me.TxtFullName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(633, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "الاسم الثلاثي:"
        '
        'LnkAdvanced
        '
        Me.LnkAdvanced.Location = New System.Drawing.Point(538, 13)
        Me.LnkAdvanced.Name = "LnkAdvanced"
        Me.LnkAdvanced.Size = New System.Drawing.Size(84, 13)
        Me.LnkAdvanced.TabIndex = 1
        Me.LnkAdvanced.TabStop = True
        Me.LnkAdvanced.Tag = "1"
        Me.LnkAdvanced.Text = "بحث عادي"
        Me.LnkAdvanced.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FrmCardSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(725, 392)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrdResults)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "FrmCardSearch"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "3008"
        Me.Text = "بحث"
        CType(Me.GrdResults, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PnlAdvanced.ResumeLayout(False)
        Me.PnlAdvanced.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GrdResults As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents PnlAdvanced As System.Windows.Forms.Panel
    Friend WithEvents CmbIdentityKind As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMobile As System.Windows.Forms.TextBox
    Friend WithEvents TxtPhone As System.Windows.Forms.TextBox
    Friend WithEvents TxtIdentityNO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LblBranch As System.Windows.Forms.Label
    Friend WithEvents TxtSerialNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblAccount As System.Windows.Forms.Label
    Friend WithEvents LnkAdvanced As System.Windows.Forms.LinkLabel
    Friend WithEvents ChkBlacklist As System.Windows.Forms.CheckBox
    Friend WithEvents ColID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColSerialNumber As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFullName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBranchId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColBranchName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColLaBranchName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCardAddress As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIdentityKind As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColIdentityNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCardPhone As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColCardMob As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BlackList As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Identity_Kind As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ChkPrivetCard As System.Windows.Forms.CheckBox
End Class
