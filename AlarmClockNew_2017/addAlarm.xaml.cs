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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace AlarmClockNew_2017
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class addAlarm : Page
    {
        public addAlarm()
        {
            this.InitializeComponent();
            //cboTimes.Items.Add("12:00am");
            //cboTimes.Items.Add("12:10am");
            //cboTimes.Items.Add("12:20am");
            //cboTimes.Items.Add("12:30am");
            //cboTimes.Items.Add("12:40am");
            //cboTimes.Items.Add("12:50am");

            //cboTimes.Items.Add("1:00am");
            //cboTimes.Items.Add("1:10am");
            //cboTimes.Items.Add("1:20am");
            //cboTimes.Items.Add("1:30am");
            //cboTimes.Items.Add("1:40am");
            //cboTimes.Items.Add("1:50am");

            //cboTimes.Items.Add("2:00am");
            //cboTimes.Items.Add("2:10am");
            //cboTimes.Items.Add("2:20am");
            //cboTimes.Items.Add("2:30am");
            //cboTimes.Items.Add("2:40am");
            //cboTimes.Items.Add("2:50am");

            //cboTimes.Items.Add("3:00am");
            //cboTimes.Items.Add("3:10am");
            //cboTimes.Items.Add("3:20am");
            //cboTimes.Items.Add("3:30am");
            //cboTimes.Items.Add("3:40am");
            //cboTimes.Items.Add("3:50am");

            //cboTimes.Items.Add("4:00am");
            //cboTimes.Items.Add("4:10am");
            //cboTimes.Items.Add("4:20am");
            //cboTimes.Items.Add("4:30am");
            //cboTimes.Items.Add("4:40am");
            //cboTimes.Items.Add("4:50am");

            //cboTimes.Items.Add("5:00am");
            //cboTimes.Items.Add("5:10am");
            //cboTimes.Items.Add("5:20am");
            //cboTimes.Items.Add("5:30am");
            //cboTimes.Items.Add("5:40am");
            //cboTimes.Items.Add("5:50am");

            //cboTimes.Items.Add("6:00am");
            //cboTimes.Items.Add("6:10am");
            //cboTimes.Items.Add("6:20am");
            //cboTimes.Items.Add("6:30am");
            //cboTimes.Items.Add("6:40am");
            //cboTimes.Items.Add("6:50am");

            //cboTimes.Items.Add("7:00am");
            //cboTimes.Items.Add("7:10am");
            //cboTimes.Items.Add("7:20am");
            //cboTimes.Items.Add("7:30am");
            //cboTimes.Items.Add("7:40am");
            //cboTimes.Items.Add("7:50am");

            //cboTimes.Items.Add("8:00am");
            //cboTimes.Items.Add("8:10am");
            //cboTimes.Items.Add("8:20am");
            //cboTimes.Items.Add("8:30am");
            //cboTimes.Items.Add("8:40am");
            //cboTimes.Items.Add("8:50am");

            //cboTimes.Items.Add("9:00am");
            //cboTimes.Items.Add("9:10am");
            //cboTimes.Items.Add("9:20am");
            //cboTimes.Items.Add("9:30am");
            //cboTimes.Items.Add("9:40am");
            //cboTimes.Items.Add("9:50am");

            //cboTimes.Items.Add("10:00am");
            //cboTimes.Items.Add("10:10am");
            //cboTimes.Items.Add("10:20am");
            //cboTimes.Items.Add("10:30am");
            //cboTimes.Items.Add("10:40am");
            //cboTimes.Items.Add("10:50am");

            //cboTimes.Items.Add("11:00am");
            //cboTimes.Items.Add("11:10am");
            //cboTimes.Items.Add("11:20am");
            //cboTimes.Items.Add("11:30am");
            //cboTimes.Items.Add("11:40am");
            //cboTimes.Items.Add("11:50am");

            //cboTimes.Items.Add("12:00pm");
            //cboTimes.Items.Add("12:10pm");
            //cboTimes.Items.Add("12:20pm");
            //cboTimes.Items.Add("12:30pm");
            //cboTimes.Items.Add("12:40pm");
            //cboTimes.Items.Add("12:50pm");

            //cboTimes.Items.Add("1:00pm");
            //cboTimes.Items.Add("1:10pm");
            //cboTimes.Items.Add("1:20pm");
            //cboTimes.Items.Add("1:30pm");
            //cboTimes.Items.Add("1:40pm");
            //cboTimes.Items.Add("1:50pm");

            //cboTimes.Items.Add("2:00pm");
            //cboTimes.Items.Add("2:10pm");
            //cboTimes.Items.Add("2:20pm");
            //cboTimes.Items.Add("2:30pm");
            //cboTimes.Items.Add("2:40pm");
            //cboTimes.Items.Add("2:50pm");

            //cboTimes.Items.Add("3:00pm");
            //cboTimes.Items.Add("3:10pm");
            //cboTimes.Items.Add("3:20pm");
            //cboTimes.Items.Add("3:30pm");
            //cboTimes.Items.Add("3:40pm");
            //cboTimes.Items.Add("3:50pm");

            //cboTimes.Items.Add("4:00pm");
            //cboTimes.Items.Add("4:10pm");
            //cboTimes.Items.Add("4:20pm");
            //cboTimes.Items.Add("4:30pm");
            //cboTimes.Items.Add("4:40pm");
            //cboTimes.Items.Add("4:50pm");

            //cboTimes.Items.Add("5:00pm");
            //cboTimes.Items.Add("5:10pm");
            //cboTimes.Items.Add("5:20pm");
            //cboTimes.Items.Add("5:30pm");
            //cboTimes.Items.Add("5:40pm");
            //cboTimes.Items.Add("5:50pm");

            //cboTimes.Items.Add("6:00pm");
            //cboTimes.Items.Add("6:10pm");
            //cboTimes.Items.Add("6:20pm");
            //cboTimes.Items.Add("6:30pm");
            //cboTimes.Items.Add("6:40pm");
            //cboTimes.Items.Add("6:50pm");

            //cboTimes.Items.Add("7:00pm");
            //cboTimes.Items.Add("7:10pm");
            //cboTimes.Items.Add("7:20pm");
            //cboTimes.Items.Add("7:30pm");
            //cboTimes.Items.Add("7:40pm");
            //cboTimes.Items.Add("7:50pm");

            //cboTimes.Items.Add("8:00pm");
            //cboTimes.Items.Add("8:10pm");
            //cboTimes.Items.Add("8:20pm");
            //cboTimes.Items.Add("8:30pm");
            //cboTimes.Items.Add("8:40pm");
            //cboTimes.Items.Add("8:50pm");

            //cboTimes.Items.Add("9:00pm");
            //cboTimes.Items.Add("9:10pm");
            //cboTimes.Items.Add("9:20pm");
            //cboTimes.Items.Add("9:30pm");
            //cboTimes.Items.Add("9:40pm");
            //cboTimes.Items.Add("9:50pm");

            //cboTimes.Items.Add("10:00pm");
            //cboTimes.Items.Add("10:10pm");
            //cboTimes.Items.Add("10:20pm");
            //cboTimes.Items.Add("10:30pm");
            //cboTimes.Items.Add("10:40pm");
            //cboTimes.Items.Add("10:50pm");

            //cboTimes.Items.Add("11:00pm");
            //cboTimes.Items.Add("11:10pm");
            //cboTimes.Items.Add("11:20pm");
            //cboTimes.Items.Add("11:30pm");
            //cboTimes.Items.Add("11:40pm");
            //cboTimes.Items.Add("11:50pm");

        }

        private void btnAddAlarm_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), tmrPicker.Time.ToString());
        }
    }
}
