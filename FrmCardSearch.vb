Imports System.Data.SqlClient
Public Class FrmCardSearch
    '----------------------------------------- 
    Public txtResult As New TextBox
    Public Branch_ID_Selected As Integer

    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        'If TxtFullName.Text.Length > 0 OrElse TxtSerialNumber.Text.Length > 0 Then
        Dim Parameters(8) As SqlParameter

        Parameters(0) = New SqlParameter("@FullName", TxtFullName.Text)
        Parameters(1) = New SqlParameter("@SerialNumber", TxtSerialNumber.Text)
        Parameters(2) = New SqlParameter("@Branch_ID", BranchID)
        Parameters(3) = New SqlParameter("@Identity_Kind", CmbIdentityKind.SelectedIndex)
        Parameters(4) = New SqlParameter("@Identity_No", TxtIdentityNO.Text)
        Parameters(5) = New SqlParameter("@Card_Phone", TxtPhone.Text)
        Parameters(6) = New SqlParameter("@Card_Mob", TxtMobile.Text)
        Parameters(7) = New SqlParameter("@IsBlackList", IIf(ChkBlacklist.Checked = True, 1, 0))
        Parameters(8) = New SqlParameter("@PrivetCard", IIf(ChkPrivetCard.Checked = True, 1, 0))
        GrdResults.DataSource = getData("P_GetCardIdentityData", Parameters)


        If GrdResults.Rows.Count > 0 Then
            GrdResults.Focus()
        End If
    End Sub

    Private Sub TxtFullName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtFullName.KeyPress
        If Asc(e.KeyChar) = Keys.Return Then
            If TxtFullName.TextLength > 0 AndAlso PnlAdvanced.Visible = False Then
                BtnSearch_Click(BtnSearch, Nothing)
            End If
        End If
    End Sub

    Private Sub LnkAdvanced_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LnkAdvanced.LinkClicked
        If LnkAdvanced.Tag = 0 Then
            LnkAdvanced.Text = "بحث عادي"
            LnkAdvanced.Tag = 1
            PnlAdvanced.Visible = True

            Me.Height += PnlAdvanced.Height
            GroupBox1.Height += PnlAdvanced.Height
        Else
            LnkAdvanced.Text = "بحث متقدم"
            LnkAdvanced.Tag = 0
            PnlAdvanced.Visible = False

            GroupBox1.Height -= PnlAdvanced.Height
            Me.Height -= PnlAdvanced.Height
        End If
    End Sub
    Private Sub FrmCardSearch_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dispose()
    End Sub
    Private Sub FrmCardSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Chr(Keys.Escape) Then Me.Dispose()
    End Sub

    Private Sub FrmCardSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        CmbIdentityKind.SelectedIndex = 0

        LnkAdvanced_LinkClicked(LnkAdvanced, Nothing)

        TxtFullName.Text = txtResult.Text
        If TxtFullName.TextLength <> 0 Then
            BtnSearch_Click(BtnSearch, Nothing)
            If GrdResults.RowCount = 1 Then
                Result()
                Exit Sub
            End If
        End If
        TxtFullName.Focus()
    End Sub
    Private Sub Result()
        If txtResult.TextLength > 0 Then
            If GrdResults.RowCount > 0 Then
                txtResult.Text = GrdResults.CurrentRow.Cells("ColFullName").Value
                txtResult.Tag = GrdResults.CurrentRow.Cells("ColID").Value
                Me.Dispose()
            End If
        End If
    End Sub

    Private Sub GrdResults_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GrdResults.DoubleClick
        Result()
        Try
            Dim ID1 As Integer
            ID1 = GrdResults.CurrentRow.Cells("ColID").Value
            FrmCardIdentity.Show()
            Dim a As Integer
            a = GetIndexFromID("tbl_ExchCardIdentity", "id", ID1)
            FrmCardIdentity.TxtRecordNumber.Text = a
            FrmCardIdentity.TxtRecordNumber_KeyPress(a, E_ON_KeyP)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GrdResults_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GrdResults.KeyDown
        If e.KeyCode = Keys.Enter Then
            Result()
        End If
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        FrmCardIdentity.ShowDialog()
    End Sub
End Class