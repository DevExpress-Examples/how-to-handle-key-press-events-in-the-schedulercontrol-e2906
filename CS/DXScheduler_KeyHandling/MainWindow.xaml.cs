using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DevExpress.Services;

namespace DXScheduler_KeyHandling
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ResourceFiller.FillResources(schedulerControl1.Storage,3);
            schedulerControl1.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;

            #region #subst
            IKeyboardHandlerService oldKeyboardHandler =
    (IKeyboardHandlerService)schedulerControl1.GetService(typeof(IKeyboardHandlerService));
            if (oldKeyboardHandler != null) {
                MyKeyboardHandlerService newKeyboardHandler =
                    new MyKeyboardHandlerService(schedulerControl1, oldKeyboardHandler);
                schedulerControl1.RemoveService(typeof(IKeyboardHandlerService));
                schedulerControl1.AddService(typeof(IKeyboardHandlerService), newKeyboardHandler);
            }
            #endregion #subst
        }
    }
}
