using Persistence;
using Microsoft.IdentityModel.Tokens;
using Domain;

namespace MyApplication;

public partial class MainForm : Infrastructure.BaseForm
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        // **************************************************
        userDataGridView.SelectionMode =
            DataGridViewSelectionMode.FullRowSelect;

        userDataGridView.EditMode =
            DataGridViewEditMode.EditProgrammatically;
        // **************************************************

        AddButtonColumn();

        Search();
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {
        Search();
    }

    private void Search()
    {
        try
        {
            using var applicationDbContext = new ApplicationDbContext();

            fullNameTextBox.Text =
                Infrastructure.Utility.FixText(text: fullNameTextBox.Text);

            List<User> users;

            if (fullNameTextBox.Text == string.Empty)
            {
                users =
                    applicationDbContext.Users
                    .ToList()
                    ;
            }
            else
            {
                users =
                    applicationDbContext.Users
                    .Where(current => current.FullName != null &&
                        current.FullName.ToLower().Contains(fullNameTextBox.Text.ToLower()))
                    .ToList()
                    ;
            }

            userDataGridView.DataSource = users;
        }
        catch (Exception ex)
        {
            var errorMessage =
                $"Error: {ex.Message}";

            MessageBox.Show(text: errorMessage);
        }

        fullNameTextBox.SelectAll();
        fullNameTextBox.Focus();
    }

    private void UserDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
    {

    }

    private void UserDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        var selectedUser =
            userDataGridView.Rows[e.RowIndex].DataBoundItem as User;

        if (selectedUser is not null)
        {
            var updateUserForm =
                new UpdateUserForm()
                {
                    SelectedUser = selectedUser,
                };

            updateUserForm.ShowDialog();

            Search();
        }
    }

    private void addUserButton_Click(object sender, EventArgs e)
    {
        var addUser = new AddUser();

        addUser.ShowDialog();

        Search();
    }

    private void AddButtonColumn()
    {
        DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
        buttonColumn.HeaderText = "Picture";
        buttonColumn.Text = "Open Picture";
        buttonColumn.UseColumnTextForButtonValue = true;
        buttonColumn.DisplayIndex = userDataGridView.Columns.Count - 1;
        userDataGridView.Columns.Add(buttonColumn);

    }
    private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.ColumnIndex == 0 && e.RowIndex >= 0)
        {
            var userId = (Guid)userDataGridView.Rows[e.RowIndex].Cells["Id"].Value;
            using (var context = new ApplicationDbContext())
            {
                var user = context.Users.Find(userId);
                if (user != null && user.IdentificationImage != null)
                {
                    var form = new Form();
                    form.Text = "User Picture";
                    form.StartPosition = FormStartPosition.CenterParent;
                    form.Width = 400;
                    form.Height = 400;
                    var pictureBox = new PictureBox();
                    pictureBox.Dock = DockStyle.Fill;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox.Image = Image.FromStream(new MemoryStream(user.IdentificationImage));
                    form.Controls.Add(pictureBox);
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("تصویر کاربر وجود ندارد.");
                }
            }
        }
    }
}
