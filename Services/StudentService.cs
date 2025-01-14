﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FREYA_BLIZZ.Model;
using System.Net.Http.Json;


namespace FREYA_BLIZZ.Services
{
    public class StudentService
    {

        private readonly HttpClient _httpClient;

        // Base URL for the API connection
        private const string BaseUrl = "http://localhost/PDC50/";

        public StudentService()
        {
            _httpClient = new HttpClient();
        }

        // GET STUDENTS
        public async Task<List<Student>> GetStudentsAsync()
        {
            var response =
                await _httpClient.GetFromJsonAsync<List<Student>>($"{BaseUrl}get_students.php");
            return response ?? new List<Student>();
        }

        // ADD STUDENT
        public async Task<string> AddStudentAsync(Student student)
        {
            var response =
                await _httpClient.PostAsJsonAsync($"{BaseUrl}add_student.php", student);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        // UPDATE STUDENT
        public async Task<string> UpdateStudentAsync(Student student)
        {
            var response =
                await _httpClient.PostAsJsonAsync($"{BaseUrl}update_student.php", student);
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }

        // DELETE STUDENT
        public async Task<string> DeleteStudentAsync(int studentId)
        {
            var response =
                await _httpClient.PostAsJsonAsync($"{BaseUrl}delete_student.php", new { student_id = studentId });
            var result = await response.Content.ReadAsStringAsync();
            return result;
        }
    }

}