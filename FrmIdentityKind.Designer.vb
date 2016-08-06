<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmIdentityKind
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmIdentityKind))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.TxtIdentityNameLatin = New System.Windows.Forms.TextBox()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PnlHeader = New System.Windows.Forms.Panel()
        Me.LblRecordsCount = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtRecordNumber = New System.Windows.Forms.TextBox()
        Me.BtnLast = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.BtnPrevious = New System.Windows.Forms.Button()
        Me.BtnFirst = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtIdentityName = New System.Windows.Forms.TextBox()
        Me.PnlButtons = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlControls = New System.Windows.Forms.Panel()
        Me.PnlHeader.SuspendLayout()
        Me.PnlButtons.SuspendLayout()
        Me.PnlControls.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = CType(resources.GetObject("BtnCancel.Image"), System.Drawing.Image)
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancel.Location = New System.Drawing.Point(408, 3)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(75, 29)
        Me.BtnCancel.TabIndex = 5
        Me.BtnCancel.Text = "إلغاء"
        Me.BtnCancel.UseVisualStyleBackColor = True
        Me.BtnCancel.Visible = False
        '
        'BtnPrint
        '
        Me.BtnPrint.Image = CType(resources.GetObject("BtnPrint.Image"), System.Drawing.Image)
        Me.BtnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPrint.Location = New System.Drawing.Point(327, 3)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(75, 29)
        Me.BtnPrint.TabIndex = 4
        Me.BtnPrint.Text = "&طباعة"
        Me.BtnPrint.UseVisualStyleBackColor = True
        Me.BtnPrint.Visible = False
        '
        'BtnNew
        '
        Me.BtnNew.Image = CType(resources.GetObject("BtnNew.Image"), System.Drawing.Image)
        Me.BtnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnNew.Location = New System.Drawing.Point(166, 3)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 29)
        Me.BtnNew.TabIndex = 1
        Me.BtnNew.Text = "&جديد"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(331, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 29)
        Me.BtnDelete.TabIndex = 8
        Me.BtnDelete.Text = "&حذف"
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(84, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 29)
        Me.BtnSave.TabIndex = 0
        Me.BtnSave.Tag = "id"
        Me.BtnSave.Text = "ح&فظ"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'TxtIdentityNameLatin
        '
        Me.TxtIdentityNameLatin.Location = New System.Drawing.Point(9, 44)
        Me.TxtIdentityNameLatin.Name = "TxtIdentityNameLatin"
        Me.TxtIdentityNameLatin.Size = New System.Drawing.Size(231, 20)
        Me.TxtIdentityNameLatin.TabIndex = 1
        Me.TxtIdentityNameLatin.Tag = "la_identity_name"
        Me.TxtIdentityNameLatin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(3, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 29)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "إ&غلاق"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'PnlHeader
        '
        Me.PnlHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlHeader.Controls.Add(Me.LblRecordsCount)
        Me.PnlHeader.Controls.Add(Me.Label1)
        Me.PnlHeader.Controls.Add(Me.TxtRecordNumber)
        Me.PnlHeader.Controls.Add(Me.BtnLast)
        Me.PnlHeader.Controls.Add(Me.BtnNext)
        Me.PnlHeader.Controls.Add(Me.BtnPrevious)
        Me.PnlHeader.Controls.Add(Me.BtnFirst)
        Me.PnlHeader.Location = New System.Drawing.Point(5, 3)
        Me.PnlHeader.Name = "PnlHeader"
        Me.PnlHeader.Size = New System.Drawing.Size(326, 35)
        Me.PnlHeader.TabIndex = 19
        '
        'LblRecordsCount
        '
        Me.LblRecordsCount.AutoSize = True
        Me.LblRecordsCount.Location = New System.Drawing.Point(139, 12)
        Me.LblRecordsCount.Name = "LblRecordsCount"
        Me.LblRecordsCount.Size = New System.Drawing.Size(13, 13)
        Me.LblRecordsCount.TabIndex = 6
        Me.LblRecordsCount.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "/"
        '
        'TxtRecordNumber
        '
        Me.TxtRecordNumber.Location = New System.Drawing.Point(69, 9)
        Me.TxtRecordNumber.Name = "TxtRecordNumber"
        Me.TxtRecordNumber.Size = New System.Drawing.Size(57, 20)
        Me.TxtRecordNumber.TabIndex = 13
        Me.TxtRecordNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnLast
        '
        Me.BtnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnLast.Image = CType(resources.GetObject("BtnLast.Image"), System.Drawing.Image)
        Me.BtnLast.Location = New System.Drawing.Point(191, 7)
        Me.BtnLast.Name = "BtnLast"
        Me.BtnLast.Size = New System.Drawing.Size(30, 23)
        Me.BtnLast.TabIndex = 15
        Me.BtnLast.UseVisualStyleBackColor = True
        '
        'BtnNext
        '
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnNext.Image = CType(resources.GetObject("BtnNext.Image"), System.Drawing.Image)
        Me.BtnNext.Location = New System.Drawing.Point(160, 7)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(30, 23)
        Me.BtnNext.TabIndex = 14
        Me.BtnNext.UseVisualStyleBackColor = True
        '
        'BtnPrevious
        '
        Me.BtnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPrevious.Image = CType(resources.GetObject("BtnPrevious.Image"), System.Drawing.Image)
        Me.BtnPrevious.Location = New System.Drawing.Point(34, 7)
        Me.BtnPrevious.Name = "BtnPrevious"
        Me.BtnPrevious.Size = New System.Drawing.Size(30, 23)
        Me.BtnPrevious.TabIndex = 12
        Me.BtnPrevious.UseVisualStyleBackColor = True
        '
        'BtnFirst
        '
        Me.BtnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnFirst.Image = CType(resources.GetObject("BtnFirst.Image"), System.Drawing.Image)
        Me.BtnFirst.Location = New System.Drawing.Point(3, 7)
        Me.BtnFirst.Name = "BtnFirst"
        Me.BtnFirst.Size = New System.Drawing.Size(30, 23)
        Me.BtnFirst.TabIndex = 11
        Me.BtnFirst.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "الاسم اللاتيني:"
        '
        'TxtIdentityName
        '
        Me.TxtIdentityName.Location = New System.Drawing.Point(9, 18)
        Me.TxtIdentityName.Name = "TxtIdentityName"
        Me.TxtIdentityName.Size = New System.Drawing.Size(231, 20)
        Me.TxtIdentityName.TabIndex = 0
        Me.TxtIdentityName.Tag = "ar_identity_name"
        '
        'PnlButtons
        '
        Me.PnlButtons.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlButtons.Controls.Add(Me.BtnCancel)
        Me.PnlButtons.Controls.Add(Me.BtnPrint)
        Me.PnlButtons.Controls.Add(Me.BtnNew)
        Me.PnlButtons.Controls.Add(Me.BtnDelete)
        Me.PnlButtons.Controls.Add(Me.BtnSave)
        Me.PnlButtons.Controls.Add(Me.BtnClose)
        Me.PnlButtons.Location = New System.Drawing.Point(5, 115)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(326, 34)
        Me.PnlButtons.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(241, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "نوع التعريف:"
        '
        'PnlControls
        '
        Me.PnlControls.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PnlControls.Controls.Add(Me.TxtIdentityNameLatin)
        Me.PnlControls.Controls.Add(Me.Label3)
        Me.PnlControls.Controls.Add(Me.TxtIdentityName)
        Me.PnlControls.Controls.Add(Me.Label2)
        Me.PnlControls.Location = New System.Drawing.Point(5, 39)
        Me.PnlControls.Name = "PnlControls"
        Me.PnlControls.Size = New System.Drawing.Size(326, 73)
        Me.PnlControls.TabIndex = 17
        '
        'FrmIdentityKind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(336, 151)
        Me.Controls.Add(Me.PnlHeader)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.PnlControls)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmIdentityKind"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "3014"
        Me.Text = "أنواع التعريف"
        Me.PnlHeader.ResumeLayout(False)
        Me.PnlHeader.PerformLayout()
        Me.PnlButtons.ResumeLayout(False)
        Me.PnlControls.ResumeLayout(False)
        Me.PnlControls.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents BtnCancel As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents TxtIdentityNameLatin As System.Windows.Forms.TextBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents PnlHeader As System.Windows.Forms.Panel
    Friend WithEvents LblRecordsCount As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtRecordNumber As System.Windows.Forms.TextBox
    Friend WithEvents BtnLast As System.Windows.Forms.Button
    Friend WithEvents BtnNext As System.Windows.Forms.Button
    Friend WithEvents BtnPrevious As System.Windows.Forms.Button
    Friend WithEvents BtnFirst As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtIdentityName As System.Windows.Forms.TextBox
    Friend WithEvents PnlButtons As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PnlControls As System.Windows.Forms.Panel
End Class
