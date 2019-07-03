<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPTController
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
        Me.GroupBoxComModel = New System.Windows.Forms.GroupBox
        Me.BtnOpen = New System.Windows.Forms.Button
        Me.RadioBtnEtheByIP = New System.Windows.Forms.RadioButton
        Me.LabelIPAddr = New System.Windows.Forms.Label
        Me.LabelSN = New System.Windows.Forms.Label
        Me.RadioBtnByIP = New System.Windows.Forms.RadioButton
        Me.LabelEXIPAddr = New System.Windows.Forms.Label
        Me.LabelEXSN = New System.Windows.Forms.Label
        Me.TextBoxIPAddr = New System.Windows.Forms.TextBox
        Me.LabelEXSPort = New System.Windows.Forms.Label
        Me.TextBoxSN = New System.Windows.Forms.TextBox
        Me.TextBoxSPort = New System.Windows.Forms.TextBox
        Me.LabelSPort = New System.Windows.Forms.Label
        Me.RadioBtnSPort = New System.Windows.Forms.RadioButton
        Me.GroupBoxOperator = New System.Windows.Forms.GroupBox
        Me.BTNHBTriggerWidth = New System.Windows.Forms.Button
        Me.BTNTriggerWidth = New System.Windows.Forms.Button
        Me.BtnSetIntensity = New System.Windows.Forms.Button
        Me.BtnCloseChannel = New System.Windows.Forms.Button
        Me.BtnOpenChannel = New System.Windows.Forms.Button
        Me.TextBoxHBTriggerWidth = New System.Windows.Forms.TextBox
        Me.TextBoxTriggerWidth = New System.Windows.Forms.TextBox
        Me.TextBoxIntensity = New System.Windows.Forms.TextBox
        Me.TextBoxChannelIndex = New System.Windows.Forms.TextBox
        Me.LabelChannelIndex = New System.Windows.Forms.Label
        Me.LabelHBTriggerWidth = New System.Windows.Forms.Label
        Me.LabelTriggerWidth = New System.Windows.Forms.Label
        Me.LabelIntensity = New System.Windows.Forms.Label
        Me.LabelIndexRange = New System.Windows.Forms.Label
        Me.LabelStatus = New System.Windows.Forms.Label
        Me.TextBoxStatus = New System.Windows.Forms.TextBox
        Me.BtnRead = New System.Windows.Forms.Button
        Me.GroupBox_SEQ = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Btn_ReadSEQTable = New System.Windows.Forms.Button
        Me.btn_SetSEQTable = New System.Windows.Forms.Button
        Me.TextBox_ModuleIndex = New System.Windows.Forms.TextBox
        Me.Label_ModuleIndex = New System.Windows.Forms.Label
        Me.GroupBox_SEQTriggerMode = New System.Windows.Forms.GroupBox
        Me.Btn_setTriggerMode = New System.Windows.Forms.Button
        Me.RadioButton_Programmable = New System.Windows.Forms.RadioButton
        Me.RadioButton_General = New System.Windows.Forms.RadioButton
        Me.GroupBoxComModel.SuspendLayout()
        Me.GroupBoxOperator.SuspendLayout()
        Me.GroupBox_SEQ.SuspendLayout()
        Me.GroupBox_SEQTriggerMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxComModel
        '
        Me.GroupBoxComModel.Controls.Add(Me.BtnOpen)
        Me.GroupBoxComModel.Controls.Add(Me.RadioBtnEtheByIP)
        Me.GroupBoxComModel.Controls.Add(Me.LabelIPAddr)
        Me.GroupBoxComModel.Controls.Add(Me.LabelSN)
        Me.GroupBoxComModel.Controls.Add(Me.RadioBtnByIP)
        Me.GroupBoxComModel.Controls.Add(Me.LabelEXIPAddr)
        Me.GroupBoxComModel.Controls.Add(Me.LabelEXSN)
        Me.GroupBoxComModel.Controls.Add(Me.TextBoxIPAddr)
        Me.GroupBoxComModel.Controls.Add(Me.LabelEXSPort)
        Me.GroupBoxComModel.Controls.Add(Me.TextBoxSN)
        Me.GroupBoxComModel.Controls.Add(Me.TextBoxSPort)
        Me.GroupBoxComModel.Controls.Add(Me.LabelSPort)
        Me.GroupBoxComModel.Controls.Add(Me.RadioBtnSPort)
        Me.GroupBoxComModel.Location = New System.Drawing.Point(9, 10)
        Me.GroupBoxComModel.Name = "GroupBoxComModel"
        Me.GroupBoxComModel.Size = New System.Drawing.Size(394, 206)
        Me.GroupBoxComModel.TabIndex = 0
        Me.GroupBoxComModel.TabStop = False
        Me.GroupBoxComModel.Text = "Communication Model"
        '
        'BtnOpen
        '
        Me.BtnOpen.Location = New System.Drawing.Point(11, 177)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(75, 23)
        Me.BtnOpen.TabIndex = 7
        Me.BtnOpen.Text = "Connect"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'RadioBtnEtheByIP
        '
        Me.RadioBtnEtheByIP.AutoSize = True
        Me.RadioBtnEtheByIP.Location = New System.Drawing.Point(22, 117)
        Me.RadioBtnEtheByIP.Name = "RadioBtnEtheByIP"
        Me.RadioBtnEtheByIP.Size = New System.Drawing.Size(191, 16)
        Me.RadioBtnEtheByIP.TabIndex = 6
        Me.RadioBtnEtheByIP.TabStop = True
        Me.RadioBtnEtheByIP.Text = "Ethernet Communication By IP"
        Me.RadioBtnEtheByIP.UseVisualStyleBackColor = True
        '
        'LabelIPAddr
        '
        Me.LabelIPAddr.AutoSize = True
        Me.LabelIPAddr.Location = New System.Drawing.Point(36, 147)
        Me.LabelIPAddr.Name = "LabelIPAddr"
        Me.LabelIPAddr.Size = New System.Drawing.Size(71, 12)
        Me.LabelIPAddr.TabIndex = 5
        Me.LabelIPAddr.Text = "IP Address:"
        '
        'LabelSN
        '
        Me.LabelSN.AutoSize = True
        Me.LabelSN.Location = New System.Drawing.Point(36, 90)
        Me.LabelSN.Name = "LabelSN"
        Me.LabelSN.Size = New System.Drawing.Size(23, 12)
        Me.LabelSN.TabIndex = 5
        Me.LabelSN.Text = "SN:"
        '
        'RadioBtnByIP
        '
        Me.RadioBtnByIP.AutoSize = True
        Me.RadioBtnByIP.Location = New System.Drawing.Point(22, 71)
        Me.RadioBtnByIP.Name = "RadioBtnByIP"
        Me.RadioBtnByIP.Size = New System.Drawing.Size(191, 16)
        Me.RadioBtnByIP.TabIndex = 4
        Me.RadioBtnByIP.TabStop = True
        Me.RadioBtnByIP.Text = "Ethernet Communication By SN"
        Me.RadioBtnByIP.UseVisualStyleBackColor = True
        '
        'LabelEXIPAddr
        '
        Me.LabelEXIPAddr.AutoSize = True
        Me.LabelEXIPAddr.Location = New System.Drawing.Point(246, 147)
        Me.LabelEXIPAddr.Name = "LabelEXIPAddr"
        Me.LabelEXIPAddr.Size = New System.Drawing.Size(137, 12)
        Me.LabelEXIPAddr.TabIndex = 3
        Me.LabelEXIPAddr.Text = "(e.g.:""192.168.18.10"")"
        '
        'LabelEXSN
        '
        Me.LabelEXSN.AutoSize = True
        Me.LabelEXSN.Location = New System.Drawing.Point(246, 90)
        Me.LabelEXSN.Name = "LabelEXSN"
        Me.LabelEXSN.Size = New System.Drawing.Size(113, 12)
        Me.LabelEXSN.TabIndex = 3
        Me.LabelEXSN.Text = "(e.g.""ffffffff01"")"
        '
        'TextBoxIPAddr
        '
        Me.TextBoxIPAddr.Location = New System.Drawing.Point(143, 144)
        Me.TextBoxIPAddr.Name = "TextBoxIPAddr"
        Me.TextBoxIPAddr.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxIPAddr.TabIndex = 2
        '
        'LabelEXSPort
        '
        Me.LabelEXSPort.AutoSize = True
        Me.LabelEXSPort.Location = New System.Drawing.Point(246, 44)
        Me.LabelEXSPort.Name = "LabelEXSPort"
        Me.LabelEXSPort.Size = New System.Drawing.Size(83, 12)
        Me.LabelEXSPort.TabIndex = 3
        Me.LabelEXSPort.Text = "(e.g.:""COM1"")"
        '
        'TextBoxSN
        '
        Me.TextBoxSN.Location = New System.Drawing.Point(143, 87)
        Me.TextBoxSN.Name = "TextBoxSN"
        Me.TextBoxSN.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSN.TabIndex = 2
        '
        'TextBoxSPort
        '
        Me.TextBoxSPort.Location = New System.Drawing.Point(143, 41)
        Me.TextBoxSPort.Name = "TextBoxSPort"
        Me.TextBoxSPort.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxSPort.TabIndex = 2
        '
        'LabelSPort
        '
        Me.LabelSPort.AutoSize = True
        Me.LabelSPort.Location = New System.Drawing.Point(36, 44)
        Me.LabelSPort.Name = "LabelSPort"
        Me.LabelSPort.Size = New System.Drawing.Size(101, 12)
        Me.LabelSPort.TabIndex = 1
        Me.LabelSPort.Text = "SerialPort Name:"
        '
        'RadioBtnSPort
        '
        Me.RadioBtnSPort.AutoSize = True
        Me.RadioBtnSPort.Checked = True
        Me.RadioBtnSPort.Location = New System.Drawing.Point(22, 21)
        Me.RadioBtnSPort.Name = "RadioBtnSPort"
        Me.RadioBtnSPort.Size = New System.Drawing.Size(167, 16)
        Me.RadioBtnSPort.TabIndex = 0
        Me.RadioBtnSPort.TabStop = True
        Me.RadioBtnSPort.Text = "SerialPort Communication"
        Me.RadioBtnSPort.UseVisualStyleBackColor = True
        '
        'GroupBoxOperator
        '
        Me.GroupBoxOperator.Controls.Add(Me.BTNHBTriggerWidth)
        Me.GroupBoxOperator.Controls.Add(Me.BTNTriggerWidth)
        Me.GroupBoxOperator.Controls.Add(Me.BtnSetIntensity)
        Me.GroupBoxOperator.Controls.Add(Me.BtnCloseChannel)
        Me.GroupBoxOperator.Controls.Add(Me.BtnOpenChannel)
        Me.GroupBoxOperator.Controls.Add(Me.TextBoxHBTriggerWidth)
        Me.GroupBoxOperator.Controls.Add(Me.TextBoxTriggerWidth)
        Me.GroupBoxOperator.Controls.Add(Me.TextBoxIntensity)
        Me.GroupBoxOperator.Controls.Add(Me.TextBoxChannelIndex)
        Me.GroupBoxOperator.Controls.Add(Me.LabelChannelIndex)
        Me.GroupBoxOperator.Controls.Add(Me.LabelHBTriggerWidth)
        Me.GroupBoxOperator.Controls.Add(Me.LabelTriggerWidth)
        Me.GroupBoxOperator.Controls.Add(Me.LabelIntensity)
        Me.GroupBoxOperator.Controls.Add(Me.LabelIndexRange)
        Me.GroupBoxOperator.Location = New System.Drawing.Point(9, 222)
        Me.GroupBoxOperator.Name = "GroupBoxOperator"
        Me.GroupBoxOperator.Size = New System.Drawing.Size(394, 209)
        Me.GroupBoxOperator.TabIndex = 1
        Me.GroupBoxOperator.TabStop = False
        Me.GroupBoxOperator.Text = "Controller Operations"
        '
        'BTNHBTriggerWidth
        '
        Me.BTNHBTriggerWidth.Location = New System.Drawing.Point(11, 145)
        Me.BTNHBTriggerWidth.Name = "BTNHBTriggerWidth"
        Me.BTNHBTriggerWidth.Size = New System.Drawing.Size(125, 23)
        Me.BTNHBTriggerWidth.TabIndex = 5
        Me.BTNHBTriggerWidth.Text = "Set HBTriggerWidth"
        Me.BTNHBTriggerWidth.UseVisualStyleBackColor = True
        '
        'BTNTriggerWidth
        '
        Me.BTNTriggerWidth.Location = New System.Drawing.Point(11, 116)
        Me.BTNTriggerWidth.Name = "BTNTriggerWidth"
        Me.BTNTriggerWidth.Size = New System.Drawing.Size(125, 23)
        Me.BTNTriggerWidth.TabIndex = 5
        Me.BTNTriggerWidth.Text = "Set TriggerWidth"
        Me.BTNTriggerWidth.UseVisualStyleBackColor = True
        '
        'BtnSetIntensity
        '
        Me.BtnSetIntensity.Location = New System.Drawing.Point(11, 88)
        Me.BtnSetIntensity.Name = "BtnSetIntensity"
        Me.BtnSetIntensity.Size = New System.Drawing.Size(125, 23)
        Me.BtnSetIntensity.TabIndex = 5
        Me.BtnSetIntensity.Text = "Set Intensity"
        Me.BtnSetIntensity.UseVisualStyleBackColor = True
        '
        'BtnCloseChannel
        '
        Me.BtnCloseChannel.Location = New System.Drawing.Point(204, 47)
        Me.BtnCloseChannel.Name = "BtnCloseChannel"
        Me.BtnCloseChannel.Size = New System.Drawing.Size(125, 23)
        Me.BtnCloseChannel.TabIndex = 4
        Me.BtnCloseChannel.Text = "TurnOffChannel"
        Me.BtnCloseChannel.UseVisualStyleBackColor = True
        '
        'BtnOpenChannel
        '
        Me.BtnOpenChannel.Location = New System.Drawing.Point(11, 47)
        Me.BtnOpenChannel.Name = "BtnOpenChannel"
        Me.BtnOpenChannel.Size = New System.Drawing.Size(125, 23)
        Me.BtnOpenChannel.TabIndex = 4
        Me.BtnOpenChannel.Text = "TurnOnChannel"
        Me.BtnOpenChannel.UseVisualStyleBackColor = True
        '
        'TextBoxHBTriggerWidth
        '
        Me.TextBoxHBTriggerWidth.Location = New System.Drawing.Point(137, 146)
        Me.TextBoxHBTriggerWidth.Name = "TextBoxHBTriggerWidth"
        Me.TextBoxHBTriggerWidth.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxHBTriggerWidth.TabIndex = 1
        Me.TextBoxHBTriggerWidth.Text = "255"
        Me.TextBoxHBTriggerWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxTriggerWidth
        '
        Me.TextBoxTriggerWidth.Location = New System.Drawing.Point(137, 118)
        Me.TextBoxTriggerWidth.Name = "TextBoxTriggerWidth"
        Me.TextBoxTriggerWidth.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxTriggerWidth.TabIndex = 1
        Me.TextBoxTriggerWidth.Text = "100"
        Me.TextBoxTriggerWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxIntensity
        '
        Me.TextBoxIntensity.Location = New System.Drawing.Point(137, 88)
        Me.TextBoxIntensity.Name = "TextBoxIntensity"
        Me.TextBoxIntensity.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxIntensity.TabIndex = 1
        Me.TextBoxIntensity.Text = "255"
        Me.TextBoxIntensity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxChannelIndex
        '
        Me.TextBoxChannelIndex.Location = New System.Drawing.Point(137, 19)
        Me.TextBoxChannelIndex.Name = "TextBoxChannelIndex"
        Me.TextBoxChannelIndex.Size = New System.Drawing.Size(100, 21)
        Me.TextBoxChannelIndex.TabIndex = 1
        Me.TextBoxChannelIndex.Text = "0"
        Me.TextBoxChannelIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelChannelIndex
        '
        Me.LabelChannelIndex.AutoSize = True
        Me.LabelChannelIndex.Location = New System.Drawing.Point(20, 22)
        Me.LabelChannelIndex.Name = "LabelChannelIndex"
        Me.LabelChannelIndex.Size = New System.Drawing.Size(89, 12)
        Me.LabelChannelIndex.TabIndex = 0
        Me.LabelChannelIndex.Text = "Channel Index:"
        '
        'LabelHBTriggerWidth
        '
        Me.LabelHBTriggerWidth.AutoSize = True
        Me.LabelHBTriggerWidth.Location = New System.Drawing.Point(254, 150)
        Me.LabelHBTriggerWidth.Name = "LabelHBTriggerWidth"
        Me.LabelHBTriggerWidth.Size = New System.Drawing.Size(83, 12)
        Me.LabelHBTriggerWidth.TabIndex = 3
        Me.LabelHBTriggerWidth.Text = "(Range:1-500)"
        '
        'LabelTriggerWidth
        '
        Me.LabelTriggerWidth.AutoSize = True
        Me.LabelTriggerWidth.Location = New System.Drawing.Point(254, 123)
        Me.LabelTriggerWidth.Name = "LabelTriggerWidth"
        Me.LabelTriggerWidth.Size = New System.Drawing.Size(89, 12)
        Me.LabelTriggerWidth.TabIndex = 3
        Me.LabelTriggerWidth.Text = "(Range:1-1023)"
        '
        'LabelIntensity
        '
        Me.LabelIntensity.AutoSize = True
        Me.LabelIntensity.Location = New System.Drawing.Point(254, 92)
        Me.LabelIntensity.Name = "LabelIntensity"
        Me.LabelIntensity.Size = New System.Drawing.Size(83, 12)
        Me.LabelIntensity.TabIndex = 3
        Me.LabelIntensity.Text = "(Range:0-255)"
        '
        'LabelIndexRange
        '
        Me.LabelIndexRange.AutoSize = True
        Me.LabelIndexRange.Location = New System.Drawing.Point(254, 23)
        Me.LabelIndexRange.Name = "LabelIndexRange"
        Me.LabelIndexRange.Size = New System.Drawing.Size(77, 12)
        Me.LabelIndexRange.TabIndex = 3
        Me.LabelIndexRange.Text = "(Range:0-16)"
        '
        'LabelStatus
        '
        Me.LabelStatus.AutoSize = True
        Me.LabelStatus.Location = New System.Drawing.Point(21, 621)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(47, 12)
        Me.LabelStatus.TabIndex = 2
        Me.LabelStatus.Text = "Status:"
        '
        'TextBoxStatus
        '
        Me.TextBoxStatus.Location = New System.Drawing.Point(79, 618)
        Me.TextBoxStatus.Name = "TextBoxStatus"
        Me.TextBoxStatus.ReadOnly = True
        Me.TextBoxStatus.Size = New System.Drawing.Size(324, 21)
        Me.TextBoxStatus.TabIndex = 5
        '
        'BtnRead
        '
        Me.BtnRead.Location = New System.Drawing.Point(20, 397)
        Me.BtnRead.Name = "BtnRead"
        Me.BtnRead.Size = New System.Drawing.Size(125, 23)
        Me.BtnRead.TabIndex = 7
        Me.BtnRead.Text = "SetMultiChannel"
        Me.BtnRead.UseVisualStyleBackColor = True
        '
        'GroupBox_SEQ
        '
        Me.GroupBox_SEQ.Controls.Add(Me.Label1)
        Me.GroupBox_SEQ.Controls.Add(Me.Btn_ReadSEQTable)
        Me.GroupBox_SEQ.Controls.Add(Me.btn_SetSEQTable)
        Me.GroupBox_SEQ.Controls.Add(Me.TextBox_ModuleIndex)
        Me.GroupBox_SEQ.Controls.Add(Me.Label_ModuleIndex)
        Me.GroupBox_SEQ.Controls.Add(Me.GroupBox_SEQTriggerMode)
        Me.GroupBox_SEQ.Location = New System.Drawing.Point(9, 437)
        Me.GroupBox_SEQ.Name = "GroupBox_SEQ"
        Me.GroupBox_SEQ.Size = New System.Drawing.Size(394, 166)
        Me.GroupBox_SEQ.TabIndex = 8
        Me.GroupBox_SEQ.TabStop = False
        Me.GroupBox_SEQ.Text = "SEQ Operation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(238, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Range[1-4]"
        '
        'Btn_ReadSEQTable
        '
        Me.Btn_ReadSEQTable.Location = New System.Drawing.Point(235, 125)
        Me.Btn_ReadSEQTable.Name = "Btn_ReadSEQTable"
        Me.Btn_ReadSEQTable.Size = New System.Drawing.Size(102, 23)
        Me.Btn_ReadSEQTable.TabIndex = 3
        Me.Btn_ReadSEQTable.Text = "Read SEQ Table"
        Me.Btn_ReadSEQTable.UseVisualStyleBackColor = True
        '
        'btn_SetSEQTable
        '
        Me.btn_SetSEQTable.Location = New System.Drawing.Point(22, 125)
        Me.btn_SetSEQTable.Name = "btn_SetSEQTable"
        Me.btn_SetSEQTable.Size = New System.Drawing.Size(114, 23)
        Me.btn_SetSEQTable.TabIndex = 3
        Me.btn_SetSEQTable.Text = "Set SEQ Table"
        Me.btn_SetSEQTable.UseVisualStyleBackColor = True
        '
        'TextBox_ModuleIndex
        '
        Me.TextBox_ModuleIndex.Location = New System.Drawing.Point(132, 98)
        Me.TextBox_ModuleIndex.Name = "TextBox_ModuleIndex"
        Me.TextBox_ModuleIndex.Size = New System.Drawing.Size(100, 21)
        Me.TextBox_ModuleIndex.TabIndex = 2
        Me.TextBox_ModuleIndex.Text = "1"
        Me.TextBox_ModuleIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label_ModuleIndex
        '
        Me.Label_ModuleIndex.AutoSize = True
        Me.Label_ModuleIndex.Location = New System.Drawing.Point(23, 101)
        Me.Label_ModuleIndex.Name = "Label_ModuleIndex"
        Me.Label_ModuleIndex.Size = New System.Drawing.Size(77, 12)
        Me.Label_ModuleIndex.TabIndex = 1
        Me.Label_ModuleIndex.Text = "ModuleIndex:"
        '
        'GroupBox_SEQTriggerMode
        '
        Me.GroupBox_SEQTriggerMode.Controls.Add(Me.Btn_setTriggerMode)
        Me.GroupBox_SEQTriggerMode.Controls.Add(Me.RadioButton_Programmable)
        Me.GroupBox_SEQTriggerMode.Controls.Add(Me.RadioButton_General)
        Me.GroupBox_SEQTriggerMode.Location = New System.Drawing.Point(11, 21)
        Me.GroupBox_SEQTriggerMode.Name = "GroupBox_SEQTriggerMode"
        Me.GroupBox_SEQTriggerMode.Size = New System.Drawing.Size(372, 73)
        Me.GroupBox_SEQTriggerMode.TabIndex = 0
        Me.GroupBox_SEQTriggerMode.TabStop = False
        Me.GroupBox_SEQTriggerMode.Text = "Set Trigger Mode"
        '
        'Btn_setTriggerMode
        '
        Me.Btn_setTriggerMode.Location = New System.Drawing.Point(224, 39)
        Me.Btn_setTriggerMode.Name = "Btn_setTriggerMode"
        Me.Btn_setTriggerMode.Size = New System.Drawing.Size(102, 23)
        Me.Btn_setTriggerMode.TabIndex = 1
        Me.Btn_setTriggerMode.Text = "SetTriggerMode"
        Me.Btn_setTriggerMode.UseVisualStyleBackColor = True
        '
        'RadioButton_Programmable
        '
        Me.RadioButton_Programmable.AutoSize = True
        Me.RadioButton_Programmable.Location = New System.Drawing.Point(11, 46)
        Me.RadioButton_Programmable.Name = "RadioButton_Programmable"
        Me.RadioButton_Programmable.Size = New System.Drawing.Size(173, 16)
        Me.RadioButton_Programmable.TabIndex = 0
        Me.RadioButton_Programmable.Text = "Programmable Trigger Mode"
        Me.RadioButton_Programmable.UseVisualStyleBackColor = True
        '
        'RadioButton_General
        '
        Me.RadioButton_General.AutoSize = True
        Me.RadioButton_General.Checked = True
        Me.RadioButton_General.Location = New System.Drawing.Point(11, 20)
        Me.RadioButton_General.Name = "RadioButton_General"
        Me.RadioButton_General.Size = New System.Drawing.Size(143, 16)
        Me.RadioButton_General.TabIndex = 0
        Me.RadioButton_General.TabStop = True
        Me.RadioButton_General.Text = "General Trigger Mode"
        Me.RadioButton_General.UseVisualStyleBackColor = True
        '
        'OPTController
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 654)
        Me.Controls.Add(Me.GroupBox_SEQ)
        Me.Controls.Add(Me.BtnRead)
        Me.Controls.Add(Me.TextBoxStatus)
        Me.Controls.Add(Me.LabelStatus)
        Me.Controls.Add(Me.GroupBoxOperator)
        Me.Controls.Add(Me.GroupBoxComModel)
        Me.Name = "OPTController"
        Me.Text = "OPTController                                   "
        Me.GroupBoxComModel.ResumeLayout(False)
        Me.GroupBoxComModel.PerformLayout()
        Me.GroupBoxOperator.ResumeLayout(False)
        Me.GroupBoxOperator.PerformLayout()
        Me.GroupBox_SEQ.ResumeLayout(False)
        Me.GroupBox_SEQ.PerformLayout()
        Me.GroupBox_SEQTriggerMode.ResumeLayout(False)
        Me.GroupBox_SEQTriggerMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxComModel As System.Windows.Forms.GroupBox
    Friend WithEvents RadioBtnSPort As System.Windows.Forms.RadioButton
    Friend WithEvents LabelSPort As System.Windows.Forms.Label
    Friend WithEvents LabelSN As System.Windows.Forms.Label
    Friend WithEvents RadioBtnByIP As System.Windows.Forms.RadioButton
    Friend WithEvents LabelEXSPort As System.Windows.Forms.Label
    Friend WithEvents TextBoxSN As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxSPort As System.Windows.Forms.TextBox
    Friend WithEvents BtnOpen As System.Windows.Forms.Button
    Friend WithEvents RadioBtnEtheByIP As System.Windows.Forms.RadioButton
    Friend WithEvents LabelIPAddr As System.Windows.Forms.Label
    Friend WithEvents LabelEXIPAddr As System.Windows.Forms.Label
    Friend WithEvents LabelEXSN As System.Windows.Forms.Label
    Friend WithEvents TextBoxIPAddr As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxOperator As System.Windows.Forms.GroupBox
    Friend WithEvents LabelChannelIndex As System.Windows.Forms.Label
    Friend WithEvents BtnSetIntensity As System.Windows.Forms.Button
    Friend WithEvents BtnCloseChannel As System.Windows.Forms.Button
    Friend WithEvents BtnOpenChannel As System.Windows.Forms.Button
    Friend WithEvents TextBoxChannelIndex As System.Windows.Forms.TextBox
    Friend WithEvents LabelIndexRange As System.Windows.Forms.Label
    Friend WithEvents TextBoxIntensity As System.Windows.Forms.TextBox
    Friend WithEvents LabelIntensity As System.Windows.Forms.Label
    Friend WithEvents LabelStatus As System.Windows.Forms.Label
    Friend WithEvents TextBoxStatus As System.Windows.Forms.TextBox
    Friend WithEvents BTNHBTriggerWidth As System.Windows.Forms.Button
    Friend WithEvents BTNTriggerWidth As System.Windows.Forms.Button
    Friend WithEvents TextBoxHBTriggerWidth As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTriggerWidth As System.Windows.Forms.TextBox
    Friend WithEvents LabelHBTriggerWidth As System.Windows.Forms.Label
    Friend WithEvents LabelTriggerWidth As System.Windows.Forms.Label
    Friend WithEvents BtnRead As System.Windows.Forms.Button
    Friend WithEvents GroupBox_SEQ As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox_SEQTriggerMode As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton_Programmable As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_General As System.Windows.Forms.RadioButton
    Friend WithEvents Label_ModuleIndex As System.Windows.Forms.Label
    Friend WithEvents Btn_setTriggerMode As System.Windows.Forms.Button
    Friend WithEvents Btn_ReadSEQTable As System.Windows.Forms.Button
    Friend WithEvents btn_SetSEQTable As System.Windows.Forms.Button
    Friend WithEvents TextBox_ModuleIndex As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
