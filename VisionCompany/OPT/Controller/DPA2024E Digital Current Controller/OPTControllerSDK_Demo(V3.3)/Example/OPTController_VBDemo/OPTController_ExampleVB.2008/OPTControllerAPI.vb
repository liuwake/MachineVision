
Imports System.Runtime.InteropServices
Imports System.Text
Module OPTControllerAPI


    Public Structure OPTControllerHandleType
        Dim type As Int32 'when using x86 complier,use this
        'Dim type As Int64 'when using x64 complier,use this
    End Structure

    Public Const OPT_SUCCEED As Integer = 0                                  'Operation succeed
    Public Const OPT_ERR_INVALIDHANDLE As Integer = 3001001                  'Invalid handle
    Public Const OPT_ERR_UNKNOWN As Integer = 3001002                        'Error unknown 
    Public Const OPT_ERR_INITSERIAL_FAILED As Integer = 3001003              'Failed to initialize a serial port
    Public Const OPT_ERR_RELEASESERIALPORT_FAILED As Integer = 3001004       'Failed to release a serial port
    Public Const OPT_ERR_SERIALPORT_UNOPENED As Integer = 3001005            'Attempt to access an unopened serial port
    Public Const OPT_ERR_CREATEETHECON_FAILED As Integer = 3001006           'Failed to create an Ethernet connection
    Public Const OPT_ERR_DESTROYETHECON_FAILED As Integer = 3001007          'Failed to destroy an Ethernet connection
    Public Const OPT_ERR_SN_NOTFOUND As Integer = 3001008                    'SN is not found
    Public Const OPT_ERR_TURNONCH_FAILED As Integer = 3001009                'Failed to turn on the specified channel(s)
    Public Const OPT_ERR_TURNOFFCH_FAILED As Integer = 3001019               'Failed to turn off the specified channel(s)
    Public Const OPT_ERR_SET_INTENSITY_FAILED As Integer = 3001011           'Failed to set the intensity for the specified channel(s)
    Public Const OPT_ERR_READ_INTENSITY_FAILED As Integer = 3001012          'Failed to read the intensity for the specified channel(s)	
    Public Const OPT_ERR_SET_TRIGGERWIDTH_FAILED As Integer = 3001013        'Failed to set trigger pulse width	
    Public Const OPT_ERR_READ_TRIGGERWIDTH_FAILED As Integer = 3001014       'Failed to read trigger pulse width
    Public Const OPT_ERR_READ_HBTRIGGERWIDTH_FAILED As Integer = 3001015     'Failed to read high brightness trigger pulse width
    Public Const OPT_ERR_SET_HBTRIGGERWIDTH_FAILED As Integer = 3001016      'Failed to set high brightness trigger pulse width
    Public Const OPT_ERR_READ_SN_FAILED As Integer = 3001017                 'Failed to read serial number
    Public Const OPT_ERR_READ_IPCONFIG_FAILED As Integer = 3001018           'Failed to read IP address
    Public Const OPT_ERR_CHINDEX_OUTRANGE As Integer = 3001019               'Index(es) out of the range
    Public Const OPT_ERR_WRITE_FAILED As Integer = 3001020                   'Failed to write data
    Public Const OPT_ERR_PARAM_OUTRANGE As Integer = 3001021                 'Parameter(s) out of the range 
    Public Const OPT_ERR_READ_MAC_FAILED As Integer = 3001022                'failed to read MAC
    Public Const OPT_ERR_SET_MAXCURRENT_FAILED As Integer = 3001023          'failed to set max current
    Public Const OPT_ERR_READ_MAXCURRENT_FAILED As Integer = 3001024  'failed to read max current
    Public Const OPT_ERR_SET_TRIGGERACTIVATION_FAILED As Integer = 3001025   'failed to set trigger activation
    Public Const OPT_ERR_READ_TRIGGERACTIVATION_FAILED As Integer = 3001026  'failed to read trigger activation
    Public Const OPT_ERR_SET_WORKMODE_FAILED As Integer = 3001027    'failed to set work mode
    Public Const OPT_ERR_READ_WORKMODE_FAILED As Integer = 3001028  'failed to read work mode
    Public Const OPT_ERR_SET_BAUDRATE_FAILED As Integer = 3001029   'failed to set baud rate
    Public Const OPT_ERR_SET_CHANNELAMOUNT_FAILED As Integer = 3001030    'failed to set channel amount
    Public Const OPT_ERR_SET_DETECTEDMINLOAD_FAILED As Integer = 3001031   'failed to set detected min load
    Public Const OPT_ERR_READ_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED As Integer = 3001032   'failed to read outer trigger frequency upper bound
    Public Const OPT_ERR_SET_AUTOSTROBEFREQUENCY_FAILED As Integer = 3001033  'failed to set auto-strobe frequency
    Public Const OPT_ERR_READ_AUTOSTROBEFREQUENCY_FAILED As Integer = 3001034    'failed to read auto-strobe frequency
    Public Const OPT_ERR_SET_DHCP_FAILED As Integer = 3001035        'failed to set DHCP
    Public Const OPT_ERR_SET_LOADMODE_FAILED As Integer = 3001036   'failed to set load mode
    Public Const OPT_ERR_READ_PROPERTY_FAILED As Integer = 3001037  'failed to read property
    Public Const OPT_ERR_CONNECTION_RESET_FAILED As Integer = 3001038   'failed to reset connection
    Public Const OPT_ERR_SET_HEARTBEAT_FAILED As Integer = 3001039    'failed to set ethe connection heartbeat
    Public Const OPT_ERR_GETCONTROLLERLIST_FAILED As Integer = 3001040    'Failed to get controler(s) list           
    Public Const OPT_ERR_SOFTWARETRIGGER_FAILED As Integer = 3001041     'Failed to software trigger                
    Public Const OPT_ERR_GET_CHANNELSTATE_FAILED As Integer = 3001042    'Failed to get channelstate          
    Public Const OPT_ERR_SET_KEEPALIVEPARAMETERS_FAILED As Integer = 3001043    'Failed to set keepalvie parameters          
    Public Const OPT_ERR_ENABLE_KEEPALIVE_FAILED As Integer = 3001044    'Failed to enable/disable keepalive
    Public Const OPT_ERR_READSTEPCOUNT_FAILED As Integer = 3001045   'Failed to read step count           
    Public Const OPT_ERR_SETTRIGGERMODE_FAILED As Integer = 3001046   'Failed to set trigger mode    
    Public Const OPT_ERR_READTRIGGERMODE_FAILED As Integer = 3001047    'Failed to read trigger mode      
    Public Const OPT_ERR_SETCURRENTSTEPINDEX_FAILED As Integer = 3001048    'Failed to set current step index          
    Public Const OPT_ERR_READCURRENTSTEPINDEX_FAILED As Integer = 3001049    'Failed to read current step index          
    Public Const OPT_ERR_RESETSEQ_FAILED As Integer = 3001050   'Failed to reset SEQ
    Public Const OPT_ERR_SETTRIGGERDELAY_FAILED As Integer = 3001051     'Failed to set trigger delay
    Public Const OPT_ERR_GET_TRIGGERDELAY_FAILED As Integer = 3001052     'Failed to get trigger delay
    Public Const OPT_ERR_SETMULTITRIGGERDELAY_FAILED As Integer = 3001053     'Failed to set multiple channels trigger delay
    Public Const OPT_ERR_SETSEQTABLEDATA_FAILED As Integer = 3001054     'Failed to set SEQ table data
    Public Const OPT_ERR_READSEQTABLEDATA_FAILED As Integer = 3001055     'Failed to Read SEQ table data
    Public Const OPT_ERR_READ_CHANNELS_FAILED As Integer = 3001056     'Failed to read controller's channel
    Public Const OPT_ERR_READ_KEEPALIVE_STATE_FAILED As Integer = 3001057     'Failed to read the state of keepalive
    Public Const OPT_ERR_READ_KEEPALIVE_CONTINUOUS_TIME_FAILED As Integer = 3001058     'Failed to read the continuous time of keepalive
    Public Const OPT_ERR_READ_DELIVERY_TIMES_FAILED As Integer = 3001059     'Failed to read the delivery times of prop packet
    Public Const OPT_ERR_READ_INTERVAL_TIME_FAILED As Integer = 3001060     'Failed to read the interval time of prop packet
    Public Const OPT_ERR_READ_OUTPUTBOARD_VISION_FAILED As Integer = 3001061     'Failed to read the vision of output board
    Public Const OPT_ERR_READ_DETECT_MODE_FAILED As Integer = 3001062     'Failed to read detect mode of load
    Public Const OPT_ERR_SET_BOOT_STATE_MODE_FAILED As Integer = 3001063     'Failed to set mode of boot State
    Public Const OPT_ERR_READ_MODEL_BOOT_MODE_FAILED As Integer = 3001064     'Failed to read the specified channel boot state
    Public Const OPT_ERR_SET_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED As Integer = 3001065   'failed to set outer trigger frequency upper bound
    Public Const OPT_ERR_SET_IPCONFIG_FAILED As Integer = 3001066   'Failed to set IP configuration of the controller
    Public Const OPT_ERR_SET_VOLTAGE_FAILEDAs As Integer = 3001067   'Failed to set voltage value
    Public Const OPT_ERR_READ_VOLTAGE_FAILEDAs As Integer = 3001068   'Failed to read voltage value
    Public Const OPT_ERR_SET_TIMEUNIT_FAILED As Integer = 3001069  'Failed to set time unit
    Public Const OPT_ERR_READ_TIMEUNIT_FAILED As Integer = 3001070   'Failed to read time unit


    Public Structure IntensityItem
        Dim channelIndex As Integer            'The channel index value of controller
        Dim intensity As Integer               'The intensity for the corresponding channel index 
    End Structure

    Public Structure TriggerWidthItem
        Dim channelIndex As Integer            'The channel index value of controller
        Dim triggerWidth As Integer            'The trigger width for the corresponding channel index 
    End Structure

    Public Structure HBTriggerWidthItem
        Dim channelIndex As Integer            'The channel index value of controller
        Dim HBTriggerWidth As Integer          'The high brightness trigger width for the corresponding channel index 
    End Structure

    Public Structure SoftwareTriggerItem
        Dim channelIndex As Integer            'The channel index value of controller
        Dim softwareTriggerTime As Integer     'The software trigger time for the corresponding channel index 
    End Structure
    Public Structure TriggerDelayItem
        Dim channelIndex As Integer            'The channel index value of controller
        Dim triggerDelayTime As Integer        'The trigger delay for the corresponding channel index 
    End Structure

    Public Structure MaxCurrentItem
        Dim channelIndex As Integer            'The channel index value of controller
        Dim maxCurrent As Integer              'The maximum current for the corresponding channel index 
    End Structure



    'Declare the 
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_InitSerialPort(ByVal comName As String, ByRef controllerHandle As OPTControllerHandleType) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReleaseSerialPort(ByVal controllerHandle As OPTControllerHandleType) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_CreateEthernetConnectionByIP(ByVal serverIPAddress As String, ByRef controllerHandle As OPTControllerHandleType) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_CreateEthernetConnectionBySN(ByVal serialNumber As String, ByRef controllerHandle As OPTControllerHandleType) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_DestroyEthernetConnection(ByVal controllerHandle As OPTControllerHandleType) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_TurnOnChannel(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_TurnOnMultiChannel(ByVal controllerHandle As OPTControllerHandleType, ByRef channelIndexArray As Integer, ByVal length As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_TurnOffChannel(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_TurnOffMultiChannel(ByVal controllerHandle As OPTControllerHandleType, ByRef channelIndexArray As Integer, ByVal length As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetIntensity(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal intensity As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetMultiIntensity(ByVal controllerHandle As OPTControllerHandleType, ByRef intensityArray As IntensityItem, ByVal arrayLength As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadIntensity(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef intensity As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetTriggerWidth(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal triggerWidth As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetMultiTriggerWidth(ByVal controllerHandle As OPTControllerHandleType, ByRef triggerWidthArray As TriggerWidthItem, ByVal arrayLength As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadTriggerWidth(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef triggerWidth As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetHBTriggerWidth(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal HBTriggerWidth As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetMultiHBTriggerWidth(ByVal controllerHandle As OPTControllerHandleType, ByRef HBtriggerWidthArray As HBTriggerWidthItem, ByVal arrayLength As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadHBTriggerWidth(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef HBTriggerWidth As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_EnableResponse(ByVal controllerHandle As OPTControllerHandleType, ByVal isResponse As Boolean) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_EnableCheckSum(ByVal controllerHandle As OPTControllerHandleType, ByVal enable As Boolean) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_EnablePowerOffBackup(ByVal controllerHandle As OPTControllerHandleType, ByVal isSave As Boolean) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadSN(ByVal controllerHandle As OPTControllerHandleType, ByVal SN As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadProperties(ByVal controllerHandle As OPTControllerHandleType, ByVal properties As Integer, ByVal value As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadIPConfig(ByVal controllerHandle As OPTControllerHandleType, ByVal IP As StringBuilder, ByVal subnetMask As StringBuilder, ByVal defaultGateway As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetMaxCurrent(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal current As Integer) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadMaxCurrent(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal mode As Integer, ByRef value As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetMultiMaxCurrent(ByVal controllerHandle As OPTControllerHandleType, ByRef maxCurrentArray As MaxCurrentItem, ByVal arrayLength As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadMAC(ByVal controllerHandle As OPTControllerHandleType, ByVal MAC As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetTriggerActivation(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal triggerActivation As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadTriggerActivation(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef triggerActivation As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetWorkMode(ByVal controllerHandle As OPTControllerHandleType, ByVal workMode As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadWorkMode(ByVal controllerHandle As OPTControllerHandleType, ByRef workMode As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetOuterTriggerFrequencyUpperBound(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal maxFrequency As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadOuterTriggerFrequencyUpperBound(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef maxFrequency As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_AutoDetectLoadOnce(ByVal controllerHandle As OPTControllerHandleType) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetAutoStrobeFrequency(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal frequency As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadAutoStrobeFrequency(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef frequency As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_EnableDHCP(ByVal controllerHandle As OPTControllerHandleType, ByVal bDHCP As Boolean) As Integer
    End Function


    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetLoadMode(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal loadMode As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_GetVersion(ByVal version As StringBuilder) As Integer
    End Function


    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ConnectionResetBySN(ByVal serialNumber As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ConnectionResetByIP(ByVal serverIPAddress As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_IsConnect(ByVal controllerHandle As OPTControllerHandleType) As Integer
    End Function
   

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetEthernetConnectionHeartBeat(ByVal controllerHandle As OPTControllerHandleType, ByVal timeout As UInteger) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_GetControllerListOnEthernet(ByVal snList As StringBuilder) As Integer
    End Function
    'Like this: Dim devs As New StringBuilder(0,1024)     OPTController_GetControllerListOnEthernet(devs).

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_GetChannelState(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIdx As Integer, ByRef state As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetKeepaliveParameter(ByVal controllerHandle As OPTControllerHandleType, ByVal keepalive_time As Integer, ByVal keepalive_intvl As Integer, ByVal keepalive_probes As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_EnableKeepalive(ByVal controllerHandle As OPTControllerHandleType, ByVal enable As Boolean) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SoftwareTrigger(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIdx As Integer, ByVal time As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_MultiSoftwareTrigger(ByVal controllerHandle As OPTControllerHandleType, ByRef softwareTriggerArray As SoftwareTriggerItem, ByVal length As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadStepCount(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByRef count As Integer) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetTriggerMode(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByVal mode As Integer) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadTriggerMode(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByRef mode As Integer) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetCurrentStepIndex(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByVal curStepIndex As Integer) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadCurrentStepIndex(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByRef curStepIndex As Integer) As Integer
    End Function
    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ResetSEQ(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetSeqTable(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByVal seqCount As Integer, ByRef triggerSource As Integer, ByRef intensity As Integer, ByRef pulseWidth As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadSeqTable(ByVal controllerHandle As OPTControllerHandleType, ByVal moduleIndex As Integer, ByRef seqCount As Integer, ByRef triggerSource As Integer, ByRef intensity As Integer, ByRef pulseWidth As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetTriggerDelay(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal triggerDelay As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_GetTriggerDelay(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef triggerDelay As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetMultiTriggerDelay(ByVal controllerHandle As OPTControllerHandleType, ByRef triggerDelayArray As TriggerDelayItem, ByVal length As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_GetControllerChannels(ByVal controllerHandle As OPTControllerHandleType, ByRef channels As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadKeepaliveSwitchState(ByVal controllerHandle As OPTControllerHandleType, ByRef state As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadContinuousKeepaliveTime(ByVal controllerHandle As OPTControllerHandleType, ByRef time As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadPacketDeliveryTimes(ByVal controllerHandle As OPTControllerHandleType, ByRef times As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadIntervalTimeOfPropPacket(ByVal controllerHandle As OPTControllerHandleType, ByRef time As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
   Public Function OPTController_ReadOutputBoardVision(ByVal controllerHandle As OPTControllerHandleType, ByVal vision As StringBuilder) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadLoadDetectMode(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef mode As Integer) As Integer
    End Function


    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetBootState(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByVal mode As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadModelBootState(ByVal controllerHandle As OPTControllerHandleType, ByVal channelIndex As Integer, ByRef state As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetOutputVoltage(ByVal controllerHandle As Integer, ByVal channelIndex As Integer, ByVal voltage As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadOutputVoltage(ByVal controllerHandle As Integer, ByVal channelIndex As Integer, ByRef voltage As Integer) As Integer
    End Function


    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_SetTimeUnit(ByVal controllerHandle As Integer, ByVal channelIndex As Integer, ByVal timeUnit As Integer) As Integer
    End Function

    <DllImport("OPTController.dll", CallingConvention:=System.Runtime.InteropServices.CallingConvention.Cdecl)> _
    Public Function OPTController_ReadTimeUnit(ByVal controllerHandle As Integer, ByVal channelIndex As Integer, ByRef timeUnit As Integer) As Integer
    End Function

End Module

