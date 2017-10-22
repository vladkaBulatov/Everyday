using System;
using System.Windows.Forms;

namespace Everyday
{
    public partial class AlarmForm : Form
    {
        private string fileMusicPath;

        public AlarmForm()
        {
            InitializeComponent();
            maskedTextBox1.Mask = "00:00:00";           
        }
        
        private void timerCurrentTime_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            if (lblCurrentTime.Text == lblAlarm.Text)//проверять надо время, а не текст
            {
                musicPlayer.URL = fileMusicPath;
            }
        }

        private void BtnGetPathClick(object sender, EventArgs e)
        {
            var open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                fileMusicPath = open.FileName;
                textBox1.Text = open.SafeFileName;//если это мызыкальный файл, у него в атрибутах будет название верное, а название файла не подходит.
            }
        }

        private void Btn_Start_Click(object sender, EventArgs e)
        {
            lblAlarm.Text = maskedTextBox1.Text;
            maskedTextBox1.Text = "";//зачем?
            timer.Start();
        }

        private void BtnStopClick(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            timer.Stop();
        }
    }
}
