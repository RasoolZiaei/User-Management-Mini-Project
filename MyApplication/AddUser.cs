using Domain;
using MyApplication.Infrastructure;
using Persistence;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApplication;

public partial class AddUser : Infrastructure.BaseForm
{
    public AddUser()
    {
        InitializeComponent();
    }

    private void AddUser_Load(object sender, EventArgs e)
    {

    }

    private void UpdateButton_Click(object sender, EventArgs e)
    {
        // **************************************************
        firstNameTextBox.Text = Utility.FixText(text: firstNameTextBox.Text);
        lastNameTextBox.Text = Utility.FixText(text: lastNameTextBox.Text);
        fullNameTextBox.Text = Utility.FixText(text: fullNameTextBox.Text);
        nationalCodeTextBox.Text = Utility.FixText(text: nationalCodeTextBox.Text);
        addressTextBox.Text = Utility.FixText(text: addressTextBox.Text);
        // **************************************************

        // **************************************************
        if (firstNameTextBox.Text == string.Empty
            || lastNameTextBox.Text == string.Empty
            || fullNameTextBox.Text == string.Empty
            || nationalCodeTextBox.Text == string.Empty)
        {
            var errorMessage =
                "First Name, Last Name, Full Name And National Cod are requied!";

            MessageBox.Show(text: errorMessage);

            if (firstNameTextBox.Text == string.Empty)
            {
                firstNameTextBox.Focus();
            }
            else if (lastNameTextBox.Text == string.Empty)
            {
                lastNameTextBox.Focus();
            }
            else if (fullNameTextBox.Text == string.Empty)
            {
                fullNameTextBox.Focus();
            }
            else
            {
                nationalCodeTextBox.Focus();
            }

            return;
        }
        // **************************************************

        // **************************************************
        var errorMessages = string.Empty;

        if (firstNameTextBox.Text.Length < 3)
        {
            errorMessages =
                "First Name length should be at least 3 characters!";
        }

        if (lastNameTextBox.Text.Length < 3)
        {
            if (errorMessages != string.Empty)
            {
                errorMessages +=
                    Environment.NewLine; // "\r\n"
            }

            errorMessages +=
                "Last Name length should be at least 3 characters!";
        }
        if (fullNameTextBox.Text.Length < 7)
        {
            if (errorMessages != string.Empty)
            {
                errorMessages +=
                    Environment.NewLine; // "\r\n"
            }

            errorMessages +=
                "Full Name length should be at least 7 characters!";
        }
        if (nationalCodeTextBox.Text.Length < 10)
        {
            if (errorMessages != string.Empty)
            {
                errorMessages +=
                    Environment.NewLine; // "\r\n"
            }

            errorMessages +=
                "National Cod length should be 10 characters!";
        }

        // اگر خطایی وجود داشت
        if (errorMessages != string.Empty)
        {
            MessageBox.Show(text: errorMessages);

            firstNameTextBox.Focus();

            return;
        }
        // **************************************************

        // **************************************************
        try
        {
            using var applicationDbContext = new ApplicationDbContext();

            var foundedUser =
                applicationDbContext.Users
                .Where(current => current.NationalCod.ToString() == nationalCodeTextBox.Text)
                .FirstOrDefault();

            if (foundedUser is not null)
            {
                var errorMessage =
                    "This user is already exist! Please choose another one.";

                MessageBox.Show(text: errorMessage);

                firstNameTextBox.Focus();

                return;
            }

            var newUser =
                new User(firstName: firstNameTextBox.Text,
                lastName: lastNameTextBox.Text,
                fullName: fullNameTextBox.Text,
                nationalCod: Convert.ToInt32(nationalCodeTextBox.Text))
                {
                    Address = addressTextBox.Text,
                };

            applicationDbContext.Add(entity: newUser);

            applicationDbContext.SaveChanges();

            MessageBox.Show(text: "Registration Done!");

            ResetForm();
        }
        catch (Exception ex)
        {
            var errorMessage =
                $"Error: {ex.Message}";

            MessageBox.Show(text: errorMessage);
        }
    }

    private void ResetButton_Click(object sender, EventArgs e)
    {
        ResetForm();
    }

    public void ResetForm()
    {
        firstNameTextBox.Text = string.Empty;
        lastNameTextBox.Text = string.Empty;
        fullNameTextBox.Text = string.Empty;
        nationalCodeTextBox.Text = string.Empty;
        addressTextBox.Text = string.Empty;

        firstNameTextBox.Focus();
    }
}
