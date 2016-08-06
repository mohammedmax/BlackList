<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBlackList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBlackList))
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DgvSearch = New System.Windows.Forms.DataGridView()
        Me.ColId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColFirstName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColNotes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CmbKindList = New System.Windows.Forms.ComboBox()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCountRecourd = New System.Windows.Forms.Label()
        Me.lblWait = New System.Windows.Forms.Label()
        CType(Me.DgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSearch
        '
        Me.BtnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSearch.Image = CType(resources.GetObject("BtnSearch.Image"), System.Drawing.Image)
        Me.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnSearch.Location = New System.Drawing.Point(9, 17)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(125, 32)
        Me.BtnSearch.TabIndex = 0
        Me.BtnSearch.Text = "بحث"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DgvSearch
        '
        Me.DgvSearch.AllowUserToAddRows = False
        Me.DgvSearch.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSearch.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColId, Me.ColFirstName, Me.ColDate, Me.ColNotes})
        Me.DgvSearch.Location = New System.Drawing.Point(2, 119)
        Me.DgvSearch.Name = "DgvSearch"
        Me.DgvSearch.ReadOnly = True
        Me.DgvSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DgvSearch.Size = New System.Drawing.Size(762, 286)
        Me.DgvSearch.TabIndex = 2
        '
        'ColId
        '
        Me.ColId.DataPropertyName = "Id"
        Me.ColId.HeaderText = "الرمز"
        Me.ColId.Name = "ColId"
        Me.ColId.ReadOnly = True
        Me.ColId.Width = 60
        '
        'ColFirstName
        '
        Me.ColFirstName.DataPropertyName = "FirstName"
        Me.ColFirstName.HeaderText = "الاسم"
        Me.ColFirstName.Name = "ColFirstName"
        Me.ColFirstName.ReadOnly = True
        Me.ColFirstName.Width = 275
        '
        'ColDate
        '
        Me.ColDate.DataPropertyName = "Date"
        Me.ColDate.HeaderText = "التاريخ"
        Me.ColDate.Name = "ColDate"
        Me.ColDate.ReadOnly = True
        '
        'ColNotes
        '
        Me.ColNotes.DataPropertyName = "OtherInfo"
        Me.ColNotes.HeaderText = "معلومات أخرى"
        Me.ColNotes.Name = "ColNotes"
        Me.ColNotes.ReadOnly = True
        Me.ColNotes.Width = 250
        '
        'CmbKindList
        '
        Me.CmbKindList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbKindList.FormattingEnabled = True
        Me.CmbKindList.Items.AddRange(New Object() {"(الكل)", "قائمة اوفاك", "قائمة un", "قائمة الامم المتحدة"})
        Me.CmbKindList.Location = New System.Drawing.Point(489, 25)
        Me.CmbKindList.Name = "CmbKindList"
        Me.CmbKindList.Size = New System.Drawing.Size(166, 21)
        Me.CmbKindList.TabIndex = 5
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Enabled = False
        Me.TxtFirstName.Location = New System.Drawing.Point(489, 17)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(166, 20)
        Me.TxtFirstName.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(659, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "الاسم الاول :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(409, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "الاسم الثاني :"
        '
        'TxtLastName
        '
        Me.TxtLastName.Enabled = False
        Me.TxtLastName.Location = New System.Drawing.Point(239, 17)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(166, 20)
        Me.TxtLastName.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(659, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "نوع القائمة :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CmbKindList)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(750, 59)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "خيارات البحث"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.lblCountRecourd)
        Me.GroupBox2.Controls.Add(Me.TxtLastName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtFirstName)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 67)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(750, 46)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "خيارات الفلترة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(114, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "عدد السجلات"
        '
        'lblCountRecourd
        '
        Me.lblCountRecourd.ForeColor = System.Drawing.Color.Red
        Me.lblCountRecourd.Location = New System.Drawing.Point(0, 22)
        Me.lblCountRecourd.Name = "lblCountRecourd"
        Me.lblCountRecourd.Size = New System.Drawing.Size(109, 13)
        Me.lblCountRecourd.TabIndex = 12
        Me.lblCountRecourd.Text = "0"
        Me.lblCountRecourd.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblWait
        '
        Me.lblWait.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.lblWait.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWait.ForeColor = System.Drawing.Color.Red
        Me.lblWait.Location = New System.Drawing.Point(249, 227)
        Me.lblWait.Name = "lblWait"
        Me.lblWait.Size = New System.Drawing.Size(268, 63)
        Me.lblWait.TabIndex = 15
        Me.lblWait.Text = "......."
        Me.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblWait.Visible = False
        '
        'FrmBlackList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 407)
        Me.Controls.Add(Me.lblWait)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DgvSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmBlackList"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Balck List"
        CType(Me.DgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents DgvSearch As System.Windows.Forms.DataGridView
    Friend WithEvents CmbKindList As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCountRecourd As System.Windows.Forms.Label
    Friend WithEvents lblWait As System.Windows.Forms.Label
    Friend WithEvents ColId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColFirstName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColDate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColNotes As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
