using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Management;

namespace CSharp_OPTControllerAPI
{     
    // using OPTControllerHandleType = Int64; //when using x64 compiler, use this;
     using OPTControllerHandleType = Int32;//when using x86 compiler, use this;

    class OPTControllerAPI
    {
        const string OPTControler_DLL = "OPTController.dll";
        private OPTControllerHandleType ControllerHandle = 0;

        public const int OPT_SUCCEED                      = 0;       //operation succeed					 
        public const int OPT_ERR_INVALIDHANDLE            = 3001001; //invalid handle  
        public const int OPT_ERR_UNKNOWN                  = 3001002; //error unknown 
        public const int OPT_ERR_INITSERIAL_FAILED        = 3001003; //failed to initialize a serial port
        public const int OPT_ERR_RELEASESERIALPORT_FAILED = 3001004; //failed to release a serial port
        public const int OPT_ERR_SERIALPORT_UNOPENED      = 3001005; //attempt to access an unopened serial port
        public const int OPT_ERR_CREATEETHECON_FAILED     = 3001006; //failed to create an Ethernet connection
        public const int OPT_ERR_DESTROYETHECON_FAILED    = 3001007; //failed to destroy an Ethernet connection
        public const int OPT_ERR_SN_NOTFOUND              = 3001008; //SN is not found
        public const int OPT_ERR_TURNONCH_FAILED          = 3001009; //failed to turn on the specified channel(s)
        public const int OPT_ERR_TURNOFFCH_FAILED         = 3001010; //failed to turn off the specified channel(s)
        public const int OPT_ERR_SET_INTENSITY_FAILED     = 3001011; //failed to set the intensity for the specified channel(s)
        public const int OPT_ERR_READ_INTENSITY_FAILED    = 3001012; //failed to read the intensity for the specified channel(s)
        public const int OPT_ERR_SET_TRIGGERWIDTH_FAILED  = 3001013; //failed to set trigger pulse width
        public const int OPT_ERR_READ_TRIGGERWIDTH_FAILED = 3001014; //failed to read trigger pulse width	
        public const int OPT_ERR_READ_HBTRIGGERWIDTH_FAILED= 3001015;//failed to read high brightness trigger pulse width
        public const int OPT_ERR_SET_HBTRIGGERWIDTH_FAILED = 3001016;//failed to set high brightness trigger pulse width
        public const int OPT_ERR_READ_SN_FAILED           = 3001017; //failed to read serial number
        public const int OPT_ERR_READ_IPCONFIG_FAILED     = 3001018; //failed to read IP address
        public const int OPT_ERR_CHINDEX_OUTRANGE         = 3001019; //index(es) out of the range
        public const int OPT_ERR_WRITE_FAILED             = 3001020; //failed to write data
        public const int OPT_ERR_PARAM_OUTRANGE           = 3001021; //parameter(s) out of the range 
        public const int OPT_ERR_READ_MAC_FAILED		  = 3001022; //failed to read MAC
        public const int OPT_ERR_SET_MAXCURRENT_FAILED	  = 3001023; //failed to set max current
        public const int OPT_ERR_READ_MAXCURRENT_FAILED   = 3001024; //failed to read max current
        public const int OPT_ERR_SET_TRIGGERACTIVATION_FAILED = 3001025; //failed to set trigger activation
        public const int OPT_ERR_READ_TRIGGERACTIVATION_FAILED = 3001026; //failed to read trigger activation
        public const int OPT_ERR_SET_WORKMODE_FAILED = 3001027;	 //failed to set work mode
        public const int OPT_ERR_READ_WORKMODE_FAILED = 3001028; //failed to read work mode
        public const int OPT_ERR_SET_BAUDRATE_FAILED = 3001029;	 //failed to set baud rate
        public const int OPT_ERR_SET_CHANNELAMOUNT_FAILED = 3001030;     //failed to set channel amount
        public const int OPT_ERR_SET_DETECTEDMINLOAD_FAILED = 3001031;	 //failed to set detected min load
        public const int OPT_ERR_READ_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED = 3001032;	 //failed to read outer trigger frequency upper bound
        public const int OPT_ERR_SET_AUTOSTROBEFREQUENCY_FAILED = 3001033;	 //failed to set auto-strobe frequency
        public const int OPT_ERR_READ_AUTOSTROBEFREQUENCY_FAILED = 3001034;	 //failed to read auto-strobe frequency
        public const int OPT_ERR_SET_DHCP_FAILED = 3001035;	 //failed to set DHCP
        public const int OPT_ERR_SET_LOADMODE_FAILED = 3001036;	 //failed to set load mode
        public const int OPT_ERR_READ_PROPERTY_FAILED = 3001037;	 //failed to read property
        public const int OPT_ERR_CONNECTION_RESET_FAILED = 3001038;	 //failed to reset connection
        public const int OPT_ERR_SET_HEARTBEAT_FAILED = 3001039;	 //failed to set Ethernet connection heartbeat
        public const int OPT_ERR_GETCONTROLLERLIST_FAILED = 3001040;     //Failed to get controller(s) list           
        public const int OPT_ERR_SOFTWARETRIGGER_FAILED = 3001041;     //Failed to software trigger                
        public const int OPT_ERR_GET_CHANNELSTATE_FAILED = 3001042;     //Failed to get channelstate          
        public const int OPT_ERR_SET_KEEPALIVEPARAMETERS_FAILED = 3001043;     //Failed to set keepalvie parameters          
        public const int OPT_ERR_ENABLE_KEEPALIVE_FAILED = 3001044;     //Failed to enable/disable keepalive
        public const int OPT_ERR_READSTEPCOUNT_FAILED  =  3001045;     //Failed to read step count           
        public const int OPT_ERR_SETTRIGGERMODE_FAILED = 3001046;     //Failed to set trigger mode    
        public const int OPT_ERR_READTRIGGERMODE_FAILED  = 3001047;     //Failed to read trigger mode      
        public const int OPT_ERR_SETCURRENTSTEPINDEX_FAILED = 3001048;     //Failed to set current step index          
        public const int OPT_ERR_READCURRENTSTEPINDEX_FAILED = 3001049;     //Failed to read current step index          
        public const int OPT_ERR_RESETSEQ_FAILED = 3001050;     //Failed to reset SEQ
        public const int OPT_ERR_SETTRIGGERDELAY_FAILED  = 3001051;      //Failed to set trigger delay
        public const int OPT_ERR_GET_TRIGGERDELAY_FAILED  = 3001052;     //Failed to get trigger delay
        public const int OPT_ERR_SETMULTITRIGGERDELAY_FAILED = 3001053;     //Failed to set multiple channels trigger delay
        public const int OPT_ERR_SETSEQTABLEDATA_FAILED  = 3001054;     //Failed to set SEQ table data
        public const int OPT_ERR_READSEQTABLEDATA_FAILED = 3001055;      //Failed to Read SEQ table data
        public const int OPT_ERR_READ_CHANNELS_FAILED  = 3001056;      //Failed to read controller's channel
        public const int OPT_ERR_READ_KEEPALIVE_STATE_FAILED  = 3001057;      //Failed to read the state of keepalive
        public const int OPT_ERR_READ_KEEPALIVE_CONTINUOUS_TIME_FAILED = 3001058;      //Failed to read the continuous time of keepalive
        public const int OPT_ERR_READ_DELIVERY_TIMES_FAILED  = 3001059;      //Failed to read the delivery times of prop packet
        public const int OPT_ERR_READ_INTERVAL_TIME_FAILED  = 3001060;      //Failed to read the interval time of prop packet
        public const int OPT_ERR_READ_OUTPUTBOARD_VISION_FAILED = 3001061;      //Failed to read the vision of output board
        public const int OPT_ERR_READ_DETECT_MODE_FAILED  = 3001062 ;    //Failed to read detect mode of load
        public const int OPT_ERR_SET_BOOT_PROTECTION_MODE_FAILED = 3001063;      //Failed to set mode of boot protection
        public const int OPT_ERR_READ_MODEL_BOOT_MODE_FAILED = 3001064;    //Failed to read the specified channel boot state
        public const int OPT_ERR_SET_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED = 3001065;	 //Failed to set outer trigger frequency upper bound
        public const int OPT_ERR_SET_IPCONFIG_FAILED = 3001066;   //Failed to set IP configuration of the controller

        public const int OPT_ERR_SET_VOLTAGE_FAILED = 3001067;	 //Failed to set voltage of specified channel voltage
        public const int OPT_ERR_READ_VOLTAGE_FAILED = 3001068;   //Failed to read the specified channel's voltage
        public const int OPT_ERR_SET_TIMEUNIT_FAILED = 3001069;	 //Failed to set time unit
        public const int OPT_ERR_READ_TIMEUNIT_FAILED = 3001070;   //Failed to read time unit

        [StructLayout(LayoutKind.Sequential)]
        public struct IntensityItem
        {
            public int channel;
            public int intensity;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct TriggerWidthItem
        {
            public int channel;
            public int triggerWidth;
        };

        [StructLayout(LayoutKind.Sequential)]
        public struct HBTriggerWidthItem
        {
            public int channel;
            public int HBTriggerWidth;
        }; 

        [StructLayout(LayoutKind.Sequential)]
        public struct SoftwareTriggerItem
        {
            public int channel;
            public int SoftwareTriggerTime;
        };


        [StructLayout(LayoutKind.Sequential)]
        public struct TriggerDelayItem
        {
            public int channel;
            public int TriggerDelayTime;
        }; 

        [StructLayout(LayoutKind.Sequential)]
        public struct MaxCurrentItem
        {
            public int channel;
            public int TriggerDelayTime;
        };
        

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_InitSerialPort(String SerialPortName, OPTControllerHandleType* ControllerHandle);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReleaseSerialPort(OPTControllerHandleType ControllerHandle);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_CreateEthernetConnectionByIP(String IP, OPTControllerHandleType* ControllerHandle);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_CreateEthernetConnectionBySN(String SN, OPTControllerHandleType* ControllerHandle);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_DestroyEthernetConnection(OPTControllerHandleType ControllerHandle);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_TurnOnChannel(OPTControllerHandleType ControllerHandle, int Channel);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_TurnOnMultiChannel(OPTControllerHandleType ControllerHandle, int[] ChannelArray, int len);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_TurnOffChannel(OPTControllerHandleType ControllerHandle, int Channel);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_TurnOffMultiChannel(OPTControllerHandleType ControllerHandle, int[] ChannelArray, int len);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetIntensity(OPTControllerHandleType ControllerHandle, int Channel, int vlaue);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetMultiIntensity(OPTControllerHandleType ControllerHandle, IntensityItem[] intensityArray, int length);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadIntensity(OPTControllerHandleType ControllerHandle, int Channel, int* vlaue);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetTriggerWidth(OPTControllerHandleType ControllerHandle, int Channel, int Value);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetMultiTriggerWidth(OPTControllerHandleType ControllerHandle, TriggerWidthItem[] triggerWidthArray, int length);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadTriggerWidth(OPTControllerHandleType ControllerHandle, int Channel, int* vlaue);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetHBTriggerWidth(OPTControllerHandleType ControllerHandle, int Channel, int Value);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetMultiHBTriggerWidth(OPTControllerHandleType ControllerHandle, HBTriggerWidthItem[] HBTriggerWidthArray, int length);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadHBTriggerWidth(OPTControllerHandleType ControllerHandle, int Channel, int* vlaue);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_EnableResponse(OPTControllerHandleType ControllerHandle, bool isResponse);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_EnableCheckSum(OPTControllerHandleType ControllerHandle, bool isCheckSum);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_EnablePowerOffBackup(OPTControllerHandleType ControllerHandle, bool isSave);
        
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadSN(OPTControllerHandleType ControllerHandle, StringBuilder SN);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadIPConfig(OPTControllerHandleType ControllerHandle, StringBuilder IP, StringBuilder subnetMask, StringBuilder defaultGateway);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadProperties(OPTControllerHandleType ControllerHandle, int properties, StringBuilder value);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetMaxCurrent(OPTControllerHandleType ControllerHandle, int channelIndex, int current);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadMaxCurrent(OPTControllerHandleType ControllerHandle, int channelIndex, int mode, int *value);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetMultiMaxCurrent(OPTControllerHandleType ControllerHandle, MaxCurrentItem[] maxCurrentArray, int arrayLength);
   
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadMAC(OPTControllerHandleType ControllerHandle,StringBuilder MAC);
   
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetTriggerActivation(OPTControllerHandleType ControllerHandle, int channelIndex, int triggerActivation);
     
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadTriggerActivation(OPTControllerHandleType ControllerHandle, int channelIndex, int *triggerActivation);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetWorkMode(OPTControllerHandleType ControllerHandle,  int workMode);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadWorkMode(OPTControllerHandleType ControllerHandle,  int *workMode);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetOuterTriggerFrequencyUpperBound(OPTControllerHandleType ControllerHandle, int channelIndex, int maxFrequency);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadOuterTriggerFrequencyUpperBound(OPTControllerHandleType ControllerHandle, int channelIndex, int *maxFrequency);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_AutoDetectLoadOnce(OPTControllerHandleType ControllerHandle);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetAutoStrobeFrequency(OPTControllerHandleType ControllerHandle, int channelIndex, int frequency);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadAutoStrobeFrequency(OPTControllerHandleType ControllerHandle, int channelIndex, int *frequency);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_EnableDHCP(OPTControllerHandleType ControllerHandle, Boolean bDHCP);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetLoadMode(OPTControllerHandleType ControllerHandle, int channelIndex, int loadMode);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_GetVersion(StringBuilder version);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ConnectionResetBySN(StringBuilder serialNumber);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_IsConnect(OPTControllerHandleType ControllerHandle);
   
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ConnectionResetByIP(String IP);
		
		[DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
	    OPTController_SetEthernetConnectionHeartBeat(OPTControllerHandleType ControllerHandle, UInt32 timeout);


        /*******/
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_GetControllerListOnEthernet(StringBuilder snList); 

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_GetChannelState(OPTControllerHandleType controllerHandle, int channelIdx, int* state);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetKeepaliveParameter(OPTControllerHandleType controllerHandle, int keepalive_time,
										 int keepalive_intvl, int keepalive_probes);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_EnableKeepalive(OPTControllerHandleType controllerHandle, bool enable);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SoftwareTrigger(OPTControllerHandleType controllerHandle, int channelIndex, int time);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_MultiSoftwareTrigger(OPTControllerHandleType controllerHandle, SoftwareTriggerItem[] softwareTriggerArray, int length);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadStepCount(OPTControllerHandleType controllerHandle, int moduleIndex, int* count);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetTriggerMode(OPTControllerHandleType controllerHandle, int moduleIndex, int mode);
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadTriggerMode(OPTControllerHandleType controllerHandle, int moduleIndex, int* mode);
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetCurrentStepIndex(OPTControllerHandleType controllerHandle, int moduleIndex, int curStepIndex);
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadCurrentStepIndex(OPTControllerHandleType controllerHandle, int moduleIndex, int* curStepIndex);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ResetSEQ(OPTControllerHandleType controllerHandle, int moduleIndex);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetSeqTable(OPTControllerHandleType controllerHandle, int moduleIndex, int seqCount, int[] triggerSource, int[] intensity, int[] pulseWidth);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadSeqTable(OPTControllerHandleType controllerHandle, int curStepIndex, int* seqCount, int[] triggerSource, int[] intensity, int[] pulseWidth);


 

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetTriggerDelay(OPTControllerHandleType controllerHandle, int channelIndex, int triggerDelay);


        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_GetTriggerDelay(OPTControllerHandleType controllerHandle, int channelIndex, int* triggerDelay);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetMultiTriggerDelay(OPTControllerHandleType controllerHandle, TriggerDelayItem[] triggerDelayArray, int length);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_GetControllerChannels(OPTControllerHandleType controllerHandle,  int* channels);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadKeepaliveSwitchState(OPTControllerHandleType controllerHandle,  int* state);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadContinuousKeepaliveTime(OPTControllerHandleType controllerHandle,  int* time);

        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadPacketDeliveryTimes(OPTControllerHandleType controllerHandle,  int* times);
    
        [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadIntervalTimeOfPropPacket(OPTControllerHandleType controllerHandle,  int* time);


         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadOutputBoardVision(OPTControllerHandleType controllerHandle,  StringBuilder vision);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadLoadDetectMode(OPTControllerHandleType controllerHandle,int channelIndex,  int* mode);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetBootProtection(OPTControllerHandleType controllerHandle, int channelIndex, int mode);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_ReadModelBootState(OPTControllerHandleType controllerHandle, int channelIndex, int* state);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
        private static extern unsafe
        int
        OPTController_SetIPConfiguration(OPTControllerHandleType controllerHandle, StringBuilder IP, StringBuilder subnetMask, StringBuilder defaultGateway);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
         private static extern unsafe
         int
          OPTController_SetOutputVoltage(OPTControllerHandleType controllerHandle, int channelIndex, int voltage);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
         private static extern unsafe
         int
         OPTController_ReadOutputVoltage(OPTControllerHandleType controllerHandle, int channelIndex, int* voltage);


         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
         private static extern unsafe
         int
          OPTController_SetTimeUnit(OPTControllerHandleType controllerHandle, int channelIndex, int timeUnit);

         [DllImport(OPTControler_DLL, CallingConvention = CallingConvention.Cdecl)]
         private static extern unsafe
         int
         OPTController_ReadTimeUnit(OPTControllerHandleType controllerHandle, int channelIndex, int* timeUnit);
       
/******************************************************************************************/
        public unsafe
        int
        ConnectionResetByIP(string IP)
        {
            int iRet = 0;
            iRet =  OPTController_ConnectionResetByIP(IP);
            return iRet;
        }

        public unsafe
        int
        InitSerialPort(string SerialPortName)
        {
            fixed (OPTControllerHandleType* controllerHandle = &ControllerHandle)
            {
                return OPTController_InitSerialPort(SerialPortName, controllerHandle);
            }
        }
        
        public unsafe
        int
        ReleaseSerialPort()
        {
            int iRet = OPTController_ReleaseSerialPort(ControllerHandle);
            ControllerHandle = 0;
            return iRet;
        }
        
        public unsafe
        int
        CreateEthernetConnectionByIP(string ComName)
        {
            fixed (OPTControllerHandleType* controllerHandle = &ControllerHandle)
            {
                return OPTController_CreateEthernetConnectionByIP(ComName, controllerHandle);
            }
        }

        public unsafe
        int
        CreateEthernetConnectionBySN(string ComName)
        {
            fixed (OPTControllerHandleType* controllerHandle = &ControllerHandle)
            {
                return OPTController_CreateEthernetConnectionBySN(ComName, controllerHandle);
            }
        }
        
        public unsafe
        int
        DestroyEthernetConnect()
        {
            int iRet = OPTController_DestroyEthernetConnection(ControllerHandle);
            ControllerHandle = 0;
            return iRet;
        }

        public unsafe
        int
        TurnOnChannel(int Channel)
        {
            return OPTController_TurnOnChannel(ControllerHandle, Channel);
        }

        public unsafe
        int
        TurnOnMultiChannel(int[] ChannelArray, int len)
        {
            return OPTController_TurnOnMultiChannel(ControllerHandle, ChannelArray, len);
        }

        public unsafe
        int
        TurnOffChannel(int Channel)
        {
            return OPTController_TurnOffChannel(ControllerHandle, Channel);
        }

        public unsafe
        int
        TurnOffMultiChannel(int[] ChannelArray, int len)
        {
            return OPTController_TurnOffMultiChannel(ControllerHandle, ChannelArray, len);
        }

        public unsafe
        int
        SetIntensity(int Channel, int Value)
        {
            return OPTController_SetIntensity(ControllerHandle, Channel, Value);
        }

        public unsafe
        int
        SetMultiIntensity(IntensityItem[] IntensityArray, int len)
        {
            return OPTController_SetMultiIntensity(ControllerHandle, IntensityArray, len);
        }

        public unsafe
        int
        ReadIntensity(int Channel, ref int Value)
        {
            fixed (int* value = &Value)
            {
                return OPTController_ReadIntensity(ControllerHandle, Channel, value);
            }
        }

        public unsafe
        int
        SetTriggerWidth(int Channel, int Value)
        {
            return OPTController_SetTriggerWidth(ControllerHandle, Channel, Value);
        }

        public unsafe
        int
        SetMultiTriggerWidth(TriggerWidthItem[] TriggerWidthArray, int len)
        {
            return OPTController_SetMultiTriggerWidth(ControllerHandle, TriggerWidthArray, len);
        }

        public unsafe
        int
        ReadTriggerWidth(int Channel, ref int Value)
        {
            fixed (int* value = &Value)
            {
                return OPTController_ReadTriggerWidth(ControllerHandle, Channel, value);
            }
        }
        
        public unsafe
        int
        SetHBTriggerWidth(int Channel, int Value)
        {
            return OPTController_SetHBTriggerWidth(ControllerHandle, Channel, Value);
        }

        public unsafe
        int
        SetMultiHBTriggerWidth(HBTriggerWidthItem[] HBTriggerWidthArray, int len)
        {
            return OPTController_SetMultiHBTriggerWidth(ControllerHandle, HBTriggerWidthArray, len);
        }

        public unsafe
        int
        ReadHBTriggerWidth(int Channel, ref int Value)
        {
            fixed (int* value = &Value)
            {
                return OPTController_ReadHBTriggerWidth(ControllerHandle, Channel, value);
            }
        }
        
        public unsafe
        int
        EnableResponse(bool isResponse)
        {
            return OPTController_EnableResponse(ControllerHandle, isResponse);
        }
        
        public unsafe
        int
        EnableCheckSum(bool isCheckSum)
        {
            return OPTController_EnableCheckSum(ControllerHandle, isCheckSum);
        }

        public unsafe
        int
        EnablePowerOffBackup(bool isSave)
        {
            return OPTController_EnablePowerOffBackup(ControllerHandle, isSave);
        }

        public unsafe
        int
        ReadSN(StringBuilder SN)
        {
            return OPTController_ReadSN(ControllerHandle, SN);
        }

        public unsafe
        int
        ReadIPConfig(StringBuilder IP, StringBuilder subnetMask, StringBuilder defaultGateway)
        {
            return OPTController_ReadIPConfig(ControllerHandle, IP, subnetMask, defaultGateway);
        }

        public unsafe
        int
        ReadProperties(int properties, StringBuilder value)
        {
            return OPTController_ReadProperties(ControllerHandle, properties,value);
        }


		public unsafe
        int
        SetEthernetConnectionHeartBeat(UInt32 timeout)
        {
            return OPTController_SetEthernetConnectionHeartBeat(ControllerHandle, timeout);
        }

        public unsafe
        int
        SetMaxCurrent(int channelIndex, int current)
        {
            return OPTController_SetMaxCurrent(ControllerHandle, channelIndex, current);
        }

        public unsafe
        int
        ReadMaxCurrent(int channelIndex, int mode, ref int value)
        {
            fixed (int* nValue = &value)
            {
                return OPTController_ReadMaxCurrent(ControllerHandle, channelIndex, mode,nValue);
            }
        }

        public unsafe
        int
        SetMultiMaxCurrent(MaxCurrentItem[] maxCurrentArray, int arrayLenght)
        {
            return OPTController_SetMultiMaxCurrent(ControllerHandle, maxCurrentArray, arrayLenght);
        }

       public unsafe
       int
       ReadMAC(int properties, StringBuilder MAC)
       {
            return OPTController_ReadMAC(ControllerHandle, MAC);
       }

       public unsafe
       int
       SetTriggerActivation(int channelIndex, int triggerActivation)
       {
           return OPTController_SetTriggerActivation(ControllerHandle, channelIndex, triggerActivation);
       }

       public unsafe
       int
       ReadTriggerActivation(int channelIndex, ref int triggerActivation)
       {

           fixed (int* polarity = &triggerActivation)
           {
               return OPTController_ReadTriggerActivation(ControllerHandle, channelIndex, polarity);
           }
       }


       public unsafe
       int
       SetWorkMode(int workMode)
       {
           return OPTController_SetWorkMode(ControllerHandle, workMode);
       }

       public unsafe
       int
       ReadWorkMode(ref int workMode)
       {
           fixed (int* mode = &workMode)
           {
               return OPTController_ReadWorkMode(ControllerHandle, mode);
           }
       }

       public unsafe
       int
       SetOuterTriggerFrequencyUpperBound(int channelIndex, int maxFrequency)
       {
           return OPTController_SetOuterTriggerFrequencyUpperBound(ControllerHandle, channelIndex, maxFrequency);
       }

       public unsafe
       int
       ReadOuterTriggerFrequencyUpperBound(int channelIndex, ref int maxFrequency)
       {

           fixed (int* frequency = &maxFrequency)
           {
               return OPTController_ReadOuterTriggerFrequencyUpperBound(ControllerHandle, channelIndex, frequency);
           }
       }

       public unsafe
       int
       AutoDetectLoadOnce()
       {
           return OPTController_AutoDetectLoadOnce(ControllerHandle);
       }

       public unsafe
       int
       SetAutoStrobeFrequency(int channelIndex, int frequency)
       {
           return OPTController_SetAutoStrobeFrequency(ControllerHandle, channelIndex, frequency);
       }

       public unsafe
       int
       ReadAutoStrobeFrequency(int channelIndex, ref int frequency)
       {
           fixed (int* nfrequency = &frequency)
           {
               return OPTController_ReadAutoStrobeFrequency(ControllerHandle, channelIndex, nfrequency);
           }
           
       }

       public unsafe
       int
       EnableDHCP(Boolean bDHCP)
       {
           return OPTController_EnableDHCP(ControllerHandle, bDHCP);
       }

       public unsafe
       int
       SetLoadMode(int channelIndex, int loadMode)
       {
           return OPTController_SetLoadMode(ControllerHandle, channelIndex, loadMode);
       }


       public unsafe
       int
       GetVersion(StringBuilder version)
       {
           return OPTController_GetVersion(version);
       }

       public unsafe
       int
       ConnectionResetBySN(StringBuilder serialNumber)
       {
           return OPTController_ConnectionResetBySN(serialNumber);
       }

       public unsafe
       int
       IsConnect()
       {
           return OPTController_IsConnect(ControllerHandle);
       }

   


        /******************/
        public unsafe
        int
        GetControllerListOnEthernet(StringBuilder snList)
        {
            return OPTController_GetControllerListOnEthernet(snList);
        }

        public unsafe
        int
        GetChannelState(int channelIdx, int *state)
        {
            return   OPTController_GetChannelState(ControllerHandle, channelIdx, state);
        }

        public unsafe
        int
        SetKeepaliveParameter( int keepalive_time, int keepalive_intvl, int keepalive_probes)
        {
            return   OPTController_SetKeepaliveParameter(ControllerHandle, keepalive_time,  keepalive_intvl, keepalive_probes);
        }

        public unsafe
        int
        EnableKeepalive(bool enable)
        {
            return OPTController_EnableKeepalive(ControllerHandle, enable);
        }

        public unsafe
        int
        SoftwareTrigger(int channelIndex, int time)
        {
            return OPTController_SoftwareTrigger(ControllerHandle, channelIndex, time);
        }

        public unsafe
        int
        MultiSoftwareTrigger(SoftwareTriggerItem[] softwareTriggerArray, int length)
        {
            return OPTController_MultiSoftwareTrigger(ControllerHandle, softwareTriggerArray, length);
        }


        public unsafe
        int
        ReadStepCount(int channelIndex, ref int count)
        {
            fixed (int* nCount = &count)
            {
                return OPTController_ReadStepCount(ControllerHandle, channelIndex, nCount);
            }
        }

        public unsafe
        int
        SetTriggerMode(int moduleIndex, int mode)
        {
            return OPTController_SetTriggerMode(ControllerHandle, moduleIndex, mode);
        }

        public unsafe
        int
        ReadTriggerMode(int moduleIndex, ref int mode)
        {
            fixed (int* nMode = &mode)
            {
                return OPTController_ReadTriggerMode(ControllerHandle, moduleIndex, nMode);
            }
        }

        public unsafe
        int
        SetCurrentStepIndex(int moduleIndex, int curStepIndex)
        {
            return OPTController_SetCurrentStepIndex(ControllerHandle, moduleIndex, curStepIndex);
        }

        public unsafe
        int
        ReadCurrentStepIndex(int moduleIndex, ref int curStepIndex)
        {
            fixed (int* nCurStepIndex = &curStepIndex)
            {
                return OPTController_ReadStepCount(ControllerHandle, moduleIndex, nCurStepIndex);
            }
        }


        public unsafe
        int
        ResetSEQ(int moduleIndex)
        {
            return OPTController_ResetSEQ(ControllerHandle, moduleIndex);
        }


        public unsafe
        int
        SetTriggerDelay(int channelIndex, int triggerDelay)
        {
            return OPTController_SetTriggerDelay(ControllerHandle, channelIndex,triggerDelay);
        }

        public unsafe
        int
        GetTriggerDelay(int channelIndex, ref int triggerDelay)
        {
            fixed (int* nDelay = &triggerDelay)
            {
                return OPTController_ReadStepCount(ControllerHandle, channelIndex, nDelay);
            }
        }

        public unsafe
        int
        SetMultiTriggerDelay(TriggerDelayItem[] triggerDelayArray, int length)
        {
            return OPTController_SetMultiTriggerDelay(ControllerHandle, triggerDelayArray, length);
        }

        public unsafe
        int
        SetSeqTable(int moduleIndex, int seqCount, int[] triggerSource, int[] intensity, int[] pulseWidth)
        {
            return OPTController_SetSeqTable(ControllerHandle, moduleIndex, seqCount, triggerSource, intensity, pulseWidth);
        }

        public unsafe
        int
        ReadSeqTable(int moduleIndex, ref int seqCount, int[] triggerSource, int[] intensity, int[] pulseWidth)
        {
            
            fixed (int* nseqCount = &seqCount)
            {
                return OPTController_ReadSeqTable(ControllerHandle, moduleIndex, nseqCount, triggerSource, intensity, pulseWidth);
            }
        }


        public unsafe
        int
        GetControllerChannels(ref int channels)
        {
            fixed (int* nChannel = &channels)
            {
                return OPTController_GetControllerChannels(ControllerHandle, nChannel);
            }
        }

        public unsafe
        int
        ReadKeepaliveSwitchState(ref int state)
        {
            fixed (int* nState = &state)
            {
                return OPTController_ReadKeepaliveSwitchState(ControllerHandle, nState);
            }
        }

        public unsafe
        int
        ReadContinuousKeepaliveTime(ref int time)
        {
            fixed (int* nTime = &time)
            {
                return OPTController_ReadContinuousKeepaliveTime(ControllerHandle, nTime);
            }
        }

        public unsafe
        int
        ReadPacketDeliveryTimes(ref int times)
        {
            fixed (int* nTimes = &times)
            {
                return OPTController_ReadPacketDeliveryTimes(ControllerHandle, nTimes);
            }
        }

        public unsafe
        int
        ReadIntervalTimeOfPropPacket(ref int time)
        {
            fixed (int* nTime = &time)
            {
                return OPTController_ReadIntervalTimeOfPropPacket(ControllerHandle, nTime);
            }
        }

        public unsafe
        int
        ReadOutputBoardVision(StringBuilder vision)
        {
            return OPTController_ReadOutputBoardVision(ControllerHandle, vision);
        }

        public unsafe
        int
        ReadLoadDetectMode(int channelIndex, ref int mode)
        {
            fixed (int* nMode = &mode)
            {
                return OPTController_ReadLoadDetectMode(ControllerHandle,channelIndex, nMode);
            }
        }

       public unsafe
       int
       SetBootProtection(int channelIndex, int mode)
       {
            return OPTController_SetBootProtection(ControllerHandle, channelIndex, mode);
       }

       public unsafe
       int
       ReadModelBootState(int channelIndex, ref int state)
       {
           fixed (int* nState = &state)
           {
               return OPTController_ReadModelBootState(ControllerHandle, channelIndex, nState);
           }
       }

       public unsafe
       int
       SetIPConfiguration(StringBuilder IP, StringBuilder subnetMask, StringBuilder defaultGateway)
       {
           return OPTController_SetIPConfiguration(ControllerHandle, IP,subnetMask,defaultGateway );
       }

       public unsafe
       int
       SetOutputVoltage(int Channel, int Value)
       {
           return OPTController_SetOutputVoltage(ControllerHandle, Channel, Value);
       }

       public unsafe
       int
       ReadOutputVoltage(int Channel, ref int Value)
       {
           fixed (int* nValue = &Value)
           {
               return OPTController_ReadOutputVoltage(ControllerHandle, Channel, nValue);
           }
       }


      public unsafe
      int
      SetTimeUnit(int Channel, int timeUnit)
       {
           return OPTController_SetTimeUnit(ControllerHandle, Channel, timeUnit);
       }

       public unsafe
       int
       ReadTimeUnit(int Channel, ref int timeUnit)
       {
           fixed (int* nValue = &timeUnit)
           {
               return OPTController_ReadTimeUnit(ControllerHandle, Channel, nValue);
           }
       }

    }
}
