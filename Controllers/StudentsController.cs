using System;
using Microsoft.AspNetCore.Mvc;

namespace vscode_webapi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return new Student
            {
                Id = id,
                Name = "John Doe",
                Class = new Class
                {
                    Id = 1,
                    Name = "Intro to Programming",
                    Teacher = new Teacher
                    {
                        Id = 1,
                        Name = "Mrs. Clarke",
                        School = new School
                        {
                            Id = 1,
                            Name = "School of Hard Knocks",
                            City = "City",
                            State = "State"
                        }
                    }
                }
            };
        }

    }
}