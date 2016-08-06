Imports System.Data.SqlClient
Imports System.IO
Public Class FrmDocumation
    Public Card_Id As Integer
    Private Sub FrmRemittDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReadData()
    End Sub
    Private Sub ReadData()
        grdDoc.Rows.Clear()
        Dim Dt As DataTable = getData("SELECT [id],[id_Card],[name_Doc],[note_Doc],[image_Doc],[Date_Doc] From [tbl_Documents] Where [id_Card] = " & Card_Id)

        For i = 0 To Dt.Rows.Count - 1
            If Dt.Rows(i)(4) IsNot DBNull.Value Then
                Dim arr As Byte() = Dt.Rows(i)(4)
                Dim ms As New MemoryStream(arr)
                ms.Write(arr, 0, arr.Length - 1)
                grdDoc.Rows.Add(Dt.Rows(i)(0), Dt.Rows(i)(1), Dt.Rows(i)(2), Dt.Rows(i)(3), New Bitmap(ms), Dt.Rows(i)(5))
            Else
                grdDoc.Rows.Add(Dt.Rows(i)(0), Dt.Rows(i)(1), Dt.Rows(i)(2), Dt.Rows(i)(3), Nothing, Dt.Rows(i)(5))
            End If
        Next
    End Sub
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If msg.WParam.ToInt32() = 13 Then
            SendKeys.Send("{TAB}")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub Add_pic_Click(sender As Object, e As EventArgs) Handles Add_pic.Click

        Using ofd As New OpenFileDialog()
            ofd.Filter = "Image File |*.PNG;*.jpg;*.bmp;*.gif"
            If ofd.ShowDialog() = Windows.Forms.DialogResult.OK And ofd.FileName <> "" Then
                grdDoc(4, grdDoc.CurrentRow.Index).Value = Image.FromFile(ofd.FileName)
            End If
        End Using

    End Sub
    Private Sub Remove_pic_Click(sender As Object, e As EventArgs) Handles Remove_pic.Click
        grdDoc(4, grdDoc.CurrentRow.Index).Value = Nothing
    End Sub
    Private Sub View_pic_Click(sender As Object, e As EventArgs) Handles View_pic.Click

        Dim img As Image = grdDoc(4, grdDoc.CurrentRow.Index).Value

        If img IsNot Nothing Then

            FrmViewImage.PictureBox1.Image = img
            FrmViewImage.ShowDialog()
            '    Dim rg_print As New cls_print_reogrid()
            '    rg_print.print_image(img)

        End If

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If BtnSave.Tag = 0 Or BtnSave.Tag = Nothing Then
            If grdDoc.Rows.Count > 0 Then
                For i As Integer = 0 To grdDoc.Rows.Count - 1
                    If (grdDoc(0, i).Value Is Nothing) Then

                        Dim par As New SqlParameter("@Image", SqlDbType.Image)
                        par.IsNullable = True
                        par.Direction = ParameterDirection.Input
                        Dim img As Image = grdDoc(4, i).Value

                        If img Is Nothing Then
                            par.Value = DBNull.Value
                        Else
                            par.Value = ImagesCompression(img)
                        End If

                        If i <> grdDoc.Rows.Count - 1 Then
                            sqlExcute("INSERT INTO [tbl_Documents] ([id_Card],[name_Doc],[note_Doc],[Date_Doc],[image_Doc]) Values (" & Card_Id & ",'" & grdDoc(2, i).Value & "','" & grdDoc(3, i).Value & "','" & grdDoc(5, i).Value & "',@Image) ", par)
                        End If
                    End If
                Next
            End If
        End If
        grdDoc.Rows.Clear()
        ReadData()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If MessageBox.Show("هل تريد حذف بيانات السطر الحالي ؟", "تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If Not grdDoc(0, grdDoc.CurrentRow.Index).Value = Nothing Then
                sqlExcute("delete from tbl_Documents where id_Card = " + grdDoc(0, grdDoc.CurrentRow.Index).Value.ToString())
                grdDoc.Rows.Clear()
                ReadData()
            End If
        End If
    End Sub

    Private Sub grdDoc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles grdDoc.CellContentClick

    End Sub

    Private Sub grdDoc_DefaultValuesNeeded(sender As Object, e As DataGridViewRowEventArgs) Handles grdDoc.DefaultValuesNeeded
        e.Row.Cells("ColExpireDate").Value = Date.Now.Date
    End Sub
End Class