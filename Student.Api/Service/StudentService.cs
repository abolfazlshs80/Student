using Microsoft.Extensions.Options;
using Student.Api.Data.Models;
using Student.Api.Data.Repository;
using Student.Api.Models.AppSetting;
using Student.Api.Models.Students;
using Student.Api.Tools.Exceptions;

namespace Student.Api.Service
{
    public class StudentService(IStudentRepository _studentRepository, IUnitOfWorkService _unitOfWorkService
        , IOptions<PaginationDto> _pagination) : IStudentService
    {


        public async Task<IEnumerable<StudentDto>> GetAllAsync(int page, CancellationToken ct)
        {
            var getAll = await _studentRepository.GetAllAsync(_pagination.Value.PageCount, page * _pagination.Value.PageCount, ct);
            return getAll.Select(_ => new StudentDto { BirthDay = _.BirthDay, FullName = _.FullName, NationalCode = _.NationalCode, Id = _.Id }).ToList();
        }
          

        public async Task<StudentDto> GetAsync(int id, CancellationToken ct)
        {
            var student = await _studentRepository.GetAsync(id, ct);
            if (student is null)
                throw new StudentNotFoundException("Not Found Student By Id");
            return new StudentDto
            {
                Id = student.Id,
                BirthDay = student.BirthDay,
                FullName = student.FullName,
                NationalCode = student.NationalCode,
            };
        }
        public async Task<bool> CreateAsync(CreateStudentDto student, CancellationToken ct)
        {

            var newStudent = new Students
            {
                BirthDay = student.BirthDay,
                FullName = student.FullName,
                NationalCode = student.NationalCode,
            };
            await _studentRepository.CreateAsync(newStudent, ct);
            return await _unitOfWorkService.SaveAsync(ct);
        }
        public async Task<bool> UpdateAsync(UpdateStudentDto student, CancellationToken ct)
        {
            var getStudent = await _studentRepository.GetAsync(student.Id, ct);
            if (getStudent is   null)
                throw new StudentNotFoundException("Not Found Student By NationalCode Id");

            getStudent.BirthDay=student.BirthDay; 
            getStudent.FullName=student.FullName; 
            getStudent.NationalCode=student.NationalCode; 


            await _studentRepository.UpdateAsync(getStudent);
            return await _unitOfWorkService.SaveAsync(ct);
        }
        public async Task<bool> DeleteAsync(int studentId, CancellationToken ct)
        {
            var student = await _studentRepository.GetAsync(studentId, ct);
            if (student is null)
                throw new StudentNotFoundException("Not Found Student By Id");
            await _studentRepository.DeleteAsync(student);
            return await _unitOfWorkService.SaveAsync(ct);
        }
    }
}
