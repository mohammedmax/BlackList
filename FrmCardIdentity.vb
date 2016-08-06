Imports System.Data.SqlClient
Imports System.IO


Public Class FrmCardIdentity
    Public Shared Recordescount As Integer = 0
    Public strTable_Name As String
    Private Sub SetScreenMode()

        Dim blnEnable As Boolean = TxtRecordNumber.Text <> "*" AndAlso TxtRecordNumber.Text <= Recordescount

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
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If TxtFirstName.Text = "" Then
            MsgBox("يرجى التأكد من ادخال الاسم")
            Exit Sub
        End If

        Dim Parameter(37) As SqlParameter
        Parameter(0) = New SqlParameter("@id", SqlDbType.Int)
        Parameter(1) = New SqlParameter("@SerialNumber", IIf(TxtSerialNumber.TextLength = 0, DBNull.Value, TxtSerialNumber.Text))
        Parameter(2) = New SqlParameter("@Branch_ID", BranchID)
        Parameter(3) = New SqlParameter("@CustomerType", IIf(RadNormal.Checked, 0, 1))
        Parameter(4) = New SqlParameter("@FirstName", TxtFirstName.Text.Trim)
        Parameter(5) = New SqlParameter("@LastName", TxtLastName.Text.Trim)
        Parameter(6) = New SqlParameter("@FatherName", TxtFatherName.Text.Trim)
        Parameter(7) = New SqlParameter("@MotherName", TxtMotherName.Text.Trim)
        Parameter(8) = New SqlParameter("@Identity_Kind", CmbIdentityKind.SelectedValue)
        Parameter(9) = New SqlParameter("@Identity_No", TxtIdentityNo.Text)
        Parameter(10) = New SqlParameter("@Nationality_id", CmbNationality.SelectedValue)
        Parameter(11) = New SqlParameter("@Card_Address", TxtAddress.Text)
        Parameter(12) = New SqlParameter("@Card_Phone", TxtCardPhone1.Text)
        Parameter(13) = New SqlParameter("@Card_Mob", TxtCardMob1.Text)
        Parameter(14) = New SqlParameter("@User_ID", User_ID)
        Parameter(15) = New SqlParameter("@BirthdayDate", DtpBirthdayDate.Value)
        Parameter(16) = New SqlParameter("@PlaceOfBirth", TxtPlaceOfBirth.Text)
        Parameter(17) = New SqlParameter("@Sex", IIf(RadMale.Checked, 0, 1))
        Parameter(18) = New SqlParameter("@FingerPrint", SqlDbType.VarBinary)
        Parameter(19) = New SqlParameter("@IssuedDate", DtpIssuedDate.Value)
        Parameter(20) = New SqlParameter("@Expiration_Date", DtpExpirationDate.Value)
        Parameter(21) = New SqlParameter("@IssuedBy", TxtIssuedBy.Text)
        Parameter(22) = New SqlParameter("@ZipCode", TxtZipCode.Text)
        Parameter(23) = New SqlParameter("@EconomicOwner", TxtEconomicOwner.Text)
        Parameter(24) = New SqlParameter("@EconomicActivity", TxtEconomicActivity.Text)
        Parameter(25) = New SqlParameter("@EmailAdress", TxtEmail.Text)
        Parameter(26) = New SqlParameter("@User_EmailAdress", TxtUserEmail.Text)
        Parameter(27) = New SqlParameter("@password", TxtPassword.Text)
        Parameter(28) = New SqlParameter("@Document_Type", CmbDocType.SelectedIndex)
        Parameter(29) = New SqlParameter("@Document_Comment", TxtDocComment.Text)
        Parameter(30) = New SqlParameter("@Document_Image", SqlDbType.VarBinary)
        Parameter(31) = New SqlParameter("@ActiveStat", IIf(ChkStatus.Checked, 1, 0))
        Parameter(32) = New SqlParameter("@BankAcc_No", TxtBankAcc_No.Text)
        Parameter(33) = New SqlParameter("@IsBlackList", IIf(ChkBlacklist.Checked, 1, 0))
        Parameter(34) = New SqlParameter("@Card_Work", TxtWork.Text)
        Parameter(35) = New SqlParameter("@Card_Jop", TxtJop.Text)
        Parameter(36) = New SqlParameter("@Annual_Income", Val((TxtAnnual_Income.Text)))
        Parameter(37) = New SqlParameter("@Currency_Id", CmbCurrency.SelectedValue)

        ''صورة البصمة
        'Parameter(18).Value = DBNull.Value
        'If Not ImgFingerPrint.Image Is Nothing Then
        '    Parameter(18).Value = cls.ImagesCompression(ImgFingerPrint.Image)
        'End If
        Parameter(18).Value = Nothing
        Parameter(30).Value = Nothing

        ''صورة الوثيقة
        'Parameter(30).Value = DBNull.Value
        'If Not ImgDocument.Image Is Nothing Then
        '    Parameter(30).Value = cls.ImagesCompression(ImgDocument.Image)
        'End If



        If BtnSave.Tag Is Nothing Or BtnSave.Tag = 0 Then
            'حفظ
            Dim cardid As Integer = Parameter(0).Value
            Parameter(0).Direction = ParameterDirection.Output
            If Execute_Procedure("p_tbl_ExchCardIdentity_Ins", Parameter) Then
                MsgBox("تمت عملية الحفظ بنجاح")
                BtnNew_Click(BtnNew, Nothing)
            Else
                MsgBox("خطأ في عملية الحفظ")
            End If
        Else
            'تعديل
            Parameter(0).Value = BtnSave.Tag
            If Execute_Procedure("p_tbl_ExchCardIdentity_Upd", Parameter) Then
                MsgBox("تمت عملية التعديل بنجاح")
            Else
                MsgBox("خطأ في عملية التعديل")
            End If
        End If


    End Sub

    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        Recordescount = getsqlvalue("select count(id) from " & strTable_Name)
        LblRecordsCount.Text = Recordescount
        ClearControls(Me)
        ChkStatus.Checked = True
        RadNormal.Checked = True
        RadMale.Checked = True
        TxtRecordNumber.Text = "*"
        TxtSerialNumber.Text = ""
        BtnSave.Tag = Nothing
        TxtFirstName.Enabled = True
        TxtFatherName.Enabled = True
        TxtLastName.Enabled = True
        SetScreenMode()
    End Sub
    Public Sub TxtRecordNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtRecordNumber.KeyPress
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
            FillControls(Me, strTable_Name, , "WHERE ID = " & BtnSave.Tag)

            Dim S As Boolean = getsqlvalue("select sex from V_CardIdentity where id = " & BtnSave.Tag)
            If S = True Then RadFMale.Checked = True Else RadMale.Checked = True
            SetScreenMode()

            TxtFirstName.Enabled = False
        End If
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
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean

        If msg.WParam.ToInt32() = 13 Then

            Select Case Me.ActiveControl.Name

                Case BtnSave.Name
                    BtnSave_Click(Nothing, Nothing)
                    Return True

                Case TxtIdentityNo.Name
                    BtnSave.Focus()
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
    Private Sub FrmCardIdentity1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strTable_Name = "V_CardIdentity"
        BtnNew_Click(BtnNew, e)
        'FillCombo(CmbBranch, "tbl_branches", "id", "ar_branch_name", "ORDER BY id")
        FillCombo(CmbIdentityKind, "tbl_identity_kind", "id", "ar_identity_name", "ORDER BY id")
        FillCombo(CmbCurrency, "tbl_currencies", "id", "ar_currency_name")
        FillCombo(CmbNationality, "tbl_nationalities", "id", "ar_nationality_name", , "ID")
    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Dispose()
    End Sub

    Private Sub AddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddFingerPrint.Click, BtnAddDocument.Click
        FileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.GIF)|*.bmp;*.jpg;*.jpeg;*.GIF|" & _
                          "PNG files (*.png)|*.png"
        FileDialog.ShowDialog()
        If File.Exists(FileDialog.FileName) Then
            If CType(sender, Button) Is BtnAddFingerPrint Then
                ImgFingerPrint.Image = Image.FromFile(FileDialog.FileName)
                ImgFingerPrint.SizeMode = PictureBoxSizeMode.StretchImage

            ElseIf CType(sender, Button) Is BtnAddDocument Then
                ImgDocument.Image = Image.FromFile(FileDialog.FileName)
                ImgDocument.SizeMode = PictureBoxSizeMode.StretchImage

            End If
        End If
    End Sub
    Private Sub RemoveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveFingerPrint.Click, BtnRemoveDocument.Click
        If CType(sender, Button) Is BtnRemoveFingerPrint Then
            ImgFingerPrint.Image = Nothing
        ElseIf CType(sender, Button) Is BtnRemoveDocument Then
            ImgDocument.Image = Nothing
        End If
    End Sub

    Private Sub BtnSaveImage_Click(sender As Object, e As EventArgs) Handles BtnSaveImage.Click
        If Not ImgDocument.Image Is Nothing Then
            SaveFileDlg.FileName = Me.Text
            SaveFileDlg.Filter = "BMP files (*.bmp)|*.bmp|" & _
                                 "JPG files (*.jpg)|*.jpg|" & _
                                 "JPEG files (*.jpeg)|*.jpeg|" & _
                                 "GIF files (*.gif)|*.gif|" & _
                                 "PNG files (*.png)|*.png"
            SaveFileDlg.ShowDialog()

            If SaveFileDlg.FileName <> "" Then
                ImgDocument.Image.Save(SaveFileDlg.FileName)
            End If
        End If
    End Sub
    Private Sub BtnShow_MouseHover(sender As Object, e As EventArgs) Handles BtnShow.MouseHover
        TxtPassword.UseSystemPasswordChar = False
    End Sub
    Private Sub BtnShow_MouseLeave(sender As Object, e As EventArgs) Handles BtnShow.MouseLeave
        TxtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub BtnAddMore_Click(sender As Object, e As EventArgs) Handles BtnAddMore.Click
        If BtnSave.Tag = Nothing Or BtnSave.Tag = 0 Then
            MsgBox("يجب حفظ البطاقة اولا", MsgBoxStyle.OkOnly, "تنبيه")
            Exit Sub
        End If
        FrmDocumation.Card_Id = BtnSave.Tag
        FrmDocumation.ShowDialog()
    End Sub


End Class