namespace Project03
{
    partial class ChrisAutoParts
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
            this.PartsCLB = new System.Windows.Forms.CheckedListBox();
            this.ServiceCLB = new System.Windows.Forms.CheckedListBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CalcButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PartsTotalLabel = new System.Windows.Forms.Label();
            this.LaborTotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.PartTotalOut = new System.Windows.Forms.Label();
            this.TaxOut = new System.Windows.Forms.Label();
            this.LaborOut = new System.Windows.Forms.Label();
            this.GrandOut = new System.Windows.Forms.Label();
            this.servicePartsDataSet = new Project03.ServicePartsDataSet();
            this.partsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partsTableTableAdapter = new Project03.ServicePartsDataSetTableAdapters.PartsTableTableAdapter();
            this.tableAdapterManager = new Project03.ServicePartsDataSetTableAdapters.TableAdapterManager();
            this.servicePartsDataSet1 = new Project03.ServicePartsDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.servicePartsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePartsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // PartsCLB
            // 
            this.PartsCLB.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.partsTableBindingSource, "PartName", true));
            this.PartsCLB.FormattingEnabled = true;
            this.PartsCLB.Location = new System.Drawing.Point(28, 28);
            this.PartsCLB.Name = "PartsCLB";
            this.PartsCLB.Size = new System.Drawing.Size(183, 244);
            this.PartsCLB.TabIndex = 0;
            // 
            // ServiceCLB
            // 
            this.ServiceCLB.FormattingEnabled = true;
            this.ServiceCLB.Location = new System.Drawing.Point(217, 28);
            this.ServiceCLB.Name = "ServiceCLB";
            this.ServiceCLB.Size = new System.Drawing.Size(180, 244);
            this.ServiceCLB.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(281, 393);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(119, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CalcButton
            // 
            this.CalcButton.Location = new System.Drawing.Point(156, 393);
            this.CalcButton.Name = "CalcButton";
            this.CalcButton.Size = new System.Drawing.Size(119, 40);
            this.CalcButton.TabIndex = 3;
            this.CalcButton.Text = "Calculate";
            this.CalcButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(31, 393);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(119, 40);
            this.ClearButton.TabIndex = 4;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PartsTotalLabel
            // 
            this.PartsTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartsTotalLabel.Location = new System.Drawing.Point(28, 297);
            this.PartsTotalLabel.Name = "PartsTotalLabel";
            this.PartsTotalLabel.Size = new System.Drawing.Size(183, 33);
            this.PartsTotalLabel.TabIndex = 5;
            this.PartsTotalLabel.Text = "Parts Total";
            // 
            // LaborTotalLabel
            // 
            this.LaborTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborTotalLabel.Location = new System.Drawing.Point(217, 297);
            this.LaborTotalLabel.Name = "LaborTotalLabel";
            this.LaborTotalLabel.Size = new System.Drawing.Size(66, 33);
            this.LaborTotalLabel.TabIndex = 6;
            this.LaborTotalLabel.Text = "Labor Total\r\n$40/Hour";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrandTotalLabel.Location = new System.Drawing.Point(217, 340);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(183, 33);
            this.GrandTotalLabel.TabIndex = 7;
            this.GrandTotalLabel.Text = "Grand Total";
            // 
            // TaxLabel
            // 
            this.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxLabel.Location = new System.Drawing.Point(28, 340);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(183, 33);
            this.TaxLabel.TabIndex = 8;
            this.TaxLabel.Text = "Tax";
            // 
            // PartTotalOut
            // 
            this.PartTotalOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PartTotalOut.Location = new System.Drawing.Point(92, 297);
            this.PartTotalOut.Name = "PartTotalOut";
            this.PartTotalOut.Size = new System.Drawing.Size(119, 33);
            this.PartTotalOut.TabIndex = 9;
            // 
            // TaxOut
            // 
            this.TaxOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxOut.Location = new System.Drawing.Point(92, 340);
            this.TaxOut.Name = "TaxOut";
            this.TaxOut.Size = new System.Drawing.Size(119, 33);
            this.TaxOut.TabIndex = 10;
            // 
            // LaborOut
            // 
            this.LaborOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LaborOut.Location = new System.Drawing.Point(281, 297);
            this.LaborOut.Name = "LaborOut";
            this.LaborOut.Size = new System.Drawing.Size(119, 33);
            this.LaborOut.TabIndex = 11;
            // 
            // GrandOut
            // 
            this.GrandOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrandOut.Location = new System.Drawing.Point(281, 340);
            this.GrandOut.Name = "GrandOut";
            this.GrandOut.Size = new System.Drawing.Size(119, 33);
            this.GrandOut.TabIndex = 12;
            // 
            // servicePartsDataSet
            // 
            this.servicePartsDataSet.DataSetName = "ServicePartsDataSet";
            this.servicePartsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // partsTableBindingSource
            // 
            this.partsTableBindingSource.DataMember = "PartsTable";
            this.partsTableBindingSource.DataSource = this.servicePartsDataSet;
            // 
            // partsTableTableAdapter
            // 
            this.partsTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PartsTableTableAdapter = this.partsTableTableAdapter;
            this.tableAdapterManager.ServiceTableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Project03.ServicePartsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicePartsDataSet1
            // 
            this.servicePartsDataSet1.DataSetName = "ServicePartsDataSet";
            this.servicePartsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ChrisAutoParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 447);
            this.Controls.Add(this.GrandOut);
            this.Controls.Add(this.LaborOut);
            this.Controls.Add(this.TaxOut);
            this.Controls.Add(this.PartTotalOut);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.LaborTotalLabel);
            this.Controls.Add(this.PartsTotalLabel);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CalcButton);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ServiceCLB);
            this.Controls.Add(this.PartsCLB);
            this.Name = "ChrisAutoParts";
            this.Text = "Chris\' Auto";
            this.Load += new System.EventHandler(this.ChrisAutoParts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.servicePartsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicePartsDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PartsCLB;
        private System.Windows.Forms.CheckedListBox ServiceCLB;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CalcButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label PartsTotalLabel;
        private System.Windows.Forms.Label LaborTotalLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label PartTotalOut;
        private System.Windows.Forms.Label TaxOut;
        private System.Windows.Forms.Label LaborOut;
        private System.Windows.Forms.Label GrandOut;
        private ServicePartsDataSet servicePartsDataSet;
        private System.Windows.Forms.BindingSource partsTableBindingSource;
        private ServicePartsDataSetTableAdapters.PartsTableTableAdapter partsTableTableAdapter;
        private ServicePartsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private ServicePartsDataSet servicePartsDataSet1;
    }
}

