
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
    }

    private void SearchButton_Click(object sender, EventArgs e)
    {

    }
}
