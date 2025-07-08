
using Student.WinForm.Forms;
using Student.WinForm.Models.Students;
using Student.WinForm.Service;
using System.ComponentModel;



namespace Student.WinForm
{
    public partial class MainPage : Form
    {
        private int CurrentPage = 0;
        private readonly IStudentApiClient _studentApi;


        private BindingList<StudentDto> _students;


        public MainPage(IStudentApiClient studentApi)
        {

            InitializeComponent();
            _studentApi = studentApi;



        }


        private async void MainPage_Load(object sender, EventArgs e)
        {
            LoadData();


        }

        async void LoadData()
        {
            _students = new BindingList<StudentDto>(
               (await _studentApi.GetAllAsync(CurrentPage)).ToList());

            DataGridViewCategory.DataSource = _students;


       
        }

        private async void ButtonCreateCategory_Click(object sender, EventArgs e)
        {
            UpdateStudentPage Page = new UpdateStudentPage(_studentApi, null);
            Page.ShowDialog();

            LoadData();
        }

        private async void ButtonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (DataGridViewCategory.SelectedRows.Count > 0)
            {
                int rowIndex = DataGridViewCategory.SelectedRows[0].Index;
                var Id = (int)DataGridViewCategory[0, rowIndex].Value;
                DataGridViewCategory.Rows.RemoveAt(rowIndex);
                await _studentApi.DeleteAsync(Id);
                LoadData();
            }

        }

        private async void ButtonEditCategory_Click(object sender, EventArgs e)
        {
            if (DataGridViewCategory.SelectedRows.Count > 0)
            {
                int rowIndex = DataGridViewCategory.SelectedRows[0].Index;
                var Id = (int)DataGridViewCategory[0, rowIndex].Value;


                var student = await _studentApi.GetByIdAsync(Id);
                UpdateStudentPage Page = new UpdateStudentPage(_studentApi, student);
                Page.ShowDialog();
            }


            LoadData();
        }

        private async void TextBoxSearchCategory_TextChanged(object sender, EventArgs e)
        {
            //if (!string.IsNullOrWhiteSpace(TextBoxSearchCategory.Text))
            //{
            //    DataGridViewCategory.DataSource = _students;
            //}
            //else
            //{
            //    LoadData();
            //}

        }


        private void DataGridViewCategory_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonEditCategory_Click(null, null);
        }

        private void Locadbutton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

   
     
    }
}