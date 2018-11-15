<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXScheduler_KeyHandling/MainWindow.xaml) (VB: [MainWindow.xaml.vb](./VB/DXScheduler_KeyHandling/MainWindow.xaml.vb))
* [MainWindow.xaml.cs](./CS/DXScheduler_KeyHandling/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXScheduler_KeyHandling/MainWindow.xaml.vb))
* [MyKeyboardHandlerService.cs](./CS/DXScheduler_KeyHandling/MyKeyboardHandlerService.cs) (VB: [MyKeyboardHandlerService.vb](./VB/DXScheduler_KeyHandling/MyKeyboardHandlerService.vb))
* [ResourceFiller.cs](./CS/DXScheduler_KeyHandling/ResourceFiller.cs) (VB: [ResourceFiller.vb](./VB/DXScheduler_KeyHandling/ResourceFiller.vb))
<!-- default file list end -->
# How to handle key press events in the SchedulerControl


<p>This example illustrates the use of the service substitution technique to handle key press events for DXScheduler. <br />
Create a <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressServicesKeyboardHandlerServiceWrappertopic"><strong><u>KeyboardHandlerServiceWrapper</u></strong></a> descendant which overrides the  <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressServicesKeyboardHandlerServiceWrapper_OnKeyDowntopic"><u>OnKeyDown</u></a> method. Instantiate this class and use it to replace default <a href="http://documentation.devexpress.com/#CoreLibraries/clsDevExpressServicesIKeyboardHandlerServicetopic"><u>IKeyboardHandlerService</u></a>.<br />
To replace a service, the Scheduler Control provides <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfSchedulerSchedulerControl_GetServicetopic"><u>GetService</u></a>, <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfSchedulerSchedulerControl_RemoveServicetopic"><u>RemoveService</u></a> and <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfSchedulerSchedulerControl_AddServicetopic"><u>AddService</u></a> methods.</p>

<br/>


