using System;
using System.Windows.Threading;
using DevExpress.Mvvm;

namespace DXSample {
    public class ViewModel : ViewModelBase {        
        DispatcherTimer Timer;
        public DateTime CurrentValue {
            get { return GetValue<DateTime>(); }
            set { SetValue(value); }
        }
        public string Content {
            get { return GetValue<string>(); }
            set { SetValue(value); }
        }
        public ViewModel() {
            Content = "Hello, World!";
            Timer = new DispatcherTimer() { Interval = TimeSpan.FromSeconds(1) };
            Timer.Tick += Timer_Tick;
            Timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e) {
            CurrentValue = DateTime.Now;
        }
        ~ViewModel() {
            Timer.Stop();
            Timer.Tick -= Timer_Tick;
            Timer = null;
        }
    }
}
