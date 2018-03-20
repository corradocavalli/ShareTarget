using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace ShareTarget
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ShareView : Page
    {
        public ShareView()
        {
            this.InitializeComponent();
            this.Loaded += async (s, e) =>
            {
                ShareViewViewModel.Operation.ReportStarted();

                //TAKE 1 :-(
                //MyVm.Instance.Values.Add(new MyUnit());

                //TAKE2 :-(
                //await this.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                //{
                //    MyVm.Instance.Values.Add(new MyUnit());
                //});

                //TAKE3 :-)
                await Task.Run((async () =>
                {
                    await CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            
                            MyVm.Instance.Values.Add(new MyUnit());
                        });
                }));

                ShareViewViewModel.Operation.ReportCompleted();
            };
        }
    }
}
