<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTrefresh = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstPorts = New System.Windows.Forms.ComboBox()
        Me.BTConnect = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lstConsole = New System.Windows.Forms.ListBox()
        Me.BTTest = New System.Windows.Forms.Button()
        Me.BTforward = New System.Windows.Forms.Button()
        Me.BTleft = New System.Windows.Forms.Button()
        Me.BTright = New System.Windows.Forms.Button()
        Me.BTbackward = New System.Windows.Forms.Button()
        Me.BTstop = New System.Windows.Forms.Button()
        Me.BTquit = New System.Windows.Forms.Button()
        Me.BTBuzz = New System.Windows.Forms.Button()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BTrefresh)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstPorts)
        Me.GroupBox1.Controls.Add(Me.BTConnect)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Settings"
        '
        'BTrefresh
        '
        Me.BTrefresh.BackgroundImage = CType(resources.GetObject("BTrefresh.BackgroundImage"), System.Drawing.Image)
        Me.BTrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTrefresh.Location = New System.Drawing.Point(324, 31)
        Me.BTrefresh.Name = "BTrefresh"
        Me.BTrefresh.Size = New System.Drawing.Size(22, 23)
        Me.BTrefresh.TabIndex = 10
        Me.BTrefresh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COM PORT:"
        '
        'lstPorts
        '
        Me.lstPorts.FormattingEnabled = True
        Me.lstPorts.Location = New System.Drawing.Point(107, 32)
        Me.lstPorts.Name = "lstPorts"
        Me.lstPorts.Size = New System.Drawing.Size(211, 21)
        Me.lstPorts.TabIndex = 1
        '
        'BTConnect
        '
        Me.BTConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTConnect.Location = New System.Drawing.Point(352, 25)
        Me.BTConnect.Name = "BTConnect"
        Me.BTConnect.Size = New System.Drawing.Size(84, 35)
        Me.BTConnect.TabIndex = 0
        Me.BTConnect.Text = "Connect"
        Me.BTConnect.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstConsole)
        Me.GroupBox2.Location = New System.Drawing.Point(33, 269)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 100)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Serial Monitor"
        '
        'lstConsole
        '
        Me.lstConsole.FormattingEnabled = True
        Me.lstConsole.Location = New System.Drawing.Point(6, 17)
        Me.lstConsole.Name = "lstConsole"
        Me.lstConsole.Size = New System.Drawing.Size(435, 69)
        Me.lstConsole.TabIndex = 0
        '
        'BTTest
        '
        Me.BTTest.Location = New System.Drawing.Point(190, 116)
        Me.BTTest.Name = "BTTest"
        Me.BTTest.Size = New System.Drawing.Size(95, 23)
        Me.BTTest.TabIndex = 3
        Me.BTTest.Text = "Bluetooth Test"
        Me.BTTest.UseVisualStyleBackColor = True
        '
        'BTforward
        '
        Me.BTforward.Location = New System.Drawing.Point(201, 157)
        Me.BTforward.Name = "BTforward"
        Me.BTforward.Size = New System.Drawing.Size(75, 23)
        Me.BTforward.TabIndex = 4
        Me.BTforward.Text = "Forward"
        Me.BTforward.UseVisualStyleBackColor = True
        '
        'BTleft
        '
        Me.BTleft.Location = New System.Drawing.Point(115, 191)
        Me.BTleft.Name = "BTleft"
        Me.BTleft.Size = New System.Drawing.Size(75, 23)
        Me.BTleft.TabIndex = 5
        Me.BTleft.Text = "Left"
        Me.BTleft.UseVisualStyleBackColor = True
        '
        'BTright
        '
        Me.BTright.Location = New System.Drawing.Point(287, 191)
        Me.BTright.Name = "BTright"
        Me.BTright.Size = New System.Drawing.Size(75, 23)
        Me.BTright.TabIndex = 6
        Me.BTright.Text = "Right"
        Me.BTright.UseVisualStyleBackColor = True
        '
        'BTbackward
        '
        Me.BTbackward.Location = New System.Drawing.Point(201, 227)
        Me.BTbackward.Name = "BTbackward"
        Me.BTbackward.Size = New System.Drawing.Size(75, 23)
        Me.BTbackward.TabIndex = 7
        Me.BTbackward.Text = "Backward"
        Me.BTbackward.UseVisualStyleBackColor = True
        '
        'BTstop
        '
        Me.BTstop.Location = New System.Drawing.Point(201, 191)
        Me.BTstop.Name = "BTstop"
        Me.BTstop.Size = New System.Drawing.Size(75, 23)
        Me.BTstop.TabIndex = 8
        Me.BTstop.Text = "Stop"
        Me.BTstop.UseVisualStyleBackColor = True
        '
        'BTquit
        '
        Me.BTquit.Location = New System.Drawing.Point(376, 380)
        Me.BTquit.Name = "BTquit"
        Me.BTquit.Size = New System.Drawing.Size(75, 23)
        Me.BTquit.TabIndex = 9
        Me.BTquit.Text = "Quit"
        Me.BTquit.UseVisualStyleBackColor = True
        '
        'BTBuzz
        '
        Me.BTBuzz.Location = New System.Drawing.Point(376, 129)
        Me.BTBuzz.Name = "BTBuzz"
        Me.BTBuzz.Size = New System.Drawing.Size(75, 23)
        Me.BTBuzz.TabIndex = 10
        Me.BTBuzz.Text = "Buzz!!"
        Me.BTBuzz.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 415)
        Me.Controls.Add(Me.BTBuzz)
        Me.Controls.Add(Me.BTquit)
        Me.Controls.Add(Me.BTstop)
        Me.Controls.Add(Me.BTbackward)
        Me.Controls.Add(Me.BTright)
        Me.Controls.Add(Me.BTleft)
        Me.Controls.Add(Me.BTforward)
        Me.Controls.Add(Me.BTTest)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "BTController"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTConnect As Button
    Friend WithEvents lstPorts As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTTest As Button
    Friend WithEvents BTforward As Button
    Friend WithEvents BTleft As Button
    Friend WithEvents BTright As Button
    Friend WithEvents BTbackward As Button
    Friend WithEvents BTstop As Button
    Friend WithEvents BTquit As Button
    Friend WithEvents lstConsole As ListBox
    Friend WithEvents BTrefresh As Button
    Friend WithEvents BTBuzz As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
End Class
