Imports System.Runtime.InteropServices
' A faire
' usermod -aG sudo lunit
' sudo visudo
'   Ajouter: lunit ALL=NOPASSWD: /sbin/shutdown, /sbin/reboot
' verifier : groups lunit
'     lunit root adm ...
' tester une remière fois la connexion ssh pour valider la clé SHA

' reste à faire
' fait : fermer la fenetre à la fin (mode avec argument uniquement
' fait : ligne de commande pour démarrage Sutdwon ou reboot
' fait : crypter le mot de passe
' fait : vérifier avec Ubuntu
' si impossible de compiler:
'  effacer dossier obj (L:\Laurent\Dev\UbuntuShutdown\UbuntuServerShutdown-Reboot\ShutdownLunit)

Public Class Form1
    Dim bDoublon As Boolean = False
    Const PuTTYFolderDefault As String = "C:\Program Files\PuTTY"
    Const pLinkExe As String = "plink.exe"
    ' Const PuttyEx As String = "\Putty.exe"
    Const PuttyOptions As String = " -no-antispoof -batch"
    Const ShutdownCommand As String = "sudo shutdown -h now"
    Const RebootCommand As String = "sudo reboot now"
    Const regApp As String = "PuTTY"
    Const regConfig As String = "Config"
    Const regIP As String = "IP"
    Const regKeepOpened As String = "DisplayCmd"
    Const regUser As String = "User"
    Const regPwd As String = "Pwd"
    Const regPath As String = "PathPuTTY"
    Const cmdTitleWindow As String = "Please Wait during sending the command !"
    Dim bSelectTxtBox As Boolean = False
    Dim bSilentMode As Boolean = False

    Private Sub ButtonShutdown_Click(sender As Object, e As EventArgs) Handles ButtonShutdown.Click
        StartShutdown()
    End Sub
    Sub StartShutdown()
        Me.LabelPuTTYCommand.Text = pLinkExe + " -ssh " + Me.TextBoxUser.Text + "@" + Me.txtIP.Text + PuttyOptions + " -pw " + Me.TextBoxPwd.Text + " " + Chr(34) + ShutdownCommand + Chr(34)
        RunCMD(Me.LabelPuTTYCommand.Text, Me.TextBoxFolderPuTTY.Text, False, False, Me.CheckBoxKeepOpened.Checked)
        If bSilentMode = True Then
            Me.Close()
        Else
            Clipboard.SetText(Me.LabelPuTTYCommand.Text)
        End If
    End Sub
    Private Sub ButtonReboot_Click(sender As Object, e As EventArgs) Handles ButtonReboot.Click
        StartReboot()
    End Sub
    Sub StartReboot()
        Me.LabelPuTTYCommand.Text = pLinkExe +
            " -ssh " + Me.TextBoxUser.Text + "@" + Me.txtIP.Text + PuttyOptions +
            " -pw " + Me.TextBoxPwd.Text + " " + Chr(34) + RebootCommand + Chr(34)
        RunCMD(Me.LabelPuTTYCommand.Text, Me.TextBoxFolderPuTTY.Text, True, True, Me.CheckBoxKeepOpened.Checked)
        If bSilentMode = True Then
            Me.Close()
        Else
            Clipboard.SetText(Me.LabelPuTTYCommand.Text)
        End If
    End Sub
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)>
    Public Shared Function SetWindowText(hWnd As IntPtr, text As String) As Integer
    End Function

    Sub RunCMD(command As String, WorkingDir As String, Optional ShowWindow As Boolean = False, Optional WaitForProcessComplete As Boolean = False, Optional permanent As Boolean = False)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(ShowWindow AndAlso permanent, "/K", "/C") + " " + command
        pi.FileName = "cmd.exe"

        pi.CreateNoWindow = Not ShowWindow
        pi.WorkingDirectory = WorkingDir
        If ShowWindow Then
            pi.WindowStyle = ProcessWindowStyle.Normal
        Else
            pi.WindowStyle = ProcessWindowStyle.Hidden
        End If
        p.StartInfo = pi
        p.Start()
        Threading.Thread.Sleep(150)
        Try ' pour éviter erreur si l'on n'affiche pas la fenêtre
            SetWindowText(p.MainWindowHandle, cmdTitleWindow)
            If WaitForProcessComplete Then Do Until p.HasExited : Loop
        Catch ex As Exception

        End Try

    End Sub
    Private Sub txtIP_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP.KeyPress
        'If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or Asc(e.KeyChar) = Keys.Delete Or
        '  Asc(e.KeyChar) = Keys.Right Or Asc(e.KeyChar) = Keys.Left Or Asc(e.KeyChar) = Keys.Delete Or Asc(e.KeyChar) = Keys.Back Then
        '    Return
        'End If
        'e.Handled = True
        e.Handled = testChar(e.KeyChar)
    End Sub

    Private Sub txtIP_LostFocus(sender As Object, e As EventArgs) Handles txtIP.LostFocus
        Dim IP() As String = txtIP.Text.Split(".")
        Dim Test As Integer
        If IP.Length = 4 Then 'il y a 3 "."
            Dim Proper As Boolean = True
            For I As Integer = 0 To IP.Length - 1
                Try
                    Test = Integer.Parse(IP(I)) 'Parse the string for an integer, if its not return -1
                    If Test < 0 Or Test > 255 Then 'If not between 0-255 then the ip is not a proper format
                        MsgBox("Tous les nombres doivent être entre 0 et 255 !")
                        txtIP.Focus()
                        txtIP.SelectionStart = txtIP.Text.Length
                        Return
                    End If
                Catch ex As Exception
                    MsgBox("Le paramètre " & (I + 1).ToString & " de l'adresse IP " & txtIP.Text & " n'est pas conforme") '& vbCrLf & ex.Message)
                End Try

            Next
            ' suppression des 0 en début des termes
            Try
                txtIP.Text = Int(IP(0)).ToString + "." + Int(IP(1)).ToString + "." + Int(IP(2)).ToString + "." + Int(IP(3)).ToString
                If IP(0).ToString = "0" Or IP(3).ToString = "0" Then
                    MsgBox("L'adresse IP ( " & txtIP.Text & " ) n'est pas règlementaire !" & vbCrLf & vbCrLf & "Pas de 0 comme membre en début ou fin de chaîne.", vbCritical + vbOKOnly, "Adresse IP incorrecte")
                    txtIP.SelectAll()
                    txtIP.Focus()
                End If
            Catch
            End Try
        Else
            MsgBox("Le format n'est pas valide! Il doit être sous la forme : XXX.XXX.XXX.XXX ")
            txtIP.Focus()
            txtIP.SelectionStart = txtIP.Text.Length
        End If
    End Sub

    Function testChar(ch As Char) As Boolean
        ' teste le caractère tappé si c'est un chiffre ou un caractère de déplacement
        ' retourne True s'il est légal
        testChar = True
        bDoublon = False     ' reset
        If Char.IsDigit(ch) Or
            Asc(ch) = Keys.Delete Or Asc(ch) = Keys.Right Or Asc(ch) = Keys.Left Or
            Asc(ch) = Keys.Delete Or Asc(ch) = Keys.Back Then
            testChar = False
        End If
        If ch = "." Then
            testChar = True ' invalide
            'ch = ""
        End If
    End Function
    Sub testMembre(str As TextBox, pos As Integer)
        ' str : valeur du membre
        ' pos : position 0,1,2,3
        Dim isValid As Boolean = True
        If str.Text = "" Then
            ' champs incorrect
        Else
            'str.Text = str.Text.ToString.Replace(".", "")
            str.Text = Int(str.Text).ToString
            If pos = 0 Or pos = 3 Then  ' vérification spéciale pos 0 et 3
                If Int(str.Text) = 0 Then
                    Dim sPos As String = "début"
                    If pos = 3 Then sPos = "fin"
                    If bDoublon = False Then    ' affiche ce message la première fois
                        bDoublon = True  ' bug refresh et 2x ce msgbox
                        MsgBox("0 est interdit comme " & sPos & " pour une IP", vbCritical + vbOKOnly, "Adresse IP incorrecte - Test contenu membre")
                    End If
                    isValid = False
                End If
            End If
            If Int(str.Text) > 254 Then    ' vérification si > 254
                MsgBox("Le terme doit être inférieur à 255 pour une IP", vbCritical + vbOKOnly, "Adresse IP incorrecte - Test contenu membre")
                isValid = False
            End If
            If isValid = False Then
                str.SelectAll()
                str.Focus()
            Else

                display_txtIP()
            End If
        End If
        If str.TextLength = 3 Then
            If bSelectTxtBox = False Then   ' uniquement si l'on édite pas une textbox
                Select Case pos
                    Case 0
                        Me.txtIP2.SelectAll()
                        Me.txtIP2.Focus()
                    Case 1
                        Me.txtIP3.SelectAll()
                        Me.txtIP3.Focus()
                    Case 2
                        Me.txtIP4.SelectAll()
                        Me.txtIP4.Focus()
                End Select
            End If
        End If
    End Sub
    Sub isVide(txt As TextBox)
        If txt.Text = "" Then
            MsgBox("Le paramètre ne peut pas être vide !", vbCritical + vbOKOnly, "Adresse IP incorrecte - Test chaîne vide")
            txt.SelectAll()
            txt.Focus()
        End If
    End Sub
    Sub display_txtIP()
        Me.txtIP.Text = txtIP1.Text + "." + txtIP2.Text + "." + txtIP3.Text + "." + txtIP4.Text
    End Sub
    ' valide le caractère tappé
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP1.KeyPress
        e.Handled = testChar(e.KeyChar)
    End Sub
    Private Sub txtIP2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP2.KeyPress
        e.Handled = testChar(e.KeyChar)
    End Sub
    Private Sub txtIP3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP3.KeyPress
        e.Handled = testChar(e.KeyChar)
    End Sub
    Private Sub txtIP4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIP4.KeyPress
        e.Handled = testChar(e.KeyChar)
    End Sub
    ' teste si le champ est vide
    Private Sub txtIP1_LostFocus(sender As Object, e As EventArgs) Handles txtIP1.LostFocus
        testMembre(txtIP1, 0)
        isVide(Me.txtIP1)
    End Sub
    Private Sub txtIP2_LostFocus(sender As Object, e As EventArgs) Handles txtIP2.LostFocus
        testMembre(txtIP2, 1)
        isVide(Me.txtIP2)
    End Sub
    Private Sub txtIP3_LostFocus(sender As Object, e As EventArgs) Handles txtIP3.LostFocus
        testMembre(txtIP3, 2)
        isVide(Me.txtIP3)
    End Sub
    Private Sub txtIP4_LostFocus(sender As Object, e As EventArgs) Handles txtIP4.LostFocus
        testMembre(txtIP4, 3)
        isVide(Me.txtIP4)
    End Sub

    ' actualise si correct
    Private Sub txtIP1_TextChanged(sender As Object, e As EventArgs) Handles txtIP1.TextChanged
        testMembre(txtIP1, 0)
    End Sub
    Private Sub txtIP2_TextChanged(sender As Object, e As EventArgs) Handles txtIP2.TextChanged
        testMembre(txtIP2, 1)
    End Sub
    Private Sub txtIP3_TextChanged(sender As Object, e As EventArgs) Handles txtIP3.TextChanged
        testMembre(txtIP3, 2)
    End Sub
    Private Sub txtIP4_TextChanged(sender As Object, e As EventArgs) Handles txtIP4.TextChanged
        testMembre(txtIP4, 3)
    End Sub

    Private Sub ButtonBrowsePuTTY_Click(sender As Object, e As EventArgs) Handles ButtonBrowsePuTTY.Click
        Dim dlgFolder As New FolderBrowserDialog
        dlgFolder.Description = "Veuillez sélectionne le dossier contenant le logiciel PuTTY"
        If Me.TextBoxFolderPuTTY.Text.Length = 0 Then
            dlgFolder.SelectedPath = PuTTYFolderDefault
        Else
            dlgFolder.SelectedPath = Me.TextBoxFolderPuTTY.Text
        End If

        dlgFolder.ShowDialog()
        If dlgFolder.SelectedPath.Length > 0 Then
            Me.TextBoxFolderPuTTY.Text = dlgFolder.SelectedPath
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitApp()
        Dim CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
        If CommandLineArgs.Count > 0 Then
            ' il y a un argument
            bSilentMode = True
            Select Case UCase(CommandLineArgs(0))
                Case "SHUTDOWN"
                    Debug.Print("Shutdown")
                    StartShutdown()
                Case "REBOOT"
                    Debug.Print("Reboot")
                    StartReboot()
            End Select
        End If
    End Sub
    Sub InitApp()
        Dim tmp As String
        tmp = GetSetting(regApp, regConfig, regIP, "")
        If tmp = "" Then
            tmp = "192.168.1.2"
            SaveSetting(regApp, regConfig, regIP, tmp)
        End If
        ' traiter IP
        'Me.txtIP.Text = tmp
        Dim IP() As String = tmp.Split(".")
        Me.txtIP1.Text = IP(0)
        Me.txtIP2.Text = IP(1)
        Me.txtIP3.Text = IP(2)
        Me.txtIP4.Text = IP(3)

        ' user name
        Me.TextBoxUser.Text = GetSetting(regApp, regConfig, regUser, "")
        If Me.TextBoxUser.Text = "" Then
            Me.TextBoxUser.Text = "lunit"
            SaveSetting(regApp, regConfig, regUser, Me.TextBoxUser.Text)
        End If

        ' password
        Me.TextBoxPwd.Text = decode(GetSetting(regApp, regConfig, regPwd, ""))
        If Me.TextBoxPwd.Text = "" Then
            Me.TextBoxPwd.Text = "fcr-iip"
            SaveSetting(regApp, regConfig, regPwd, code(Me.TextBoxPwd.Text))
        End If

        ' path
        Me.TextBoxFolderPuTTY.Text = GetSetting(regApp, regConfig, regPath, "")
        If Me.TextBoxFolderPuTTY.Text = "" Then
            Me.TextBoxFolderPuTTY.Text = PuTTYFolderDefault
            SaveSetting(regApp, regConfig, regPath, Me.TextBoxFolderPuTTY.Text)
        End If
        tmp = GetSetting(regApp, regConfig, regKeepOpened, "")
        If tmp = "" Then
            Me.CheckBoxKeepOpened.Checked = True
            SaveSetting(regApp, regConfig, regKeepOpened, Me.CheckBoxKeepOpened.Checked)
        Else
            Me.CheckBoxKeepOpened.Checked = tmp
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Remote Shutdown/Reboot for Lunit MG" & vbCrLf & vbCrLf & "Laurent MOLINA - v1.0 - GITHUB  - 2022", vbOKOnly, "About ...")
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveSettignsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveSettignsToolStripMenuItem.Click
        SaveSetting(regApp, regConfig, regUser, Me.TextBoxUser.Text)
        SaveSetting(regApp, regConfig, regPwd, code(Me.TextBoxPwd.Text))
        SaveSetting(regApp, regConfig, regPath, Me.TextBoxFolderPuTTY.Text)
        SaveSetting(regApp, regConfig, regKeepOpened, Me.CheckBoxKeepOpened.Checked)
        SaveSetting(regApp, regConfig, regIP, Me.txtIP.Text)
    End Sub

    Function code(toEncode As String) As String
        code = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(toEncode))
    End Function
    Function decode(toDecode As String) As String
        decode = ""
        Try
            decode = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(toDecode.ToString))

        Catch ex As Exception

        End Try
    End Function


    ' évite le focus sur le 3ème texte de l'IP
    Private Sub TextBoxUser_MouseMove(sender As Object, e As MouseEventArgs) Handles TextBoxUser.MouseMove
        bSelectTxtBox = True    ' gère l'event IP
    End Sub
    Private Sub TextBoxUser_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxUser.MouseLeave
        bSelectTxtBox = False ' gère l'event IP
    End Sub
    Private Sub TextBoxPwd_MouseEnter(sender As Object, e As EventArgs) Handles TextBoxPwd.MouseEnter
        bSelectTxtBox = True ' gère l'event IP
    End Sub
    Private Sub TextBoxPwd_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxPwd.MouseLeave
        bSelectTxtBox = False ' gère l'event IP
    End Sub
    Private Sub TextBoxFolderPuTTY_MouseEnter(sender As Object, e As EventArgs) Handles TextBoxFolderPuTTY.MouseEnter
        bSelectTxtBox = True ' gère l'event IP
    End Sub
    Private Sub TextBoxFolderPuTTY_MouseLeave(sender As Object, e As EventArgs) Handles TextBoxFolderPuTTY.MouseLeave
        bSelectTxtBox = False ' gère l'event IP
    End Sub
    Private Sub CheckBoxKeepOpened_MouseLeave(sender As Object, e As EventArgs) Handles CheckBoxKeepOpened.MouseLeave
        bSelectTxtBox = False ' gère l'event IP
    End Sub
    Private Sub CheckBoxKeepOpened_MouseMove(sender As Object, e As MouseEventArgs) Handles CheckBoxKeepOpened.MouseMove
        bSelectTxtBox = True ' gère l'event IP
    End Sub
End Class