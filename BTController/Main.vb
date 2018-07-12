'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
' Copyleft (C) 2018 - coded by Marcos A. Guerine [mguerine@id.uff.br].
'
' Based on http://www.instructables.com/id/How-to-Program-Arduino-Bluetooth-Serial-Communicat/
' 
' This file is part of a Bluetooth Controller for Arduino project.
'
' It can be copied and distributed without the express permission.
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

Imports System.IO
Imports System.Threading

Public Class Main
    Dim buffer As String
    Delegate Sub myMethodDelegate(ByVal [text] As String)
    Dim bD1 As New myMethodDelegate(AddressOf Process)
    Dim WithEvents SerialPort As New IO.Ports.SerialPort

    Private Sub Form1_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If SerialPort.IsOpen() Then
            SerialPort.Close()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckForIllegalCrossThreadCalls = False
        GetSerialPortNames()
    End Sub

    Sub GetSerialPortNames()
        For Each sp As String In My.Computer.Ports.SerialPortNames
            lstPorts.Items.Add(sp)
        Next
    End Sub

    Sub SendSerialData(ByVal Port As String, ByVal data As String)
        If (SerialPort.IsOpen) Then
            lstConsole.Items.Add("Writing " + data)
            SerialPort.Write(data)
            System.Threading.Thread.Sleep(1000)
            Dim str As String = SerialPort.ReadExisting()
            str = "++Receiving " + str + "]"
            Console.WriteLine(str)
            lstConsole.Items.Add(str)
        Else
            MsgBox("Not connected to Port.")
        End If
    End Sub

    Sub process(ByVal myString As String)
        buffer = buffer + myString
        Dim str As String
        str = buffer
        If InStr(str, "|") Then
            Dim words As String() = str.Split(New Char() {"|"})
            buffer = ""
            Dim word As String
            For Each word In words
                If (word.Length > 0) Then
                    lstConsole.Items.Add(word)
                End If
            Next
        End If
    End Sub

    Private Sub SerialPort_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort.DataReceived
        'Dim str As String = SerialPort.ReadExisting()
        'Invoke(bD1, str)
    End Sub

    Private Sub BTConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTConnect.Click
        If lstPorts.SelectedIndex <> -1 Then
            Try
                If SerialPort.IsOpen Then
                    lstPorts.Enabled = True
                    BTConnect.Text = "Connect"
                    SerialPort.Close()

                Else
                    lstConsole.Items.Add("Connected to " + lstPorts.SelectedItem.ToString)
                    SerialPort.PortName = lstPorts.SelectedItem.ToString
                    SerialPort.BaudRate = 9600
                    SerialPort.DataBits = 8
                    SerialPort.Parity = Ports.Parity.None
                    SerialPort.StopBits = Ports.StopBits.One
                    SerialPort.Handshake = Ports.Handshake.None
                    SerialPort.Encoding = System.Text.Encoding.Default
                    SerialPort.Open()
                    lstPorts.Enabled = False
                    BTConnect.Text = "Disconnect"
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Please choose a serial port", vbInformation, "Serial Port")
        End If
    End Sub

    Private Sub BTTest_Click(sender As Object, e As EventArgs) Handles BTTest.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "AT")
        End If
    End Sub


    Private Sub BTforward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTforward.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "F")
        End If
    End Sub

    Private Sub BTbackward_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTbackward.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "B")
        End If
    End Sub

    Private Sub BTleft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTleft.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "L")
        End If
    End Sub

    Private Sub BTright_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTright.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "R")
        End If
    End Sub

    Private Sub BTstop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTstop.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "S")
        End If
    End Sub


    Private Sub BTBuzz_Click(sender As Object, e As EventArgs) Handles BTBuzz.Click
        If (lstPorts.SelectedIndex <> -1) Then
            SendSerialData(lstPorts.SelectedItem.ToString, "V")
        End If
    End Sub

    Private Sub BTquit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTquit.Click
        Application.Exit()
        If SerialPort.IsOpen Then
            SerialPort.Close()
        End If
    End Sub

    Private Sub BTrefresh_Click(sender As Object, e As EventArgs) Handles BTrefresh.Click
        lstPorts.Items.Clear()
        GetSerialPortNames()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim visibleItems As Integer = lstConsole.ClientSize.Height / lstConsole.ItemHeight
        lstConsole.TopIndex = Math.Max(lstConsole.Items.Count - visibleItems + 1, 0)
    End Sub
End Class
