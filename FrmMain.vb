Imports System.Management
Imports System.Net.NetworkInformation

Public Class FrmMain

    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Close()
    End Sub

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Application.DoEvents()
        For i As Integer = 0 To Me.Controls.Count - 1
            Application.DoEvents()
            If TypeOf (Me.Controls(i)) Is MdiClient Then
                CType(Me.Controls(i), MdiClient).BackColor = Color.White
            End If
        Next

        Me.tslLabDateVal.Text = Format(Date.Now, "yyyy/MM/dd")
        Timer1.Start()
        FrmLogin.MdiParent = Me
        FrmLogin.Show()
        serverMacAddress = ""
        ServerCpuId = ""
        ServerPartionCId = ""
    End Sub

    Private Sub mnuIdentityKind_Click(sender As Object, e As EventArgs) Handles mnuIdentityKind.Click
        FrmIdentityKind.MdiParent = Me
        FrmIdentityKind.Show()
    End Sub

    Private Sub mnuCardIdentity_Click(sender As Object, e As EventArgs) Handles mnuCardIdentity.Click
        FrmCardIdentity.MdiParent = Me
        FrmCardIdentity.Show()
    End Sub

    Private Sub mnuCardSearch_Click(sender As Object, e As EventArgs) Handles mnuCardSearch.Click
        FrmCardSearch.MdiParent = Me
        FrmCardSearch.Show()
    End Sub

    Private Sub mnuBlackList_Click(sender As Object, e As EventArgs) Handles mnuBlackList.Click
        FrmBlackList.MdiParent = Me
        FrmBlackList.Show()
    End Sub

    Private Sub mnuSqlAuthintication_Click(sender As Object, e As EventArgs) Handles mnuSqlAuthintication.Click
        FrmSqlAuthintication.MdiParent = Me
        FrmSqlAuthintication.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.tslLabTimeVal.Text = Format(Date.Now, "H:mm:ss")
    End Sub
End Class