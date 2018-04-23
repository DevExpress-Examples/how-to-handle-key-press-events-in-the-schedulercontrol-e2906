using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Services;
using System.Windows.Forms;
using DevExpress.Xpf.Scheduler;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Services;

namespace DXScheduler_KeyHandling
{
    #region #keyhandlerservice
    class MyKeyboardHandlerService : KeyboardHandlerServiceWrapper
    {
        private IServiceProvider _provider;

        public MyKeyboardHandlerService(IServiceProvider provider, IKeyboardHandlerService service)
            : base(service)
        {
            _provider = provider;            
        }

        public override void OnKeyDown(System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.N && e.Control) {
                SchedulerControl scheduler = (SchedulerControl)_provider;
                Appointment apt = scheduler.Storage.CreateAppointment(AppointmentType.Normal);
				apt.Subject = "Test";
				apt.Start = scheduler.SelectedInterval.Start;
				apt.End = scheduler.SelectedInterval.End;
				apt.ResourceId = scheduler.SelectedResource.Id;
                scheduler.Storage.AppointmentStorage.Add(apt);
                /*Uncommment the next code line to navigate one time frame forward
                 (determined by the currently active view) */
                //scheduler.GetService<IDateTimeNavigationService>().NavigateForward();
                return;
            }
            base.OnKeyDown(e);
        }

    }
    #endregion #keyhandlerservice
}
