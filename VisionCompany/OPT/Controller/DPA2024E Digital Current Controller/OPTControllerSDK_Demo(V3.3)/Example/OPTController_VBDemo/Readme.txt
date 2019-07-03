当使用VB调控制器库时出错可能是.NET版本不同导至。
1、C++ OPTController.dll工程采用.NET3.5编译。以下解决方法：
2、如果VB程序调用可以采用安装VS2008的运行库后使用OPTController.dll
3、使用OPTControllerAPI(.net4.0).vb文件（请将文件名改为OPTControllerAPI.vb再使用）引到工程中。使用方法例：替换OPTController_ExampleVB.2008工程中的OPTControllerAPI.vb。
