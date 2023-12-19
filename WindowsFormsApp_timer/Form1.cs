using System;
using System.Media;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_timer
{
    
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            numericUpDown_h.Select(0, numericUpDown_h.Text.Length);
            button_start.Visible = true;
            button_delete.Visible = false;
            button_pause.Visible = false;
            button_continue.Visible = false;
            numericUpDown_h.Enabled = true;
            numericUpDown_m.Enabled = true;
            numericUpDown_s.Enabled = true;
            vTimer.Tick += new EventHandler(ShowTimer);
            

        }
        private decimal h = 0;
        private decimal m = 0;
        private decimal s = 0;
        Timer vTimer = new Timer();
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void ShowTimer(object vObject, EventArgs e)
        {
            if(numericUpDown_s.Value == 0)
            {
                if (numericUpDown_m.Value == 0&&numericUpDown_h.Value > 0)
                {
                    numericUpDown_h.Value--;
                    numericUpDown_m.Value=59;
                    numericUpDown_s.Value = 59;
                }
                else if (numericUpDown_m.Value > 0)
                {
                    numericUpDown_m.Value--;
                    numericUpDown_s.Value = 59;
                }
            }
            else numericUpDown_s.Value--;

            if (numericUpDown_h.Value==0&&
                numericUpDown_m.Value == 0 &&
                numericUpDown_s.Value == 0)
            {
                vTimer.Stop();
                
                button_start.Visible = true;
                button_delete.Visible = false;
                button_pause.Visible = false;
                button_continue.Visible = false;

                numericUpDown_h.Value = 0;
                numericUpDown_m.Value = 0;
                numericUpDown_s.Value = 0;

                numericUpDown_h.Enabled = true;
                numericUpDown_m.Enabled = true;
                numericUpDown_s.Enabled = true;



                player.SoundLocation = "signal.wav";
                try
                {
                    player.Play();
                }
                catch (Exception ex) {
                    ;
                }

                DialogResult res=MessageBox.Show("Таймер спрацював!  ", "Таймер", 
                    MessageBoxButtons.RetryCancel, 
                    MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1);
                player.Stop();
                if (res == DialogResult.Retry)
                {
                    numericUpDown_h.Value=h;
                    numericUpDown_m.Value=m;
                    numericUpDown_s.Value=s;                    
                    start_timer();
                }
                
                return;
            }
        }




        //виділення всього текста при переході між віконцями
        private void numericUpDown_h_Enter(object sender, EventArgs e)
        {
            numericUpDown_h.Select(0, numericUpDown_h.Text.Length);
        }

        private void numericUpDown_m_Enter(object sender, EventArgs e)
        {
            numericUpDown_m.Select(0, numericUpDown_m.Text.Length);
        }

        private void numericUpDown_s_Enter(object sender, EventArgs e)
        {
            numericUpDown_s.Select(0, numericUpDown_s.Text.Length);
        }
        //зупинка таймера
        private void button_delete_Click(object sender, EventArgs e)
        {
            button_start.Visible = true;
            button_delete.Visible = false;
            button_pause.Visible = false;
            button_continue.Visible = false;
            vTimer.Stop();
            numericUpDown_h.Value = 0;
            numericUpDown_m.Value = 0;
            numericUpDown_s.Value = 0;

            numericUpDown_h.Enabled = true;
            numericUpDown_m.Enabled = true;
            numericUpDown_s.Enabled = true;
        }
        //запуск таймера
        private void start_timer()
        {
            if (numericUpDown_h.Value + numericUpDown_m.Value + numericUpDown_s.Value == 0) return;
            h = numericUpDown_h.Value;
            m = numericUpDown_m.Value;
            s = numericUpDown_s.Value;


            button_start.Visible = false;
            button_delete.Visible = true;
            button_pause.Visible = true;
            button_continue.Visible = false;
            vTimer.Interval = 1000;
            vTimer.Start();

            numericUpDown_h.Enabled = false;
            numericUpDown_m.Enabled = false;
            numericUpDown_s.Enabled = false;
        }
        private void button_start_Click(object sender, EventArgs e)
        {
            start_timer();
        }
        //пауза
        private void button_pause_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;
            button_delete.Visible = true;
            button_pause.Visible = false;
            button_continue.Visible = true;

            numericUpDown_h.Enabled = false;
            numericUpDown_m.Enabled = false;
            numericUpDown_s.Enabled = false;
            vTimer.Stop();
        }
        //продовжити
        private void button_continue_Click(object sender, EventArgs e)
        {
            button_start.Visible = false;
            button_delete.Visible = true;
            button_pause.Visible = true;
            button_continue.Visible = false;
            
            vTimer.Interval = 1000;
            vTimer.Start();

            numericUpDown_h.Enabled = false;
            numericUpDown_m.Enabled = false;
            numericUpDown_s.Enabled = false;
        }
    }
}
