namespace CSCN72030_GROUP_5
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            LightStatusLabel = new Label();
            LightEnergyUsageLabel = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label17 = new Label();
            currentTemperatureLabel = new Label();
            EnergyUsageLabel = new Label();
            label20 = new Label();
            label21 = new Label();
            NewTemperatureTb = new TextBox();
            button6 = new Button();
            label22 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bathroom;
            pictureBox1.Location = new Point(27, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 197);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(224, 62);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "On/Off";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 34);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 2;
            label1.Text = "Light Switch";
            // 
            // LightStatusLabel
            // 
            LightStatusLabel.AutoSize = true;
            LightStatusLabel.Location = new Point(227, 100);
            LightStatusLabel.Name = "LightStatusLabel";
            LightStatusLabel.Size = new Size(93, 15);
            LightStatusLabel.TabIndex = 3;
            LightStatusLabel.Text = "Light Status: ON";
            // 
            // LightEnergyUsageLabel
            // 
            LightEnergyUsageLabel.AutoSize = true;
            LightEnergyUsageLabel.Location = new Point(224, 131);
            LightEnergyUsageLabel.Name = "LightEnergyUsageLabel";
            LightEnergyUsageLabel.Size = new Size(135, 15);
            LightEnergyUsageLabel.TabIndex = 4;
            LightEnergyUsageLabel.Text = "Energy Usage: 0.014kWh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 34);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 5;
            label4.Text = "Water Sources";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(375, 70);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 6;
            label5.Text = "Sink Faucet 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(375, 158);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 7;
            label6.Text = "Sink Faucet 2";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(375, 246);
            label7.Name = "label7";
            label7.Size = new Size(46, 15);
            label7.TabIndex = 8;
            label7.Text = "Shower";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(375, 327);
            label8.Name = "label8";
            label8.Size = new Size(35, 15);
            label8.TabIndex = 9;
            label8.Text = "Toilet";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(376, 100);
            label9.Name = "label9";
            label9.Size = new Size(97, 15);
            label9.TabIndex = 10;
            label9.Text = "Total Usage: 1 m³";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(376, 276);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 11;
            label10.Text = "Total Usage: 5 m³";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(376, 186);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 12;
            label11.Text = "Total Usage: 0 m³";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(376, 353);
            label12.Name = "label12";
            label12.Size = new Size(97, 15);
            label12.TabIndex = 13;
            label12.Text = "Total Usage: 7 m³";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(474, 70);
            label13.Name = "label13";
            label13.Size = new Size(24, 15);
            label13.TabIndex = 14;
            label13.Text = "Off";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(474, 158);
            label14.Name = "label14";
            label14.Size = new Size(24, 15);
            label14.TabIndex = 15;
            label14.Text = "Off";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(472, 246);
            label15.Name = "label15";
            label15.Size = new Size(24, 15);
            label15.TabIndex = 16;
            label15.Text = "Off";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(474, 327);
            label16.Name = "label16";
            label16.Size = new Size(24, 15);
            label16.TabIndex = 17;
            label16.Text = "Off";
            // 
            // button2
            // 
            button2.Location = new Point(509, 66);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "On/Off";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(509, 158);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 19;
            button3.Text = "On/Off";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(509, 238);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 20;
            button4.Text = "On/Off";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(509, 323);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 21;
            button5.Text = "On/Off";
            button5.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(27, 238);
            label17.Name = "label17";
            label17.Size = new Size(91, 15);
            label17.TabIndex = 22;
            label17.Text = "Climate Control";
            // 
            // currentTemperatureLabel
            // 
            currentTemperatureLabel.AutoSize = true;
            currentTemperatureLabel.Location = new Point(27, 315);
            currentTemperatureLabel.Name = "currentTemperatureLabel";
            currentTemperatureLabel.Size = new Size(150, 15);
            currentTemperatureLabel.TabIndex = 23;
            currentTemperatureLabel.Text = "Current Temperature: 20 °C";
            // 
            // EnergyUsageLabel
            // 
            EnergyUsageLabel.AutoSize = true;
            EnergyUsageLabel.Location = new Point(27, 346);
            EnergyUsageLabel.Name = "EnergyUsageLabel";
            EnergyUsageLabel.Size = new Size(120, 15);
            EnergyUsageLabel.TabIndex = 24;
            EnergyUsageLabel.Text = "Energy Usage: 50kWh";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(224, 162);
            label20.Name = "label20";
            label20.Size = new Size(103, 15);
            label20.TabIndex = 25;
            label20.Text = "Total Usage: 6kWh";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(27, 374);
            label21.Name = "label21";
            label21.Size = new Size(118, 15);
            label21.TabIndex = 26;
            label21.Text = "Total Usage: 155 kWh";
            // 
            // NewTemperatureTb
            // 
            NewTemperatureTb.Location = new Point(27, 276);
            NewTemperatureTb.Name = "NewTemperatureTb";
            NewTemperatureTb.Size = new Size(38, 23);
            NewTemperatureTb.TabIndex = 27;
            // 
            // button6
            // 
            button6.Location = new Point(102, 276);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 28;
            button6.Text = "Enter";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(71, 276);
            label22.Name = "label22";
            label22.Size = new Size(23, 15);
            label22.TabIndex = 29;
            label22.Text = " °C";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 408);
            Controls.Add(label22);
            Controls.Add(button6);
            Controls.Add(NewTemperatureTb);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(EnergyUsageLabel);
            Controls.Add(currentTemperatureLabel);
            Controls.Add(label17);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LightEnergyUsageLabel);
            Controls.Add(LightStatusLabel);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Bathroom Controls";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label LightStatusLabel;
        private Label LightEnergyUsageLabel;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label17;
        private Label currentTemperatureLabel;
        private Label EnergyUsageLabel;
        private Label label20;
        private Label label21;
        private TextBox NewTemperatureTb;
        private Button button6;
        private Label label22;
    }
}