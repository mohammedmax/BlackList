'-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-
'-. Created by : Mohammed.Max ************** .-
'-. Date : 02/02/2015 ***************************** .-
'-. *********************************************** .-
'-. Developer  : Mohammed.Max  ************** .-
'-. Last update: 02/02/2015 *********************** .-
'-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-.-

Imports System.Data.SqlClient ' sqlserver
Imports System.Data.OleDb ' Oracel
Imports System.Data
Imports System.Xml
Imports System.IO
Public Class clsConnection

#Region "Fields"
    'Sql_Server
    Private Shared _SqlCSB As New SqlClient.SqlConnectionStringBuilder()
    'Oracel_DB
    Private Shared _OleCSB As New OleDb.OleDbConnectionStringBuilder()

#End Region

#Region "Properties"
    Public Shared Property ConnectionString() As SqlConnectionStringBuilder
        Get
            Return _SqlCSB
        End Get
        Set(ByVal value As SqlConnectionStringBuilder)
            _SqlCSB = value
        End Set
    End Property

#End Region

#Region "Functions"
    Public Sub New(ByVal _MainApplicationPath As String, ByVal _NameDataBase As String)
        NamePublicDataBase = _NameDataBase
        MainApplicationPath = _MainApplicationPath
    End Sub
    Public Sub New()
        _SqlCSB = New SqlConnectionStringBuilder(GetConnectionString)
    End Sub
    Public Sub New(ByVal constr As String)
        _SqlCSB = New SqlConnectionStringBuilder(constr)
    End Sub

    Private Function GetConnectionString() As String
        Dim XmlDoc = New XmlDocument()
        Dim XmlNod As XmlNode
        If File.Exists(MainApplicationPath & "\SqlSettings.xml") Then
            XmlDoc.Load(MainApplicationPath & "\SqlSettings.xml")
            XmlNod = XmlDoc.Item("Controls")
            _SqlCSB.DataSource = XmlNod.Item("cmbserver").InnerText
            _SqlCSB.AttachDBFilename = "BestRate_db9"
            If CType(XmlNod.Item("RadWinAuthin").InnerText, Boolean) Then
                _SqlCSB.IntegratedSecurity = True
                _SqlCSB.PersistSecurityInfo = False
            Else
                _SqlCSB.IntegratedSecurity = False
                _SqlCSB.PersistSecurityInfo = True
                _SqlCSB.UserID = XmlNod.Item("txtusername").InnerText
                _SqlCSB.Password = XmlNod.Item("txtpassword").InnerText
            End If
        End If
        Return _SqlCSB.ToString()

    End Function

#End Region

End Class
