using Kreata.Backend.Repos;
using Kreta.Shared.Dtos;
using Kreta.Shared.Extensions;
using Kreta.Shared.Models;
using Kreta.Shared.Parameters;
using Kreta.Shared.Responses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private IStudentRepo _studentRepo;

        public StudentController(IStudentRepo studentRepo)
        {
            _studentRepo = studentRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            Student? entity = new();
            if (_studentRepo is not null)
            {
                entity = await _studentRepo.GetById(id);
                if (entity != null)
                    return Ok(entity.ToStudentDto());
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<Student>? users = new();

            if (_studentRepo != null)
            {
                users = await _studentRepo.FindAll().ToListAsync();
                return Ok(users.Select(student => student.ToStudentDto()));
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateStudentAsync(StudentDto entity)
        {
            ControllerResponse response = new();
            if (_studentRepo is not null)
            {
                response = await _studentRepo.UpdateAsync(entity.ToStudent());
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                    response.ClearAndAddError("A diák adatainak módosítása nem sikerült!");
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok frissítés nem lehetséges!");
            return BadRequest(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudendAsync(Guid id)
        {
            ControllerResponse response = new();
            if (_studentRepo is not null)
            {
                response = await _studentRepo.DeleteAsync(id);

                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                    response.ClearAndAddError("A diák adatainak törlése nem sikerült!");
                    return BadRequest(response);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az adatok törlése nem lehetséges!");
            return BadRequest(response);
        }

        [HttpPost()]
        public async Task<IActionResult> InsertStudentAsync(StudentDto student)
        {
            ControllerResponse response = new();
            if (_studentRepo is not null)
            {
                response = await _studentRepo.InsertAsync(student.ToStudent());
                if (response.HasError)
                {
                    Console.WriteLine(response.Error);
                }
                else
                {
                    return Ok(response);
                }
            }
            response.ClearAndAddError("Az új adatok mentése nem lehetséges!");
            return BadRequest(response);
        }

        [HttpGet("/queryparameters")]
        public async Task<IActionResult> GetStudents([FromQuery] StudentQueryParametersDto dto)
        {
            StudentQueryParameters parameters = dto.ToStudentQueryParameters();
            if (!parameters.ValidYearRange)
            {
                return BadRequest("A születési év maximuma nagyobb kell legyen a születési év minimumánál!");
            }
            else
            {
                if (_studentRepo is null)
                {
                    return BadRequest("A diákok szűrése születési év alapján nem lehetséges");
                }
                else
                {
                    List<Student> result = await _studentRepo.GetStudents(parameters).ToListAsync();
                    return Ok(result);
                }
            }
        }
    }
}
