namespace ReplicateGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.capacityProgBar = new System.Windows.Forms.ProgressBar();
            this.motorCycleTrack = new System.Windows.Forms.TrackBar();
            this.truckTrack = new System.Windows.Forms.TrackBar();
            this.carTrack = new System.Windows.Forms.TrackBar();
            this.trainCarTrack = new System.Windows.Forms.TrackBar();
            this.lblMotorCycle = new System.Windows.Forms.Label();
            this.lblTruck = new System.Windows.Forms.Label();
            this.lblCar = new System.Windows.Forms.Label();
            this.lblTrainCar = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblCurrentLoad = new System.Windows.Forms.Label();
            this.lblCapacityCount = new System.Windows.Forms.Label();
            this.lblLoadCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.newBoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.motorCycleTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainCarTrack)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // capacityProgBar
            // 
            this.capacityProgBar.Location = new System.Drawing.Point(108, 25);
            this.capacityProgBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.capacityProgBar.Maximum = 239;
            this.capacityProgBar.Name = "capacityProgBar";
            this.capacityProgBar.Size = new System.Drawing.Size(470, 74);
            this.capacityProgBar.TabIndex = 0;
            // 
            // motorCycleTrack
            // 
            this.motorCycleTrack.Location = new System.Drawing.Point(111, 291);
            this.motorCycleTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.motorCycleTrack.Name = "motorCycleTrack";
            this.motorCycleTrack.Size = new System.Drawing.Size(268, 56);
            this.motorCycleTrack.TabIndex = 1;
            this.motorCycleTrack.Scroll += new System.EventHandler(this.motorCycleTrack_Scroll);
            // 
            // truckTrack
            // 
            this.truckTrack.Location = new System.Drawing.Point(464, 291);
            this.truckTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.truckTrack.Name = "truckTrack";
            this.truckTrack.Size = new System.Drawing.Size(268, 56);
            this.truckTrack.TabIndex = 2;
            this.truckTrack.Scroll += new System.EventHandler(this.truckTrack_Scroll);
            // 
            // carTrack
            // 
            this.carTrack.Location = new System.Drawing.Point(111, 396);
            this.carTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carTrack.Name = "carTrack";
            this.carTrack.Size = new System.Drawing.Size(268, 56);
            this.carTrack.TabIndex = 3;
            this.carTrack.Scroll += new System.EventHandler(this.carTrack_Scroll);
            // 
            // trainCarTrack
            // 
            this.trainCarTrack.Location = new System.Drawing.Point(464, 396);
            this.trainCarTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trainCarTrack.Name = "trainCarTrack";
            this.trainCarTrack.Size = new System.Drawing.Size(268, 56);
            this.trainCarTrack.TabIndex = 4;
            this.trainCarTrack.Scroll += new System.EventHandler(this.trainCarTrack_Scroll);
            // 
            // lblMotorCycle
            // 
            this.lblMotorCycle.AutoSize = true;
            this.lblMotorCycle.Location = new System.Drawing.Point(167, 273);
            this.lblMotorCycle.Name = "lblMotorCycle";
            this.lblMotorCycle.Size = new System.Drawing.Size(0, 17);
            this.lblMotorCycle.TabIndex = 5;
            // 
            // lblTruck
            // 
            this.lblTruck.AutoSize = true;
            this.lblTruck.Location = new System.Drawing.Point(514, 273);
            this.lblTruck.Name = "lblTruck";
            this.lblTruck.Size = new System.Drawing.Size(0, 17);
            this.lblTruck.TabIndex = 6;
            // 
            // lblCar
            // 
            this.lblCar.AutoSize = true;
            this.lblCar.Location = new System.Drawing.Point(167, 378);
            this.lblCar.Name = "lblCar";
            this.lblCar.Size = new System.Drawing.Size(0, 17);
            this.lblCar.TabIndex = 7;
            // 
            // lblTrainCar
            // 
            this.lblTrainCar.AutoSize = true;
            this.lblTrainCar.Location = new System.Drawing.Point(511, 378);
            this.lblTrainCar.Name = "lblTrainCar";
            this.lblTrainCar.Size = new System.Drawing.Size(0, 17);
            this.lblTrainCar.TabIndex = 8;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCapacity.Location = new System.Drawing.Point(108, 110);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(84, 17);
            this.lblCapacity.TabIndex = 9;
            this.lblCapacity.Text = "Capacity =";
            // 
            // lblCurrentLoad
            // 
            this.lblCurrentLoad.AutoSize = true;
            this.lblCurrentLoad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblCurrentLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentLoad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblCurrentLoad.Location = new System.Drawing.Point(285, 110);
            this.lblCurrentLoad.Name = "lblCurrentLoad";
            this.lblCurrentLoad.Size = new System.Drawing.Size(112, 17);
            this.lblCurrentLoad.TabIndex = 10;
            this.lblCurrentLoad.Text = "CurrentLoad =";
            // 
            // lblCapacityCount
            // 
            this.lblCapacityCount.AutoSize = true;
            this.lblCapacityCount.Location = new System.Drawing.Point(196, 110);
            this.lblCapacityCount.Name = "lblCapacityCount";
            this.lblCapacityCount.Size = new System.Drawing.Size(0, 17);
            this.lblCapacityCount.TabIndex = 11;
            // 
            // lblLoadCount
            // 
            this.lblLoadCount.AutoSize = true;
            this.lblLoadCount.Location = new System.Drawing.Point(403, 109);
            this.lblLoadCount.Name = "lblLoadCount";
            this.lblLoadCount.Size = new System.Drawing.Size(0, 17);
            this.lblLoadCount.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Motor Cycle (3 Units)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Trucks (11 Units)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Care (5 Units)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Train Car (17 Units)";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.lblCapacity);
            this.panel1.Controls.Add(this.lblCurrentLoad);
            this.panel1.Controls.Add(this.lblCapacityCount);
            this.panel1.Controls.Add(this.lblLoadCount);
            this.panel1.Controls.Add(this.capacityProgBar);
            this.panel1.Location = new System.Drawing.Point(88, 70);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 155);
            this.panel1.TabIndex = 18;
            // 
            // newBoat
            // 
            this.newBoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBoat.Location = new System.Drawing.Point(88, 471);
            this.newBoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newBoat.Name = "newBoat";
            this.newBoat.Size = new System.Drawing.Size(118, 31);
            this.newBoat.TabIndex = 19;
            this.newBoat.Text = "New Boat";
            this.newBoat.UseVisualStyleBackColor = true;
            this.newBoat.Click += new System.EventHandler(this.newBoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1075, 512);
            this.Controls.Add(this.newBoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTrainCar);
            this.Controls.Add(this.lblCar);
            this.Controls.Add(this.lblTruck);
            this.Controls.Add(this.lblMotorCycle);
            this.Controls.Add(this.trainCarTrack);
            this.Controls.Add(this.carTrack);
            this.Controls.Add(this.truckTrack);
            this.Controls.Add(this.motorCycleTrack);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Fill the Boat";
            ((System.ComponentModel.ISupportInitialize)(this.motorCycleTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.truckTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainCarTrack)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar capacityProgBar;
        private System.Windows.Forms.TrackBar motorCycleTrack;
        private System.Windows.Forms.TrackBar truckTrack;
        private System.Windows.Forms.TrackBar carTrack;
        private System.Windows.Forms.TrackBar trainCarTrack;
        private System.Windows.Forms.Label lblMotorCycle;
        private System.Windows.Forms.Label lblTruck;
        private System.Windows.Forms.Label lblCar;
        private System.Windows.Forms.Label lblTrainCar;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblCurrentLoad;
        private System.Windows.Forms.Label lblCapacityCount;
        private System.Windows.Forms.Label lblLoadCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button newBoat;
    }
}

