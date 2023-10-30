**[View document in Syncfusion Xamarin Knowledge base](https://www.syncfusion.com/kb/12479/how-to-trigger-itemholding-event-using-mouse-hold-in-the-xamarin-forms-uwp-treeview)**

# [System Requirements](https://help.syncfusion.com/xamarin-android/system-requirements)

This section describes the system requirements of Syncfusion UWP Controls for development.

## Framework
The following frameworks are supported:

Microsoft .NET Framework 4.6

## Hardware Environment
Processor: x86 or x64
RAM : 512 MB (minimum), 1 GB (recommended)
Hard disk: up to 3 GB of free space may be required

## Development Environments
The following IDEs can be used for development that are compatible with Microsoft Windows, both 32bit and 64 bit Operating System in Windows 10 and Windows 8.1 with windows10 toolkit.

- Microsoft Visual Studio 2015/2017/2019/2022
- Windows 10 SDK

# How to run the sample

1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.xaml.cs file as demonstrated in the following code.

		public App()
		{
			//Register Syncfusion license
			Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

			InitializeComponent();

			MainPage = new App1.MainPage();
		}
		
	Refer to this [link](https://help.syncfusion.com/xamarin/licensing/overview) for more details.

3. Clean and build the application.

4. Run the application.

# License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.