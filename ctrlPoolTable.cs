using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolTable
{
    public partial class ctrlPoolTable : UserControl
    {

        public class TableEventArgs :EventArgs
        {
            private int _Hours;
            private int _Miuntes;
            private int _Seconds;

            public string PlayerName;
            public string TableTitle;
            public string TableTime;
            public double Fees;

            public TableEventArgs (string PlayerName, string TableTitle, TimeSpan _elapsedTime ,double HourlyRate)
            {
                _Hours = _elapsedTime.Hours;
                _Miuntes = _elapsedTime.Minutes;
                _Seconds = _elapsedTime.Seconds;

                this.PlayerName = PlayerName;
                this.TableTitle = TableTitle;
                TableTime= "Hours : " + _Hours.ToString() +" " + "Minutes : " + _Miuntes.ToString() + " " + "Seconds : " + _Seconds.ToString();
                Fees = Fees = (_Hours * HourlyRate) + (HourlyRate / 60 * _Miuntes) + (HourlyRate / 3600 * _Seconds);

            }
        }

        public event EventHandler<TableEventArgs> OnTableFinish;
        public void RaiseOnTableFinish ()
        {
            OnTableFinish?.Invoke(this, new TableEventArgs(_PlayerName, _TableTitle, _elapsedTime, _HourlyRate));
        }
        private Timer _timer;
        public ctrlPoolTable()
        {
            InitializeComponent();
            
        }
        private double _HourlyRate;
        public double HourlyRate
        {
            set { _HourlyRate = value; }
            get { return _HourlyRate; }
        }

        private string _TableTitle;
        public string TableTitle
        {
            set { _TableTitle = value; SetTableValues(); }
            get { return _TableTitle; }
        }

        private string _PlayerName;
        public string PlayerName
        {
            set { _PlayerName = value; SetTableValues(); }
            get { return _PlayerName; }
        }

        private void SetTableValues ()
        {
            gbTable.Text = _TableTitle;
            lblPlayerName.Text = _PlayerName;
        }
        private void Table_Enter(object sender, EventArgs e)
        {

        }

        private TimeSpan _elapsedTime;
        
        private void SetTimer()
        {
            _elapsedTime = TimeSpan.Zero;
            _timer = new Timer();
            _timer.Interval = 1000; 
            _timer.Tick += Timer_Tick; 
            _timer.Start(); 
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _elapsedTime = _elapsedTime.Add(TimeSpan.FromSeconds(1)); 

          
            lblTimer.Text = _elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private bool _isPaused;
        private void btnStart_Click(object sender, EventArgs e)
        {
            
            switch (btnStart.Text)
            {
                case "Stop":
                    btnStart.Text = "Start";
                    btnStart.ForeColor = Color.White;
                    _isPaused = true;
                    _timer.Stop();
                    break;

                case "Start":
                    btnStart.Text = "Stop";
                    btnStart.ForeColor = Color.Red;
                    if (_isPaused)
                    {
                        _timer.Start();

                    }
                    else
                    {
                        SetTimer();
                    }
                    break;

            }
       
        }
      
        
        private void btnEnd_Click(object sender, EventArgs e)
        {
            _timer.Stop();
            lblTimer.Text = "00:00:00";

            btnStart.Text = "Start";
            btnStart.ForeColor = Color.White;
            _isPaused = false;
            RaiseOnTableFinish();

        }
    }
}
