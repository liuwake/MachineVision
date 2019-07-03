// OPTController.h : OPTController DLL 的主头文件
//

#pragma once

/*************************************************
Copyright (C), 2005 OPT MACHINE VISION TECH CO.,LTD. All rights reserved.
Version: 1.0.8          
Date: 2015.03.10         
Description: the set of functions that exported for the controller to control light source, such as turn on/off the light source, 
             adjust the intensity.
History: 
Shengping Wang 2014/10/17 1.0.0 build this module
Shengping Wang 2014/11/14 1.0.1 fix bug:#001  
Shengping Wang 2014/11/19 1.0.5 fix bug:#002 #003
Shengping Wang 2014/12/03 1.0.6 fix bug:#004
Jintang	  Mai  2015/03/06 1.0.7 fix bug:#005
Jintang	  Mai  2015/03/10 1.0.8 add new function : OPTController_ConnectionResetByIP OPTController_SetEtheConnectionHeartBeat
Zhouping       2016.05.11 1.1.0 add new function: OPTController_IsConnect
ZhongYong      20161014   1.0.12 add new functions and fix bugs
ZhouLi         20171114   1.0.13 add new functions and fix bugs
ZhouLi         20180903   1.0.14 add new functions,fix bugs
*************************************************/

#ifndef __OPTCONTROLER_H__
#define __OPTCONTROLER_H__


#define DLL_EXPORT __declspec(dllexport)   // ZP

//typedef	  long   OPTController_Handle;

#ifdef _WIN64 //zy 20160809
typedef	  long long   OPTController_Handle;
#else
typedef	  long   OPTController_Handle;
#endif

typedef struct OPTController_IntensityItem
{
	int channelIndex;
	int intensity;
}IntensityItem;

typedef struct OPTController_TriggerWidthItem
{
	int channelIndex;
	int triggerWidth;
}TriggerWidthItem;

typedef struct OPTController_HBTriggerWidthItem
{
	int channelIndex;
	int HBTriggerWidth;
}HBTriggerWidthItem;

typedef struct OPTController_MaxCurrentItem
{
	int channelIndex;
	int maxCurrent;
}MaxCurrentItem;

typedef struct OPTController_SoftwareTriggerItem
{
	int channelIndex;
	int time;
}SoftwareTriggerItem;

typedef struct OPTController_TriggerDelayItem
{
	int channelIndex;
	int time;
}TriggerDelayItem;

extern "C" //ZP
{
	/*******************************************************************
	Function: OPTController_InitSerialPort
	Description:  initialize an available serial port
	Input(s):  
	    comName  -the name of the serial port. e.g., "COM1"
	Output(s): 
	    controllerHandle -the handle of the controller
	Return: 
	    succeed  -OPT_SUCCEED
	    failed   -OPT_ERR_INITSERIAL_FAILED or OPT_ERR_SERIALPORT_UNOPENED (see the error code in  OPTErrorCode.h)
	See also: OPTController_ReleaseSerialPort
	*******************************************************************/
	long DLL_EXPORT OPTController_InitSerialPort(char *comName, OPTController_Handle *controllerHandle);

	
	/*******************************************************************
	Function: OPTController_ReleaseSerialPort
	Description: release an existing serial port
	Input(s): 
	    controllerHandle -the handle of the controller
	Return:   
	    succeed  -OPT_SUCCEED
		failed   -OPT_ERR_RELEASESERIALPORT_FAILED     
	See also: OPTController_InitSerialPort                                                        
	****************************************************************/
	long DLL_EXPORT OPTController_ReleaseSerialPort(OPTController_Handle controllerHandle);

	
	/*******************************************************************
	Function: OPTController_CreateEthernetConnectionByIP
	Description: create an Ethernet connection by IP address
	Input(s):  
	    serverIPAddress    -the IP of the server. e.g.: IP address of the device which is employed as server. The server IP address can be 127.0.0.1
	Output(s): 
	    controllerHandle   -the handle of the controller
	Return: 
	    succeed   -OPT_SUCCEED
		failed    -OPT_ERR_CREATEETHECON_FAILED        
	See also: OPTController_DestroyEthernetConnection   
	Remarks:  
	    (1) connect to a server as a client. Before connecting, make sure that the controller is connected to the LAN
		(2) We recommend creating an Ethernet connection by SN (compared with by IP) because IP is likely to be changed dynamically in LAN 
	        under the DHCP protocol. We have provided a tool (SearchForControllers.exe) to check SN.
	*******************************************************************/
	long DLL_EXPORT OPTController_CreateEthernetConnectionByIP(char *serverIPAddress, OPTController_Handle *controllerHandle);

	
	/*******************************************************************
	Function: OPTController_CreateEthernetConnectionBySN
	Description: create an Ethernet connection by serial number
	Input(s): 
	    serialNumber     -the serial number of the controller 
	Output(s): 
	    controllerHandle -the handle of the controller
	Return: 
	    succeed   -OPT_ SUCCEED
	    failed    -OPT_ERR_CREATEETHECON_FAILED 
	See also: OPTController_DestroyEthernetConnect  
	Remarks:  
	    (1) connect to a server as a client. Before connecting, make sure that the controller is connected to the LAN
	    (2) We recommend creating an Ethernet connection by SN (compared with by IP) because IP is likely to be changed dynamically in LAN 
	        under the DHCP protocol. We have provided a tool (SearchForControllers.exe) to check SN.
	*******************************************************************/
	long DLL_EXPORT OPTController_CreateEthernetConnectionBySN(char *serialNumber, OPTController_Handle *controllerHandle);

	
	/*****************************************************************
	Function: OPTController_DestroyEthernetConnection
	Description: destroy an existing Ethernet Connection
	Input(s):    
	    controllerHandle  -the handle of the controller
	Return: 
	    succeed   -OPT_SUCCEED
	    failed    -OPT_ERR_DESTROYETHECON_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_DestroyEthernetConnection(OPTController_Handle controllerHandle);

	
	/*******************************************************************
	Function: OPTController_TurnOnChannel
	Description:turn on the specified channel(s)
	Input(s):
	    controllerHandle -the handle of controller
	    channelIndex     -the index(es) of the channel(s) to be turned on, range:[0-16] (in decimal form, 0 for all channels)
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_TURNONCH_FAILED
	See also: OPTController_TurnOffChannel           
	*******************************************************************/
	long DLL_EXPORT OPTController_TurnOnChannel(OPTController_Handle controllerHandle,int channelIndex);

	
	/*******************************************************************
	Function: OPTController_TurnOnMultiChannel
	Description: turn on the specified multiple channels
	Input(s):
	    controllerHandle   -the handle of controller
	    channelIndexArray  -an array consists of the indexes of the channels to be turned on, range:[1-16] (in decimal form)
		length             -the length of the channel index array
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_TURNONCH_FAILED
	See also: OPTController_TurnOffMultiChannel              
	*******************************************************************/
	long DLL_EXPORT OPTController_TurnOnMultiChannel(OPTController_Handle controllerHandle,int* channelIndexArray, int length);


	/*******************************************************************
	Function: OPTController_TurnOffChannel
	Description: turn off the specified channel(s)
	Input(s):
	    controllerHandle -the handle of controller
	    channelIndex     -the index(es) of the channel(s) to be turned off, range:[0-16] (in decimal form, 0 for all channels);
	Return:
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_TURNOFFCH_FAILED
    See also: OPTController_TurnOnChannel  
	*******************************************************************/
	long DLL_EXPORT OPTController_TurnOffChannel(OPTController_Handle controllerHandle,int channelIndex);

	
	/*******************************************************************
	Function: OPTController_TurnOffMultiChannel
	Description: turn off the specified multiple channels
	Input(s):
	    controllerHandle  -the handle of controller;
	    channelIndexArray -an array consists of the indexes of the channels to be turned off, range:[1-16] (in decimal form);
		length            -the length of the channel index array
	Return: 
	    succeed    -OPT_SUCCEED;
	    failed     -OPT_ERR_TURNOFFCH_FAILED
    See also: OPTController_TurnOnMultiChannel 
	*******************************************************************/
	long DLL_EXPORT OPTController_TurnOffMultiChannel(OPTController_Handle controllerHandle,int* channelIndexArray, int length);

	/*******************************************************************
	Function: SetIntensity
	Description: set intensity for the specified channel(s)
	Input(s):
	    controllerHandle -the handle of controller
	    channelIndex     -the index(es) of the channel(s), range:[0-16] (in decimal form, 0 for all channels)
	    intensity        -the intensity value, range: [0-255] (in decimal form)
	Return:   
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_INTENSITY_FAILED
    See also: OPTController_ReadIntensity
	*******************************************************************/
	long DLL_EXPORT OPTController_SetIntensity (OPTController_Handle controllerHandle,int channelIndex, int intensity);

	
	/*******************************************************************
	Function: SetMultiIntensity
	Description: set intensities for the specified multiple  channels
	Input(s):
	    controllerHandle -the handle of controller
	    intensityArray   -an array consists of the intensities (and the indexes of corresponding channels) to be set, range: [0-255] (in decimal form)
		length           -the length of the intensity array
	Return:   
	    succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_INTENSITY_FAILED    
    See also: OPTController_ReadIntensity
	*******************************************************************/
	long DLL_EXPORT OPTController_SetMultiIntensity (OPTController_Handle controllerHandle,IntensityItem* intensityArray, int length);

	
	/*******************************************************************
	Function: ReadIntensity
	Description: read intensity of the specified channel
	Input(s):
	controllerHandle -the handle of controller
	channelIndex     -the index of the channel, range: [1-16] (in decimal form)
	Output(s): 
	    intensity    -the obtained intensity value;
	Return: 
	    succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_INTENSITY_FAILED   
	See also: OPTController_SetIntensity & OPTController_SetMultiIntensity
	****************************************************************/
	long DLL_EXPORT OPTController_ReadIntensity (OPTController_Handle controllerHandle,int channelIndex, int *intensity);

	/*******************************************************************
	Function: SetTriggerWidth
	Description: set trigger pulse width for corresponding channel(s)
	Input(s):
	    controllerHandle  -the handle of controller
	    channelIndex      -the index(es) of the channel(s), range:[0-16] (in decimal form, 0 for all channels)
	    triggerWidth      -the value of the trigger pulse width to be set, range:[1-1023],optional trigger width units are available:1us,10us,1ms,100ms,
		                  default time unit is 1ms.when time unit is 100ms,the maximum is 300(30s).Please refer to the manual for details.
	Return: 
	    succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_TRIGGERWIDTH_FAILED        
	See also: OPTController_ReadTriggerWidth
	******************************************************************/
	long DLL_EXPORT OPTController_SetTriggerWidth(OPTController_Handle controllerHandle,int channelIndex, int triggerWidth);

	
	/*******************************************************************
	Function: SetMultiTriggerWidth
	Description: set trigger pulse width for the specified multiple  channels simultaneously 
	Input(s):
	    controllerHandle   -the handle of controller
		triggerWidthArray  -an array consists of values of the trigger pulse width (and the indexes of corresponding channels) to be set, range:[1-1023],optional trigger width units are available:1us,10us,1ms,100ms,
		default time unit is 1ms.when time unit is 100ms,the maximum is 300(30s).Please refer to the manual for details.
		length             -the length of the trigger width array
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_TRIGGERWIDTH_FAILED
    See also: OPTController_ReadTriggerWidth
	******************************************************************/
	long DLL_EXPORT OPTController_SetMultiTriggerWidth(OPTController_Handle controllerHandle,TriggerWidthItem* triggerWidthArray, int length);

	
	/*******************************************************************
	Function: ReadTriggerWidth
	Description: read the trigger pulse width of the specified channel
	Input(s):
	    controllerHandle  -the handle of controller;
	    channelIndex      -the index of the channel, range:[1-16] (in decimal form)
	Output(s):    
	    triggerWidth      -the obtained trigger pulse width;
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_TRIGGERWIDTH_FAILED	    
	See also: OPTController_SetTriggerWidth & OPTController_SetMultiTriggerWidth
	****************************************************************/
	long DLL_EXPORT OPTController_ReadTriggerWidth(OPTController_Handle controllerHandle,int channelIndex, int* triggerWidth);

	
	/*******************************************************************
	Function: SetHBTriggerWidth
	Description: set the high brightness trigger pulse width for corresponding channel(s);
	Input(s):
	    controllerHandle  -the handle of controller;
	    channelIndex      -the index(es) of the channel(s), range:[0-16] (in decimal form, 0 for all channels);
	    HBTriggerWidth    -the value of the high brightness trigger pulse width to be set, range:[1-500].unit:0.01ms
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_HBTRIGGERWIDTH_FAILED
	See also: OPTController_ReadHBTriggerWidth
	****************************************************************/
	long DLL_EXPORT OPTController_SetHBTriggerWidth(OPTController_Handle controllerHandle,int channelIndex, int HBTriggerWidth);

	
	/*******************************************************************
	Function: SetMultiHBTriggerWidth
	Description: set high brightness trigger pulse width for the specified multiple channels
	Input(s):
	    controllerHandle     -the handle of controller;
	    HBtriggerWidthArray  -an array consists of values of the high brightness trigger pulse width (and the indexes of corresponding channels) 
		                      to be set, range:[1-500].unit:0.01ms
		length               -the length of the high brightness trigger width array
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_HBTRIGGERWIDTH_FAILED
    See also: OPTController_ReadHBTriggerWidth
	****************************************************************/
	long DLL_EXPORT OPTController_SetMultiHBTriggerWidth(OPTController_Handle controllerHandle,HBTriggerWidthItem* HBtriggerWidthArray, int length);

	
	/*******************************************************************
	Function：ReadHBTriggerWidth
	Description: read the high brightness trigger pulse width of the specified channel
	Input(s):
	    controllerHandle  -the handle of controller
	    channelIndex      -the index of the channel, range:[1-16] (in decimal form)
	Output(s):  	 
	    HBTriggerWidth    -the obtained high brightness trigger pulse width
	Return: 
	    succeed    -OPT_SUCCEED
 	    failed     -OPT_ERR_READ_HBTRIGGERWIDTH_FAILED
    See also: OPTController_SetHBTriggerWidth & OPTController_SetMultiHBTriggerWidth
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadHBTriggerWidth(OPTController_Handle controllerHandle,int channelIndex,int* HBTriggerWidth);

	
	/*******************************************************************
	Function: OPTController_EnableResponse
	Description:  to set whether return value are needed or not
	Input:
		controllerHandle  -the handle of controller
		isResponse        -"true" means "need response" while "false" stands for not
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_UNKNOWN
	*****************************************************************/
	long DLL_EXPORT OPTController_EnableResponse(OPTController_Handle controllerHandle,bool isResponse);

	
	/*******************************************************************
	Function: OPTController_EnableCheckSum
	Description: to set whether checksum are needed or not
	Input:
	    controllerHandle  -the handle of controller
	    isCheckSum        -"true" means "need checksum" while "false" stands for not
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_UNKNOWN
	*****************************************************************/
	long DLL_EXPORT OPTController_EnableCheckSum(OPTController_Handle controllerHandle, bool isCheckSum);

	
	/*******************************************************************
	Function：OPTController_EnablePowerOffBackup
	Description:  to set whether backup are needed or not in the case of power off
	Input:
		controllerHandle   -the handle of controller
		isSave:            -"true" means "need back up" while "false" stands for not
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_UNKNOWN
	*****************************************************************/
	long DLL_EXPORT OPTController_EnablePowerOffBackup(OPTController_Handle controllerHandle,bool isSave);

	
	/*******************************************************************
	Function: OPTController_ReadSN
	Description: read the serial number (SN) of the controller
	Input:
		controllerHandle  -the handle of controller
	Output:
		SN 	              -the obtained serial number
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_READ_SN_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadSN(OPTController_Handle controllerHandle, char *SN);

	
	/*******************************************************************
	Function: OPTController_ReadIPConfig
	Description: read IP configuration of the controller
	Input:
		controllerHandle	 -the handle of controller
	Output:
		IP                   -the obtained IP address
		subnetMask           -the obtained subnet mask
		defaultGateway       -the obtained default gateway
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_READ_IPCONFIG_FAILED
	Remark:only for Ethernet controllers
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadIPConfig(OPTController_Handle controllerHandle, char *IP, char *subnetMask, char *defaultGateway);

	
	/*******************************************************************
	Function: OPTController_SetMaxCurrent
	Description: set maximum current for the specified channel	
	Input:
		controllerHandle	-the handle of controller
		channelIndex		-the index(es) of the channel(s), range:[0-16] (in decimal form, 0 for all channels);
		current				-the value of the maximum current to be set, range:[1-200].unit 10mA.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_MAXCURRENT_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetMaxCurrent (OPTController_Handle controllerHandle, int channelIndex, int current);

	
	/*******************************************************************
	Function: OPTController_ReadMaxCurrent
	Description: read maximum current for the specified channel	
	Input:
		controllerHandle	-the handle of controller
		channelIndex		-the index of the channel, range:[1-16] (in decimal form)
		mode               -the mode of value,range:[0-2]
		                    0:Read manually set current value;
							1:Read current value;
							2:Read voltage value.
	Output(s):  	 
		value    -the obtained value.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_MAXCURRENT_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadMaxCurrent (OPTController_Handle controllerHandle, int channelIndex, int mode,int *value);

	
	/*******************************************************************
	Function: OPTController_SetMultiMaxCurrent
	Description: set maximum current for the specified multiple channels
	Input(s):
		controllerHandle     -the handle of controller;
		maxCurrentArray		 -an array consists of values of the maximum current (and the indexes of corresponding channels) 
							 to be set, range:[1-200],unit 10mA.
	    length			     -the length of the maximum current array
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_MAXCURRENT_FAILED	
	****************************************************************/
	long DLL_EXPORT OPTController_SetMultiMaxCurrent(OPTController_Handle controllerHandle, MaxCurrentItem *maxCurrentArray, int length);

	
	/*******************************************************************
	Function: OPTController_ReadMAC
	Description: read the media access control (MAC) address of the controller
	Input:
		controllerHandle	 -the handle of controller
	Output:
		MAC 				 -the obtained media access control
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_MAC_FAILED
    Remark:only for Ethernet controllers
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadMAC(OPTController_Handle controllerHandle, char *MAC);

	
	/*******************************************************************
	Function: OPTController_SetTriggerActivation
	Description: set the trigger activation of the controller
	Input:
		controllerHandle		-the handle of controller
        channelIndex            -the index(es) of the channel(s), range:[0-16](in decimal form, 0 for all channels).	
		triggerActivation		-the value of the trigger activation to be set, range:[0-3].
		                         0:realTime positive trigger.
		                         1:realTime negative trigger.
		                         2:falling edge trigger.
		                         3:rising edge trigger.

	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_TRIGGERACTIVATION_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetTriggerActivation(OPTController_Handle controllerHandle,int channelIndex, int triggerActivation);

	
	/*******************************************************************
	Function: OPTController_ReadTriggerActivation
	Description: read the trigger activation of the controller
	Input:
		controllerHandle	-the handle of controller
        channelIndex        -he index(es) of the channel, range:[1-16](in decimal form).
	Output:
		triggerActivation	-the obtained trigger activation
		                    0:realTime positive trigger.
	                     	1:realTime negative trigger.
	                     	2:falling edge trigger.
	                    	3:rising edge trigger.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_TRIGGERACTIVATION_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadTriggerActivation(OPTController_Handle controllerHandle, int channelIndex, int *triggerActivation);

	
	/*******************************************************************
	Function: OPTController_SetWorkMode
	Description: set the working mode of the controller
	Input:
		controllerHandle		-the handle of controller	
		workMode				-the value of the work mode to be set, range:[0-3].
		                         0 for general lighting mode.
		                         1 for general trigger mode.
		                         2 for highlight trigger mode.
		                         3 for set the working mode on panel.

	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_WORKMODE_FAILED
	Others:
	    Only for mini digital controller effective.
	*****************************************************************/
	long DLL_EXPORT OPTController_SetWorkMode(OPTController_Handle controllerHandle, int workMode);

	
	/*******************************************************************
	Function: OPTController_ReadWorkMode
	Description: read the work mode of the controller
	Input:
		controllerHandle		-the handle of controller
	Output:
		workMode				-the obtained work mode
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_WORKMODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadWorkMode(OPTController_Handle controllerHandle, int *workMode);


	/*******************************************************************
	Function: OPTController_SetOuterTriggerFrequencyUpperBound
	Description: set the upper bound of the outer frequency of the controller
	Input:
		controllerHandle		-the handle of controller
		channelIndex			-the index(es) of the channel(s), range:[0-16] (in decimal form);
		maxFrequency			-the obtained maximum frequency,range:[1-900],unit:1Hz.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED
    Remark:Only for strobe mode controller
	*****************************************************************/
	long DLL_EXPORT OPTController_SetOuterTriggerFrequencyUpperBound(OPTController_Handle controllerHandle, int channelIndex,int maxFrequency);


	/*******************************************************************
	Function: OPTController_ReadOuterTriggerFrequencyUpperBound
	Description: read the upper bound of the outer frequency of the controller
	Input:
		controllerHandle		-the handle of controller
		channelIndex			-the index(es) of the channel(s), range:[1-16] (in decimal form);
	Output:
		maxFrequency			-the obtained maximum frequency
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_OUTERTRIGGERFREQUENCYUPPERBOUND_FAILED
    Remark:Only for strobe mode controller
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadOuterTriggerFrequencyUpperBound(OPTController_Handle controllerHandle, int channelIndex,int *maxFrequency);

	
	/*******************************************************************
	Function: OPTController_AutoDetectLoadOnce
	Description: The controller automatically detects the load current once it receives this command.
	Input:
		controllerHandle		-the handle of controller	
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_WRITE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_AutoDetectLoadOnce(OPTController_Handle controllerHandle);

	
	/*******************************************************************
	Function: OPTController_SetAutoStrobeFrequency
	Description: set the auto-strobe frequency of the controller
	Input:
		controllerHandle		-the handle of controller	
		channelIndex			-the index(es) of the channel(s), range:[0-16] (in decimal form, 0 for all channels);
		frequency				-the value of the frequency to be set, range:[15-1000].
	Return: 
	succeed    -OPT_SUCCEED
	failed     -OPT_ERR_SET_AUTOSTROBEFREQUENCY_FAILED
	Remark:Only for strobe mode controller
	*****************************************************************/
	long DLL_EXPORT OPTController_SetAutoStrobeFrequency(OPTController_Handle controllerHandle, int channelIndex, int frequency);

	
	/*******************************************************************
	Function: OPTController_ReadAutoStrobeFrequency
	Description: read the auto-strobe frequency of the controller
	Input:
		controllerHandle		-the handle of controller	
		channelIndex			-the index(es) of the channel(s), range:[1-16] (in decimal form);
	Output:
		frequency				-the obtained frequency
	Return: 
	succeed    -OPT_SUCCEED
	failed     -OPT_ERR_READ_AUTOSTROBEFREQUENCY_FAILED
	Remark:Only for strobe mode controller
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadAutoStrobeFrequency(OPTController_Handle controllerHandle, int channelIndex, int *frequency);

	
	/*******************************************************************
	Function: OPTController_EnableDHCP
	Description: to enable the Dynamic Host Configuration Protocol(DHCP) or disable it
	Input:
		controllerHandle		-the handle of controller
		bDHCP					-"TRUE" means "enable DHCP" while "FALSE" stands for disable
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_DHCP_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_EnableDHCP(OPTController_Handle controllerHandle, BOOL bDHCP);

	
	/*******************************************************************
	Function: OPTController_SetLoadMode
	Description: set the load mode of the controller
	Input:
		controllerHandle		-the handle of controller			
		loadMode				-the value of the load mode to be set, 
		                         0 for automatic detection of load current 
								 1 for manually set the maximum current
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_LOADMODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetLoadMode(OPTController_Handle controllerHandle,int channelIndex,  int loadMode);

	
	/*******************************************************************
	Function: OPTController_ReadProperties
	Description: read the property of the controller
	Input:
		controllerHandle		-the handle of controller
		property				-the code of the property to be read, 
		                        1 for model; 
								2 for firmware version.
	Output:
		value					-the obtained property
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_PROPERTY_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadProperties(OPTController_Handle controllerHandle, int property, char *value);

	
	/*******************************************************************
	Function: OPTController_GetVersion
	Description: get version of the controller dll	
	Output:
		version					-the version of the controller dll
	Return: 
	succeed    -OPT_SUCCEED
	*****************************************************************/
	long DLL_EXPORT OPTController_GetVersion(char *version);

	
	/*******************************************************************
	Function: OPTController_ConnectionResetBySN
	Description: reset Ethernet connection	
	Input:
		serialNumber		-the serial number of controller
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_CONNECTION_RESET_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ConnectionResetBySN(char *serialNumber);

	
	/*******************************************************************
	Function: OPTController_ConnectionResetByIP
	Description: reset Ethernet connection	
	Input:
		serverIPAddress		-the IP address of controller
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_CONNECTION_RESET_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ConnectionResetByIP(char *serverIPAddress);

	
	/*******************************************************************
	Function: OPTController_SetEthernetConnectionHeartBeat
	Description: set Ethernet connection heartbeat	
	Input:
		controllerHandle		-the handle of controller
		timeout					-heartbeat timeout,range[1,65535],unit:1s,default 5s timeout
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_HEARTBEAT_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetEthernetConnectionHeartBeat(OPTController_Handle controllerHandle, unsigned timeout);

	
    /****************************************************************
	Function: OPTController_IsConnect(OPTController_Handle controllerHandle)
	Description: check Controller Connect state
	Input:
	controllerHandle		-the handle of controller
	Return: 
	succeed    - OPT_SUCCEED (0)
	failed     - OPT_ERR_UNKNOWN

	****************************************************************/
    long DLL_EXPORT OPTController_IsConnect(OPTController_Handle controllerHandle); //ZP

	

    /****************************************************************
	Function: OPTController_GetControllerListOnEthernet(char *snList);
	Description: search for the Online controllers, for Ethernet  only.
	Input:
	snList	   -the point of char,should new by user and make sure the length is enough  
	Return: 
	succeed    - OPT_SUCCEED (0) 
	failed     - OPT_ERR_GETCONTROLLERLIST_FAILED

	****************************************************************/
   long DLL_EXPORT OPTController_GetControllerListOnEthernet(char *snList); 

   /*******************************************************************
	Function: OPTController_GetChannelState
	Description: get channel state	
	Input:
	   controllerHandle		-the handle of controller
	   channelIndex			-the index(es) of the channel(s), range:[1-16] (in decimal form);
    Output:
	   state				-channel state; 0 --Light sources connected
	                                        1 --Light sources disconnected
											2 --Short circuit protection
											3 --Over voltage protection
											4 --Over current protection
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_GET_CHANNELSTATE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_GetChannelState(OPTController_Handle controllerHandle, int channelIndex, int *state);


	/*******************************************************************
	Function: OPTController_SetKeepaliveParameter
	Description: set keepalive parameter	
	Input:
	   controllerHandle		-the handle of controller
	   keepalive_time		-idle time,range:[1-65535] (in decimal form),Unit:seconds;
	   keepalive_intvl		-interval between two keepalive_probes,range:[1-65535] (in decimal form),Unit:seconds;
       keepalive_probes     -probes of keepalive range:[1-65535]
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_KEEPALIVEPARAMETERS_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetKeepaliveParameter(OPTController_Handle controllerHandle, int keepalive_time,
		int keepalive_intvl, int keepalive_probes);

	/*******************************************************************
	Function: OPTController_EnableKeepalive
	Description: to enable the keepalive or disable it
	Input:
		controllerHandle		-the handle of controller
		enable					-"TRUE" means "enable keepalive" while "FALSE" stands for disable
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_ENABLE_KEEPALIVE_FAILED
	*****************************************************************/
    long DLL_EXPORT OPTController_EnableKeepalive(OPTController_Handle controllerHandle, BOOL enable);

   /*******************************************************************
	Function:OPTController_SoftwareTrigger
	Description: software trigger,specified channel on specified time.
	Input:
	   controllerHandle		-the handle of controller
	   channelIndex			-the index(es) of the channel(s), range:[0-16] (in decimal form, 0 for all channels)
	   time					-light duration,range:[1-3000],Unit:10ms
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SOFTWARETRIGGER_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SoftwareTrigger(OPTController_Handle controllerHandle, int channelIndex, int time);

	/*******************************************************************
	Function: OPTController_MultiSoftwareTrigger
	Description: software trigger for the specified multiple channels
	Input(s):
		controllerHandle       -the handle of controller
		softwareTriggerArray   -an array consists of values of the software trigger (and the indexes of corresponding channels) 
							 to be set, range:[1-3000],Unit:10ms
	    length				   -the length of the softwareTrigger array
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SOFTWARETRIGGER_FAILED	
	****************************************************************/
    long DLL_EXPORT OPTController_MultiSoftwareTrigger(OPTController_Handle controllerHandle, SoftwareTriggerItem* softwareTriggerArray, int length);


////20170316 add--SEQ Operation
   /*******************************************************************
	Function:OPTController_ReadStepCount
	Description: read the specified channel's programmable trigger step count.
	Input:
	   controllerHandle		-the handle of controller
	    moduleIndex			-the index of the module, range:[1-4],
		                    1 for channel 1 to channel 4;
							2 for channel 5 to channel 8;
							3 for channel 9 to channel 12;
							4 for channel 13 to channel 16
    Output:
       count                -the specified channel's stepCount
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READSTEPCOUNT_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadStepCount(OPTController_Handle controllerHandle, int moduleIndex, int* count);

	/*******************************************************************
	Function:OPTController_SetTriggerMode
	Description: set the specified channel's SEQ trigger mode.
	Input:
	   controllerHandle		-the handle of controller
	    moduleIndex			-the index of the module, range:[1-4],
		                     1 for channel 1 to channel 4;
							 2 for channel 5 to channel 8;
							 3 for channel 9 to channel 12;
							 4 for channel 13 to channel 16
	   mode					-trigger mode,range:[1-2]. 1:General-Trigger-mode; 2:Programmable-Trigger-mode;
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SETTRIGGERMODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetTriggerMode(OPTController_Handle controllerHandle,int moduleIndex, int mode);
	
   /*******************************************************************
	Function:OPTController_ReadTriggerMode
	Description: read the specified channel's SEQ trigger mode.
	Input:
	   controllerHandle		-the handle of controller
	   moduleIndex			-the index of the module, range:[1-4],1 for channel 1 to channel 4, 2 for channel 5 to channel 8,3 for channel 9 to channel 12, 4 for channel 13 to channel 16
	Output:
	   mode					-trigger mode,range:[1-2].  1:General-Trigger-Mode; 2:Programmable-Trigger-Mode;
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READTRIGGERMODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadTriggerMode(OPTController_Handle controllerHandle, int moduleIndex, int *mode);
	
	 /*******************************************************************
	Function:OPTController_SetCurrentStepIndex
	Description: set the specified channel's current Step Index.
	Input:
	   controllerHandle		-the handle of controller
	    moduleIndex			-the index of the module, range:[1-4],
		                    1 for channel 1 to channel 4;
							2 for channel 5 to channel 8;
							3 for channel 9 to channel 12;
							4 for channel 13 to channel 16
	   curStepIndex		    -the specified channel's current step index,range:[1-64]
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SETCURRENTSTEPINDEX_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetCurrentStepIndex(OPTController_Handle controllerHandle, int moduleIndex, int curStepIndex);
	
	/*******************************************************************
	Function:OPTController_ReadCurrentStepIndex
	Description: read the specified channel's current step index.
	Input:
	   controllerHandle		-the handle of controller
	    moduleIndex			-the index of the module, range:[1-4],
		                   1 for channel 1 to channel 4; 
						   2 for channel 5 to channel 8;
						   3 for channel 9 to channel 12;
						   4 for channel 13 to channel 16.
    Output:
	   curStepIndex		    -the specified channel's current step index,range:[1-64]
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READCURRENTSTEPINDEX_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadCurrentStepIndex(OPTController_Handle controllerHandle, int moduleIndex, int* curStepIndex);
	
	/*******************************************************************
	Function:OPTController_ResetSEQ
	Description: reset the specified channel's SEQ.
	Input:
	   controllerHandle		-the handle of controller
	   moduleIndex			-the index of the module, range:[1-4],
	                        1 for channel 1 to channel 4;
							2 for channel 5 to channel 8;
							3 for channel 9 to channel 12;
							4 for channel 13 to channel 16.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_RESETSEQ_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ResetSEQ(OPTController_Handle controllerHandle, int moduleIndex);

	 /*******************************************************************
	Function:OPTController_SetSeqTable
	Description: set the specified channel's SEQ table data.
	Input:
	   controllerHandle		-the handle of controller   
	   moduleIndex			-the index of the module, range:[1-4],1 for channel1 to channel 4, 2 for channel5 to channel8,3 for channel9 to channel 12, 4 for channel13 to channel 16
	   seqCount             -the SEQ count,range:[1-64]
	   triggerSource        -the trigger source data,range[1-16](the value of moduleIndex is 1,the range of triggerSource is [1-4];the value of moduleIndex is 2,the range of triggerSource is [5-8];the value of moduleIndex is 3,the range of triggerSource is [9-12];the value of moduleIndex is 4,the range of triggerSource is [13-16])
       intensity            -the intensity data,range[0,255]
       pulseWidth           -the pulse width data,range[0,1023]
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SETSEQTABLEDATA_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetSeqTable(OPTController_Handle controllerHandle,  int moduleIndex,int seqCount, int *triggerSource,int *intensity,int *pulseWidth);

	 /*******************************************************************
	Function:OPTController_ReadSeqTable
	Description: Read the specified channel's SEQ table data.
	Input:
	   controllerHandle		-the handle of controller
	   channelIndex			-the index of the channel, range:[1-16] (in decimal form)
	Output:
	    seqCount  		    -the SEQ count,range:[1-64]
	    triggerSource        -the trigger source data
        intensity            -the intensity data
        pulseWidth           -the pulse width data
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READSEQTABLEDATA_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadSeqTable(OPTController_Handle controllerHandle, int moduleIndex, int *seqCount,int *triggerSource,int *intensity,int *pulseWidth);



	/*******************************************************************
	Function:OPTController_SetTriggerDelay
	Description: trigger delay,specified channel on specified time.
	Input:
	    controllerHandle		-the handle of controller
	    channelIndex			-the index(es) of the channel(s), range:[0-16] (in decimal form)
	    triggerDelay			-trigger delay,range:[1-65000],if the trigger delay less than 10,set it 0,Unit:1us
	Return: 
	succeed    -OPT_SUCCEED
	failed     -OPT_ERR_SETTRIGGERDELAY_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetTriggerDelay(OPTController_Handle controllerHandle,int channelIndex,int triggerDelay);
	
	/*******************************************************************
	Function:OPTController_GetTriggerDelay
	Description: get the specified channel's trigger delay.
	Input:
	   controllerHandle		-the handle of controller
	   channelIndex			-the index of the channel, range:[1-16] (in decimal form)
	Output:
	    triggerDelay        -the specified channel's trigger delay,Unit:1us
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_GET_TRIGGERDELAY_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_GetTriggerDelay(OPTController_Handle controllerHandle,int channelIndex,int *triggerDelay);
	
	/*******************************************************************
	Function:OPTController_SetMultiTriggerDelay
	Description: set multiple channels' trigger delay .
	Input:
	   controllerHandle		-the handle of controller
	   triggerDelayArray    -an array consists of values of the trigger delay(and the indexes of corresponding channels) 
	   to be set, range:[0-65000],if the trigger delay less than 10,set it 0
	   length			     -the length of the trigger delay array
	Return: 
	   succeed    -OPT_SUCCEED
	   failed     -OPT_ERR_SETMULTITRIGGERDELAY_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetMultiTriggerDelay(OPTController_Handle controllerHandle,TriggerDelayItem *triggerDelayArray,int length);


     /*******************************************************************
	Function:OPTController_GetControllerChannels
	Description: Get the channels of Controller 
	Input:
	    controllerHandle		-the handle of controller
	Output:
	    nChannels               -the number of channels
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_CHANNELS_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_GetControllerChannels(OPTController_Handle controllerHandle, int *channels);


    /*******************************************************************
	Function:OPTController_ReadKeepaliveSwitchState
	Description: Read the switch state of keepalive 
	Input:
	    controllerHandle		-the handle of controller
	Output:
	    nState                  -the state of Keepalive switch,0 for close,1 for open
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_KEEPALIVE_STATE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadKeepaliveSwitchState(OPTController_Handle controllerHandle, int *state);

	/*******************************************************************
	Function:OPTController_ReadContinuousKeepaliveTime
	Description: Read the continuous time of keepalive 
	Input:
	    controllerHandle		-the handle of controller
	Output:  
	    times                   -the continuous time of keepalive,range[1,65535],unit :1s.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_KEEPALIVE_CONTINUOUS_TIME_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadContinuousKeepaliveTime(OPTController_Handle controllerHandle, int *time);


	/*******************************************************************
	Function:OPTController_ReadPacketDeliveryTimes
	Description: Read the delivery times of prop packet 
	Input:
	    controllerHandle		-the handle of controller
	Output:
	    times                   -the delivery times of prop packet
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_DELIVERY_TIMES_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadPacketDeliveryTimes(OPTController_Handle controllerHandle, int *times);


	/*******************************************************************
	Function:OPTController_ReadIntervalTimeOfPropPacket
	Description: Read the interval time of prop packet 
	Input:
	    controllerHandle		-the handle of controller
	Output:
	    time                   -the interval time of prop packet
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_INTERVAL_TIME_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadIntervalTimeOfPropPacket (OPTController_Handle controllerHandle, int *time);

	/*******************************************************************
	Function:OPTController_ReadOutputBoardVision
	Description: Read the vision of output board
	Input:
	    controllerHandle		-the handle of controller
	Output:
	    vision                   -the vision of output board
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_OUTPUTBOARD_VISION_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadOutputBoardVision(OPTController_Handle controllerHandle,char *vision);

	/*******************************************************************
	Function:OPTController_ReadLoadDetectMode
	Description: Read the detect mode of load
	Input:
	    controllerHandle		-the handle of controller
		channelIndex            -the index of the channel, range:[1-16] (in decimal form)
	Output:
	    mode                    -the detect mode of load,0 for automatic detection;1 for manual setting.
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_DETECT_MODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadLoadDetectMode(OPTController_Handle controllerHandle,int channelIndex,int *mode);
	

	/*******************************************************************
	Function:OPTController_SetBootState
	Description: Set the specified channel boot state on in general light mode
	Input:
	    controllerHandle		-the handle of controller
		channelIndex            -the index of the channel, range:[0-16] (in decimal form)
	    mode                    -the mode of protection,0 for general light mode,1 for general close mode
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_BOOT_STATE_MODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetBootState(OPTController_Handle controllerHandle,int channelIndex,int mode);

	
    
	/*******************************************************************
	Function:OPTController_ReadModelBootState
	Description: Read the specified channel state of boot
	Input:
	    controllerHandle		-the handle of controller
		channelIndex            -the index of the channel, range:[1-16] (in decimal form)
	Output:
	    state                    -the state of specified channel  ,0 for turn on mode,1 for turn off mode
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_MODEL_BOOT_MODE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadModelBootState(OPTController_Handle controllerHandle,int channelIndex,int *state);


	/*******************************************************************
	Function: OPTController_SetIPConfiguration
	Description: Set IP configuration of the controller
	Input:
		controllerHandle	 -the handle of controller
		IP                   -the IP address
		subnetMask           -the subnet mask
		defaultGateway       -the default gateway
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_IPCONFIG_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetIPConfiguration(OPTController_Handle controllerHandle, char *IP, char *subnetMask, char *defaultGateway);

	/*******************************************************************
	Function: OPTController_SetOutputVoltage
	Description: Set the specified channel's output voltage
	Input:
		controllerHandle	 -the handle of controller
		channelIndex         -the index of the channel, range:[0-4] (in decimal form,0 for all channels)
		voltage              - the value of voltage,range[30,250]
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_SET_VOLTAGE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_SetOutputVoltage(OPTController_Handle controllerHandle, int channelIndex,int voltage);

	/*******************************************************************
	Function: OPTController_ReadOutputVoltage
	Description: Read the specified channel's output voltage
	Input:
		controllerHandle	 -the handle of controller
		channelIndex         -the index of the channel, range:[1-4] (in decimal form)
	Output:
		voltage              - the voltage value of specified channel  
	Return: 
	    succeed    -OPT_SUCCEED
	    failed     -OPT_ERR_READ_VOLTAGE_FAILED
	*****************************************************************/
	long DLL_EXPORT OPTController_ReadOutputVoltage(OPTController_Handle controllerHandle, int channelIndex,int *voltage);


	/*******************************************************************
	Function:OPTController_SetTimeUnit
	Description: Common trigger mode time unit switching
	Input:
	    controllerHandle		-the handle of controller
		channelIdx		    	-the index(es) of the channel(s), range:[0-16] (in decimal form),0 for all channels,1-16 for specified channel
	    timeUnit                -the time unit, range:[0-3],0 for 1us,1 for 10us,2 for 1ms,3 for 100ms
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_SET_TIMEUNIT_FAILED
	*****************************************************************/
	long  DLL_EXPORT OPTController_SetTimeUnit(OPTController_Handle controllerHandle,int channelIndex,int timeUnit);


	/*******************************************************************
	Function:OPTController_ReadTimeUnit
	Description: Read the specified channel's common trigger mode time unit 
	Input:
	    controllerHandle		-the handle of controller
		channelIdx		    	-the index(es) of the channel(s), range:[1-16] (in decimal form),,1-16 for specified channel
    Output:
	    timeUnit                -the time unit,  range:[0-3],0 for 1us,1 for 10us,2 for 1ms,3 for 100ms
	Return: 
		succeed    -OPT_SUCCEED
		failed     -OPT_ERR_READ_TIMEUNIT_FAILED
	*****************************************************************/
	long  DLL_EXPORT OPTController_ReadTimeUnit(OPTController_Handle controllerHandle,int channelIndex,int *timeUnit);
}; 

#endif // __OPTCONTROLER_H__





