using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using CSharp_OPTControllerAPI;

namespace OPTController__ExampleCSharp._2008
{
    public partial class Form1 : Form
    {
        
        public enum OPT_COMMUNICATION_MODEL : int
        {
            COMMUNICATION_BY_COM,
            COMMUNICATION_BY_SN,
            COMMUNICATION_BY_IP,
        }

        private OPT_COMMUNICATION_MODEL model = 0;
        private String serialPortName;
        private String IPAddr;
        private String SN;
        private OPTControllerAPI OPTController = null;

        public Form1()
        {
            OPTController = new OPTControllerAPI();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_COMName.Text = "";
            textBox_ChannelIndex.Text = "1";
            textBox_Intensity.Text = "255";
        }

        private void button_Open_Click(object sender, EventArgs e)
        {
            serialPortName = textBox_COMName.Text;
            SN = textBox_SN.Text;
            IPAddr = textBox_IP.Text;
            long lRet = -1;
            if ("Connect" == button_Open.Text)
            {
                switch (model)
                {
                    case OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_COM:
                        {
                            if ("" == serialPortName)
                            {
                                textBox_Status.Text = "Serial name can not be empty";
                                return;
                            }

                            lRet = OPTController.InitSerialPort(serialPortName);
                            if (0 != lRet)
                            {
                                textBox_Status.Text = "Failed to initialize serial port";
                                return;
                            }
                            else
                            {
                                textBox_Status.Text = "Succeed";
                            }
                        }
                        break;
                    case OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_SN:
                        {
                            if ("" == SN)
                            {
                                textBox_Status.Text = "SN can not be empty";
                                return;
                            }

                            lRet = OPTController.CreateEthernetConnectionBySN(SN);
                            if (0 != lRet)
                            {
                                textBox_Status.Text = "Failed to create Ethernet connection by SN";
                                return;
                            }
                            else
                            {
                                textBox_Status.Text = "Succeed";
                            }
                        }
                        break;
                    case OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_IP:
                        {
                            if ("" == IPAddr)
                            {
                                textBox_Status.Text = "IP can not be empty";
                                return;
                            }

                            lRet = OPTController.CreateEthernetConnectionByIP(IPAddr);
                            if (0 != lRet)
                            {
                                textBox_Status.Text = "Failed to create Ethernet connection by IP";
                                return;
                            }
                            else
                            {
                                textBox_Status.Text = "Succeed";
                            }
                        }
                        break;
                    default:
                        return;
                }

                button_Open.Text = "Disconnect";
                radioButton_SerialPort.Enabled = false;
                textBox_COMName.Enabled = false;
                radioButton_IP.Enabled = false;
                textBox_IP.Enabled = false;
                radioButton_SN.Enabled = false;
                textBox_SN.Enabled = false;
            }
            else if ("Disconnect" == button_Open.Text)
            {
                switch (model)
                {
                    case OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_COM:
                        {
                            lRet = OPTController.ReleaseSerialPort();
                            if (0 != lRet)
                            {
                                textBox_Status.Text = "Failed to release serial port";
                                return;
                            }
                        }
                        break;
                    case OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_SN:
                        {
                            lRet = OPTController.DestroyEthernetConnect();
                            if (0 != lRet)
                            {
                                textBox_Status.Text = "Failed to disconnect Ethernet connection by SN";
                                return;
                            }
                        }
                        break;
                    case OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_IP:
                        {
                            lRet = OPTController.DestroyEthernetConnect();
                            if (0 != lRet)
                            {
                                textBox_Status.Text = "Failed to disconnect Ethernet connection by IP";
                                return;
                            }
                        }
                        break;
                    default:
                        return;
                }
                button_Open.Text = "Connect";
                radioButton_SerialPort.Enabled = true;
                textBox_COMName.Enabled = true;
                radioButton_IP.Enabled = true;
                textBox_IP.Enabled = true;
                radioButton_SN.Enabled = true;
                textBox_SN.Enabled = true;
            }
        }

        private void button_OpenChannel_Click(object sender, EventArgs e)
        {
            if (OPTController.TurnOnChannel(Convert.ToInt32(textBox_ChannelIndex.Text)) == 0)
            {
                textBox_Status.Text = "Turn on successfully";
            }
            else
            {
                textBox_Status.Text = "Failed to turn on";
            }
           
        }

        private void button_CloseChannel_Click(object sender, EventArgs e)
        {
           if(OPTController.TurnOffChannel(Convert.ToInt32(textBox_ChannelIndex.Text)) == 0)
            {
                textBox_Status.Text = "Turn off successfully";
            }
            else
            {
                textBox_Status.Text = "Failed to turn off";
            }
        }

    
        private void buttonSetIntensity_Click(object sender, EventArgs e)
        {
            int channel = Convert.ToInt32(textBox_ChannelIndex.Text);
            int intensity = Convert.ToInt32(textBox_Intensity.Text);
            if( OPTController.SetIntensity(channel, intensity) == 0)
            {
                textBox_Status.Text = "Set intensity successfully";
            }
            else
            {
                textBox_Status.Text = "Failed to set intensity";
            }
        }

        private void radioButton_SerialPort_CheckedChanged(object sender, EventArgs e)
        {
            model = OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_COM;
        }

        private void radioButton_SN_CheckedChanged(object sender, EventArgs e)
        {
            model = OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_SN;
        }

        private void radioButton_IP_CheckedChanged(object sender, EventArgs e)
        {
            model = OPT_COMMUNICATION_MODEL.COMMUNICATION_BY_IP;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            SN = textBox_SN.Text;
            IPAddr = textBox_IP.Text;
            long lRet = -1;
            lRet = OPTController.ConnectionResetByIP(IPAddr);
            if(lRet == 0)
            {
                textBox_Status.Text = "Reset successfully,please reconnect";
            }
            else
            {
                textBox_Status.Text = "Failed to set reset";
            }
 
        }

        private void btn_TriggerMode_Click(object sender, EventArgs e)
        {
            int channelIndex = Convert.ToInt32(textBox1.Text);
            long lRet = -1;
            if (radioBtn_General.Checked)
            {
                lRet = OPTController.SetTriggerMode(channelIndex, 1); //set general trigger mode
            }
            if (radioBtn_Programmable.Checked)
            {
                lRet = OPTController.SetTriggerMode(channelIndex, 2); //set programmable trigger mode
            }
            if (lRet == 0)
            {
                textBox_Status.Text = "Set triggerMode successfully!";
            }
            else
            {
                textBox_Status.Text = "Failed to set triggerMode";
            }
        }
       
        private void btn_SetTable_Click(object sender, EventArgs e)
        {
            int[]  triggerSource={1,1,1,1};
	        int[]  intensity= {255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0};
	        int[]  plusWidth = {100,100,999,999,100,100,999,999,100,100,999,999,100,100,999,999};
            int rowCount = 4;

            int moduleIndex = Convert.ToInt32(textBox1.Text); ; //获取通道
            long lRet = -1;

            lRet = OPTController.SetSeqTable(moduleIndex, rowCount, triggerSource, intensity, plusWidth);//设置SEQ表到指定通道 
            if (lRet == 0)
            {
                textBox_Status.Text = "Set SEQ table data successfully!";
            }
            else
            {
                textBox_Status.Text = "Failed to set SEQ table data";
            }
        }

        private void btn_ReadTable_Click(object sender, EventArgs e)
        {
            int[] triggerSource = new int[4];
            int[] intensity = new int[16];
            int[] plusWidth = new int[16];

            int rowCount = 0;  

            int moduleIndex = Convert.ToInt32(textBox1.Text); //获取通道
            long lRet = -1;
            lRet = OPTController.ReadSeqTable(moduleIndex, ref rowCount, triggerSource, intensity, plusWidth);//设置SEQ表到指定通道  
            if (lRet == 0)
            {
                textBox_Status.Text = "Read SEQ table data successfully!";
            }
            else
            {
                textBox_Status.Text = "Failed to read SEQ table data";
            }

        }

        private void btn_SetTriggerMode_Click(object sender, EventArgs e)
        {
            int moduleIndex = Convert.ToInt32(textBox1.Text); //获取通道
            int mode = 2;
            long lRet = -1;
            lRet = OPTController.SetTriggerMode(moduleIndex, mode);
            if (lRet == 0)
            {
                textBox_Status.Text = "Set SEQ trigger mode successfully!";
            }
            else
            {
                textBox_Status.Text = "Failed to set SEQ trigger mode";
            }
        }

        private void ReadTriggerMode_Click(object sender, EventArgs e)
        {
            int moduleIndex = Convert.ToInt32(textBox1.Text); //获取通道
            int mode = -1;
            long lRet = -1;
            lRet = OPTController.ReadTriggerMode(moduleIndex, ref mode);
            if (lRet == 0)
            {
                textBox_Status.Text = "Read SEQ trigger mode successfully!";
            }
            else
            {
                textBox_Status.Text = "Failed to read SEQ trigger mode";
            }
        }

        private void btn_SetIP_Click(object sender, EventArgs e)
        {
            StringBuilder ip = new StringBuilder("192.168.1.20");
            StringBuilder subnetMask = new StringBuilder("255.255.255.0");
            StringBuilder defaultGateway = new StringBuilder("192.168.1.1");
            long lret = OPTController.SetIPConfiguration(ip, subnetMask, defaultGateway);
            if (lret == 0)
            {
                textBox_Status.Text = "Set IP configuration successfully";
            }
            else
            {
                textBox_Status.Text = "Failed to set  IP configuration";
            }
 
        }
      
        private void btn_SetCurrent_Click(object sender, EventArgs e)
        {
            int channel = Convert.ToInt32(textBox_ChannelIndex.Text);
            int current = 100;
            long lret = OPTController.SetMaxCurrent(channel, current);
            if (lret == 0)
            {
                textBox_Status.Text = "Set current successfully";
            }
            else
            {
                textBox_Status.Text = "Failed to set current";
            }

        }
    }
}
