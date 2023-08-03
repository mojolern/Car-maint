namespace JoeXiongFinalProject
{
    partial class MainForm
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
            this.vehicleListBox = new System.Windows.Forms.ListBox();
            this.vehicleListLabel = new System.Windows.Forms.Label();
            this.newEntryButton = new System.Windows.Forms.Button();
            this.showStatus = new System.Windows.Forms.Button();
            this.updateVehicle = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.deleteVehicle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vehicleListBox
            // 
            this.vehicleListBox.FormattingEnabled = true;
            this.vehicleListBox.Location = new System.Drawing.Point(102, 35);
            this.vehicleListBox.Name = "vehicleListBox";
            this.vehicleListBox.Size = new System.Drawing.Size(308, 186);
            this.vehicleListBox.TabIndex = 0;
            this.vehicleListBox.SelectedIndexChanged += new System.EventHandler(this.vehicleListBox_SelectedIndexChanged);
            // 
            // vehicleListLabel
            // 
            this.vehicleListLabel.AutoSize = true;
            this.vehicleListLabel.Location = new System.Drawing.Point(189, 9);
            this.vehicleListLabel.Name = "vehicleListLabel";
            this.vehicleListLabel.Size = new System.Drawing.Size(61, 13);
            this.vehicleListLabel.TabIndex = 1;
            this.vehicleListLabel.Text = "Vehicle List";
            // 
            // newEntryButton
            // 
            this.newEntryButton.Location = new System.Drawing.Point(12, 44);
            this.newEntryButton.Name = "newEntryButton";
            this.newEntryButton.Size = new System.Drawing.Size(84, 38);
            this.newEntryButton.TabIndex = 2;
            this.newEntryButton.Text = "New Entry";
            this.newEntryButton.UseVisualStyleBackColor = true;
            this.newEntryButton.Click += new System.EventHandler(this.newEntryButton_Click);
            // 
            // showStatus
            // 
            this.showStatus.Location = new System.Drawing.Point(12, 174);
            this.showStatus.Name = "showStatus";
            this.showStatus.Size = new System.Drawing.Size(84, 36);
            this.showStatus.TabIndex = 3;
            this.showStatus.Text = "Next Maintenance";
            this.showStatus.UseVisualStyleBackColor = true;
            this.showStatus.Click += new System.EventHandler(this.showStatus_Click);
            // 
            // updateVehicle
            // 
            this.updateVehicle.Location = new System.Drawing.Point(12, 88);
            this.updateVehicle.Name = "updateVehicle";
            this.updateVehicle.Size = new System.Drawing.Size(84, 38);
            this.updateVehicle.TabIndex = 4;
            this.updateVehicle.Text = "Update Vehicle Entry";
            this.updateVehicle.UseVisualStyleBackColor = true;
            this.updateVehicle.Click += new System.EventHandler(this.updateVehicle_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(167, 227);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(114, 38);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // deleteVehicle
            // 
            this.deleteVehicle.Location = new System.Drawing.Point(12, 132);
            this.deleteVehicle.Name = "deleteVehicle";
            this.deleteVehicle.Size = new System.Drawing.Size(84, 36);
            this.deleteVehicle.TabIndex = 6;
            this.deleteVehicle.Text = "Delete Vehicle";
            this.deleteVehicle.UseVisualStyleBackColor = true;
            this.deleteVehicle.Click += new System.EventHandler(this.deleteVehicle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 278);
            this.Controls.Add(this.deleteVehicle);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.updateVehicle);
            this.Controls.Add(this.showStatus);
            this.Controls.Add(this.newEntryButton);
            this.Controls.Add(this.vehicleListLabel);
            this.Controls.Add(this.vehicleListBox);
            this.Name = "MainForm";
            this.Text = "Joe Xiong";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vehicleListBox;
        private System.Windows.Forms.Label vehicleListLabel;
        private System.Windows.Forms.Button newEntryButton;
        private System.Windows.Forms.Button showStatus;
        private System.Windows.Forms.Button updateVehicle;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button deleteVehicle;
    }
}

