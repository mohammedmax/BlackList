Public Class FrmLogin
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If msg.WParam.ToInt32() = 13 And Not Me.ActiveControl Is Me.btnLogin Then
            SendKeys.Send("{TAB}")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtName.Text <> "مدير النظام" Then
            MsgBox("يرجى التأكد من اسم المستخدم")
            txtName.Focus()
            Exit Sub
        End If
        If txtPassword.Text <> "123456789" Then
            MsgBox("يرجى التأكد من كلمة المرور")
            txtPassword.Focus()
            Exit Sub
        End If
        Try
            FrmSqlAuthintication.btnOk_Click(Nothing, Nothing)
        Catch ex As Exception
            MsgBox("يرجى التأكد من ضبط اعدادات الاتصال بمخدم قواعد البيانات")
            Exit Sub
        End Try
        ConnectString = clsConnection.ConnectionString.ConnectionString
        FrmMain.mnuOpretion.Visible = True
        Me.Dispose()
    End Sub
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()
    End Sub
    Private Sub lblServerSetting_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblServerSetting.LinkClicked
        FrmSqlAuthintication.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dispose()
    End Sub
End Class