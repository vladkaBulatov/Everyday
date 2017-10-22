using System;
using System.Windows.Forms;

namespace Everyday
{

    public partial class EverydayStartForm : Form
    {
       //подумать о, чтобы не запускалось более одного будильника, сколько бы раз не нажималась кнопка вызова будильника
       
        public EverydayStartForm()
        {
            InitializeComponent();            
        }

        private void BtnShowAlarmFormClick(object sender, EventArgs e)
        {
            var alarm = new AlarmForm();
            alarm.Show();
        }
    }
}
