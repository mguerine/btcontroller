<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btForwR = New System.Windows.Forms.Button()
        Me.btForwL = New System.Windows.Forms.Button()
        Me.btBackL = New System.Windows.Forms.Button()
        Me.btBackR = New System.Windows.Forms.Button()
        Me.chbAutonomouz = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AjudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.lstPorts)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(54, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 62)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Connection Settings"
        '
        'BTrefresh
        '
        Me.BTrefresh.BackColor = System.Drawing.Color.Black
        Me.BTrefresh.BackgroundImage = Global.BTController.My.Resources.Resources.icons8_refresh_500
        Me.BTrefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTrefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTrefresh.ForeColor = System.Drawing.Color.White
        Me.BTrefresh.Location = New System.Drawing.Point(352, 102)
        Me.BTrefresh.Name = "BTrefresh"
        Me.BTrefresh.Size = New System.Drawing.Size(28, 28)
        Me.BTrefresh.TabIndex = 10
        Me.BTrefresh.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 552)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "COM PORT:"
        '
        'lstPorts
        '
        Me.lstPorts.FormattingEnabled = True
        Me.lstPorts.Location = New System.Drawing.Point(6, 25)
        Me.lstPorts.Name = "lstPorts"
        Me.lstPorts.Size = New System.Drawing.Size(280, 28)
        Me.lstPorts.TabIndex = 1
        '
        'BTConnect
        '
        Me.BTConnect.BackColor = System.Drawing.Color.Black
        Me.BTConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTConnect.ForeColor = System.Drawing.Color.White
        Me.BTConnect.Location = New System.Drawing.Point(383, 99)
        Me.BTConnect.Name = "BTConnect"
        Me.BTConnect.Size = New System.Drawing.Size(102, 35)
        Me.BTConnect.TabIndex = 0
        Me.BTConnect.Text = "Connect"
        Me.BTConnect.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lstConsole)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(54, 338)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 312)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Serial Monitor"
        '
        'lstConsole
        '
        Me.lstConsole.BackColor = System.Drawing.SystemColors.Window
        Me.lstConsole.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstConsole.FormattingEnabled = True
        Me.lstConsole.ItemHeight = 20
        Me.lstConsole.Location = New System.Drawing.Point(6, 20)
        Me.lstConsole.Name = "lstConsole"
        Me.lstConsole.ScrollAlwaysVisible = True
        Me.lstConsole.Size = New System.Drawing.Size(435, 284)
        Me.lstConsole.TabIndex = 0
        '
        'BTTest
        '
        Me.BTTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTTest.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTTest.Location = New System.Drawing.Point(401, 170)
        Me.BTTest.Name = "BTTest"
        Me.BTTest.Size = New System.Drawing.Size(84, 33)
        Me.BTTest.TabIndex = 3
        Me.BTTest.Text = "Bluetooth Test"
        Me.BTTest.UseVisualStyleBackColor = True
        '
        'BTforward
        '
        Me.BTforward.BackgroundImage = Global.BTController.My.Resources.Resources.seta_cima
        Me.BTforward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTforward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTforward.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTforward.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTforward.Location = New System.Drawing.Point(117, 209)
        Me.BTforward.Name = "BTforward"
        Me.BTforward.Size = New System.Drawing.Size(40, 40)
        Me.BTforward.TabIndex = 4
        Me.BTforward.UseVisualStyleBackColor = True
        '
        'BTleft
        '
        Me.BTleft.BackColor = System.Drawing.Color.Black
        Me.BTleft.BackgroundImage = Global.BTController.My.Resources.Resources.seta_esquerda
        Me.BTleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTleft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTleft.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTleft.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTleft.Location = New System.Drawing.Point(73, 251)
        Me.BTleft.Name = "BTleft"
        Me.BTleft.Size = New System.Drawing.Size(40, 40)
        Me.BTleft.TabIndex = 5
        Me.BTleft.UseVisualStyleBackColor = False
        '
        'BTright
        '
        Me.BTright.BackColor = System.Drawing.Color.Black
        Me.BTright.BackgroundImage = Global.BTController.My.Resources.Resources.seta_direita
        Me.BTright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTright.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTright.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTright.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTright.Location = New System.Drawing.Point(161, 251)
        Me.BTright.Name = "BTright"
        Me.BTright.Size = New System.Drawing.Size(40, 40)
        Me.BTright.TabIndex = 6
        Me.BTright.UseVisualStyleBackColor = False
        '
        'BTbackward
        '
        Me.BTbackward.BackgroundImage = Global.BTController.My.Resources.Resources.seta_baixo
        Me.BTbackward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTbackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTbackward.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTbackward.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTbackward.Location = New System.Drawing.Point(117, 294)
        Me.BTbackward.Name = "BTbackward"
        Me.BTbackward.Size = New System.Drawing.Size(40, 40)
        Me.BTbackward.TabIndex = 7
        Me.BTbackward.UseVisualStyleBackColor = True
        '
        'BTstop
        '
        Me.BTstop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTstop.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTstop.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTstop.Location = New System.Drawing.Point(117, 251)
        Me.BTstop.Name = "BTstop"
        Me.BTstop.Size = New System.Drawing.Size(40, 40)
        Me.BTstop.TabIndex = 8
        Me.BTstop.Text = "S"
        Me.BTstop.UseVisualStyleBackColor = True
        '
        'BTquit
        '
        Me.BTquit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTquit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTquit.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTquit.Location = New System.Drawing.Point(426, 654)
        Me.BTquit.Name = "BTquit"
        Me.BTquit.Size = New System.Drawing.Size(75, 23)
        Me.BTquit.TabIndex = 9
        Me.BTquit.Text = "Quit"
        Me.BTquit.UseVisualStyleBackColor = True
        '
        'BTBuzz
        '
        Me.BTBuzz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTBuzz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTBuzz.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.BTBuzz.Location = New System.Drawing.Point(91, 170)
        Me.BTBuzz.Name = "BTBuzz"
        Me.BTBuzz.Size = New System.Drawing.Size(87, 33)
        Me.BTBuzz.TabIndex = 10
        Me.BTBuzz.Text = "Buzz!!"
        Me.BTBuzz.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 2000
        '
        'TrackBar1
        '
        Me.TrackBar1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TrackBar1.Location = New System.Drawing.Point(10, 18)
        Me.TrackBar1.Maximum = 11
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(178, 45)
        Me.TrackBar1.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.TrackBar1)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(291, 224)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 77)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Velocity"
        '
        'btForwR
        '
        Me.btForwR.BackgroundImage = Global.BTController.My.Resources.Resources.seta_cima_direita
        Me.btForwR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btForwR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btForwR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btForwR.Location = New System.Drawing.Point(161, 209)
        Me.btForwR.Name = "btForwR"
        Me.btForwR.Size = New System.Drawing.Size(40, 40)
        Me.btForwR.TabIndex = 15
        Me.btForwR.UseVisualStyleBackColor = True
        '
        'btForwL
        '
        Me.btForwL.BackgroundImage = Global.BTController.My.Resources.Resources.seta_cima_esquerda
        Me.btForwL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btForwL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btForwL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btForwL.Location = New System.Drawing.Point(73, 209)
        Me.btForwL.Name = "btForwL"
        Me.btForwL.Size = New System.Drawing.Size(40, 40)
        Me.btForwL.TabIndex = 16
        Me.btForwL.UseVisualStyleBackColor = True
        '
        'btBackL
        '
        Me.btBackL.BackgroundImage = Global.BTController.My.Resources.Resources.seta_baixo_esquerda
        Me.btBackL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBackL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBackL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btBackL.Location = New System.Drawing.Point(73, 294)
        Me.btBackL.Name = "btBackL"
        Me.btBackL.Size = New System.Drawing.Size(40, 40)
        Me.btBackL.TabIndex = 17
        Me.btBackL.UseVisualStyleBackColor = True
        '
        'btBackR
        '
        Me.btBackR.BackgroundImage = Global.BTController.My.Resources.Resources.seta_baixo_direita
        Me.btBackR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btBackR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btBackR.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btBackR.Location = New System.Drawing.Point(161, 294)
        Me.btBackR.Name = "btBackR"
        Me.btBackR.Size = New System.Drawing.Size(40, 40)
        Me.btBackR.TabIndex = 18
        Me.btBackR.UseVisualStyleBackColor = True
        '
        'chbAutonomouz
        '
        Me.chbAutonomouz.AutoSize = True
        Me.chbAutonomouz.BackColor = System.Drawing.Color.Transparent
        Me.chbAutonomouz.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbAutonomouz.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.chbAutonomouz.Location = New System.Drawing.Point(229, 177)
        Me.chbAutonomouz.Name = "chbAutonomouz"
        Me.chbAutonomouz.Size = New System.Drawing.Size(111, 20)
        Me.chbAutonomouz.TabIndex = 19
        Me.chbAutonomouz.Text = "Autonomouz"
        Me.chbAutonomouz.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 29)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Robotonomouz 205 2.0"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(546, 24)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjudaToolStripMenuItem
        '
        Me.AjudaToolStripMenuItem.Name = "AjudaToolStripMenuItem"
        Me.AjudaToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.AjudaToolStripMenuItem.Text = "Help"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.BTController.My.Resources.Resources.fundo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(546, 680)
        Me.Controls.Add(Me.BTrefresh)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chbAutonomouz)
        Me.Controls.Add(Me.btBackR)
        Me.Controls.Add(Me.BTConnect)
        Me.Controls.Add(Me.btBackL)
        Me.Controls.Add(Me.btForwL)
        Me.Controls.Add(Me.btForwR)
        Me.Controls.Add(Me.GroupBox3)
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
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "BTController"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents TrackBar1 As TrackBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btForwR As Button
    Friend WithEvents btForwL As Button
    Friend WithEvents btBackL As Button
    Friend WithEvents btBackR As Button
    Friend WithEvents chbAutonomouz As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AjudaToolStripMenuItem As ToolStripMenuItem
End Class
