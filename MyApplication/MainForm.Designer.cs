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
            searchButton = new Razi.windows.Forms.Button();
            searchTextBox = new Razi.windows.Forms.TextBox();
            fullNameLabel = new Razi.windows.Forms.Label();
            addUserButton = new Razi.windows.Forms.Button();
            userDataGridView = new Razi.windows.Forms.DataGridView();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userDataGridView).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(searchButton);
            mainPanel.Controls.Add(searchTextBox);
            mainPanel.Controls.Add(fullNameLabel);
            mainPanel.Controls.Add(addUserButton);
            mainPanel.Controls.Add(userDataGridView);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(664, 361);
            mainPanel.TabIndex = 0;
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
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchTextBox.Location = new Point(79, 41);
            searchTextBox.MaxLength = 50;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(492, 23);
            searchTextBox.TabIndex = 2;
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
            // 
            // userDataGridView
            // 
            userDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGridView.Location = new Point(0, 70);
            userDataGridView.Name = "userDataGridView";
            userDataGridView.Size = new Size(664, 291);
            userDataGridView.TabIndex = 4;
            // 
            // MainForm
            // 
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
        private Razi.windows.Forms.TextBox searchTextBox;
        private Razi.windows.Forms.Label fullNameLabel;
        private Razi.windows.Forms.Button addUserButton;
    }
}