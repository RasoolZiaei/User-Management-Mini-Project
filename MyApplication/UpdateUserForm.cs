using Domain;
using MyApplication.Infrastructure;
using Persistence;

namespace MyApplication;

public partial class UpdateUserForm : BaseForm
{
    public UpdateUserForm()
    {
        InitializeComponent();
    }

    public User? SelectedUser { get; set; }

    private void UpdateUserForm_Load(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    private void ResetForm()
    {
        if (SelectedUser is null)
        {
            Close();
            return;
        }

        try
        {
            using var applicationDbContext = new ApplicationDbContext();

            var currentUser =
                applicationDbContext.Users
                .Where(current => current.Id == SelectedUser.Id)
                .FirstOrDefault();

            if (currentUser is null)
            {
                Close();
                return;
            }

            firstNameTextBox.Text = currentUser.FirstName;
            lastNameTextBox.Text = currentUser.LastName;
            fullNameTextBox.Text = currentUser.FullName;
            nationalCodeTextBox.Text = currentUser.NationalCod.ToString();
            addressTextBox.Text = currentUser.Address;
        }
        catch (Exception ex)
        {
            var errorMessage =
                $"Error: {ex.Message}";

            MessageBox.Show(text: errorMessage);
        }
    }

    private void updateButton_Click(object sender, EventArgs e)
    {
        if (SelectedUser is null)
        {
            Close();
            return;
        }
        try
        {
            using var applicationDbContext = new ApplicationDbContext();

            var currentUser =
                applicationDbContext.Users
                .Where(current => current.Id == SelectedUser.Id)
                .FirstOrDefault();

            if (currentUser is null)
            {
                Close();
                return;
            }

            // **************************************************
            firstNameTextBox.Text = Utility.FixText(text: firstNameTextBox.Text);
            lastNameTextBox.Text = Utility.FixText(text: lastNameTextBox.Text);
            fullNameTextBox.Text = Utility.FixText(text: fullNameTextBox.Text);
            nationalCodeTextBox.Text = Utility.FixText(text: nationalCodeTextBox.Text);
            addressTextBox.Text = Utility.FixText(text: addressTextBox.Text);

            // **************************************************

            currentUser.FirstName = firstNameTextBox.Text;
            currentUser.LastName = lastNameTextBox.Text;
            currentUser.FullName = fullNameTextBox.Text;
            currentUser.NationalCod = Convert.ToInt32(nationalCodeTextBox.Text);
            currentUser.Address = addressTextBox.Text;

            applicationDbContext.SaveChanges();

            // **************************************************
            //Utility.AuthenticatedUser = currentUser;

            //Utility.MainForm.ResetForm();
            // **************************************************

            MessageBox.Show
                (text: "User profile updated successfully...");

            // استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از UpdateProfileForm در داخل
            //Close();

            
        }
        catch (Exception ex)
        {
            var errorMessage =
                $"Error: {ex.Message}";

            MessageBox.Show(text: errorMessage);
        }

    }
}
