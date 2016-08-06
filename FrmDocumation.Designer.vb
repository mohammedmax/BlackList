<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumation))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grdDoc = New System.Windows.Forms.DataGridView()
        Me.Menu_grid = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Add_pic = New System.Windows.Forms.ToolStripMenuItem()
        Me.Remove_pic = New System.Windows.Forms.ToolStripMenuItem()
        Me.View_pic = New System.Windows.Forms.ToolStripMenuItem()
        Me.PnlButtons = New System.Windows.Forms.Panel()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColRemittID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.ColExpireDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Menu_grid.SuspendLayout()
        Me.PnlButtons.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdDoc
        '
        Me.grdDoc.AllowUserToDeleteRows = False
        Me.grdDoc.ColumnHeadersHeight = 25
        Me.grdDoc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColID, Me.ColRemittID, Me.Col1, Me.Column4, Me.Column3, Me.ColExpireDate})
        Me.grdDoc.ContextMenuStrip = Me.Menu_grid
        Me.grdDoc.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdDoc.Location = New System.Drawing.Point(0, 0)
        Me.grdDoc.Name = "grdDoc"
        Me.grdDoc.Size = New System.Drawing.Size(756, 243)
        Me.grdDoc.TabIndex = 0
        '
        'Menu_grid
        '
        Me.Menu_grid.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Add_pic, Me.Remove_pic, Me.View_pic})
        Me.Menu_grid.Name = "Menu_grid"
        Me.Menu_grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Menu_grid.Size = New System.Drawing.Size(136, 70)
        '
        'Add_pic
        '
        Me.Add_pic.Image = CType(resources.GetObject("Add_pic.Image"), System.Drawing.Image)
        Me.Add_pic.Name = "Add_pic"
        Me.Add_pic.Size = New System.Drawing.Size(135, 22)
        Me.Add_pic.Text = "أضافة صورة"
        '
        'Remove_pic
        '
        Me.Remove_pic.Image = CType(resources.GetObject("Remove_pic.Image"), System.Drawing.Image)
        Me.Remove_pic.Name = "Remove_pic"
        Me.Remove_pic.Size = New System.Drawing.Size(135, 22)
        Me.Remove_pic.Text = "مسح صورة"
        '
        'View_pic
        '
        Me.View_pic.Image = CType(resources.GetObject("View_pic.Image"), System.Drawing.Image)
        Me.View_pic.Name = "View_pic"
        Me.View_pic.Size = New System.Drawing.Size(135, 22)
        Me.View_pic.Text = "عرض صورة"
        '
        'PnlButtons
        '
        Me.PnlButtons.Controls.Add(Me.BtnDelete)
        Me.PnlButtons.Controls.Add(Me.BtnSave)
        Me.PnlButtons.Controls.Add(Me.BtnClose)
        Me.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlButtons.Location = New System.Drawing.Point(0, 246)
        Me.PnlButtons.Name = "PnlButtons"
        Me.PnlButtons.Size = New System.Drawing.Size(756, 34)
        Me.PnlButtons.TabIndex = 14
        '
        'BtnDelete
        '
        Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
        Me.BtnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDelete.Location = New System.Drawing.Point(134, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(60, 29)
        Me.BtnDelete.TabIndex = 9
        Me.BtnDelete.Text = "&حذف"
        Me.BtnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
        Me.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSave.Location = New System.Drawing.Point(69, 3)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(60, 29)
        Me.BtnSave.TabIndex = 1
        Me.BtnSave.Text = "ح&فظ"
        Me.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClose.Location = New System.Drawing.Point(2, 3)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(60, 29)
        Me.BtnClose.TabIndex = 2
        Me.BtnClose.Text = "إ&غلاق"
        Me.BtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'ColID
        '
        Me.ColID.DataPropertyName = "id_RmtDoc"
        Me.ColID.HeaderText = "ID"
        Me.ColID.Name = "ColID"
        Me.ColID.ReadOnly = True
        Me.ColID.Visible = False
        '
        'ColRemittID
        '
        Me.ColRemittID.DataPropertyName = "id_RmtId"
        Me.ColRemittID.HeaderText = "RemittID"
        Me.ColRemittID.Name = "ColRemittID"
        Me.ColRemittID.ReadOnly = True
        Me.ColRemittID.Visible = False
        '
        'Col1
        '
        Me.Col1.DataPropertyName = "name_RmtDoc"
        Me.Col1.HeaderText = "نوع الوثيقة"
        Me.Col1.Name = "Col1"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "note_RmtDoc"
        Me.Column4.HeaderText = "ملاحظات"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 300
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "image_RmtDoc"
        Me.Column3.HeaderText = "صورة الوثيقة"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.Width = 200
        '
        'ColExpireDate
        '
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.ColExpireDate.DefaultCellStyle = DataGridViewCellStyle1
        Me.ColExpireDate.HeaderText = "تاريخ الانتهاء"
        Me.ColExpireDate.Name = "ColExpireDate"
        '
        'FrmDocumation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnClose
        Me.ClientSize = New System.Drawing.Size(756, 280)
        Me.Controls.Add(Me.PnlButtons)
        Me.Controls.Add(Me.grdDoc)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumation"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اضافة وثائق"
        CType(Me.grdDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Menu_grid.ResumeLayout(False)
        Me.PnlButtons.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdDoc As System.Windows.Forms.DataGridView
    Friend WithEvents Menu_grid As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Add_pic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Remove_pic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents View_pic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PnlButtons As System.Windows.Forms.Panel
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents ColID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ColRemittID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Col1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents ColExpireDate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
