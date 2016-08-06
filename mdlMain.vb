Imports System.Data.SqlClient
Imports System.Text
Imports System.IO
Imports System.Drawing.Imaging

Module mdlMain
    Friend MainApplicationPath As String = My.Application.Info.DirectoryPath
    Friend NamePublicDataBase As String = "BestRate_db"
    Public serverMacAddress As String
    Public ServerCpuId As String
    Public ServerPartionCId As String
    Public ConnectString As String = "" '"Data Source=walsh;Initial Catalog=BestRate_db9;Integrated Security=SSPI;User ID=sa;Password=123456;"
    Public E_ON_KeyP As New System.Windows.Forms.KeyPressEventArgs(ChrW(Keys.Enter))
    Public E_ON_KeyD As New System.Windows.Forms.KeyEventArgs(Keys.Enter)
    Public BranchID As Integer = 1
    Public User_Id As Integer = 1
    Public Sub sqlExcute(sqlstring As String)
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            conn.Open()
            Dim comd As SqlCommand = New SqlCommand(sqlstring, conn)
            comd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تمت العملية بنجاح")
        Catch ex As Exception
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
    End Sub
    Public Sub sqlExcute(sqlstring As String, par As SqlParameter)
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            conn.Open()
            Dim comd As SqlCommand = New SqlCommand(sqlstring, conn)
            comd.CommandType = CommandType.Text
            comd.Parameters.Clear()
            'comd.CommandText = sqlstring
            comd.Parameters.Add(par)
            comd.ExecuteNonQuery()
            conn.Close()
            MessageBox.Show("تمت العملية بنجاح")
        Catch ex As Exception
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
    End Sub
    Public Function Execute_Procedure(ByVal PRC_Name As String, ByRef Parameters() As SqlParameter) As Boolean
        Dim success As Boolean

        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            ReDim Preserve Parameters(UBound(Parameters) + 1)
            Parameters(Parameters.Count - 1) = New SqlParameter("@success", False)
            Parameters(Parameters.Count - 1).Direction = ParameterDirection.Output

            Dim comd As SqlCommand = New SqlCommand(PRC_Name, conn)
            comd.CommandType = CommandType.StoredProcedure
            comd.Parameters.AddRange(Parameters)
            conn.Open()
            comd.ExecuteNonQuery()
            success = Parameters(Parameters.Count - 1).Value
            conn.Close()
            MessageBox.Show("تمت العملية بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
            success = False
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
        Return success
    End Function
    Function GetIDFromIndex(ByVal TableName As String, ByVal RowIndex As Integer, Optional ByVal strwhere As String = "") As Integer
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            Dim sqlstring As StringBuilder = New StringBuilder("With TTT(F_Serial,ID) AS (SELECT ROW_NUMBER()OVER(ORDER BY ID)AS F_Serial, ID FROM " & TableName & " " & strwhere & " ) " & _
         "SELECT ID FROM TTT Where F_Serial=" & RowIndex & "")
            Dim comd As SqlCommand = New SqlCommand(sqlstring.ToString(), conn)
            conn.Open()
            Dim dReader As SqlDataReader = comd.ExecuteReader()
            While dReader.Read
                GetIDFromIndex = dReader(0)
            End While
            dReader.Close()
            conn.Close()
        Catch ex As Exception
            GetIDFromIndex = 0
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
        Return GetIDFromIndex
    End Function

    Function GetIndexFromID(ByVal TableName As String, ByVal ColmName As String, ByVal ColmValue As String, Optional ByVal strwhere As String = "") As Integer
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            Dim sqlstring As StringBuilder = New StringBuilder("With TTT(F_Serial," & ColmName & ") AS (SELECT ROW_NUMBER()OVER(ORDER BY " & ColmName & ")AS F_Serial, " & ColmName & " FROM " & TableName & " " & strwhere & " ) " & _
         "SELECT F_Serial FROM TTT Where " & ColmName & "=" & ColmValue & "")
            conn.Open()
            Dim comd As SqlCommand = New SqlCommand(sqlstring.ToString(), conn)
            Dim dReader As SqlDataReader = comd.ExecuteReader()
            While dReader.Read
                GetIndexFromID = dReader(0)
            End While
            dReader.Close()
            conn.Close()
        Catch ex As Exception
            GetIndexFromID = 0
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
        Return GetIndexFromID
    End Function
    Function getData(sqlstring As String) As DataTable
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            conn.Open()
            Dim comd As SqlCommand = New SqlCommand(sqlstring, conn)
            Dim DataAdabter As SqlDataAdapter = New SqlDataAdapter(comd)
            Dim DataSet As DataSet = New DataSet()
            DataAdabter.Fill(DataSet)
            getData = DataSet.Tables(0)
            conn.Close()
        Catch ex As Exception
            getData = Nothing
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
        Return getData
    End Function

    Function getData(Query As String, ByVal parameters As SqlParameter()) As DataTable
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            For Each p As SqlParameter In parameters
                If p.SqlDbType = SqlDbType.NVarChar OrElse p.SqlDbType = SqlDbType.NChar OrElse p.SqlDbType = SqlDbType.DateTime Then
                    Query = Query & " '" & p.Value & "',"
                Else
                    Query = Query & " " & p.Value & ","
                End If

            Next
            Query = Query.TrimEnd(",")
            conn.Open()
            Dim comd As SqlCommand = New SqlCommand(Query, conn)
            Dim DataAdabter As SqlDataAdapter = New SqlDataAdapter(comd)
            Dim DataSet As DataSet = New DataSet()
            DataAdabter.Fill(DataSet)
            getData = DataSet.Tables(0)
            conn.Close()
        Catch ex As Exception
            getData = Nothing
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
        Return getData
    End Function
    Function getsqlvalue(sqlstring As String) As Object
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        getsqlvalue = 0
        Try
            conn.Open()
            Dim comd As SqlCommand = New SqlCommand(sqlstring, conn)
            Dim Dreader As SqlDataReader
            Dreader = comd.ExecuteReader()
            While Dreader.Read
                getsqlvalue = Dreader(0)
            End While
            Dreader.Close()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try

        Return getsqlvalue
    End Function
    Public Sub FillCombo(ByRef cmb As ComboBox, ByVal Table As String, ByVal PrimaryKey As String, ByVal Display_Field As String, Optional ByVal WhereCriteria As String = "", Optional ByVal Order_By As String = "", Optional ByVal InitialValue As Boolean = False)

        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        Try
            Dim sqlstring As StringBuilder = New StringBuilder()
            If InitialValue Then
                If Order_By IsNot String.Empty AndAlso Trim(Order_By).ToLower <> Trim(PrimaryKey).ToLower Then
                    sqlstring.Append("SELECT  0  as  " & PrimaryKey & ",'" & IIf(TypeOf (cmb.Items(0)) Is DataRowView, cmb.Items(0)(1), cmb.Items(0)) & "'  AS " & Display_Field & ", '' AS " & Order_By & " UNION  ")
                Else
                    sqlstring.Append("SELECT  0  as  " & PrimaryKey & ",'" & IIf(TypeOf (cmb.Items(0)) Is DataRowView, cmb.Items(0)(1), cmb.Items(0)) & "'  AS " & Display_Field & " UNION  ")
                End If
            End If
            sqlstring.Append("SELECT " & PrimaryKey & " , " & Display_Field)
            If Order_By IsNot String.Empty AndAlso Trim(Order_By).ToLower <> Trim(PrimaryKey).ToLower Then
                sqlstring.Append(" , " & Order_By)
            End If
            sqlstring.Append(" FROM " & Table & " " & WhereCriteria)
            If Order_By IsNot String.Empty Then
                sqlstring.Append(" ORDER BY " & Order_By)
            End If
            Dim comd As SqlCommand = New SqlCommand(sqlstring.ToString(), conn)
            conn.Open()
            Dim DataAdabter As SqlDataAdapter = New SqlDataAdapter(comd)
            Dim DataSet As DataSet = New DataSet()
            DataAdabter.Fill(DataSet)
            cmb.DataSource = DataSet.Tables(0)
            cmb.DisplayMember = Display_Field
            cmb.ValueMember = PrimaryKey
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("حدث خطا في اتمام العملية")
            conn.Close()
        End Try
    End Sub
    Private Sub FillControlList(ByVal ctrl As Control, ByRef lstCtrls As List(Of Control))
        For Each c As Control In ctrl.Controls
            If TypeOf (c) Is Panel OrElse TypeOf (c) Is GroupBox OrElse TypeOf (c) Is SplitContainer OrElse TypeOf (c) Is TabControl _
                     OrElse TypeOf (c) Is FlowLayoutPanel OrElse TypeOf (c) Is TableLayoutPanel Then
                FillControlList(c, lstCtrls)
            Else
                If TypeOf (c) Is TextBox OrElse TypeOf (c) Is RadioButton OrElse TypeOf (c) Is CheckBox OrElse _
                  TypeOf (c) Is DateTimePicker OrElse TypeOf (c) Is ComboBox OrElse TypeOf (c) Is PictureBox OrElse TypeOf (c) Is Label Then ' OrElse TypeOf (c) Is RadRadioButton OrElse _TypeOf (c) Is RadCheckBox OrElse TypeOf (c) Is RadDateTimePicker
                    If lstCtrls.Count = 0 Then
                        lstCtrls.Add(c)
                    Else
                        Dim i As Integer = 0
                        Dim inserted As Boolean = False
                        While i < lstCtrls.Count AndAlso Not inserted
                            If lstCtrls(i).TabIndex > c.TabIndex Then
                                lstCtrls.Insert(i, c)
                                inserted = True
                            End If
                            i += 1
                        End While
                        If Not inserted Then
                            lstCtrls.Add(c)
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub FillControls(ByRef ctrl As Control, ByVal Table As String, Optional ByVal Joinstatement As String = "", Optional ByVal WhereCriteria As String = "")
        Dim lstControls As List(Of Control) = New List(Of Control)
        Dim conn As SqlConnection = New SqlConnection(ConnectString)
        FillControlList(ctrl, lstControls)
        Dim sqlQuery As StringBuilder = New StringBuilder("SELECT  ")
        For Each c In lstControls
            If c.Tag IsNot Nothing Then
                sqlQuery.Append(c.Tag.ToString() & ",")
            End If
        Next
        sqlQuery = New StringBuilder(sqlQuery.ToString().TrimEnd(","))
        sqlQuery.Append(" FROM " & Table & "  " & Joinstatement & "  " & WhereCriteria)
        conn.Open()
        Dim comd As SqlCommand = New SqlCommand(sqlQuery.ToString(), conn)
        Dim DReader As SqlDataReader
        DReader = comd.ExecuteReader()
        While DReader.Read()
            For Each c In lstControls
                If c.Tag IsNot Nothing Then
                    If TypeOf (c) Is TextBox Then
                        CType(c, TextBox).Text = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, "", DReader(c.Tag.ToString()).ToString())
                    ElseIf TypeOf (c) Is Label Then
                        CType(c, Label).Text = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, "", DReader.Item(c.Tag.ToString()).ToString())
                    ElseIf TypeOf (c) Is DateTimePicker Then
                        CType(c, DateTimePicker).Value = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, Date.Now, DReader(c.Tag.ToString()).ToString())
                        'ElseIf TypeOf (c) Is RadDateTimePicker Then
                        '    CType(c, RadDateTimePicker).Value = DReader.Item(c.Tag.ToString()).ToString()
                    ElseIf TypeOf (c) Is CheckBox Then
                        CType(c, CheckBox).Checked = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, False, DReader(c.Tag.ToString()).ToString())
                        'ElseIf TypeOf (c) Is RadCheckBox Then
                        '    CType(c, RadCheckBox).Checked = DReader.Item(c.Tag.ToString()).ToString()
                    ElseIf TypeOf (c) Is RadioButton Then
                        CType(c, RadioButton).Checked = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, False, DReader(c.Tag.ToString()).ToString())
                    ElseIf TypeOf (c) Is ComboBox Then
                        If CType(c, ComboBox).ValueMember = "0" Then   'this for set combo index
                            CType(c, ComboBox).SelectedIndex = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, 0, DReader(c.Tag.ToString()).ToString())
                        ElseIf CType(c, ComboBox).ValueMember = "1" Then   'this for set combo text
                            CType(c, ComboBox).Text = IIf(DReader(c.Tag.ToString()) Is DBNull.Value, "", DReader(c.Tag.ToString()).ToString())
                        Else
                            CType(c, ComboBox).SelectedValue = DReader(c.Tag.ToString()).ToString()
                        End If

                    ElseIf TypeOf (c) Is PictureBox Then
                        Dim strm As New MemoryStream()
                        Dim img() As Byte = Nothing
                        If DReader.Item(c.Tag.ToString()) IsNot DBNull.Value Then
                            img = DReader.Item(c.Tag.ToString())
                            If img.Length > 0 Then
                                strm.Write(img, 0, img.Length - 1)
                                CType(c, PictureBox).Image = New Bitmap(strm)
                                CType(c, PictureBox).SizeMode = PictureBoxSizeMode.StretchImage
                            End If
                        Else
                            CType(c, PictureBox).Image = Nothing
                        End If
                    End If
                End If
            Next
        End While
        conn.Close()
    End Sub

    Public Sub ClearControls(ByVal frm As Control)
        'Clear all control's content
        For Each ctrl In frm.Controls
            If TypeOf (ctrl) Is Panel OrElse TypeOf (ctrl) Is GroupBox OrElse TypeOf (ctrl) Is SplitContainer OrElse TypeOf (ctrl) Is TabControl _
                      OrElse TypeOf (ctrl) Is FlowLayoutPanel OrElse TypeOf (ctrl) Is TableLayoutPanel Then
                ClearControls(ctrl)
            Else
                If TypeOf (ctrl) Is TextBox Then
                    CType(ctrl, TextBox).Clear()
                ElseIf TypeOf (ctrl) Is ComboBox AndAlso CType(ctrl, Windows.Forms.ComboBox).Items.Count > 0 Then
                    CType(ctrl, Windows.Forms.ComboBox).SelectedIndex = 0
                ElseIf TypeOf (ctrl) Is CheckBox Then
                    CType(ctrl, CheckBox).Checked = False
                ElseIf TypeOf (ctrl) Is RadioButton Then
                    CType(ctrl, RadioButton).Checked = False
                ElseIf TypeOf (ctrl) Is PictureBox Then
                    CType(ctrl, PictureBox).Image = Nothing
                End If
            End If
        Next
    End Sub
    Private Function GetEncoder(ByVal format As ImageFormat) As ImageCodecInfo

        Dim codecs As ImageCodecInfo() = ImageCodecInfo.GetImageDecoders()

        Dim codec As ImageCodecInfo
        For Each codec In codecs
            If codec.FormatID = format.Guid Then Return codec
        Next codec
        Return Nothing

    End Function
    Public Function ImagesCompression(Img As Object) As Byte()

        Dim arr As Byte() = {}
        Try

            Dim bit As Bitmap = CType(Img, Bitmap)
            bit.SetResolution(70, 70)

            Dim jgpEncoder As ImageCodecInfo = GetEncoder(ImageFormat.Jpeg)

            Dim myEncoderParameters As New EncoderParameters(2)
            myEncoderParameters.Param(0) = New EncoderParameter(System.Drawing.Imaging.Encoder.Compression, CLng(EncoderValue.CompressionCCITT3))
            myEncoderParameters.Param(1) = New EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 15)

            Dim ms As New MemoryStream()
            bit.Save(ms, jgpEncoder, myEncoderParameters)
            arr = ms.GetBuffer()

        Catch ex As Exception

        End Try

        Return arr

    End Function
End Module
