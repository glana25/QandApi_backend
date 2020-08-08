using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QqndAApi.Data;
using QqndAApi.Data.Repository;

namespace QqndAApi.Controllers
{
      
    [Route("api/questions")] // are URL will be http:localhost/api/
    [ApiController]
    public class QuestionsController : ControllerBase
    {
        private readonly IdataRepository _dataRepasitory;

        public QuestionsController(IdataRepository repository)
        {
            _dataRepasitory = repository;
        }
        [HttpGet]
        public IEnumerable<Questions> GetQuestions()
        {
            return _dataRepasitory.GetQuestions();
        }
        [HttpGet("{id}")]
        public ActionResult<Questions> GetQuestionById(int id)
        {
           Questions question = _dataRepasitory.GetQuestionById(id);
            if (question == null)
            {
                return NotFound();
            }
            return question;


        }

    }

}
