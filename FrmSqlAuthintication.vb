'-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-
'-. Created by : Mohammed.Max ************** .-
'-. Date : 02/02/2015 ***************************** .-
'-. *********************************************** .-
'-. Developer  : Mohammed.Max  ************** .-
'-. Last update: 02/02/2015 *********************** .-
'-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-

Imports SQL_Express_DropListBox
Imports System.Xml
Imports System.IO
Imports System.Data.SqlClient
Public Class FrmSqlAuthintication
    Private SaverMeToXML As New DataSaver()
    Public Sub btnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Try
            clsConnection.ConnectionString.Clear()
            clsConnection.ConnectionString.DataSource = cmbserver.Text
            clsConnection.ConnectionString.InitialCatalog = "BlackList_db"
            If RadWinAuthin.Checked Then
                clsConnection.ConnectionString.IntegratedSecurity = True
            Else
                clsConnection.ConnectionString.PersistSecurityInfo = True
                clsConnection.ConnectionString.Password = txtpassword.Text
                clsConnection.ConnectionString.UserID = txtusername.Text

            End If
            ConnectString = clsConnection.ConnectionString.ConnectionString
            SaverMeToXML.SaveData(Me)
            Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles BtnTest.Click
        Try
            Dim cnn As New SqlConnection
            Dim C As New SqlConnectionStringBuilder
            C.DataSource = cmbserver.Text
            If RadWinAuthin.Checked Then
                C.IntegratedSecurity = True
            Else
                C.PersistSecurityInfo = True
                C.Password = txtpassword.Text
                C.UserID = txtusername.Text

            End If
            cnn.ConnectionString = C.ConnectionString
            cnn.Open()
            Dim sqlcmd As SqlCommand
            Dim reader As SqlDataReader
            Dim command As String = "declare @Sql_Verssion varchar(50), @index int 	" & _
                                    " set @Sql_Verssion=(SELECT convert(varchar(50),SERVERPROPERTY('ProductVersion'))) " & _
                                    " set @index=(select  charindex('.',@Sql_Verssion) - 1) " & _
                                    " select  left(@Sql_Verssion,@index) "
            sqlcmd = New SqlCommand(command, cnn)
            reader = sqlcmd.ExecuteReader()
            While reader.Read()
                If reader(0) > 8 Then

                    MsgBox("تم الاتصال بنجاح")
                Else
                    MsgBox("إصدار مخدم قواعد البيانات غير متوافق مع البرنامج " & vbCrLf & " فما فوق  SQL يجب أن يكون الإصدار 2005")
                End If

            End While
            If cnn.State <> ConnectionState.Closed Then cnn.Close()
        Catch ex As SqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub FrmSqlAuthintication_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '//End Change Langauge 
        SaverMeToXML.LoadData(Me)
    End Sub
    Private Sub optWinAuthin_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadWinAuthin.CheckedChanged, RadSqlAuthin.CheckedChanged
        txtusername.Enabled = RadSqlAuthin.Checked
        txtpassword.Enabled = RadSqlAuthin.Checked
    End Sub
End Class

Public Class DataSaver
    ''' <summary>
    ''' This class was designed when I had a user approach me and ask me to save all of the data on her windows form and automatically
    ''' fill the form back in with the same data when she opened it next time.  It handles most every type of user control (textbox,
    ''' combobox, radiobuttons, and checkboxes.
    ''' 
    ''' To use the class, simply add a line like this one to your form..
    ''' DIM MyFormManager as New DataSaver
    ''' 
    ''' In the constructor of the form, call ...
    ''' MyFormManager.LoadCriteria(Me) 
    ''' to bring in all of the XML it saved for that form.
    ''' 
    ''' In the form's closing event, call
    ''' MyFormManager.SaveCriteria(Me)
    ''' This will save all of the info to a file called ...
    ''' \Documents and Settings\(USERNAME)\Local Settings\Application Data\(APPNAME)\(PROJECT)\(Build #)
    ''' 
    ''' You can also enable/disable specific types of controls to save data for by setting any of the properties in this class
    ''' to false.
    ''' </summary>
    ''' <remarks>Copyright 2006 Jim Evans
    ''' This code may be reproduced, modified, and redistributed without any financial liabilities to Jim Evans.  All he asks is that
    ''' you continue to leave the initial copyright intact.  Thanks
    '''</remarks>
#Region " Modular Variables"

    Private oControl As System.Windows.Forms.Control
    Private oParentForm As System.Windows.Forms.Form
    Private oControls As System.Windows.Forms.Form.ControlCollection

    'Property variables
    Private mbSaveTextBox As System.Boolean = True
    Private mbSaveComboBox As System.Boolean = True
    Private mbSaveRadioButton As System.Boolean = True
    Private mbSaveCheckBox As System.Boolean = True

    Private msFileName As System.String
    Private oTextWriter As XmlTextWriter

#End Region

#Region " Public Properties"

    Public Property SaveTextBox() As System.Boolean
        Get
            Return mbSaveTextBox
        End Get
        Set(ByVal value As System.Boolean)
            mbSaveTextBox = value
        End Set
    End Property

    Public Property SaveComboBox() As System.Boolean
        Get
            Return mbSaveComboBox
        End Get
        Set(ByVal value As System.Boolean)
            mbSaveComboBox = value
        End Set
    End Property

    Public Property SaveRadioButton() As System.Boolean
        Get
            Return mbSaveRadioButton
        End Get
        Set(ByVal value As System.Boolean)
            mbSaveRadioButton = value
        End Set
    End Property

    Public Property SaveCheckBox() As System.Boolean
        Get
            Return mbSaveCheckBox
        End Get
        Set(ByVal value As System.Boolean)
            mbSaveCheckBox = value
        End Set
    End Property

#End Region

#Region " Public Methods"

    Public Sub SaveData(ByVal oParentForm As System.Windows.Forms.Form)
        Try

            msFileName = CType(MainApplicationPath & "\SqlSettings.xml", System.String)

            If File.Exists(msFileName) Then

                Try
                    File.Delete(msFileName)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
            End If

            oTextWriter = New XmlTextWriter(msFileName, System.Text.Encoding.UTF8)

            With oTextWriter
                .WriteStartDocument(True)
                .WriteStartElement("Controls")
            End With

            For Each oControl As Control In oParentForm.Controls

                If TypeOf oControl Is Panel Or TypeOf oControl Is GroupBox Then
                    Dim oContainer As Control
                    Dim oChild As Control
                    oContainer = oControl

                    For Each oChild In oContainer.Controls
                        If TypeOf oChild Is GroupBox Then

                            Dim oGroupBox As Control
                            oGroupBox = oChild
                            Dim ochild2 As Control

                            For Each ochild2 In oGroupBox.Controls
                                CheckSaveControl(ochild2)
                            Next
                        Else
                            CheckSaveControl(oChild)
                        End If

                    Next

                Else
                    CheckSaveControl(oControl)
                End If
            Next
            Dim cnn As SqlConnection
            cnn = New SqlConnection(clsConnection.ConnectionString.ToString)
            cnn.Open()
            Dim sqlcmd As SqlCommand
            Dim reader As SqlDataReader
            Dim command As String = "declare @Sql_Verssion varchar(50), @index int 	" & _
                                    " set @Sql_Verssion=(SELECT convert(varchar(50),SERVERPROPERTY('ProductVersion'))) " & _
                                    " set @index=(select  charindex('.',@Sql_Verssion) - 1) " & _
                                    " select  left(@Sql_Verssion,@index) "
            sqlcmd = New SqlCommand(command, cnn)
            reader = sqlcmd.ExecuteReader()
            While reader.Read()
                oTextWriter.WriteElementString("Version", reader(0).ToString)
            End While
            With oTextWriter
                .WriteEndElement()
                .WriteEndDocument()
                .Flush()
                .Close()
            End With

            'ShowMSG("MSG_8")
        Catch ex As Exception
            MsgBox("يرجى التأكد من ضبط اعدادات الاتصال بمخدم قواعد البيانات")
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LoadData(ByVal oParentForm As System.Windows.Forms.Form)

        Dim moControl As Control

        If File.Exists(MainApplicationPath & "\SqlSettings.xml") Then
            msFileName = MainApplicationPath & "\SqlSettings.xml"
        Else
            Exit Sub
        End If
        Try

            Dim oXMLDoc As New XmlDocument

            oXMLDoc.Load(msFileName)

            Dim oxmlnode As XmlNode

            For Each oxmlnode In oXMLDoc.DocumentElement.ChildNodes

                If oxmlnode.InnerText <> "" Then

                    For Each moControl In oParentForm.Controls

                        If TypeOf moControl Is Panel Or TypeOf moControl Is GroupBox Then
                            Dim oContainer As Control
                            Dim ochild As Control

                            oContainer = moControl

                            For Each ochild In oContainer.Controls

                                If TypeOf ochild Is GroupBox Then

                                    Dim oGroupBox As Control
                                    oGroupBox = ochild
                                    Dim ochild2 As Control

                                    For Each ochild2 In oGroupBox.Controls
                                        CheckLoadControl(ochild2, oxmlnode.Name, oxmlnode.InnerText)
                                    Next
                                Else
                                    CheckLoadControl(ochild, oxmlnode.Name, oxmlnode.InnerText)
                                End If
                            Next
                        Else
                            CheckLoadControl(moControl, oxmlnode.Name, oxmlnode.InnerText)
                        End If
                    Next
                End If
            Next
        Catch ex As Exception
            Exit Try
        End Try

    End Sub

#End Region

#Region " Private Methods"

    Private Sub CheckSaveControl(ByVal oChild As Control)

        Select Case True

            Case TypeOf oChild Is ComboBox Or TypeOf oChild Is SQLExpressCombo
                If SaveComboBox Then
                    oTextWriter.WriteElementString(oChild.Name, IIf(TypeOf oChild Is SQLExpressCombo, CType(oChild, SQLExpressCombo).Text, oChild.Text).ToString)
                End If

            Case TypeOf oChild Is TextBox
                If SaveTextBox Then
                    oTextWriter.WriteElementString(oChild.Name, oChild.Text.ToString)
                End If

            Case TypeOf oChild Is RadioButton
                If SaveRadioButton Then
                    If CType(oChild, RadioButton).Checked Then
                        oTextWriter.WriteElementString(oChild.Name, "True")
                    Else
                        oTextWriter.WriteElementString(oChild.Name, "False")
                    End If
                End If

            Case TypeOf oChild Is CheckBox
                If SaveComboBox Then
                    If CType(oChild, CheckBox).Checked Then
                        oTextWriter.WriteElementString(oChild.Name, "True")
                    End If
                End If
        End Select

    End Sub


    Private Sub CheckLoadControl(ByVal oChild As Control, ByVal ControlName As System.String, ByVal controlValue As System.String)

        Select Case True

            Case TypeOf oChild Is ComboBox Or TypeOf oChild Is SQLExpressCombo
                If oChild.Name = ControlName Then
                    CType(oChild, SQLExpressCombo).Text = controlValue
                End If

            Case TypeOf oChild Is TextBox
                If oChild.Name = ControlName Then
                    oChild.Text = controlValue
                End If

            Case TypeOf oChild Is RadioButton
                If oChild.Name = ControlName Then
                    If controlValue = "True" Then
                        CType(oChild, RadioButton).Checked = True
                    End If
                End If

            Case TypeOf oChild Is CheckBox
                If oChild.Name = ControlName Then
                    If controlValue = "True" Then
                        CType(oChild, CheckBox).Checked = True
                    End If
                End If
        End Select
    End Sub



#End Region

End Class