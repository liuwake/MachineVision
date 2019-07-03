// OPTController_ExampleVC.2008Dlg.cpp : implementation file
//

#include "stdafx.h"
#include "OPTController_ExampleVC.2008.h"
#include "OPTController_ExampleVC.2008Dlg.h"

#include <atlconv.h>
#include "OPTErrorCode.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif


// CAboutDlg dialog used for App About

class CAboutDlg : public CDialog
{
public:
	CAboutDlg();

// Dialog Data
	enum { IDD = IDD_ABOUTBOX };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);    // DDX/DDV support

// Implementation
protected:
	DECLARE_MESSAGE_MAP()
};

CAboutDlg::CAboutDlg() : CDialog(CAboutDlg::IDD)
{
}

void CAboutDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
}

BEGIN_MESSAGE_MAP(CAboutDlg, CDialog)
END_MESSAGE_MAP()


// COPTController_ExampleVC2008Dlg dialog




COPTController_ExampleVC2008Dlg::COPTController_ExampleVC2008Dlg(CWnd* pParent /*=NULL*/)
	: CDialog(COPTController_ExampleVC2008Dlg::IDD, pParent)
	,m_CommModel(COMM_MODEL_SERIALPORT)
	,m_OPTControllerHanlde(0)
	
{
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void COPTController_ExampleVC2008Dlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	DDX_Control(pDX, IDC_RADIO_GeneralTrig, m_GeneralTrigger);
	DDX_Control(pDX, IDC_COMBO1, m_Combo_CurStep);
	
}

BEGIN_MESSAGE_MAP(COPTController_ExampleVC2008Dlg, CDialog)
	ON_WM_SYSCOMMAND()
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_RADIO_SerialPort, &COPTController_ExampleVC2008Dlg::OnBnClickedRadioSerialport)
	ON_BN_CLICKED(IDC_RADIO_SN, &COPTController_ExampleVC2008Dlg::OnBnClickedRadioSn)
	ON_BN_CLICKED(IDC_RADIO_IP, &COPTController_ExampleVC2008Dlg::OnBnClickedRadioIp)
	ON_BN_CLICKED(IDC_BUTTON_Connection, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonConnection)
	ON_BN_CLICKED(IDC_BUTTON_OpenChannel, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonOpenchannel)
	ON_BN_CLICKED(IDC_BUTTON_CloseChannel, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonClosechannel)
	ON_BN_CLICKED(IDC_BUTTON_SetIntensity, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonSetintensity)
	ON_EN_UPDATE(IDC_EDIT_ChannelIndex, &COPTController_ExampleVC2008Dlg::OnEnUpdateEditChannelindex)
	ON_EN_UPDATE(IDC_EDIT_Intensity, &COPTController_ExampleVC2008Dlg::OnEnUpdateEditIntensity)
	ON_BN_CLICKED(IDC_BUTTON_TRIGGERMODE, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonTriggermode)
	ON_BN_CLICKED(IDC_BUTTON_SETSEQTABLE, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonSetseqtable)
	ON_BN_CLICKED(IDC_BUTTON_READSEQTABLE, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonReadseqtable)
	ON_BN_CLICKED(IDC_BUTTON_SETCURSTEP, &COPTController_ExampleVC2008Dlg::OnBnClickedButtonSetcurstep)
	
END_MESSAGE_MAP()


// COPTController_ExampleVC2008Dlg message handlers

BOOL COPTController_ExampleVC2008Dlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Add "About..." menu item to system menu.

	// IDM_ABOUTBOX must be in the system command range.
	ASSERT((IDM_ABOUTBOX & 0xFFF0) == IDM_ABOUTBOX);
	ASSERT(IDM_ABOUTBOX < 0xF000);

	CMenu* pSysMenu = GetSystemMenu(FALSE);
	if (pSysMenu != NULL)
	{
		CString strAboutMenu;
		strAboutMenu.LoadString(IDS_ABOUTBOX);
		if (!strAboutMenu.IsEmpty())
		{
			pSysMenu->AppendMenu(MF_SEPARATOR);
			pSysMenu->AppendMenu(MF_STRING, IDM_ABOUTBOX, strAboutMenu);
		}
	}

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon

	// TODO: Add extra initialization here
	InitControls();
	CButton* radioGeneral=(CButton*)GetDlgItem(IDC_RADIO_GeneralTrig);

	radioGeneral->SetCheck(1);
	m_Combo_CurStep.SetCurSel(0);
	SetDlgItemInt(IDC_EDIT_ChannelIndex2,1);

	return TRUE;  // return TRUE  unless you set the focus to a control
}

void COPTController_ExampleVC2008Dlg::OnSysCommand(UINT nID, LPARAM lParam)
{
	if ((nID & 0xFFF0) == IDM_ABOUTBOX)
	{
		CAboutDlg dlgAbout;
		dlgAbout.DoModal();
	}
	else
	{
		CDialog::OnSysCommand(nID, lParam);
	}
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void COPTController_ExampleVC2008Dlg::OnPaint()
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, reinterpret_cast<WPARAM>(dc.GetSafeHdc()), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this function to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR COPTController_ExampleVC2008Dlg::OnQueryDragIcon()
{
	return static_cast<HCURSOR>(m_hIcon);
}

void COPTController_ExampleVC2008Dlg::InitControls()
{
	CheckRadioButton(IDC_RADIO_SerialPort, IDC_RADIO_IP, IDC_RADIO_SerialPort);
	SetDlgItemInt(IDC_EDIT_ChannelIndex, 0);
	SetDlgItemInt(IDC_EDIT_Intensity, 255);

	((CEdit*)GetDlgItem(IDC_EDIT_COMName))->SetLimitText(5);
	((CEdit*)GetDlgItem(IDC_EDIT_SN))->SetLimitText(10);
	((CEdit*)GetDlgItem(IDC_EDIT_IP))->SetLimitText(16);
	((CEdit*)GetDlgItem(IDC_EDIT_ChannelIndex))->SetLimitText(2);
	((CEdit*)GetDlgItem(IDC_EDIT_Intensity))->SetLimitText(3);
}
void COPTController_ExampleVC2008Dlg::OnBnClickedRadioSerialport()
{
	// TODO: Add your control notification handler code here
	m_CommModel = COMM_MODEL_SERIALPORT;
}

void COPTController_ExampleVC2008Dlg::OnBnClickedRadioSn()
{
	// TODO: Add your control notification handler code here
	m_CommModel = COMM_MODEL_SN;
}

void COPTController_ExampleVC2008Dlg::OnBnClickedRadioIp()
{
	// TODO: Add your control notification handler code here
	m_CommModel = COMM_MODEL_IP;
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonConnection()
{
	// TODO: Add your control notification handler code here
	long lRet = -1;
	CString connectionStatus;
	GetDlgItemText(IDC_BUTTON_Connection, connectionStatus);

	USES_CONVERSION;
	switch (m_CommModel)
	{
	case COMM_MODEL_SERIALPORT:
		{
			if ("Connect" == connectionStatus)
			{
				CString strCOMName;
				GetDlgItemText(IDC_EDIT_COMName, strCOMName);
				if (false != strCOMName.IsEmpty())
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Serial name can not be empty"));
					return;
				}

				lRet = OPTController_InitSerialPort(W2A(strCOMName.GetBuffer(0)), &m_OPTControllerHanlde);
				if (OPT_SUCCEED == lRet)	
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Succeed"));
					GetDlgItem(IDC_RADIO_SN)->EnableWindow(FALSE);
					GetDlgItem(IDC_EDIT_SN)->EnableWindow(FALSE);
					GetDlgItem(IDC_RADIO_IP)->EnableWindow(FALSE);
					GetDlgItem(IDC_EDIT_IP)->EnableWindow(FALSE);
					SetDlgItemText(IDC_BUTTON_Connection, _T("Disconnect"));
				}
				else
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Failed to initialize serial port"));
				}
			}
			else if ("Disconnect" == connectionStatus)
			{
				lRet = OPTController_ReleaseSerialPort(m_OPTControllerHanlde);
				if (OPT_SUCCEED == lRet)	
				{
					m_OPTControllerHanlde = 0;
					SetDlgItemText(IDC_EDIT_Status, _T("Succeed"));
					GetDlgItem(IDC_RADIO_SN)->EnableWindow(TRUE);
					GetDlgItem(IDC_EDIT_SN)->EnableWindow(TRUE);
					GetDlgItem(IDC_RADIO_IP)->EnableWindow(TRUE);
					GetDlgItem(IDC_EDIT_IP)->EnableWindow(TRUE);
					SetDlgItemText(IDC_BUTTON_Connection, _T("Connect"));
				}
			}
		}
		break;
	case COMM_MODEL_SN:
		{
			if ("Connect" == connectionStatus)
			{
				CString strSN;
				GetDlgItemText(IDC_EDIT_SN, strSN);
				if (false != strSN.IsEmpty())
				{
					SetDlgItemText(IDC_EDIT_Status, _T("SN can not be empty"));
					return;
				}

				lRet = OPTController_CreateEthernetConnectionBySN(W2A(strSN.GetBuffer(0)), &m_OPTControllerHanlde);
				if (OPT_SUCCEED == lRet)
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Succeed"));
					GetDlgItem(IDC_RADIO_SerialPort)->EnableWindow(FALSE);
					GetDlgItem(IDC_EDIT_COMName)->EnableWindow(FALSE);
					GetDlgItem(IDC_RADIO_IP)->EnableWindow(FALSE);
					GetDlgItem(IDC_EDIT_IP)->EnableWindow(FALSE);
					SetDlgItemText(IDC_BUTTON_Connection, _T("Disconnect"));
				}
				else
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Failed to create Ethernet connection by SN"));
				}
			}
			else if ("Disconnect" == connectionStatus)
			{
				lRet = OPTController_DestroyEthernetConnection(m_OPTControllerHanlde);
				if (OPT_SUCCEED == lRet)	
				{
					m_OPTControllerHanlde = 0;
					SetDlgItemText(IDC_EDIT_Status, _T("Succeed"));
					GetDlgItem(IDC_RADIO_SerialPort)->EnableWindow(TRUE);
					GetDlgItem(IDC_EDIT_COMName)->EnableWindow(TRUE);
					GetDlgItem(IDC_RADIO_IP)->EnableWindow(TRUE);
					GetDlgItem(IDC_EDIT_IP)->EnableWindow(TRUE);
					SetDlgItemText(IDC_BUTTON_Connection, _T("Connect"));
				}
			}
		}
		break;
	case COMM_MODEL_IP:
		{
			if ("Connect" == connectionStatus)
			{
				CString strIP;
				GetDlgItemText(IDC_EDIT_IP, strIP);
				if (false != strIP.IsEmpty())
				{
					SetDlgItemText(IDC_EDIT_Status, _T("IP can not be empty"));
					return;
				}

				long lRet = OPTController_CreateEthernetConnectionByIP(W2A(strIP.GetBuffer(0)), &m_OPTControllerHanlde);
				if (OPT_SUCCEED == lRet)
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Succeed"));
					GetDlgItem(IDC_RADIO_SerialPort)->EnableWindow(FALSE);
					GetDlgItem(IDC_EDIT_COMName)->EnableWindow(FALSE);
					GetDlgItem(IDC_RADIO_SN)->EnableWindow(FALSE);
					GetDlgItem(IDC_EDIT_SN)->EnableWindow(FALSE);
					SetDlgItemText(IDC_BUTTON_Connection, _T("Disconnect"));
				}
				else
				{
					SetDlgItemText(IDC_EDIT_Status, _T("Failed to create Ethernet connection by IP"));
				}
			}
			else if ("Disconnect" == connectionStatus)
			{
				lRet = OPTController_DestroyEthernetConnection(m_OPTControllerHanlde);
				if (OPT_SUCCEED == lRet)
				{
					m_OPTControllerHanlde = 0;
					SetDlgItemText(IDC_EDIT_Status, _T("Succeed"));
					GetDlgItem(IDC_RADIO_SerialPort)->EnableWindow(TRUE);
					GetDlgItem(IDC_EDIT_COMName)->EnableWindow(TRUE);
					GetDlgItem(IDC_RADIO_SN)->EnableWindow(TRUE);
					GetDlgItem(IDC_EDIT_SN)->EnableWindow(TRUE);
					SetDlgItemText(IDC_BUTTON_Connection, _T("Connect"));
				}
			}
		}
		break;
	default:
		return;
	}

}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonOpenchannel()
{
	// TODO: Add your control notification handler code here
	int channelIndex = GetDlgItemInt(IDC_EDIT_ChannelIndex);
	long lRet = OPTController_TurnOnChannel(m_OPTControllerHanlde, channelIndex);
	CString responseInformation;
	if (OPT_SUCCEED == lRet)
	{
		switch (channelIndex)
		{
		case 0:
			responseInformation = _T("Succeed to turn on all channels.");
			break;
		case 1:
			responseInformation.Format(_T("Succeed to turn on the 1st channel"));
			break;
		case 2:
			responseInformation.Format(_T("Succeed to turn on the 2nd channel"));
			break;
		case 3:
			responseInformation.Format(_T("Succeed to turn on the 3rd channel"));
			break;
		default:
			responseInformation.Format(_T("Succeed to turn on the %dth channel"), channelIndex);
			return;
		}
	}
	else
	{
		responseInformation.Format(_T("Failed to turn on channel(s)."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonClosechannel()
{
	// TODO: Add your control notification handler code here
	int channelIndex = GetDlgItemInt(IDC_EDIT_ChannelIndex);
	long lRet = OPTController_TurnOffChannel(m_OPTControllerHanlde, channelIndex);
	CString responseInformation;
	if (OPT_SUCCEED == lRet)
	{
		switch (channelIndex)
		{
		case 0:
			responseInformation = _T("Succeed to turn off all channels.");
			break;
		case 1:
			responseInformation.Format(_T("Succeed to turn off the 1st channel"));
			break;
		case 2:
			responseInformation.Format(_T("Succeed to turn off the 2nd channel"));
			break;
		case 3:
			responseInformation.Format(_T("Succeed to turn off the 3rd channel"));
			break;
		default:
			responseInformation.Format(_T("Succeed to turn off the %dth channel"), channelIndex);
			return;
		}
	}
	else
	{
		responseInformation.Format(_T("Failed to turn off channel(s)."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonSetintensity()
{
	// TODO: Add your control notification handler code here
	int channelIndex = GetDlgItemInt(IDC_EDIT_ChannelIndex);
	int intensity = GetDlgItemInt(IDC_EDIT_Intensity);
	long lRet = OPTController_SetIntensity(m_OPTControllerHanlde, channelIndex, intensity);
	CString responseInformation;
	if (OPT_SUCCEED == lRet)
	{
		switch (channelIndex)
		{
		case 1:
			responseInformation.Format(_T("Set intensity for the 1st channel. The value is %d"), intensity);
			break;
		case 2:
			responseInformation.Format(_T("Set intensity for the 2nd channel. The value is %d"), intensity);
			break;
		case 3:
			responseInformation.Format(_T("Set intensity for the 3rd channel. The value is %d"), intensity);
			break;
		default:
			responseInformation.Format(_T("Set intensity for the %dth channel. The value is %d"), channelIndex, intensity);
		}
	}
	else
	{
		responseInformation.Format(_T("Failed to set intensity, might resulting from incorrect parameter(s)."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);
}

void COPTController_ExampleVC2008Dlg::OnEnUpdateEditChannelindex()
{
	int channelIndex = GetDlgItemInt(IDC_EDIT_ChannelIndex);
	if (channelIndex<0)
	{
		SetDlgItemInt(IDC_EDIT_ChannelIndex, 0);
	}
	else if (channelIndex>16)
	{
		SetDlgItemInt(IDC_EDIT_ChannelIndex, 16);
	}
}

void COPTController_ExampleVC2008Dlg::OnEnUpdateEditIntensity()
{
	int intensity = GetDlgItemInt(IDC_EDIT_Intensity);
	if (intensity<0)
	{
		SetDlgItemInt(IDC_EDIT_Intensity, 0);
	}
	else if (intensity>255)
	{
		SetDlgItemInt(IDC_EDIT_Intensity, 255);
	}
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonTriggermode()
{
	// TODO: Add your control notification handler code here
    int channelIndex = GetDlgItemInt(IDC_EDIT_ChannelIndex2);
	long lret = -1;
	if(m_GeneralTrigger.GetCheck() == TRUE)
	{
		//处于选中状态
		lret = OPTController_SetTriggerMode(m_OPTControllerHanlde,channelIndex,1); //设置指定通道的触发模式为普通触发模式

	}
	else
	{
		lret = OPTController_SetTriggerMode(m_OPTControllerHanlde,channelIndex,2); //设置指定通道的触发模式为可编程触发模式
	}
	CString responseInformation;
	if (OPT_SUCCEED == lret)
	{
		switch (channelIndex)
		{
		case 0:
			responseInformation = _T("Succeed to Set trigger mode all channels.");
			break;
		case 1:
			responseInformation.Format(_T("Succeed to set trigger mode the 1st channel"));
			break;
		case 2:
			responseInformation.Format(_T("Succeed to set trigger mode the 2nd channel"));
			break;
		case 3:
			responseInformation.Format(_T("Succeed to set trigger mode the 3rd channel"));
			break;
		default:
			responseInformation.Format(_T("Succeed to set trigger mode the %dth channel"), channelIndex);
			return;
		}
	}
	else
	{
		responseInformation.Format(_T("Failed to Set trigger mode channel(s)."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonSetseqtable()
{
	// TODO: Add your control notification handler code here
	
	int  triggerSource[]={1,1,1,1};
	int  intensity[]= {255,255,255,255,0,0,0,0,255,255,255,255,0,0,0,0};
	int  plusWidth[] = {100,100,999,999,100,100,999,999,100,100,999,999,100,100,999,999};
	int rowCount = 4;
	
	int nChannel =  GetDlgItemInt(IDC_EDIT_ChannelIndex2); //获取通道

	long lRet = -1;
	lRet = OPTController_SetSeqTable(m_OPTControllerHanlde,nChannel,4,triggerSource, intensity, plusWidth);//设置SEQ表到指定通道里面

	CString responseInformation;
	if (OPT_SUCCEED == lRet)
	{
		responseInformation = _T("Succeed to set SEQ table data.");
	}
	else
	{
		responseInformation.Format(_T("Failed to set SEQ table data."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonReadseqtable()
{
	// TODO: Add your control notification handler code here
	long lRet = -1;
	int *triggerSource = new int[4];
	int *intensity = new int[16];
	int *plusWidth = new int[16];

	int rowCount = 0;  
	int nSetpCount;
	int nChannel =  GetDlgItemInt(IDC_EDIT_ChannelIndex2);
	lRet = OPTController_ReadSeqTable(m_OPTControllerHanlde,nChannel,&nSetpCount,triggerSource,intensity,plusWidth);//获取指定通道的SEQ数据表
    
	CString responseInformation;
	if (OPT_SUCCEED == lRet)
	{
		responseInformation = _T("Succeed to read SEQ table data.");
	}
	else
	{
		responseInformation.Format(_T("Failed to read SEQ table data."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);
}

void COPTController_ExampleVC2008Dlg::OnBnClickedButtonSetcurstep()
{
	// TODO: Add your control notification handler code here
	int curStep = m_Combo_CurStep.GetCurSel() +1;
	int nChannel =  GetDlgItemInt(IDC_EDIT_ChannelIndex2);
	long lRet = -1;
	lRet = OPTController_SetCurrentStepIndex(m_OPTControllerHanlde,nChannel,curStep);//设置指定通道的场景模式
	CString responseInformation;
	if (OPT_SUCCEED == lRet)
	{
		responseInformation = _T("Succeed to set SEQ current step.");
	}
	else
	{
		responseInformation.Format(_T("Failed to set SEQ current step."));
	}
	SetDlgItemText(IDC_EDIT_Status, responseInformation);

}





