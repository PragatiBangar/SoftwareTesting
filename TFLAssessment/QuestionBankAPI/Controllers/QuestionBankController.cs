using QuestionBankEntities;
using QuestionBank.Services;
using Microsoft.AspNetCore.Mvc;

namespace QuestionBankAPI.Controllers
{

    [ApiController]
    [Route("api/questionbank")]
    public class QuestionBankController : ControllerBase
    {
        QuestionBankService _service = new QuestionBankService();
        public QuestionBankController()
        {
            // Initialize with some sample data

        }

        //https://localhost:7104/api/questionbank/questions
        [HttpGet("questions")]
        public IActionResult GetAllQuestions()
        {
            List<QuestionTitle> questions = _service.GetAllQuestions();
            return Ok(questions);
        }
    }
}
