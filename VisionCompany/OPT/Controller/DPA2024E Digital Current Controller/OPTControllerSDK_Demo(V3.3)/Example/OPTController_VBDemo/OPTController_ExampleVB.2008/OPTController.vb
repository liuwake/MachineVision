Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text

Public Class OPTController
    Public Enum OPT_COMMUNICATION_nModel
        COMMUNICATION_BY_COM = 0
        COMMUNICATION_BY_SN = 1
        COMMUNICATION_BY_IP = 2
    End Enum
    'Initialization
    Private nModel As OPT_COMMUNICATION_nModel = OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_COM
    Private serialPortName As String
    Private IPAddr As String
    Private SN As String
    Private controllerHandle As OPTControllerAPI.OPTControllerHandleType

    Dim strIndex As String = ""
    Dim strIntensity As String = ""
    Dim isConnect As Boolean = False
    Dim strTriggerWidth As String = ""
    Dim strHBTriggerWidth As String = ""

    Private Sub BtnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpen.Click
        ' Create a connection
        serialPortName = TextBoxSPort.Text
        SN = TextBoxSN.Text
        IPAddr = TextBoxIPAddr.Text
        Dim nRet As Integer = -1
        If "Connect" = BtnOpen.Text Then
            If 0 = nModel Then
                nRet = OPTControllerAPI.OPTController_InitSerialPort(serialPortName, controllerHandle)
                If 0 <> nRet Then
                    TextBoxStatus.Text = "Failed to initialize serial port!"
                    Return
                Else
                    TextBoxStatus.Text = "Succeed"
                End If
                BtnOpen.Text = "Disconnect"
                RadioBtnSPort.Enabled = False
                TextBoxSPort.Enabled = False
                RadioBtnEtheByIP.Enabled = False
                TextBoxIPAddr.Enabled = False
                RadioBtnByIP.Enabled = False
                TextBoxSN.Enabled = False
                isConnect = True
            End If
            If OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_SN = nModel Then
                nRet = OPTControllerAPI.OPTController_CreateEthernetConnectionBySN(SN, controllerHandle)
                If 0 <> nRet Then
                    TextBoxStatus.Text = "Failed to create Ethernet connection by SN!"
                    Return
                Else
                    TextBoxStatus.Text = "Succeed"
                End If
                BtnOpen.Text = "Disconnect"
                RadioBtnSPort.Enabled = False
                TextBoxSPort.Enabled = False
                RadioBtnEtheByIP.Enabled = False
                TextBoxIPAddr.Enabled = False
                RadioBtnByIP.Enabled = False
                TextBoxSN.Enabled = False
                isConnect = True
            End If
            If OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_IP = nModel Then
                nRet = OPTControllerAPI.OPTController_CreateEthernetConnectionByIP(IPAddr, controllerHandle)
                If 0 <> nRet Then
                    TextBoxStatus.Text = "Failed to create Ethernet connection by IP!"
                    Return
                Else
                    TextBoxStatus.Text = "Succeed"
                End If

                BtnOpen.Text = "Disconnect"
                RadioBtnSPort.Enabled = False
                TextBoxSPort.Enabled = False
                RadioBtnEtheByIP.Enabled = False
                TextBoxIPAddr.Enabled = False
                RadioBtnByIP.Enabled = False
                TextBoxSN.Enabled = False
                isConnect = True
            End If
        Else
            'Close connection
            If OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_COM = nModel Then
                nRet = OPTControllerAPI.OPTController_ReleaseSerialPort(controllerHandle)
                If 0 <> nRet Then
                    TextBoxStatus.Text = "Failed to release serial port!"
                    Return
                End If
            End If
            If OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_SN = nModel Then
                nRet = OPTControllerAPI.OPTController_DestroyEthernetConnection(controllerHandle)
                If 0 <> nRet Then
                    TextBoxStatus.Text = "Failed to disconnect Ethernet connection by SN!"
                    Return
                End If
            End If
            If OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_IP = nModel Then
                nRet = OPTControllerAPI.OPTController_DestroyEthernetConnection(controllerHandle)
                If 0 <> nRet Then
                    TextBoxStatus.Text = "Failed to disconnect Ethernet connection by IP!"
                    Return
                End If
            End If

            BtnOpen.Text = "Connect"
            RadioBtnSPort.Enabled = True
            TextBoxSPort.Enabled = True
            RadioBtnEtheByIP.Enabled = True
            TextBoxIPAddr.Enabled = True
            RadioBtnByIP.Enabled = True
            TextBoxSN.Enabled = True
            isConnect = False
			
            Dim temp As OPTControllerAPI.OPTControllerHandleType
            temp.type = 0
            controllerHandle = temp
        End If

    End Sub

    Private Sub RadioBtnSPort_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnSPort.CheckedChanged
        'SerialPort Communication
        nModel = OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_COM
    End Sub

    Private Sub RadioBtnByIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnByIP.CheckedChanged
        'Ethernet Communication By SN
        nModel = OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_SN
    End Sub

    Private Sub RadioBtnEtheByIP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioBtnEtheByIP.CheckedChanged
        'Ethernet Communication By IP
        nModel = OPTController.OPT_COMMUNICATION_nModel.COMMUNICATION_BY_IP
    End Sub

    Private Sub BtnOpenChannel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenChannel.Click
        'Check the connection state of the controller
        If isConnect = False Then
            TextBoxStatus.Text = "Failed to Connection!"
            Return
        End If
        'Get the channel index
        Dim nIndex As Integer
        nIndex = Convert.ToInt32(TextBoxChannelIndex.Text)
        'Turn on the channel
        OPTControllerAPI.OPTController_TurnOnChannel(controllerHandle, nIndex)

    End Sub

    Private Sub BtnCloseChannel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseChannel.Click
        'Check the connection state of the controller
        If isConnect = False Then
            TextBoxStatus.Text = "Failed to Connection!"
            Return
        End If
        'Get the channel index
        Dim nIndex As Integer
        nIndex = Convert.ToInt32(TextBoxChannelIndex.Text)
        'Turn off the channel
        OPTControllerAPI.OPTController_TurnOffChannel(controllerHandle, nIndex)
    End Sub

    Private Sub BtnSetIntensity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSetIntensity.Click
        'Check the connection state of the controller
        If isConnect = False Then
            TextBoxStatus.Text = "Failed to Connection!"
            Return
        End If
        'Get the channel index
        Dim nChannel As Integer
        nChannel = Convert.ToInt32(TextBoxChannelIndex.Text)
        'Get the intensity value
        Dim intensity As Integer
        intensity = Convert.ToInt32(TextBoxIntensity.Text)
        'Set the intensity 
        OPTControllerAPI.OPTController_SetIntensity(controllerHandle, nChannel, intensity)

        Dim nIntensity As Integer
        Dim lret As Integer
        Threading.Thread.Sleep(100)
        'Read the intensity of the specified channel (channel index within [1, 16])
        lret = OPTControllerAPI.OPTController_ReadIntensity(controllerHandle, 1, nIntensity)
        If lret = 0 Then
            TextBoxStatus.Text = nIntensity
        Else
            TextBoxStatus.Text = "Failed to read intensity!"
        End If
    End Sub

    Private Sub TextBoxChannelIndex_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxChannelIndex.TextChanged
        'Support Number Only 
        Dim num As Integer = 0
        Dim temp As String = ""
        While num < TextBoxChannelIndex.Text.Length
            temp += "[0-9]"
            num += 1
        End While
        If Not (TextBoxChannelIndex.Text Like temp) Then
            TextBoxChannelIndex.Text = strIndex
            TextBoxChannelIndex.Focus()
        Else
            strIndex = TextBoxChannelIndex.Text
        End If
        If TextBoxChannelIndex.Text = "" Then
            TextBoxChannelIndex.Text = "0"
        End If
        'Confine the channel index within [0, 16]
        Dim nIndex As Integer
        nIndex = Convert.ToInt32(TextBoxChannelIndex.Text)
        If nIndex < 0 Or nIndex > 16 Then
            TextBoxChannelIndex.Text = "0"
        End If

    End Sub

    Private Sub TextBoxIntensity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxIntensity.TextChanged
        ' Support Number Only
        Dim num As Integer = 0
        Dim temp As String = ""
        While num < TextBoxIntensity.Text.Length
            temp += "[0-9]"
            num += 1
        End While
        If Not (TextBoxIntensity.Text Like temp) Then
            TextBoxIntensity.Text = strIntensity
            TextBoxIntensity.Focus()
        Else
            strIntensity = TextBoxIntensity.Text
        End If
        If TextBoxIntensity.Text = "" Then
            TextBoxIntensity.Text = "255"
        End If
        'Confine the intensity within [0, 255]
        Dim intensity As Integer
        intensity = Convert.ToInt32(TextBoxIntensity.Text)
        If intensity < 0 Or intensity > 255 Then
            TextBoxIntensity.Text = "255"
        End If
    End Sub

    Private Sub TextBoxSPort_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSPort.TextChanged
        If TextBoxSPort.Text = "" Then
            TextBoxStatus.Text = "Please input the number of serial port!"
            Return
        End If
    End Sub

    Private Sub TextBoxSN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxSN.TextChanged
        If TextBoxSN.Text = "" Then
            TextBoxStatus.Text = "Please input the SN of controller!"
            Return
        End If
    End Sub

    Private Sub TextBoxIPAddr_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxIPAddr.TextChanged
        If TextBoxIPAddr.Text = "" Then
            TextBoxStatus.Text = "Please input the IP Address of controller!"
            Return
        End If
    End Sub

    Private Sub BtnSetTriggerWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTriggerWidth.Click
        'Check the connection state of the controller
        If isConnect = False Then
            TextBoxStatus.Text = "Failed to Connection!"
            Return
        End If
        'Get the channel index
        Dim nChannel As Integer
        nChannel = Convert.ToInt32(TextBoxChannelIndex.Text)
        'Get the intensity value
        Dim triggerWidth As Integer
        triggerWidth = Convert.ToInt32(TextBoxTriggerWidth.Text)
        'Set the trigger width for the specified channel(s) (channel index within [0, 16])
        Dim lret As Integer
        OPTControllerAPI.OPTController_SetTriggerWidth(controllerHandle, nChannel, triggerWidth)

        'Read the trigger width of specified channel (channel index within [1, 16])
        Dim nWidth As Integer
        Threading.Thread.Sleep(100)
        lret = OPTControllerAPI.OPTController_ReadTriggerWidth(controllerHandle, 1, nWidth)
        If lret = 0 Then
            TextBoxStatus.Text = nWidth
        Else
            TextBoxStatus.Text = "Failed to read trigger width!"
        End If
    End Sub

    Private Sub BtnSetHBTriggerWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNHBTriggerWidth.Click
        'Check the connection state of the controller
        If isConnect = False Then
            TextBoxStatus.Text = "Failed to Connection!"
            Return
        End If
        'Get the channel index
        Dim nChannel As Integer
        nChannel = Convert.ToInt32(TextBoxChannelIndex.Text)
        'Get the intensity value
        Dim HBTriggerWidth As Integer
        HBTriggerWidth = Convert.ToInt32(TextBoxHBTriggerWidth.Text)

        'Set the high brightness trigger width of the specified channel(s) (channel index within [0, 16])
        OPTControllerAPI.OPTController_SetHBTriggerWidth(controllerHandle, nChannel, HBTriggerWidth)

        'Read the high brightness trigger width of the specified channel (channel index within [1, 16])
        Dim lret As Integer
        Dim nWidth As Integer
        Threading.Thread.Sleep(100)
        lret = OPTControllerAPI.OPTController_ReadHBTriggerWidth(controllerHandle, 1, nWidth)
        If lret = 0 Then
            TextBoxStatus.Text = nWidth
        Else
            TextBoxStatus.Text = "Failed to read high brightness trigger width!"
        End If
    End Sub

    Private Sub TextBoxTriggerWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxTriggerWidth.TextChanged
        'Support Number Only 
        Dim num As Integer = 0
        Dim temp As String = ""
        While num < TextBoxTriggerWidth.Text.Length
            temp += "[0-9]"
            num += 1
        End While
        If Not (TextBoxTriggerWidth.Text Like temp) Then
            TextBoxTriggerWidth.Text = strTriggerWidth
            TextBoxTriggerWidth.Focus()
        Else
            strTriggerWidth = TextBoxTriggerWidth.Text
        End If
        If TextBoxTriggerWidth.Text = "" Then
            TextBoxTriggerWidth.Text = "100"
        End If
        'Confine the trigger width within [0, 999]
        Dim triggerWidth As Integer
        triggerWidth = Convert.ToInt32(TextBoxTriggerWidth.Text)
        If triggerWidth < 1 Or triggerWidth > 999 Then
            TextBoxTriggerWidth.Text = "100"
        End If
    End Sub

    Private Sub TextBoxHBTriggerWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBoxHBTriggerWidth.TextChanged
        'Support Number Only 
        Dim num As Integer = 0
        Dim temp As String = ""
        While num < TextBoxHBTriggerWidth.Text.Length
            temp += "[0-9]"
            num += 1
        End While
        If Not (TextBoxHBTriggerWidth.Text Like temp) Then
            TextBoxHBTriggerWidth.Text = strHBTriggerWidth
            TextBoxHBTriggerWidth.Focus()
        Else
            strHBTriggerWidth = TextBoxHBTriggerWidth.Text
        End If
        If TextBoxHBTriggerWidth.Text = "" Then
            TextBoxHBTriggerWidth.Text = "255"
        End If
        'Confine the intensity within [0, 255]
        Dim intensity As Integer
        intensity = Convert.ToInt32(TextBoxHBTriggerWidth.Text)
        If intensity < 1 Or intensity > 500 Then
            TextBoxHBTriggerWidth.Text = "255"
        End If
    End Sub

    Private Sub BtnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRead.Click
'        'Set intensity for multiple channels
        'Dim intenArray(2) As OPTControllerAPI.IntensityItem
        'intenArray(0).channelIndex = 1
        'intenArray(0).intensity = 100
        'intenArray(1).channelIndex = 2
        'intenArray(1).intensity = 100
        'intenArray(2).channelIndex = 4
        'intenArray(2).intensity = 100
        'OPTControllerAPI.OPTController_SetMultiIntensity(controllerHandle, intenArray(0), 3)
        Dim arr(2) As Integer
        arr(0) = 1
        arr(1) = 2
        arr(2) = 4
        Dim nRet As Integer = -1
        nRet = OPTControllerAPI.OPTController_TurnOffMultiChannel(controllerHandle, arr(0), 3)

    End Sub

    Private Sub Btn_setTriggerMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_setTriggerMode.Click
        Dim moduleIndex As Integer
        moduleIndex = Convert.ToInt32(TextBox_ModuleIndex.Text)

        Dim lRet As Integer = -1
        If RadioButton_General.Checked = True Then
            lRet = OPTController_SetTriggerMode(controllerHandle, moduleIndex, 1)  'set general trigger mode
        End If

        If RadioButton_Programmable.Checked = True Then
            lRet = OPTController_SetTriggerMode(controllerHandle, moduleIndex, 2)  'set Programmale trigger mode
        End If
       
        If lRet = 0 Then

            TextBoxStatus.Text = "Set triggerMode successfully!"

        Else
            TextBoxStatus.Text = "Failed to set triggerMode"
        End If

    End Sub

    Private Sub btn_SetSEQTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_SetSEQTable.Click
        Dim moduleIndex As Integer
        moduleIndex = Convert.ToInt32(TextBox_ModuleIndex.Text)
        Dim lRet As Integer = -1
        Dim triggerSource As Integer() = {1, 1, 1, 1}
        Dim intensity As Integer() = {255, 255, 255, 255, 0, 0, 0, 0, 255, 255, 255, 255, 0, 0, 0, 0}
        Dim plusWidth As Integer() = {100, 100, 999, 999, 100, 100, 999, 999, 100, 100, 999, 999, 100, 100, 999, 999}
        Dim seqCount As Integer = 4
        lRet = OPTController_SetSeqTable(controllerHandle, moduleIndex, seqCount, triggerSource(0), intensity(0), plusWidth(0))
        If lRet = 0 Then

            TextBoxStatus.Text = "Set SEQ table data successfully!"

        Else
            TextBoxStatus.Text = "Failed to set SEQ table data "
        End If
    End Sub

    Private Sub Btn_ReadSEQTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ReadSEQTable.Click
        Dim triggerSource(4) As Integer
        Dim intensity(16) As Integer
        Dim plusWidth(16) As Integer
        Dim moduleIndex As Integer
        moduleIndex = Convert.ToInt32(TextBox_ModuleIndex.Text)
        Dim seqCount As Integer
        Dim lRet As Integer = -1
        lRet = OPTController_ReadSeqTable(controllerHandle, moduleIndex, seqCount, triggerSource(0), intensity(0), plusWidth(0))
        If lRet = 0 Then
            TextBoxStatus.Text = "Read SEQ table data successfully!"
        Else
            TextBoxStatus.Text = "Failed to read SEQ table data "
        End If
    End Sub
End Class
