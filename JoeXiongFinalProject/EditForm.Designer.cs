namespace JoeXiongFinalProject
{
    partial class EditForm
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
            this.mainCompletedListBox = new System.Windows.Forms.GroupBox();
            this.oilFilterChangeCheck = new System.Windows.Forms.CheckBox();
            this.oilChangeCheck = new System.Windows.Forms.CheckBox();
            this.editMileageTextBox = new System.Windows.Forms.TextBox();
            this.editYearTextBox = new System.Windows.Forms.TextBox();
            this.editModelTextBox = new System.Windows.Forms.TextBox();
            this.editMakeTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.modelLabel = new System.Windows.Forms.Label();
            this.oilTypeLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.editVehicleEntryTxtLabel = new System.Windows.Forms.Label();
            this.oilGradeDropDownBox = new System.Windows.Forms.ComboBox();
            this.mainCompletedListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainCompletedListBox
            // 
            this.mainCompletedListBox.Controls.Add(this.oilFilterChangeCheck);
            this.mainCompletedListBox.Controls.Add(this.oilChangeCheck);
            this.mainCompletedListBox.Location = new System.Drawing.Point(221, 44);
            this.mainCompletedListBox.Name = "mainCompletedListBox";
            this.mainCompletedListBox.Size = new System.Drawing.Size(155, 76);
            this.mainCompletedListBox.TabIndex = 29;
            this.mainCompletedListBox.TabStop = false;
            this.mainCompletedListBox.Text = "Maintenance Performed";
            // 
            // oilFilterChangeCheck
            // 
            this.oilFilterChangeCheck.AutoSize = true;
            this.oilFilterChangeCheck.Location = new System.Drawing.Point(17, 42);
            this.oilFilterChangeCheck.Name = "oilFilterChangeCheck";
            this.oilFilterChangeCheck.Size = new System.Drawing.Size(109, 17);
            this.oilFilterChangeCheck.TabIndex = 1;
            this.oilFilterChangeCheck.Text = "Oil Filter Changed";
            this.oilFilterChangeCheck.UseVisualStyleBackColor = true;
            // 
            // oilChangeCheck
            // 
            this.oilChangeCheck.AutoSize = true;
            this.oilChangeCheck.Location = new System.Drawing.Point(17, 19);
            this.oilChangeCheck.Name = "oilChangeCheck";
            this.oilChangeCheck.Size = new System.Drawing.Size(84, 17);
            this.oilChangeCheck.TabIndex = 0;
            this.oilChangeCheck.Text = "Oil Changed";
            this.oilChangeCheck.UseVisualStyleBackColor = true;
            // 
            // editMileageTextBox
            // 
            this.editMileageTextBox.Location = new System.Drawing.Point(68, 126);
            this.editMileageTextBox.Name = "editMileageTextBox";
            this.editMileageTextBox.Size = new System.Drawing.Size(121, 20);
            this.editMileageTextBox.TabIndex = 26;
            // 
            // editYearTextBox
            // 
            this.editYearTextBox.Location = new System.Drawing.Point(69, 99);
            this.editYearTextBox.Name = "editYearTextBox";
            this.editYearTextBox.Size = new System.Drawing.Size(121, 20);
            this.editYearTextBox.TabIndex = 25;
            // 
            // editModelTextBox
            // 
            this.editModelTextBox.Location = new System.Drawing.Point(69, 70);
            this.editModelTextBox.Name = "editModelTextBox";
            this.editModelTextBox.Size = new System.Drawing.Size(121, 20);
            this.editModelTextBox.TabIndex = 24;
            // 
            // editMakeTextBox
            // 
            this.editMakeTextBox.Location = new System.Drawing.Point(69, 44);
            this.editMakeTextBox.Name = "editMakeTextBox";
            this.editMakeTextBox.Size = new System.Drawing.Size(121, 20);
            this.editMakeTextBox.TabIndex = 23;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(221, 194);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 38);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(81, 194);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(74, 38);
            this.editButton.TabIndex = 21;
            this.editButton.Text = "Confirm Changes";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(23, 73);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 20;
            this.modelLabel.Text = "Model:";
            // 
            // oilTypeLabel
            // 
            this.oilTypeLabel.AutoSize = true;
            this.oilTypeLabel.Location = new System.Drawing.Point(8, 157);
            this.oilTypeLabel.Name = "oilTypeLabel";
            this.oilTypeLabel.Size = new System.Drawing.Size(54, 13);
            this.oilTypeLabel.TabIndex = 19;
            this.oilTypeLabel.Text = "Oil Grade:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(30, 102);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 18;
            this.yearLabel.Text = "Year:";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(15, 129);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(47, 13);
            this.mileageLabel.TabIndex = 17;
            this.mileageLabel.Text = "Mileage:";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(25, 47);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(37, 13);
            this.makeLabel.TabIndex = 16;
            this.makeLabel.Text = "Make:";
            // 
            // editVehicleEntryTxtLabel
            // 
            this.editVehicleEntryTxtLabel.AutoSize = true;
            this.editVehicleEntryTxtLabel.Location = new System.Drawing.Point(158, 9);
            this.editVehicleEntryTxtLabel.Name = "editVehicleEntryTxtLabel";
            this.editVehicleEntryTxtLabel.Size = new System.Drawing.Size(90, 13);
            this.editVehicleEntryTxtLabel.TabIndex = 15;
            this.editVehicleEntryTxtLabel.Text = "Edit Vehicle Entry";
            // 
            // oilGradeDropDownBox
            // 
            this.oilGradeDropDownBox.FormattingEnabled = true;
            this.oilGradeDropDownBox.Items.AddRange(new object[] {
            "SAE 0W",
            "SAE 5W",
            "SAE 10W",
            "SAE 20W",
            "SAE 30",
            "SAE 40",
            "SAE 0W-20",
            "SAE 0W-30",
            "SAE 0W-40",
            "SAE 0W-50",
            "SAE 5W-30",
            "SAE 5W-40",
            "SAE 5W-50",
            "SAE 10W-30",
            "SAE 10W-40",
            "SAE 10W-50",
            "SAE 15W-30",
            "SAE 15W-40"});
            this.oilGradeDropDownBox.Location = new System.Drawing.Point(66, 154);
            this.oilGradeDropDownBox.Name = "oilGradeDropDownBox";
            this.oilGradeDropDownBox.Size = new System.Drawing.Size(123, 21);
            this.oilGradeDropDownBox.TabIndex = 30;
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 265);
            this.Controls.Add(this.oilGradeDropDownBox);
            this.Controls.Add(this.mainCompletedListBox);
            this.Controls.Add(this.editMileageTextBox);
            this.Controls.Add(this.editYearTextBox);
            this.Controls.Add(this.editModelTextBox);
            this.Controls.Add(this.editMakeTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.oilTypeLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.editVehicleEntryTxtLabel);
            this.Name = "EditForm";
            this.Text = "Edit Vehicle Entry";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.mainCompletedListBox.ResumeLayout(false);
            this.mainCompletedListBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mainCompletedListBox;
        private System.Windows.Forms.CheckBox oilFilterChangeCheck;
        private System.Windows.Forms.CheckBox oilChangeCheck;
        private System.Windows.Forms.TextBox editMileageTextBox;
        private System.Windows.Forms.TextBox editYearTextBox;
        private System.Windows.Forms.TextBox editModelTextBox;
        private System.Windows.Forms.TextBox editMakeTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label oilTypeLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label editVehicleEntryTxtLabel;
        private System.Windows.Forms.ComboBox oilGradeDropDownBox;
    }
}