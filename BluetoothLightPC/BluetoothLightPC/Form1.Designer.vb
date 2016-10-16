<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ScanBtn = New System.Windows.Forms.Button()
        Me.ConnectBtn = New System.Windows.Forms.Button()
        Me.statusLabel = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.checkStatus = New System.Windows.Forms.Timer(Me.components)
        Me.disconnectBtn = New System.Windows.Forms.Button()
        Me.SettingsBtn = New System.Windows.Forms.Button()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.TurnON = New System.Windows.Forms.Button()
        Me.TurnOFF = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select the Serial Port of the lamp:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(13, 30)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'ScanBtn
        '
        Me.ScanBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ScanBtn.Location = New System.Drawing.Point(141, 30)
        Me.ScanBtn.Name = "ScanBtn"
        Me.ScanBtn.Size = New System.Drawing.Size(97, 23)
        Me.ScanBtn.TabIndex = 2
        Me.ScanBtn.Text = "Scan"
        Me.ScanBtn.UseVisualStyleBackColor = True
        '
        'ConnectBtn
        '
        Me.ConnectBtn.Location = New System.Drawing.Point(13, 59)
        Me.ConnectBtn.Name = "ConnectBtn"
        Me.ConnectBtn.Size = New System.Drawing.Size(70, 23)
        Me.ConnectBtn.TabIndex = 3
        Me.ConnectBtn.Text = "Connect"
        Me.ConnectBtn.UseVisualStyleBackColor = True
        '
        'statusLabel
        '
        Me.statusLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.statusLabel.AutoSize = True
        Me.statusLabel.Location = New System.Drawing.Point(165, 64)
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(73, 13)
        Me.statusLabel.TabIndex = 4
        Me.statusLabel.Text = "Disconnected"
        '
        'checkStatus
        '
        Me.checkStatus.Interval = 1000
        '
        'disconnectBtn
        '
        Me.disconnectBtn.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.disconnectBtn.Location = New System.Drawing.Point(89, 59)
        Me.disconnectBtn.Name = "disconnectBtn"
        Me.disconnectBtn.Size = New System.Drawing.Size(70, 23)
        Me.disconnectBtn.TabIndex = 5
        Me.disconnectBtn.Text = "Disconnect"
        Me.disconnectBtn.UseVisualStyleBackColor = True
        '
        'SettingsBtn
        '
        Me.SettingsBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SettingsBtn.Location = New System.Drawing.Point(12, 226)
        Me.SettingsBtn.Name = "SettingsBtn"
        Me.SettingsBtn.Size = New System.Drawing.Size(75, 23)
        Me.SettingsBtn.TabIndex = 6
        Me.SettingsBtn.Text = "Settings"
        Me.SettingsBtn.UseVisualStyleBackColor = True
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.Location = New System.Drawing.Point(93, 226)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 23)
        Me.CloseBtn.TabIndex = 7
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'TurnON
        '
        Me.TurnON.Location = New System.Drawing.Point(12, 88)
        Me.TurnON.Name = "TurnON"
        Me.TurnON.Size = New System.Drawing.Size(224, 62)
        Me.TurnON.TabIndex = 8
        Me.TurnON.Text = "ON"
        Me.TurnON.UseVisualStyleBackColor = True
        '
        'TurnOFF
        '
        Me.TurnOFF.Location = New System.Drawing.Point(13, 156)
        Me.TurnOFF.Name = "TurnOFF"
        Me.TurnOFF.Size = New System.Drawing.Size(225, 64)
        Me.TurnOFF.TabIndex = 9
        Me.TurnOFF.Text = "OFF"
        Me.TurnOFF.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 261)
        Me.Controls.Add(Me.TurnOFF)
        Me.Controls.Add(Me.TurnON)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SettingsBtn)
        Me.Controls.Add(Me.disconnectBtn)
        Me.Controls.Add(Me.statusLabel)
        Me.Controls.Add(Me.ConnectBtn)
        Me.Controls.Add(Me.ScanBtn)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Bluetooth Light PC"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ScanBtn As Button
    Friend WithEvents ConnectBtn As Button
    Friend WithEvents statusLabel As Label
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents checkStatus As Timer
    Friend WithEvents disconnectBtn As Button
    Friend WithEvents SettingsBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents TurnON As Button
    Friend WithEvents TurnOFF As Button
End Class
