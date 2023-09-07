using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures.ApplicationLogic.Proxies
{
    public class FormProxy : Form
    {
        private int m_NumberOfClickesOnForm = 0;
        private int m_TimeSpentOnForm = 0;
        private Timer m_Timer = new Timer();

        public FormProxy()
        {
            initializeTimer();
        }

        private void initializeTimer()
        {
            m_Timer.Interval = 1000;
            m_Timer.Tick += timer_Tick;
            m_Timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            m_TimeSpentOnForm++;
        }

        protected override void OnClick(EventArgs e)
        {
            m_NumberOfClickesOnForm++;
            base.OnClick(e);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            string fileName = $"{this.Name}Data.txt";

            string dataToWrite = $"Time Spent: {m_TimeSpentOnForm}, Number of Clicks: {m_NumberOfClickesOnForm}";

            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(dataToWrite);
            }
        }
    }
}
