#ifndef __OPTERRORCODE_H__
#define __OPTERRORCODE_H__

#define   OPT_SUCCEED			                           0	 //operation succeed
#define   OPT_ERR_INVALIDHANDLE						 3001001     //invalid handle
#define   OPT_ERR_UNKNOWN                            3001002     //error unknown 
#define   OPT_ERR_INITSERIAL_FAILED                  3001003	 //failed to initialize a serial port
#define   OPT_ERR_RELEASESERIALPORT_FAILED           3001004	 //failed to release a serial port
#define   OPT_ERR_SERIALPORT_UNOPENED                3001005	 //attempt to access an unopened serial port
#define   OPT_ERR_CREATEETHECON_FAILED               3001006     //failed to create an Ethernet connection
#define   OPT_ERR_DESTROYETHECON_FAILED              3001007     //failed to destroy an Ethernet connection
#define   OPT_ERR_SN_NOTFOUND						 3001008     //SN is not found
#define   OPT_ERR_TURNONCH_FAILED                    3001009	 //failed to turn on the specified channel(s)
#define   OPT_ERR_TURNOFFCH_FAILED                   3001010	 //failed to turn off the specified channel(s)
#define   OPT_ERR_SET_INTENSITY_FAILED               3001011     //failed to set the intensity for the specified channel(s)
#define   OPT_ERR_READ_INTENSITY_FAILED              3001012     //failed to read the intensity for the specified channel(s)
#define   OPT_ERR_SET_TRIGGERWIDTH_FAILED	         3001013	 //failed to set trigger pulse width
#define   OPT_ERR_READ_TRIGGERWIDTH_FAILED           3001014	 //failed to read trigger pulse width	
#define   OPT_ERR_READ_HBTRIGGERWIDTH_FAILED         3001015	 //failed to read high brightness trigger pulse width
#define   OPT_ERR_SET_HBTRIGGERWIDTH_FAILED          3001016	 //failed to set high brightness trigger pulse width
#define   OPT_ERR_READ_SN_FAILED                     3001017	 //failed to read serial number
#define   OPT_ERR_READ_IPCONFIG_FAILED               3001018	 //failed to read IP address
#define   OPT_ERR_CHINDEX_OUTRANGE	                 3001019     //index(es) out of the range
#define   OPT_ERR_WRITE_FAILED		                 3001020     //failed to write data
#define   OPT_ERR_PARAM_OUTRANGE	                 3001021     //parameter(s) out of the range 
#define   OPT_ERR_READ_MAC_FAILED					 3001022	 //failed to read MAC
#define   OPT_ERR_SET_MAXCURRENT_FAILED				 3001023	 //failed to set max current
#define	  OPT_ERR_READ_MAXCURRENT_FAILED			 3001024	 //failed to read max current
#define   OPT_ERR_SET_TRIGGERACTIVATION_FAILED		 3001025	 //failed to set trigger activation
#define   OPT_ERR_READ_TRIGGERACTIVATION_FAILED		 3001026	 //failed to read trigger activation
#define   OPT_ERR_SET_WORKMODE_FAILED				 3001027	 //failed to set work mode
#define   OPT_ERR_READ_WORKMODE_FAILED				 3001028	 //failed to read work mode
#define   OPT_ERR_SET_BAUDRATE_FAILED				 3001029	 //failed to set baud rate
#define   OPT_ERR_SET_CHANNELAMOUNT_FAILED			 3001030	 //failed to set channel amount
#define   OPT_ERR_SET_DETECTEDMINLOAD_FAILED		 3001031	 //failed to set detected min load
#define   OPT_ERR_READ_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED 3001032	 //failed to read outer trigger frequency upper bound
#define   OPT_ERR_SET_AUTOSTROBEFREQUENCY_FAILED       3001033	 //failed to set auto-strobe frequency
#define   OPT_ERR_READ_AUTOSTROBEFREQUENCY_FAILED      3001034	 //failed to read auto-strobe frequency
#define   OPT_ERR_SET_DHCP_FAILED					 3001035	 //failed to set DHCP
#define   OPT_ERR_SET_LOADMODE_FAILED				 3001036	 //failed to set load mode
#define   OPT_ERR_READ_PROPERTY_FAILED				 3001037	 //failed to read property
#define   OPT_ERR_CONNECTION_RESET_FAILED			 3001038	 //failed to reset connection
#define	  OPT_ERR_SET_HEARTBEAT_FAILED				 3001039	 //failed to set ethe connection heartbeat

#define   OPT_ERR_GETCONTROLLERLIST_FAILED           3001040     //Failed to get controler(s) list           
#define   OPT_ERR_SOFTWARETRIGGER_FAILED             3001041     //Failed to software trigger                
#define   OPT_ERR_GET_CHANNELSTATE_FAILED            3001042     //Failed to get channelstate          
#define   OPT_ERR_SET_KEEPALIVEPARAMETERS_FAILED     3001043     //Failed to set keepalvie parameters          
#define   OPT_ERR_ENABLE_KEEPALIVE_FAILED            3001044     //Failed to enable/disable keepalive

#define   OPT_ERR_READSTEPCOUNT_FAILED               3001045     //Failed to read step count           
#define   OPT_ERR_SETTRIGGERMODE_FAILED              3001046     //Failed to set trigger mode    
#define   OPT_ERR_READTRIGGERMODE_FAILED             3001047     //Failed to read trigger mode      
#define   OPT_ERR_SETCURRENTSTEPINDEX_FAILED         3001048     //Failed to set current step index          
#define   OPT_ERR_READCURRENTSTEPINDEX_FAILED        3001049     //Failed to read current step index          
#define   OPT_ERR_RESETSEQ_FAILED       3001050     //Failed to reset current step index

#define   OPT_ERR_SETTRIGGERDELAY_FAILED             3001051     //Failed to set trigger delay
#define   OPT_ERR_GET_TRIGGERDELAY_FAILED            3001052     //Failed to get trigger delay
#define   OPT_ERR_SETMULTITRIGGERDELAY_FAILED        3001053     //Failed to set multiple channels trigger delay

#define   OPT_ERR_SETSEQTABLEDATA_FAILED             3001054     //Failed to set SEQ table data
#define   OPT_ERR_READSEQTABLEDATA_FAILED            3001055     //Failed to Read SEQ table data

#define   OPT_ERR_READ_CHANNELS_FAILED               3001056     //Failed to read controller's channel
#define   OPT_ERR_READ_KEEPALIVE_STATE_FAILED        3001057     //Failed to read the state of keepalive
#define   OPT_ERR_READ_KEEPALIVE_CONTINUOUS_TIME_FAILED    3001058     //Failed to read the continuous time of keepalive
#define   OPT_ERR_READ_DELIVERY_TIMES_FAILED          3001059     //Failed to read the delivery times of prop packet
#define   OPT_ERR_READ_INTERVAL_TIME_FAILED           3001060     //Failed to read the interval time of prop packet
#define   OPT_ERR_READ_OUTPUTBOARD_VISION_FAILED      3001061     //Failed to read the vision of output board
#define   OPT_ERR_READ_DETECT_MODE_FAILED             3001062     //Failed to read detect mode of load
#define   OPT_ERR_SET_BOOT_STATE_MODE_FAILED     3001063     //Failed to set mode of boot state
#define   OPT_ERR_READ_MODEL_BOOT_MODE_FAILED         3001064     //Failed to read the specified channel boot state
#define   OPT_ERR_SET_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED  3001065 //Failed to set outer trigger frequency upper bound
#define   OPT_ERR_SET_IPCONFIG_FAILED                 3001066     //Failed to set IP configuration of the controller
#define   OPT_ERR_SET_VOLTAGE_FAILED                 3001067     //Failed to set voltage of specified channel voltage
#define   OPT_ERR_READ_VOLTAGE_FAILED                 3001068     //Failed to read the specified channel's voltage
 
#define   OPT_ERR_SET_TIMEUNIT_FAILED                 3001069     //Failed to set time unit
#define   OPT_ERR_READ_TIMEUNIT_FAILED                3001070     //Failed to read time unit






#endif
