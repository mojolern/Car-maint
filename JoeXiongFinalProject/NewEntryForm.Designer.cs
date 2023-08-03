namespace JoeXiongFinalProject
{
    partial class NewEntryForm
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
            this.newVehicleEntryTxtLabel = new System.Windows.Forms.Label();
            this.makeLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.oilTypeLabel = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newMakeTextBox = new System.Windows.Forms.TextBox();
            this.newModelTextBox = new System.Windows.Forms.TextBox();
            this.newYearTextBox = new System.Windows.Forms.TextBox();
            this.newMileageTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.mainCompletedListBox = new System.Windows.Forms.GroupBox();
            this.oilFilterChangeCheck = new System.Windows.Forms.CheckBox();
            this.oilChangeCheck = new System.Windows.Forms.CheckBox();
            this.oilGradeDropDownBox = new System.Windows.Forms.ComboBox();
            this.mainCompletedListBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // newVehicleEntryTxtLabel
            // 
            this.newVehicleEntryTxtLabel.AutoSize = true;
            this.newVehicleEntryTxtLabel.Location = new System.Drawing.Point(148, 9);
            this.newVehicleEntryTxtLabel.Name = "newVehicleEntryTxtLabel";
            this.newVehicleEntryTxtLabel.Size = new System.Drawing.Size(94, 13);
            this.newVehicleEntryTxtLabel.TabIndex = 0;
            this.newVehicleEntryTxtLabel.Text = "New Vehicle Entry";
            // 
            // makeLabel
            // 
            this.makeLabel.AutoSize = true;
            this.makeLabel.Location = new System.Drawing.Point(32, 43);
            this.makeLabel.Name = "makeLabel";
            this.makeLabel.Size = new System.Drawing.Size(37, 13);
            this.makeLabel.TabIndex = 1;
            this.makeLabel.Text = "Make:";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(22, 125);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(47, 13);
            this.mileageLabel.TabIndex = 2;
            this.mileageLabel.Text = "Mileage:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(37, 98);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(32, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Year:";
            // 
            // oilTypeLabel
            // 
            this.oilTypeLabel.AutoSize = true;
            this.oilTypeLabel.Location = new System.Drawing.Point(15, 153);
            this.oilTypeLabel.Name = "oilTypeLabel";
            this.oilTypeLabel.Size = new System.Drawing.Size(54, 13);
            this.oilTypeLabel.TabIndex = 4;
            this.oilTypeLabel.Text = "Oil Grade:";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(30, 69);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(39, 13);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model:";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(40, 191);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(72, 32);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(259, 191);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(74, 32);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newMakeTextBox
            // 
            this.newMakeTextBox.Location = new System.Drawing.Point(76, 40);
            this.newMakeTextBox.Name = "newMakeTextBox";
            this.newMakeTextBox.Size = new System.Drawing.Size(121, 20);
            this.newMakeTextBox.TabIndex = 8;
            // 
            // newModelTextBox
            // 
            this.newModelTextBox.Location = new System.Drawing.Point(76, 66);
            this.newModelTextBox.Name = "newModelTextBox";
            this.newModelTextBox.Size = new System.Drawing.Size(121, 20);
            this.newModelTextBox.TabIndex = 9;
            // 
            // newYearTextBox
            // 
            this.newYearTextBox.Location = new System.Drawing.Point(76, 95);
            this.newYearTextBox.Name = "newYearTextBox";
            this.newYearTextBox.Size = new System.Drawing.Size(121, 20);
            this.newYearTextBox.TabIndex = 10;
            // 
            // newMileageTextBox
            // 
            this.newMileageTextBox.Location = new System.Drawing.Point(75, 122);
            this.newMileageTextBox.Name = "newMileageTextBox";
            this.newMileageTextBox.Size = new System.Drawing.Size(121, 20);
            this.newMileageTextBox.TabIndex = 11;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(151, 191);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(72, 32);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear ";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // mainCompletedListBox
            // 
            this.mainCompletedListBox.Controls.Add(this.oilFilterChangeCheck);
            this.mainCompletedListBox.Controls.Add(this.oilChangeCheck);
            this.mainCompletedListBox.Location = new System.Drawing.Point(225, 43);
            this.mainCompletedListBox.Name = "mainCompletedListBox";
            this.mainCompletedListBox.Size = new System.Drawing.Size(155, 76);
            this.mainCompletedListBox.TabIndex = 14;
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
            this.oilGradeDropDownBox.Location = new System.Drawing.Point(76, 148);
            this.oilGradeDropDownBox.Name = "oilGradeDropDownBox";
            this.oilGradeDropDownBox.Size = new System.Drawing.Size(120, 21);
            this.oilGradeDropDownBox.TabIndex = 15;
            // 
            // NewEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 267);
            this.Controls.Add(this.oilGradeDropDownBox);
            this.Controls.Add(this.mainCompletedListBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.newMileageTextBox);
            this.Controls.Add(this.newYearTextBox);
            this.Controls.Add(this.newModelTextBox);
            this.Controls.Add(this.newMakeTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.oilTypeLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.makeLabel);
            this.Controls.Add(this.newVehicleEntryTxtLabel);
            this.Name = "NewEntryForm";
            this.Text = "New Vehicle Entry";
            this.mainCompletedListBox.ResumeLayout(false);
            this.mainCompletedListBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newVehicleEntryTxtLabel;
        private System.Windows.Forms.Label makeLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label oilTypeLabel;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox newMakeTextBox;
        private System.Windows.Forms.TextBox newModelTextBox;
        private System.Windows.Forms.TextBox newYearTextBox;
        private System.Windows.Forms.TextBox newMileageTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.GroupBox mainCompletedListBox;
        private System.Windows.Forms.CheckBox oilFilterChangeCheck;
        private System.Windows.Forms.CheckBox oilChangeCheck;
        private System.Windows.Forms.ComboBox oilGradeDropDownBox;
    }
}