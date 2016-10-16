Public Class Main

    Private Sub addPorts()
        ComboBox1.Items.Clear()
        For Each port As String In getPorts()
            ComboBox1.Items.Add(port)
        Next
        ComboBox1.SelectedItem = ComboBox1.Items.Item(0)
    End Sub
    Private Function getPorts() As ArrayList
        Dim sp_array As New ArrayList
        For Each sp As String In My.Computer.Ports.SerialPortNames
            sp_array.Add(sp)
        Next
        Return sp_array
    End Function
    Private Function getStatus() As String
        If SerialPort1.IsOpen Then
            Return "Connected"
        Else
            Return "Disconnected"
        End If
    End Function
    Private Sub alertError(ByVal Text As String)
        MessageBox.Show(Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub connect()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
        End If
        SerialPort1.PortName = ComboBox1.SelectedItem
        SerialPort1.BaudRate = My.Settings.BaudRate
        Try
            SerialPort1.Open()
        Catch ex As Exception
            alertError(ex.Message)
        End Try
    End Sub
    Private Sub TurnLightON()
        Try
            SerialPort1.Write(My.Settings.onChar)
        Catch ex As Exception
            alertError(ex.Message)
        End Try
    End Sub
    Private Sub TurnLightOFF()
        Try
            SerialPort1.Write(My.Settings.offChar)
        Catch ex As Exception
            alertError(ex.Message)
        End Try
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addPorts()
        checkStatus.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ScanBtn.Click
        addPorts()
    End Sub

    Private Sub ConnectBtn_Click(sender As Object, e As EventArgs) Handles ConnectBtn.Click
        connect()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles checkStatus.Tick
        statusLabel.Text = getStatus()
        checkStatus.Start()
    End Sub

    Private Sub disconnectBtn_Click(sender As Object, e As EventArgs) Handles disconnectBtn.Click
        SerialPort1.Close()
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub SettingsBtn_Click(sender As Object, e As EventArgs) Handles SettingsBtn.Click
        Settings.Show()
    End Sub

    Private Sub TurnON_Click(sender As Object, e As EventArgs) Handles TurnON.Click
        TurnLightON()
    End Sub

    Private Sub TurnOFF_Click(sender As Object, e As EventArgs) Handles TurnOFF.Click
        TurnLightOFF()
    End Sub
End Class
