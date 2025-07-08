

using Student.WinForm.Models.Students;
using Student.WinForm.Service;

namespace Student.WinForm.Forms;

public partial class UpdateStudentPage : Form
{
    private readonly IStudentApiClient _studentApi;
    public StudentDto Student { get; set; }
    public UpdateStudentPage(IStudentApiClient studentApi,StudentDto student)
    {

        InitializeComponent();
        _studentApi = studentApi;
        Student = student;
    }

    private async void ButtonSubmitStudent_Click(object sender, EventArgs e)
    {

        if (Student != null)
        {


            var result = await _studentApi.UpdateAsync(new UpdateStudentDto(Student.Id, TextBoxName.Text, TextBoxNationalCode.Text, DatePickerBirthDay.Value));
            if (!result)
            {
                MessageBox.Show("Error Student!");
                return;
            }
            MessageBox.Show("Updated Student!");
            this.Close();
        }
        else
        {

            var result = await _studentApi.CreateAsync(new CreateStudentDto(TextBoxName.Text, TextBoxNationalCode.Text, DatePickerBirthDay.Value));
            if (!result)
            {
                MessageBox.Show("Error Student!");
                return;
            }
            MessageBox.Show("Created Student!");
            this.Close();
        }



    }


    private async void UpdateStudentPage_Load(object sender, EventArgs e)
    {
        if (Student != null)
        {
            var student = await _studentApi.GetByIdAsync(Student.Id);
            TextBoxName.Text = student.FullName;
            TextBoxNationalCode.Text = student.NationalCode;
            DatePickerBirthDay.Value = student.BirthDay;
        }

    }
}
