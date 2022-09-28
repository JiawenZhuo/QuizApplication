using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuizApplication.Models;
using QuizApplication.ViewModels;

namespace QuizApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IQuestionRepository _questionRepository;
        private readonly IChoiceRepository _choiceRepository;
        public HomeController(ILogger<HomeController> logger, IQuestionRepository questionRepository, IChoiceRepository choiceRepository)
        {
            _logger = logger;
            this._questionRepository = questionRepository;
            this._choiceRepository = choiceRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Question()
        {
            QuestionViewModel questionViewModel = new QuestionViewModel()
            {

            };
            questionViewModel.Questions = _questionRepository.AllQuestions;
       
            questionViewModel.Heading = "Welcome, take a quiz";

            //var question = questionViewModel.Questions.ToList().SingleOrDefault(x => x.QuestionId == id);


            return View(questionViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

