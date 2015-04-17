using BO;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CarForm : Form
    {

        BoClass bl = new BoClass();
        Car cc = new Car();
        Graphics g;
        Char keyPress;
        int x;
        int y;
       
        public CarForm()
        {
            InitializeComponent();
            g = drawPanel.CreateGraphics();
             x = bl.x;
             y = bl.y;
            keyPress = 'd';
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bl.changeAxes(keyPress);
            drawPanel.Location = new Point(bl.x, bl.y);
        }

      


        private void CarKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                keyPress = 'u';
                g.Clear(Color.DarkSeaGreen);
                cc.carUp(g);
            }
            else if (e.KeyCode == Keys.Down)
            {
                keyPress = 'd';
                g.Clear(Color.DarkSeaGreen);
                cc.carDown(g);
            }
            else if (e.KeyCode == Keys.Left)
            {
                keyPress = 'l';
                g.Clear(Color.DarkSeaGreen);
                cc.carLeft(g);
            }
            else if (e.KeyCode == Keys.Right)
            {
                keyPress = 'r';
                g.Clear(Color.DarkSeaGreen);
                cc.carRight(g);
            }
        }

      
       
       

        private void CarForm_Load(object sender, EventArgs e)
        {
            currentInfoLabel.Text = Convert.ToString(bl.getData());
        }

        private void speedButton_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(speedBox.Text))
                MessageBox.Show("Please, enter speed correctly.");
            else
            {
                Car c = new Car();
                c.speed = Convert.ToInt32(speedBox.Text);
                if (bl.saveSpeed(c))
                {
                    info.Text = "Now, Press 'Start'";
                    currentInfoLabel.Text = Convert.ToString(bl.getData());
                }
                else
                {
                    MessageBox.Show("error");
                    info.Text = null;
                }

            }
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            info.Text = null;
            cc.carDown(g);


            if (bl.speedCalculation() != 0 && !String.IsNullOrEmpty(currentInfoLabel.Text))
            {
                timer1.Interval = bl.speedCalculation();
                timer1.Start();
            }
        }

        private void stopButton_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
