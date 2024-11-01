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

            //فراخوانی عکس از پایگاه داده تبدیل آن به فرمت قابل مشاهده در فرم 
            var ImageBytes = currentUser.IdentificationImage;

            using (var ms = new MemoryStream(ImageBytes))
            {
                userPictureBox.Image = Image.FromStream(ms);
            }


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
            currentUser.NationalCod = nationalCodeTextBox.Text;
            currentUser.Address = addressTextBox.Text;
            currentUser.IdentificationImage = ImageToByte(userPictureBox.Image);

            applicationDbContext.SaveChanges();


            MessageBox.Show
                (text: "User profile updated successfully...");

            // استفاده کنیم Close فرم به طور اتوماتیک بسته شود، می‌توانیم از دستور MessageBox اگر بخواهیم بعد از UpdateProfileForm در داخل
            Close();


        }
        catch (Exception ex)
        {
            var errorMessage =
                $"Error: {ex.Message}";

            MessageBox.Show(text: errorMessage);
        }

    }
    private byte[] ImageToByte(Image img)
    {
        using (var stream = new MemoryStream())
        {
            img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            return stream.ToArray();
        }
    }

    private void DeleteButton_Click(object sender, EventArgs e)
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

            applicationDbContext.Remove(entity: currentUser);

            applicationDbContext.SaveChanges();

            MessageBox.Show
                (text: "The User profile deleted successfully...");

            Close();
        }
        catch (Exception ex)
        {
            var errorMessage =
                $"Error: {ex.Message}";

            MessageBox.Show(text: errorMessage);
        }
    }

    private void userPictureBox_Click(object sender, EventArgs e)
    {

    }

    private void changePictureButton_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            var photo = File.ReadAllBytes(openFileDialog.FileName);
            // ذخیره عکس در یک فیلد در فرم
            userPictureBox.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
