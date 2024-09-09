namespace MyApplication
{
    partial class AddUser
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
            firstNameTextBox = new Razi.windows.Forms.TextBox();
            firstNameLabel = new Razi.windows.Forms.Label();
            addressTextBox = new Razi.windows.Forms.TextBox();
            addressLabel = new Razi.windows.Forms.Label();
            nationalCodeTextBox = new Razi.windows.Forms.TextBox();
            nationalCodeLabel = new Razi.windows.Forms.Label();
            fullNameTextBox = new Razi.windows.Forms.TextBox();
            fullNameLabel = new Razi.windows.Forms.Label();
            lastNameTextBox = new Razi.windows.Forms.TextBox();
            lastNameLabel = new Razi.windows.Forms.Label();
            resetButton = new Razi.windows.Forms.Button();
            addButton = new Razi.windows.Forms.Button();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(101, 12);
            firstNameTextBox.MaxLength = 25;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(190, 23);
            firstNameTextBox.TabIndex = 1;
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 15);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "&First Name";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(101, 128);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(190, 95);
            addressTextBox.TabIndex = 9;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(12, 131);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(49, 15);
            addressLabel.TabIndex = 8;
            addressLabel.Text = "&Address";
            // 
            // nationalCodeTextBox
            // 
            nationalCodeTextBox.Location = new Point(101, 99);
            nationalCodeTextBox.MaxLength = 10;
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(190, 23);
            nationalCodeTextBox.TabIndex = 7;
            // 
            // nationalCodeLabel
            // 
            nationalCodeLabel.AutoSize = true;
            nationalCodeLabel.Location = new Point(12, 102);
            nationalCodeLabel.Name = "nationalCodeLabel";
            nationalCodeLabel.Size = new Size(83, 15);
            nationalCodeLabel.TabIndex = 6;
            nationalCodeLabel.Text = "&National Code";
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Location = new Point(101, 70);
            fullNameTextBox.MaxLength = 50;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(190, 23);
            fullNameTextBox.TabIndex = 5;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(12, 73);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(61, 15);
            fullNameLabel.TabIndex = 4;
            fullNameLabel.Text = "&Full Name";
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(101, 41);
            lastNameTextBox.MaxLength = 25;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(190, 23);
            lastNameTextBox.TabIndex = 3;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(12, 44);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "&Last Name";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(93, 229);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 11;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 229);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 10;
            addButton.Text = "&Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += UpdateButton_Click;
            // 
            // AddUser
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = resetButton;
            ClientSize = new Size(303, 264);
            Controls.Add(resetButton);
            Controls.Add(addButton);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(nationalCodeTextBox);
            Controls.Add(nationalCodeLabel);
            Controls.Add(fullNameTextBox);
            Controls.Add(fullNameLabel);
            Controls.Add(lastNameTextBox);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(firstNameLabel);
            MaximizeBox = false;
            MaximumSize = new Size(319, 303);
            MinimizeBox = false;
            MinimumSize = new Size(319, 303);
            Name = "AddUser";
            Text = "Add";
            Load += AddUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Razi.windows.Forms.TextBox firstNameTextBox;
        private Razi.windows.Forms.Label firstNameLabel;
        private Razi.windows.Forms.TextBox addressTextBox;
        private Razi.windows.Forms.Label addressLabel;
        private Razi.windows.Forms.TextBox nationalCodeTextBox;
        private Razi.windows.Forms.Label nationalCodeLabel;
        private Razi.windows.Forms.TextBox fullNameTextBox;
        private Razi.windows.Forms.Label fullNameLabel;
        private Razi.windows.Forms.TextBox lastNameTextBox;
        private Razi.windows.Forms.Label lastNameLabel;
        private Razi.windows.Forms.Button resetButton;
        private Razi.windows.Forms.Button addButton;
    }
}