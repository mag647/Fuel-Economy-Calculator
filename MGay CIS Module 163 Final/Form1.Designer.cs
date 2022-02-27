namespace MGay_CIS_Module_163_Final
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblDirections = new System.Windows.Forms.Label();
            this.grpBoxTheme = new System.Windows.Forms.GroupBox();
            this.radioBtnPurpleTheme = new System.Windows.Forms.RadioButton();
            this.radioBtnDarkTheme = new System.Windows.Forms.RadioButton();
            this.radioBtnDefaultTheme = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSelectUnits = new System.Windows.Forms.Label();
            this.lblCalculate = new System.Windows.Forms.Label();
            this.comboBoxUnits = new System.Windows.Forms.ComboBox();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblFuelUsed = new System.Windows.Forms.Label();
            this.txtBoxDistance = new System.Windows.Forms.TextBox();
            this.txtBoxFuel = new System.Windows.Forms.TextBox();
            this.lblFuelEconomy = new System.Windows.Forms.Label();
            this.lblDistanceUnits = new System.Windows.Forms.Label();
            this.lblFuelUnits = new System.Windows.Forms.Label();
            this.lblFuelEconomyUnits = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.timerComplete = new System.Windows.Forms.Timer(this.components);
            this.grpBoxTheme.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDirections
            // 
            this.lblDirections.AutoSize = true;
            this.lblDirections.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirections.Location = new System.Drawing.Point(96, 20);
            this.lblDirections.Name = "lblDirections";
            this.lblDirections.Size = new System.Drawing.Size(207, 20);
            this.lblDirections.TabIndex = 0;
            this.lblDirections.Text = "Calculate Fuel Economy:";
            // 
            // grpBoxTheme
            // 
            this.grpBoxTheme.Controls.Add(this.radioBtnPurpleTheme);
            this.grpBoxTheme.Controls.Add(this.radioBtnDarkTheme);
            this.grpBoxTheme.Controls.Add(this.radioBtnDefaultTheme);
            this.grpBoxTheme.Location = new System.Drawing.Point(27, 396);
            this.grpBoxTheme.Name = "grpBoxTheme";
            this.grpBoxTheme.Size = new System.Drawing.Size(339, 48);
            this.grpBoxTheme.TabIndex = 2;
            this.grpBoxTheme.TabStop = false;
            this.grpBoxTheme.Text = "Change Theme:";
            // 
            // radioBtnPurpleTheme
            // 
            this.radioBtnPurpleTheme.AutoSize = true;
            this.radioBtnPurpleTheme.Location = new System.Drawing.Point(251, 19);
            this.radioBtnPurpleTheme.Name = "radioBtnPurpleTheme";
            this.radioBtnPurpleTheme.Size = new System.Drawing.Size(55, 17);
            this.radioBtnPurpleTheme.TabIndex = 2;
            this.radioBtnPurpleTheme.Text = "Purple";
            this.radioBtnPurpleTheme.UseVisualStyleBackColor = true;
            this.radioBtnPurpleTheme.CheckedChanged += new System.EventHandler(this.radioBtnPurpleTheme_CheckedChanged);
            // 
            // radioBtnDarkTheme
            // 
            this.radioBtnDarkTheme.AutoSize = true;
            this.radioBtnDarkTheme.Location = new System.Drawing.Point(137, 19);
            this.radioBtnDarkTheme.Name = "radioBtnDarkTheme";
            this.radioBtnDarkTheme.Size = new System.Drawing.Size(48, 17);
            this.radioBtnDarkTheme.TabIndex = 1;
            this.radioBtnDarkTheme.Text = "Dark";
            this.radioBtnDarkTheme.UseVisualStyleBackColor = true;
            this.radioBtnDarkTheme.CheckedChanged += new System.EventHandler(this.radioBtnDarkTheme_CheckedChanged);
            // 
            // radioBtnDefaultTheme
            // 
            this.radioBtnDefaultTheme.AutoSize = true;
            this.radioBtnDefaultTheme.Checked = true;
            this.radioBtnDefaultTheme.Location = new System.Drawing.Point(30, 20);
            this.radioBtnDefaultTheme.Name = "radioBtnDefaultTheme";
            this.radioBtnDefaultTheme.Size = new System.Drawing.Size(59, 17);
            this.radioBtnDefaultTheme.TabIndex = 0;
            this.radioBtnDefaultTheme.TabStop = true;
            this.radioBtnDefaultTheme.Text = "Default";
            this.radioBtnDefaultTheme.UseVisualStyleBackColor = true;
            this.radioBtnDefaultTheme.CheckedChanged += new System.EventHandler(this.radioBtnDefaultTheme_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Silver;
            this.btnClear.Location = new System.Drawing.Point(100, 343);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Silver;
            this.btnExit.Location = new System.Drawing.Point(228, 343);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Silver;
            this.btnCalculate.Location = new System.Drawing.Point(140, 220);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(121, 42);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            this.btnCalculate.MouseEnter += new System.EventHandler(this.btnCalculate_MouseEnter);
            this.btnCalculate.MouseLeave += new System.EventHandler(this.btnCalculate_MouseLeave);
            // 
            // lblSelectUnits
            // 
            this.lblSelectUnits.AutoSize = true;
            this.lblSelectUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectUnits.Location = new System.Drawing.Point(159, 52);
            this.lblSelectUnits.Name = "lblSelectUnits";
            this.lblSelectUnits.Size = new System.Drawing.Size(82, 16);
            this.lblSelectUnits.TabIndex = 8;
            this.lblSelectUnits.Text = "Select Units:";
            // 
            // lblCalculate
            // 
            this.lblCalculate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculate.Location = new System.Drawing.Point(152, 290);
            this.lblCalculate.Name = "lblCalculate";
            this.lblCalculate.Size = new System.Drawing.Size(100, 21);
            this.lblCalculate.TabIndex = 9;
            this.lblCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxUnits
            // 
            this.comboBoxUnits.FormattingEnabled = true;
            this.comboBoxUnits.Location = new System.Drawing.Point(140, 71);
            this.comboBoxUnits.Name = "comboBoxUnits";
            this.comboBoxUnits.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUnits.TabIndex = 10;
            this.comboBoxUnits.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnits_SelectedIndexChanged);
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(48, 126);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(98, 16);
            this.lblDistance.TabIndex = 11;
            this.lblDistance.Text = "Enter Distance:";
            // 
            // lblFuelUsed
            // 
            this.lblFuelUsed.AutoSize = true;
            this.lblFuelUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelUsed.Location = new System.Drawing.Point(39, 175);
            this.lblFuelUsed.Name = "lblFuelUsed";
            this.lblFuelUsed.Size = new System.Drawing.Size(107, 16);
            this.lblFuelUsed.TabIndex = 12;
            this.lblFuelUsed.Text = "Enter Fuel Used:";
            // 
            // txtBoxDistance
            // 
            this.txtBoxDistance.Location = new System.Drawing.Point(152, 128);
            this.txtBoxDistance.Name = "txtBoxDistance";
            this.txtBoxDistance.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDistance.TabIndex = 13;
            // 
            // txtBoxFuel
            // 
            this.txtBoxFuel.Location = new System.Drawing.Point(152, 175);
            this.txtBoxFuel.Name = "txtBoxFuel";
            this.txtBoxFuel.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFuel.TabIndex = 14;
            // 
            // lblFuelEconomy
            // 
            this.lblFuelEconomy.AutoSize = true;
            this.lblFuelEconomy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelEconomy.Location = new System.Drawing.Point(39, 295);
            this.lblFuelEconomy.Name = "lblFuelEconomy";
            this.lblFuelEconomy.Size = new System.Drawing.Size(97, 16);
            this.lblFuelEconomy.TabIndex = 15;
            this.lblFuelEconomy.Text = "Fuel Economy:";
            // 
            // lblDistanceUnits
            // 
            this.lblDistanceUnits.AutoSize = true;
            this.lblDistanceUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceUnits.Location = new System.Drawing.Point(276, 132);
            this.lblDistanceUnits.Name = "lblDistanceUnits";
            this.lblDistanceUnits.Size = new System.Drawing.Size(40, 16);
            this.lblDistanceUnits.TabIndex = 16;
            this.lblDistanceUnits.Text = "Miles";
            // 
            // lblFuelUnits
            // 
            this.lblFuelUnits.AutoSize = true;
            this.lblFuelUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelUnits.Location = new System.Drawing.Point(276, 179);
            this.lblFuelUnits.Name = "lblFuelUnits";
            this.lblFuelUnits.Size = new System.Drawing.Size(54, 16);
            this.lblFuelUnits.TabIndex = 17;
            this.lblFuelUnits.Text = "Gallons";
            // 
            // lblFuelEconomyUnits
            // 
            this.lblFuelEconomyUnits.AutoSize = true;
            this.lblFuelEconomyUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelEconomyUnits.Location = new System.Drawing.Point(275, 295);
            this.lblFuelEconomyUnits.Name = "lblFuelEconomyUnits";
            this.lblFuelEconomyUnits.Size = new System.Drawing.Size(105, 16);
            this.lblFuelEconomyUnits.TabIndex = 18;
            this.lblFuelEconomyUnits.Text = "Miles per Gallon";
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnits.Location = new System.Drawing.Point(276, 104);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(41, 16);
            this.lblUnits.TabIndex = 19;
            this.lblUnits.Text = "Units:";
            // 
            // timerComplete
            // 
            this.timerComplete.Interval = 5000;
            this.timerComplete.Tick += new System.EventHandler(this.timerComplete_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 464);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblFuelEconomyUnits);
            this.Controls.Add(this.lblFuelUnits);
            this.Controls.Add(this.lblDistanceUnits);
            this.Controls.Add(this.lblFuelEconomy);
            this.Controls.Add(this.txtBoxFuel);
            this.Controls.Add(this.txtBoxDistance);
            this.Controls.Add(this.lblFuelUsed);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.comboBoxUnits);
            this.Controls.Add(this.lblCalculate);
            this.Controls.Add(this.lblSelectUnits);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpBoxTheme);
            this.Controls.Add(this.lblDirections);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fuel Economy Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxTheme.ResumeLayout(false);
            this.grpBoxTheme.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirections;
        private System.Windows.Forms.GroupBox grpBoxTheme;
        private System.Windows.Forms.RadioButton radioBtnDarkTheme;
        private System.Windows.Forms.RadioButton radioBtnDefaultTheme;
        private System.Windows.Forms.RadioButton radioBtnPurpleTheme;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSelectUnits;
        private System.Windows.Forms.Label lblCalculate;
        private System.Windows.Forms.ComboBox comboBoxUnits;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblFuelUsed;
        private System.Windows.Forms.TextBox txtBoxDistance;
        private System.Windows.Forms.TextBox txtBoxFuel;
        private System.Windows.Forms.Label lblFuelEconomy;
        private System.Windows.Forms.Label lblDistanceUnits;
        private System.Windows.Forms.Label lblFuelUnits;
        private System.Windows.Forms.Label lblFuelEconomyUnits;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.Timer timerComplete;
    }
}

