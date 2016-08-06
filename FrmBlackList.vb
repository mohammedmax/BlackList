Imports System.Text
Imports System.IO

Public Class FrmBlackList
    Private dt As DataTable
    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        Clear()
        lblWait.Visible = True
        lblWait.Text = "يتم الان جلب بيانات القائمة , يرجى الانتظار"
        GroupBox1.Enabled = False
        GroupBox2.Enabled = False

        If CmbKindList.SelectedIndex = 0 Then

            Dim DSetMain As New DataSet
            Dim DSetFirst As New DataSet
            Dim DSetSecound As New DataSet
            Dim DSetThrid As New DataSet
            DSetFirst.ReadXml("https://www.treasury.gov/ofac/downloads/sdn.xml")
            DSetSecound.ReadXml("https://www.un.org/sc/suborg/sites/www.un.org.sc.suborg/files/consolidated.xml")
            DSetThrid.ReadXml("http://ec.europa.eu/external_relations/cfsp/sanctions/list/version4/global/global.xml")
            DSetMain.Merge(DSetFirst.Tables("sdnEntry"))
            DSetMain.Merge(DSetSecound.Tables("INDIVIDUAL"))
            DSetMain.Merge(DSetThrid.Tables("Name"))
            Dim dt As New DataTable

            dt.Columns.Add("ID", GetType(Integer))
            dt.Columns.Add("FirstName", GetType(String))
            dt.Columns.Add("Date", GetType(String))
            dt.Columns.Add("OtherInfo", GetType(String))

            For i As Integer = 0 To DSetMain.Tables(0).Rows.Count - 1
                dt.Rows.Add(DSetMain.Tables(0).Rows(i)("uid"), DSetMain.Tables(0).Rows(i)("FirstName") + " " + DSetMain.Tables(0).Rows(i)("LastName"), "", DSetMain.Tables(0).Rows(i)("title"))
            Next

            For i As Integer = 0 To DSetMain.Tables(1).Rows.Count - 1
                dt.Rows.Add(DSetMain.Tables(1).Rows(i)("DATAID"), DSetMain.Tables(1).Rows(i)("First_Name") + " " + DSetMain.Tables(1).Rows(i)("SECOND_Name") + " " + DSetMain.Tables(1).Rows(i)("THIRD_Name"), DSetMain.Tables(1).Rows(i)("Listed_ON"), DSetMain.Tables(1).Rows(i)("Comments1"))
            Next

            For i As Integer = 0 To DSetMain.Tables(2).Rows.Count - 1
                dt.Rows.Add(DSetMain.Tables(2).Rows(i)("Id"), DSetMain.Tables(2).Rows(i)("WHOLENAME"), DSetMain.Tables(2).Rows(i)("reg_date"), DSetMain.Tables(2).Rows(i)("Function"))
            Next

            DgvSearch.DataSource = dt

        ElseIf CmbKindList.SelectedIndex = 1 Then
            Dim DSetCurrencies As New DataSet
            'DSetCurrencies.ReadXml("http://search.ofac-api.com/api/v1?name=" & TxtName.Text & "&data=xml&apiKey=be206b33-0453-4aad-a405-fed6d427df1b")
            DSetCurrencies.ReadXml("https://www.treasury.gov/ofac/downloads/sdn.xml")
            DgvSearch.DataSource = DSetCurrencies.Tables("sdnEntry")
        ElseIf CmbKindList.SelectedIndex = 2 Then
            Dim DSetCurrencies As New DataSet
            DSetCurrencies.ReadXml("https://www.un.org/sc/suborg/sites/www.un.org.sc.suborg/files/consolidated.xml")
            DgvSearch.DataSource = DSetCurrencies.Tables("INDIVIDUAL")
        ElseIf CmbKindList.SelectedIndex = 3 Then
            Dim DSetCurrencies As New DataSet
            DSetCurrencies.ReadXml("http://ec.europa.eu/external_relations/cfsp/sanctions/list/version4/global/global.xml")
            DgvSearch.DataSource = DSetCurrencies.Tables("Name")
        End If
L:      lblWait.Visible = False
        If DgvSearch.Rows.Count > 0 Then
            dt = DgvSearch.DataSource
            lblCountRecourd.Text = DgvSearch.Rows.Count
            TxtFirstName.Enabled = True
            TxtLastName.Enabled = True
        End If
        GroupBox1.Enabled = True
        GroupBox2.Enabled = True
    End Sub
    Private Sub FrmBlackList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbKindList.SelectedIndex = 0
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtFirstName.TextChanged
        If CmbKindList.SelectedIndex = 1 Then
            dt.DefaultView.RowFilter = " FIRST_NAME Like '%" & TxtFirstName.Text & "%'"
        Else
            dt.DefaultView.RowFilter = " FIRSTNAME Like '%" & TxtFirstName.Text & "%'"
        End If
        lblCountRecourd.Text = DgvSearch.Rows.Count
    End Sub
    Private Sub TxtLastName_TextChanged(sender As Object, e As EventArgs) Handles TxtLastName.TextChanged
        If CmbKindList.SelectedIndex = 1 Then
            dt.DefaultView.RowFilter = " Second_Name Like '%" & TxtLastName.Text & "%'"
        Else
            dt.DefaultView.RowFilter = " LastName Like '%" & TxtLastName.Text & "%'"
        End If
        lblCountRecourd.Text = DgvSearch.Rows.Count
    End Sub
    Private Sub Clear()
        DgvSearch.DataSource = Nothing
        DgvSearch.Rows.Clear()
        DgvSearch.Refresh()
    End Sub

    Private Sub GroupBox1_DoubleClick(sender As Object, e As EventArgs) Handles GroupBox1.DoubleClick
        If Me.Dock = DockStyle.Fill Then
            Me.Dock = DockStyle.None
        Else
            Me.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub FrmBlackList_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        If Me.Dock = DockStyle.Fill Then
            Me.Dock = DockStyle.None
        Else
            Me.Dock = DockStyle.Fill
        End If
    End Sub
    Private Sub GroupBox2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles GroupBox2.MouseDoubleClick
        If Me.Dock = DockStyle.Fill Then
            Me.Dock = DockStyle.None
        Else
            Me.Dock = DockStyle.Fill
        End If
    End Sub
End Class
