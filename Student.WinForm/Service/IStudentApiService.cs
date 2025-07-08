
using Student.WinForm.Models.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Student.WinForm.Service
{
    public interface IStudentApiClient
    {
        Task<IEnumerable<StudentDto>?> GetAllAsync(int page = 0);
        Task<StudentDto?> GetByIdAsync(int id);
        Task<bool> CreateAsync(CreateStudentDto student);
        Task<bool> UpdateAsync( UpdateStudentDto student);
        Task<bool> DeleteAsync(int id);
    }
    public class StudentApiService: IStudentApiClient
    {
        private readonly HttpClient _client;
        private const string baseUrl = "https://localhost:7111/";
        public StudentApiService()
        {
            _client = new HttpClient();
        }


        public async Task<IEnumerable<StudentDto>?> GetAllAsync(int page=0)
        {
            return await _client.GetFromJsonAsync<IEnumerable<StudentDto>>($"{baseUrl}api/Students?{page}=0");
        }

        public async Task<StudentDto?> GetByIdAsync(int id)
        {
            return await _client.GetFromJsonAsync<StudentDto>($"{baseUrl}api/Students/{id}");
        }


        public async Task<bool> CreateAsync(CreateStudentDto student)
        {
            var response = await _client.PostAsJsonAsync($"{baseUrl}api/Students", student);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateAsync( UpdateStudentDto student)
        {
            var response = await _client.PutAsJsonAsync($"{baseUrl}api/Students", student);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var response = await _client.DeleteAsync($"{baseUrl}api/Students/{id}");

            return response.IsSuccessStatusCode;
        }
    }
}
