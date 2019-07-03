// OPTController_ExampleVC.2008.h : main header file for the PROJECT_NAME application
//

#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"		// main symbols


// COPTController_ExampleVC2008App:
// See OPTController_ExampleVC.2008.cpp for the implementation of this class
//

class COPTController_ExampleVC2008App : public CWinApp
{
public:
	COPTController_ExampleVC2008App();

// Overrides
	public:
	virtual BOOL InitInstance();

// Implementation

	DECLARE_MESSAGE_MAP()
};

extern COPTController_ExampleVC2008App theApp;