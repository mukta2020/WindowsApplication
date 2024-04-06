using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReplicateGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCapacityCount.Text = "239";
        }

        private void motorCycleTrack_Scroll(object sender, EventArgs e)
        {
            lblMotorCycle.Text = motorCycleTrack.Value.ToString();
            LoadCapacity();
        }

        private void truckTrack_Scroll(object sender, EventArgs e)
        {
            lblTruck.Text = truckTrack.Value.ToString();
            LoadCapacity();
        }
        private void carTrack_Scroll(object sender, EventArgs e)
        {
            lblCar.Text = carTrack.Value.ToString();
            LoadCapacity();
        }

        private void trainCarTrack_Scroll(object sender, EventArgs e)
        {
            lblTrainCar.Text = trainCarTrack.Value.ToString();
            LoadCapacity();
        }
        private void LoadCapacity()
        {
            string res = (
                (lblMotorCycle.Text!=string.Empty?Convert.ToInt32(lblMotorCycle.Text) * 3:0)
                + (lblTruck.Text != string.Empty ? Convert.ToInt32(lblTruck.Text) * 11 : 0)
                + (lblCar.Text != string.Empty ? Convert.ToInt32(lblCar.Text) * 5 : 0)
                + (lblTrainCar.Text != string.Empty ? Convert.ToInt32(lblTrainCar.Text) * 17 : 0) 
                ).ToString();
            lblLoadCount.Text = res;

            int n = Convert.ToInt32(lblLoadCount.Text);
            if (n < Convert.ToInt32(lblCapacityCount.Text))
            {
                capacityProgBar.Value = n;
                capacityProgBar.SetState(3);
                //capacityProgBar.ForeColor = Color.Yellow;
            }
            else if (n > Convert.ToInt32(lblCapacityCount.Text))
            {
                capacityProgBar.Value = Convert.ToInt32(lblCapacityCount.Text);
                capacityProgBar.SetState(2);
                //capacityProgBar.ForeColor = Color.Red;
            }
            else if (n == Convert.ToInt32(lblCapacityCount.Text))
            {
                capacityProgBar.Value = n;
                capacityProgBar.SetState(1);
                //capacityProgBar.ForeColor = Color.Green;
            }
            else
            {
                capacityProgBar.Value = 0;
                capacityProgBar.SetState(0);
            }
        }

        private void newBoat_Click(object sender, EventArgs e)
        {
            ClearBoat();
        }

        
        private void ClearBoat() 
        { lblLoadCount.Text = "0"; 
          lblCapacityCount.Text = "0"; 
          lblMotorCycle.Text = "0"; 
          lblTruck.Text = "0"; 
          lblCar.Text = "0"; 
          lblTrainCar.Text = "0"; 
          motorCycleTrack.Value = 0;
          truckTrack.Value = 0; 
          carTrack.Value = 0; 
          trainCarTrack.Value = 0; 
          LoadCapacity(); 
        }
    }
}
