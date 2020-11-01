using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment_2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddTask : Page
    {

        public DispatcherTimer timer;
        int ctr = 0;


        public AddTask()
        {
            this.InitializeComponent();

            App.RandomBackground(gridAddTask);
            App.DisplayJoke(textBlockFirstLine, textBlockSecondLine);

            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0,0,1);
            
            timer.Start();
            timer.Tick += timer_tick;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {

            TaskManager.AddTask(textBoxTask.Text, datePicker.SelectedDate.Value.Date.ToShortDateString());

        }

        void timer_tick(object sender, object e ) {

            ctr++;

            if (ctr >= 8) {
                ctr = 0;

                App.RandomBackground(gridAddTask);
                App.DisplayJoke(textBlockFirstLine, textBlockSecondLine);
            }

        }

    

    }
}
