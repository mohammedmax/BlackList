Imports System.Data.SqlClient
Public Class FrmIdentityKind
    Private ChkIdentity As Integer
    Public Shared Recordescount As Integer = 0
    Public strTable_Name As String

    Private Sub FrmIdentityKind_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load Permissions
        strTable_Name = "tbl_identity_kind"
        BtnNew_Click(BtnNew, e)
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If TxtIdentityName.Text = "" Then
            MsgBox("يرجى التأكد من ادخال البيانات", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If BtnSave.Tag = Nothing Then
            'Save
            sqlExcute("INSERT INTO tbl_identity_kind Values ('" & TxtIdentityName.Text & "' , '" & TxtIdentityNameLatin.Text & "')")
            MsgBox("تمت عملية الحفظ بنجاح")
            BtnNew_Click(BtnNew, e)
        Else
            'Update
            sqlExcute("UPDATE tbl_identity_kind SET ar_identity_name = '" & TxtIdentityName.Text & "' , " & _
                               "la_identity_name = '" & TxtIdentityNameLatin.Text & "' where id = " & BtnSave.Tag)
            MsgBox("تمت عملية التعديل بنجاح")
        End If

    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Recordescount = getsqlvalue("select count(id) from " & strTable_Name)
        LblRecordsCount.Text = Recordescount
        TxtRecordNumber.Text = "*"
        TxtIdentityName.Text = ""
        TxtIdentityNameLatin.Text = ""
        BtnSave.Tag = Nothing
        BtnSave.Text = "حفظ"
        SetScreenMode()
        TxtIdentityName.Focus()
    End Sub
    Private Sub TxtRecordNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRecordNumber.KeyPress
        'e.KeyChar = FilterNumbers(e.KeyChar)
        If e.KeyChar = ChrW(Keys.Enter) Then

            If Recordescount = 0 OrElse TxtRecordNumber.Text = "*" Then
                BtnNew_Click(BtnNew, e)
                Exit Sub
            Else
                TxtRecordNumber.Text = Val(TxtRecordNumber.Text)
            End If

            If Val(TxtRecordNumber.Text) < 1 OrElse Val(TxtRecordNumber.Text) > Recordescount Then
                MsgBox("خارج المجال")
                TxtRecordNumber.Text = Recordescount
                TxtRecordNumber_KeyPress(TxtRecordNumber, E_ON_KeyP)
                Exit Sub
            End If
            BtnSave.Tag = GetIDFromIndex(strTable_Name, TxtRecordNumber.Text)
            ToolTip.SetToolTip(TxtRecordNumber, BtnSave.Tag)

            'DBO.FillControls(PnlControls, strTable_Name, , "WHERE ID = " & BtnSave.Tag)
            ReadData(BtnSave.Tag)
            SetScreenMode()
        End If
    End Sub
    Private Sub ReadData(idmove As Integer)
        Dim Dt As DataTable = getData("select * from " & strTable_Name & " Where id = " & idmove)
        TxtIdentityName.Text = Dt(0)("ar_identity_name")
        TxtIdentityNameLatin.Text = Dt(0)("la_identity_name")
    End Sub
    Private Sub BtnFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFirst.Click
        TxtRecordNumber.Text = 1
        TxtRecordNumber_KeyPress(TxtRecordNumber, E_ON_KeyP)
    End Sub
    Private Sub BtnPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrevious.Click
        If Val(TxtRecordNumber.Text) = 0 Then
            TxtRecordNumber.Text = Recordescount
        Else
            TxtRecordNumber.Text -= 1
        End If

        TxtRecordNumber_KeyPress(TxtRecordNumber, E_ON_KeyP)
    End Sub
    Private Sub BtnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNext.Click
        If TxtRecordNumber.Text < Recordescount Then
            TxtRecordNumber.Text += 1
            TxtRecordNumber_KeyPress(TxtRecordNumber, E_ON_KeyP)
        End If
    End Sub
    Private Sub BtnLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLast.Click
        TxtRecordNumber.Text = Recordescount
        TxtRecordNumber_KeyPress(TxtRecordNumber, E_ON_KeyP)
    End Sub
    Private Sub SetScreenMode()
        Dim blnEnable As Boolean = TxtRecordNumber.Text <> "*" AndAlso TxtRecordNumber.Text <= Recordescount
        BtnCancel.Enabled = blnEnable AndAlso Recordescount > 0
        BtnDelete.Enabled = blnEnable AndAlso Recordescount > 0
        BtnNew.Enabled = blnEnable
        If blnEnable Then
            BtnSave.Text = "ت&عديل"
        Else
            BtnSave.Text = "ح&فظ"
        End If
        BtnFirst.Enabled = Recordescount <> 0 AndAlso TxtRecordNumber.Text = "*" OrElse Val(TxtRecordNumber.Text) > 1
        BtnPrevious.Enabled = Recordescount <> 0 AndAlso TxtRecordNumber.Text = "*" OrElse Val(TxtRecordNumber.Text) > 1
        BtnNext.Enabled = TxtRecordNumber.Text <> "*" AndAlso TxtRecordNumber.Text < Recordescount
        BtnLast.Enabled = TxtRecordNumber.Text <> "*" AndAlso TxtRecordNumber.Text < Recordescount
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If msg.WParam.ToInt32() = 13 Then

            Select Case Me.ActiveControl.Name

                Case BtnSave.Name
                    BtnSave_Click(Nothing, Nothing)
                    Return True
            End Select

        End If

        If msg.WParam.ToInt32() = 13 And Not Me.ActiveControl Is Me.BtnSave Then
            SendKeys.Send("{TAB}")
            Return True

        Else
            Return False
        End If

    End Function
End Class