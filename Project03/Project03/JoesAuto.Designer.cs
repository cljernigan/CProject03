namespace Project03
{
    partial class JoesAuto
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
            this.MaintenanceGroupBox = new System.Windows.Forms.GroupBox();
            this.LubeCheckBox = new System.Windows.Forms.CheckBox();
            this.OilChangeCheckBox = new System.Windows.Forms.CheckBox();
            this.FlushGroupBox = new System.Windows.Forms.GroupBox();
            this.TranFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.RadFlushCheckBox = new System.Windows.Forms.CheckBox();
            this.MiscGroupBox = new System.Windows.Forms.GroupBox();
            this.TireRotationCheckBox = new System.Windows.Forms.CheckBox();
            this.ReplaceMuffCheckBox = new System.Windows.Forms.CheckBox();
            this.InspectionCheckBox = new System.Windows.Forms.CheckBox();
            this.PartsLaborGroupBox = new System.Windows.Forms.GroupBox();
            this.PartLabel = new System.Windows.Forms.Label();
            this.PartCostTextBox = new System.Windows.Forms.TextBox();
            this.RateLabel = new System.Windows.Forms.Label();
            this.LaborHourLabel = new System.Windows.Forms.Label();
            this.LaborHoursTextBox = new System.Windows.Forms.TextBox();
            this.ServiceLabel = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.TaxPartLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.ServiceLaborOutLabel = new System.Windows.Forms.Label();
            this.PartsOutLabel = new System.Windows.Forms.Label();
            this.TaxOutLabel = new System.Windows.Forms.Label();
            this.TotalOutLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.MaintenanceGroupBox.SuspendLayout();
            this.FlushGroupBox.SuspendLayout();
            this.MiscGroupBox.SuspendLayout();
            this.PartsLaborGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaintenanceGroupBox
            // 
            this.MaintenanceGroupBox.Controls.Add(this.LubeCheckBox);
            this.MaintenanceGroupBox.Controls.Add(this.OilChangeCheckBox);
            this.MaintenanceGroupBox.Location = new System.Drawing.Point(13, 13);
            this.MaintenanceGroupBox.Name = "MaintenanceGroupBox";
            this.MaintenanceGroupBox.Size = new System.Drawing.Size(177, 89);
            this.MaintenanceGroupBox.TabIndex = 0;
            this.MaintenanceGroupBox.TabStop = false;
            this.MaintenanceGroupBox.Text = "Oil And Lube";
            // 
            // LubeCheckBox
            // 
            this.LubeCheckBox.AutoSize = true;
            this.LubeCheckBox.Location = new System.Drawing.Point(16, 62);
            this.LubeCheckBox.Name = "LubeCheckBox";
            this.LubeCheckBox.Size = new System.Drawing.Size(112, 17);
            this.LubeCheckBox.TabIndex = 1;
            this.LubeCheckBox.Text = "Lube Job ($18.00)";
            this.LubeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OilChangeCheckBox
            // 
            this.OilChangeCheckBox.AutoSize = true;
            this.OilChangeCheckBox.Location = new System.Drawing.Point(16, 25);
            this.OilChangeCheckBox.Name = "OilChangeCheckBox";
            this.OilChangeCheckBox.Size = new System.Drawing.Size(120, 17);
            this.OilChangeCheckBox.TabIndex = 0;
            this.OilChangeCheckBox.Text = "Oil Change ($26.00)";
            this.OilChangeCheckBox.UseVisualStyleBackColor = true;
            // 
            // FlushGroupBox
            // 
            this.FlushGroupBox.Controls.Add(this.TranFlushCheckBox);
            this.FlushGroupBox.Controls.Add(this.RadFlushCheckBox);
            this.FlushGroupBox.Location = new System.Drawing.Point(196, 13);
            this.FlushGroupBox.Name = "FlushGroupBox";
            this.FlushGroupBox.Size = new System.Drawing.Size(177, 89);
            this.FlushGroupBox.TabIndex = 1;
            this.FlushGroupBox.TabStop = false;
            this.FlushGroupBox.Text = "Flushes";
            // 
            // TranFlushCheckBox
            // 
            this.TranFlushCheckBox.AutoSize = true;
            this.TranFlushCheckBox.Location = new System.Drawing.Point(16, 62);
            this.TranFlushCheckBox.Name = "TranFlushCheckBox";
            this.TranFlushCheckBox.Size = new System.Drawing.Size(157, 17);
            this.TranFlushCheckBox.TabIndex = 1;
            this.TranFlushCheckBox.Text = "Transmission Flush ($80.00)";
            this.TranFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // RadFlushCheckBox
            // 
            this.RadFlushCheckBox.AutoSize = true;
            this.RadFlushCheckBox.Location = new System.Drawing.Point(16, 25);
            this.RadFlushCheckBox.Name = "RadFlushCheckBox";
            this.RadFlushCheckBox.Size = new System.Drawing.Size(136, 17);
            this.RadFlushCheckBox.TabIndex = 0;
            this.RadFlushCheckBox.Text = "Radiator Flush ($30.00)";
            this.RadFlushCheckBox.UseVisualStyleBackColor = true;
            // 
            // MiscGroupBox
            // 
            this.MiscGroupBox.Controls.Add(this.TireRotationCheckBox);
            this.MiscGroupBox.Controls.Add(this.ReplaceMuffCheckBox);
            this.MiscGroupBox.Controls.Add(this.InspectionCheckBox);
            this.MiscGroupBox.Location = new System.Drawing.Point(13, 123);
            this.MiscGroupBox.Name = "MiscGroupBox";
            this.MiscGroupBox.Size = new System.Drawing.Size(177, 129);
            this.MiscGroupBox.TabIndex = 2;
            this.MiscGroupBox.TabStop = false;
            this.MiscGroupBox.Text = "Misc";
            // 
            // TireRotationCheckBox
            // 
            this.TireRotationCheckBox.AutoSize = true;
            this.TireRotationCheckBox.Location = new System.Drawing.Point(6, 93);
            this.TireRotationCheckBox.Name = "TireRotationCheckBox";
            this.TireRotationCheckBox.Size = new System.Drawing.Size(132, 17);
            this.TireRotationCheckBox.TabIndex = 2;
            this.TireRotationCheckBox.Text = "Tire Rotation  ($20.00)";
            this.TireRotationCheckBox.UseVisualStyleBackColor = true;
            // 
            // ReplaceMuffCheckBox
            // 
            this.ReplaceMuffCheckBox.AutoSize = true;
            this.ReplaceMuffCheckBox.Location = new System.Drawing.Point(6, 55);
            this.ReplaceMuffCheckBox.Name = "ReplaceMuffCheckBox";
            this.ReplaceMuffCheckBox.Size = new System.Drawing.Size(149, 17);
            this.ReplaceMuffCheckBox.TabIndex = 1;
            this.ReplaceMuffCheckBox.Text = "Replace Muffler ($100.00)";
            this.ReplaceMuffCheckBox.UseVisualStyleBackColor = true;
            // 
            // InspectionCheckBox
            // 
            this.InspectionCheckBox.AutoSize = true;
            this.InspectionCheckBox.Location = new System.Drawing.Point(6, 19);
            this.InspectionCheckBox.Name = "InspectionCheckBox";
            this.InspectionCheckBox.Size = new System.Drawing.Size(117, 17);
            this.InspectionCheckBox.TabIndex = 0;
            this.InspectionCheckBox.Text = "Inspection ($15.00)";
            this.InspectionCheckBox.UseVisualStyleBackColor = true;
            // 
            // PartsLaborGroupBox
            // 
            this.PartsLaborGroupBox.Controls.Add(this.PartLabel);
            this.PartsLaborGroupBox.Controls.Add(this.PartCostTextBox);
            this.PartsLaborGroupBox.Controls.Add(this.RateLabel);
            this.PartsLaborGroupBox.Controls.Add(this.LaborHourLabel);
            this.PartsLaborGroupBox.Controls.Add(this.LaborHoursTextBox);
            this.PartsLaborGroupBox.Location = new System.Drawing.Point(196, 123);
            this.PartsLaborGroupBox.Name = "PartsLaborGroupBox";
            this.PartsLaborGroupBox.Size = new System.Drawing.Size(191, 129);
            this.PartsLaborGroupBox.TabIndex = 3;
            this.PartsLaborGroupBox.TabStop = false;
            this.PartsLaborGroupBox.Text = "Parts and Labor";
            // 
            // PartLabel
            // 
            this.PartLabel.AutoSize = true;
            this.PartLabel.Location = new System.Drawing.Point(13, 87);
            this.PartLabel.Name = "PartLabel";
            this.PartLabel.Size = new System.Drawing.Size(55, 13);
            this.PartLabel.TabIndex = 4;
            this.PartLabel.Text = "Parts Cost";
            // 
            // PartCostTextBox
            // 
            this.PartCostTextBox.Location = new System.Drawing.Point(16, 103);
            this.PartCostTextBox.Name = "PartCostTextBox";
            this.PartCostTextBox.Size = new System.Drawing.Size(83, 20);
            this.PartCostTextBox.TabIndex = 3;
            // 
            // RateLabel
            // 
            this.RateLabel.AutoSize = true;
            this.RateLabel.Location = new System.Drawing.Point(6, 36);
            this.RateLabel.Name = "RateLabel";
            this.RateLabel.Size = new System.Drawing.Size(106, 13);
            this.RateLabel.TabIndex = 2;
            this.RateLabel.Text = " (Rate $40.00 /Hour)";
            // 
            // LaborHourLabel
            // 
            this.LaborHourLabel.AutoSize = true;
            this.LaborHourLabel.Location = new System.Drawing.Point(9, 23);
            this.LaborHourLabel.Name = "LaborHourLabel";
            this.LaborHourLabel.Size = new System.Drawing.Size(95, 13);
            this.LaborHourLabel.TabIndex = 1;
            this.LaborHourLabel.Text = "Total Labor Hours ";
            // 
            // LaborHoursTextBox
            // 
            this.LaborHoursTextBox.Location = new System.Drawing.Point(16, 55);
            this.LaborHoursTextBox.Name = "LaborHoursTextBox";
            this.LaborHoursTextBox.Size = new System.Drawing.Size(83, 20);
            this.LaborHoursTextBox.TabIndex = 0;
            // 
            // ServiceLabel
            // 
            this.ServiceLabel.AutoSize = true;
            this.ServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLabel.Location = new System.Drawing.Point(31, 286);
            this.ServiceLabel.Name = "ServiceLabel";
            this.ServiceLabel.Size = new System.Drawing.Size(137, 20);
            this.ServiceLabel.TabIndex = 6;
            this.ServiceLabel.Text = "Service and Labor";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(31, 316);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(46, 20);
            this.PartsLabel.TabIndex = 7;
            this.PartsLabel.Text = "Parts";
            // 
            // TaxPartLabel
            // 
            this.TaxPartLabel.AutoSize = true;
            this.TaxPartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxPartLabel.Location = new System.Drawing.Point(30, 346);
            this.TaxPartLabel.Name = "TaxPartLabel";
            this.TaxPartLabel.Size = new System.Drawing.Size(124, 20);
            this.TaxPartLabel.TabIndex = 8;
            this.TaxPartLabel.Text = "Taxes (on Parts)";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(31, 380);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(81, 20);
            this.TotalLabel.TabIndex = 9;
            this.TotalLabel.Text = "Total Cost";
            // 
            // ServiceLaborOutLabel
            // 
            this.ServiceLaborOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServiceLaborOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceLaborOutLabel.Location = new System.Drawing.Point(191, 283);
            this.ServiceLaborOutLabel.Name = "ServiceLaborOutLabel";
            this.ServiceLaborOutLabel.Size = new System.Drawing.Size(152, 23);
            this.ServiceLaborOutLabel.TabIndex = 10;
            // 
            // PartsOutLabel
            // 
            this.PartsOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsOutLabel.Location = new System.Drawing.Point(191, 316);
            this.PartsOutLabel.Name = "PartsOutLabel";
            this.PartsOutLabel.Size = new System.Drawing.Size(152, 23);
            this.PartsOutLabel.TabIndex = 11;
            // 
            // TaxOutLabel
            // 
            this.TaxOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxOutLabel.Location = new System.Drawing.Point(191, 346);
            this.TaxOutLabel.Name = "TaxOutLabel";
            this.TaxOutLabel.Size = new System.Drawing.Size(152, 23);
            this.TaxOutLabel.TabIndex = 12;
            // 
            // TotalOutLabel
            // 
            this.TotalOutLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOutLabel.Location = new System.Drawing.Point(191, 380);
            this.TotalOutLabel.Name = "TotalOutLabel";
            this.TotalOutLabel.Size = new System.Drawing.Size(152, 23);
            this.TotalOutLabel.TabIndex = 13;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(30, 418);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(124, 29);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "C&lear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(219, 418);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(124, 29);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "E&xit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(125, 453);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(124, 29);
            this.CalculateButton.TabIndex = 16;
            this.CalculateButton.Text = "&Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // JoesAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 553);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.TotalOutLabel);
            this.Controls.Add(this.TaxOutLabel);
            this.Controls.Add(this.PartsOutLabel);
            this.Controls.Add(this.ServiceLaborOutLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.TaxPartLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.ServiceLabel);
            this.Controls.Add(this.PartsLaborGroupBox);
            this.Controls.Add(this.MiscGroupBox);
            this.Controls.Add(this.FlushGroupBox);
            this.Controls.Add(this.MaintenanceGroupBox);
            this.Name = "JoesAuto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joe\'s Automotive - Christopher Jernigan";
            this.MaintenanceGroupBox.ResumeLayout(false);
            this.MaintenanceGroupBox.PerformLayout();
            this.FlushGroupBox.ResumeLayout(false);
            this.FlushGroupBox.PerformLayout();
            this.MiscGroupBox.ResumeLayout(false);
            this.MiscGroupBox.PerformLayout();
            this.PartsLaborGroupBox.ResumeLayout(false);
            this.PartsLaborGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox MaintenanceGroupBox;
        private System.Windows.Forms.CheckBox LubeCheckBox;
        private System.Windows.Forms.CheckBox OilChangeCheckBox;
        private System.Windows.Forms.GroupBox FlushGroupBox;
        private System.Windows.Forms.CheckBox TranFlushCheckBox;
        private System.Windows.Forms.CheckBox RadFlushCheckBox;
        private System.Windows.Forms.GroupBox MiscGroupBox;
        private System.Windows.Forms.CheckBox TireRotationCheckBox;
        private System.Windows.Forms.CheckBox ReplaceMuffCheckBox;
        private System.Windows.Forms.CheckBox InspectionCheckBox;
        private System.Windows.Forms.GroupBox PartsLaborGroupBox;
        private System.Windows.Forms.TextBox LaborHoursTextBox;
        private System.Windows.Forms.Label LaborHourLabel;
        private System.Windows.Forms.Label ServiceLabel;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label RateLabel;
        private System.Windows.Forms.Label TaxPartLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label ServiceLaborOutLabel;
        private System.Windows.Forms.Label PartsOutLabel;
        private System.Windows.Forms.Label TaxOutLabel;
        private System.Windows.Forms.Label TotalOutLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox PartCostTextBox;
        private System.Windows.Forms.Label PartLabel;
    }
}

