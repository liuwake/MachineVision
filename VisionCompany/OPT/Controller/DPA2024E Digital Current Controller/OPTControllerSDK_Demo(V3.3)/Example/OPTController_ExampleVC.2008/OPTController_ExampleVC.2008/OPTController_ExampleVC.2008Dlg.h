// OPTController_ExampleVC.2008Dlg.h : header file
//

#pragma once
#include "OPTController.h"
#include "afxwin.h"


enum COMM_MODEL
{
	COMM_MODEL_SERIALPORT,
	COMM_MODEL_SN,
	COMM_MODEL_IP
};

// COPTController_ExampleVC2008Dlg dialog
class COPTController_ExampleVC2008Dlg : public CDialog
{
// Construction
public:
	COPTController_ExampleVC2008Dlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_OPTCONTROLLER_EXAMPLEVC2008_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	afx_msg void OnBnClickedRadioSerialport();
	afx_msg void OnBnClickedRadioSn();
	afx_msg void OnBnClickedRadioIp();
	afx_msg void OnBnClickedButtonConnection();
	afx_msg void OnBnClickedButtonOpenchannel();
	afx_msg void OnBnClickedButtonClosechannel();
	afx_msg void OnBnClickedButtonSetintensity();
	DECLARE_MESSAGE_MAP()

private:
	void InitControls();

private:
	OPTController_Handle m_OPTControllerHanlde;
	COMM_MODEL	m_CommModel;
public:
	afx_msg void OnEnUpdateEditChannelindex();
	afx_msg void OnEnUpdateEditIntensity();
	afx_msg void OnBnClickedButtonTriggermode();
	CButton m_GeneralTrigger;
	CComboBox m_Combo_CurStep;
	afx_msg void OnBnClickedButtonSetseqtable();
	afx_msg void OnBnClickedButtonReadseqtable();
	afx_msg void OnBnClickedButtonSetcurstep();
	
	
};
