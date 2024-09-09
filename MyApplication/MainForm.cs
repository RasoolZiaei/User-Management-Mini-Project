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
}
