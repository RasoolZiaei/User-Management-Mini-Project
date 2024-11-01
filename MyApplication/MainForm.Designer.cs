namespace MyApplication
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
            mainPanel = new Razi.windows.Forms.Panel();
            label1 = new Razi.windows.Forms.Label();
            searchButton = new Razi.windows.Forms.Button();
            fullNameTextBox = new Razi.windows.Forms.TextBox();
            fullNameLabel = new Razi.windows.Forms.Label();
            addUserButton = new Razi.windows.Forms.Button();
            userDataGridView = new Razi.windows.Forms.DataGridView();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(searchButton);
            mainPanel.Controls.Add(fullNameTextBox);
            mainPanel.Controls.Add(fullNameLabel);
            mainPanel.Controls.Add(addUserButton);
            mainPanel.Controls.Add(userDataGridView);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(664, 361);
            mainPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 335);
            label1.Name = "label1";
            label1.Size = new Size(467, 17);
            label1.TabIndex = 5;
            label1.Text = "To see the complete information of each user, double click on the desired row.";
            // 
            // searchButton
            // 
            searchButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchButton.Location = new Point(577, 41);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(75, 23);
            searchButton.TabIndex = 3;
            searchButton.Text = "&Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += SearchButton_Click;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            fullNameTextBox.Location = new Point(79, 41);
            fullNameTextBox.MaxLength = 50;
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(492, 23);
            fullNameTextBox.TabIndex = 2;
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Location = new Point(12, 44);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new Size(61, 15);
            fullNameLabel.TabIndex = 1;
            fullNameLabel.Text = "&Full Name";
            // 
            // addUserButton
            // 
            addUserButton.Location = new Point(12, 12);
            addUserButton.Name = "addUserButton";
            addUserButton.Size = new Size(69, 23);
            addUserButton.TabIndex = 0;
            addUserButton.Text = "&Add User";
            addUserButton.UseVisualStyleBackColor = true;
            addUserButton.Click += addUserButton_Click;
            // 
            // userDataGridView
            // 
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(0, 70);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.Size = new Size(664, 262);
            userDataGridView.TabIndex = 4;
            userDataGridView.CellContentClick += userDataGridView_CellContentClick;
            userDataGridView.CellDoubleClick += UserDataGridView_CellDoubleClick;
            userDataGridView.CellMouseDoubleClick += UserDataGridView_CellMouseDoubleClick;
            // 
            // MainForm
            // 
            AcceptButton = searchButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 361);
            Controls.Add(mainPanel);
            MinimumSize = new Size(680, 400);
            Name = "MainForm";
            Text = "Main";
            Load += MainForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Razi.windows.Forms.Panel mainPanel;
        private Razi.windows.Forms.DataGridView userDataGridView;
        private Razi.windows.Forms.Button searchButton;
        private Razi.windows.Forms.TextBox fullNameTextBox;
        private Razi.windows.Forms.Label fullNameLabel;
        private Razi.windows.Forms.Button addUserButton;
        private Razi.windows.Forms.Label label1;
    }
}