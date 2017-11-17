using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AlarmClockNew_2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        List<string> alarmsList = new List<string>();
        DispatcherTimer timer = new DispatcherTimer();

        String alarm = "";
        String time = "";

        public MainPage()
        {
            this.InitializeComponent();

            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timeTick;
            timer.Start();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is string && !string.IsNullOrWhiteSpace((string)e.Parameter))
            {
                alarm = $"{e.Parameter.ToString()}";
                alarm = alarm.Substring(0, 7);
                lblAlarmSet.Text = alarm;
            }
        }

        void timeTick(object sender, object e)
        {
            secondHand.Angle = DateTime.Now.Second * 6;
            minuteHand.Angle = DateTime.Now.Minute * 6;
            hourHand.Angle = (DateTime.Now.Hour * 30) + (DateTime.Now.Minute * 0.5);

            time = DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
            //time = DateTime.Now.TimeOfDay.ToString();

            lblTimeShow.Text = time;

            if (time == alarm)
            {
                this.Frame.Navigate(typeof(alarmSounding));
            }
        }

        private void btnAlarm_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(addAlarm));
        }
    }
}
