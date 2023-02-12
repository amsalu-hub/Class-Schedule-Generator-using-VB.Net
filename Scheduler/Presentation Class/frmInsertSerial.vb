Public Class frmInsertSerial
    Private motherboardid As String
    Private cpu As String
    Private Function SystemSerialNumber() As String
        ' Get the Windows Management Instrumentation object.
        Dim wmi As Object = GetObject("WinMgmts:")

        ' Get the "base boards" (mother boards).
        Dim serial_numbers As String = ""
        Dim mother_boards As Object = wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board

        If serial_numbers.Length > 0 Then
            serial_numbers = serial_numbers.Substring(2)
        End If
        If serial_numbers = "Not Applicable" Then
            serial_numbers = serial_numbers.Replace("Not Applicable", "00EFBR08H05109427FGSQL")
        End If
        Return serial_numbers
    End Function
    Private Function CpuId() As String
        Dim computer As String = "."
        Dim wmi As Object = GetObject("winmgmts:" & "{impersonationLevel=impersonate}!\\" & computer & "\root\cimv2")
        Dim processors As Object = wmi.ExecQuery("Select * from " & "Win32_Processor")

        Dim cpu_ids As String = ""
        For Each cpu As Object In processors
            cpu_ids = cpu_ids & ", " & cpu.ProcessorId
        Next cpu
        If cpu_ids.Length > 0 Then
            cpu_ids = cpu_ids.Substring(2)
        End If
        Return cpu_ids
    End Function
    Private Sub frmInsertSerial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        motherboardid = SystemSerialNumber()
        cpu = CpuId()
        txtcompid.Text = motherboardid + "##" + cpu
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If Not txtserialNo.Text = "" Then
            If txtserialNo.Text = motherboardid.Substring(motherboardid.Length / 2).ToLower + cpu.Substring(cpu.Length / 2).ToLower + cpu.ToUpper + motherboardid.ToUpper Then
                My.Settings.Registered = True
                My.Settings.Save()
                Me.Hide()
                LoginForm.Show()
            ElseIf txtserialNo.Text = motherboardid.Substring(motherboardid.Length / 2).ToLower + cpu.Substring(cpu.Length / 2).ToLower + motherboardid.Substring(0, motherboardid.Length / 2).ToUpper + cpu.Substring(0, cpu.Length / 2).ToUpper Then
                My.Settings.Registered = True
                My.Settings.Save()
                Me.Hide()
                LoginForm.Show()
            ElseIf txtserialNo.Text = cpu.Substring(cpu.Length / 2).ToLower + motherboardid.Substring(motherboardid.Length / 2).ToLower + motherboardid.Substring(0, motherboardid.Length / 2).ToUpper + cpu.Substring(0, cpu.Length / 2).ToUpper Then
                My.Settings.Registered = True
                My.Settings.Save()
                Me.Hide()
                LoginForm.Show()
            ElseIf txtserialNo.Text = cpu.Substring(cpu.Length / 2).ToLower + motherboardid.Substring(motherboardid.Length / 2).ToLower + cpu.Substring(cpu.Length / 2).ToLower + motherboardid.Substring(0, motherboardid.Length / 2).ToUpper + cpu.Substring(0, cpu.Length / 2).ToUpper Then
                My.Settings.Registered = True
                My.Settings.Save()
                Me.Hide()
                LoginForm.Show()
            Else
                MessageBox.Show("You are trying to register an invalid serial number." + vbNewLine + "Please, contanct the owner of the product" + vbNewLine + "to get the correct serial number.", "Scheduler", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Else
            MessageBox.Show("Please, insert serial number of the product your are given from the producer of this software!", "Insert Serial Number", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class