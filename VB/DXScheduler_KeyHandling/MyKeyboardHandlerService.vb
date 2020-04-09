Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.Services
Imports System.Windows.Forms
Imports DevExpress.Xpf.Scheduler
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraScheduler.Services
Imports DevExpress.Portable.Input

Namespace DXScheduler_KeyHandling
#Region "#keyhandlerservice"
    Friend Class MyKeyboardHandlerService
        Inherits KeyboardHandlerServiceWrapper
        Private _provider As IServiceProvider

        Public Sub New(ByVal provider As IServiceProvider, ByVal service As IKeyboardHandlerService)
            MyBase.New(service)
            _provider = provider
        End Sub


        Public Overrides Sub OnKeyDown(ByVal e As PortableKeyEventArgs)
            If e.KeyCode = PortableKeys.N AndAlso e.Control Then
                Dim scheduler As SchedulerControl = CType(_provider, SchedulerControl)
                Dim apt As Appointment = scheduler.Storage.CreateAppointment(AppointmentType.Normal)
                apt.Subject = "Test"
                apt.Start = scheduler.SelectedInterval.Start
                apt.End = scheduler.SelectedInterval.End
                apt.ResourceId = scheduler.SelectedResource.Id
                scheduler.Storage.AppointmentStorage.Add(apt)
                '                Uncommment the next code line to navigate one time frame forward
                '                 (determined by the currently active view) 
                'scheduler.GetService<IDateTimeNavigationService>().NavigateForward();
                Return
            End If
            MyBase.OnKeyDown(e)
        End Sub

    End Class
#End Region ' #keyhandlerservice
End Namespace
