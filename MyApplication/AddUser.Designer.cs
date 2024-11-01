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
            uploadPictureButton = new Razi.windows.Forms.Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new Razi.windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(122, 12);
            firstNameTextBox.MaxLength = 25;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(207, 23);
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
            addressTextBox.Location = new Point(122, 128);
            addressTextBox.Multiline = true;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(207, 55);
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
            nationalCodeTextBox.Location = new Point(122, 99);
            nationalCodeTextBox.MaxLength = 10;
            nationalCodeTextBox.Name = "nationalCodeTextBox";
            nationalCodeTextBox.Size = new Size(207, 23);
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
            fullNameTextBox.Location = new Point(122, 70);
            fullNameTextBox.MaxLength = 50;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(207, 23);
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
            lastNameTextBox.Location = new Point(122, 41);
            lastNameTextBox.MaxLength = 25;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(207, 23);
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
            resetButton.Location = new Point(93, 351);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 13;
            resetButton.Text = "&Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(12, 351);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 12;
            addButton.Text = "&Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButton_Click;
            // 
            // uploadPictureButton
            // 
            uploadPictureButton.Location = new Point(12, 189);
            uploadPictureButton.Name = "uploadPictureButton";
            uploadPictureButton.Size = new Size(104, 23);
            uploadPictureButton.TabIndex = 10;
            uploadPictureButton.Text = "&Upload Picture";
            uploadPictureButton.UseVisualStyleBackColor = true;
            uploadPictureButton.Click += UploadPictureButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(224, 224, 224);
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(122, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // AddUser
            // 
            AcceptButton = addButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 386);
            Controls.Add(pictureBox1);
            Controls.Add(uploadPictureButton);
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
            MinimizeBox = false;
            MinimumSize = new Size(357, 343);
            Name = "AddUser";
            Text = "Add";
            Load += AddUser_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Razi.windows.Forms.Button uploadPictureButton;
        private OpenFileDialog openFileDialog1;
        private Razi.windows.Forms.PictureBox pictureBox1;
    }
}