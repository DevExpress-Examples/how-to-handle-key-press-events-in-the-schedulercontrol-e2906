Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Services

Namespace DXScheduler_KeyHandling
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Public Sub New()
			InitializeComponent()
			ResourceFiller.FillResources(schedulerControl1.Storage,3)
			schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource

'			#Region "#subst"
			Dim oldKeyboardHandler As IKeyboardHandlerService = CType(schedulerControl1.GetService(GetType(IKeyboardHandlerService)), IKeyboardHandlerService)
			If oldKeyboardHandler IsNot Nothing Then
				Dim newKeyboardHandler As New MyKeyboardHandlerService(schedulerControl1, oldKeyboardHandler)
				schedulerControl1.RemoveService(GetType(IKeyboardHandlerService))
				schedulerControl1.AddService(GetType(IKeyboardHandlerService), newKeyboardHandler)
			End If
'			#End Region ' #subst
		End Sub
	End Class
End Namespace
