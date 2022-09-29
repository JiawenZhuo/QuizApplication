using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Models;
using QuizApplication.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace QuizApplication.Controllers
{
    public class NextQuestionController : Controller
    {
        private readonly IQuestionRepository _questionRepository;
        private readonly IChoiceRepository _choiceRepository;
        private int _questionCount;

        public NextQuestionController(IQuestionRepository questionRepository, IChoiceRepository choiceRepository)
        {
            this._questionRepository = questionRepository;
            this._choiceRepository = choiceRepository;
        }

        public Question GetById(int Id)
        {

            foreach (Question q in _questionRepository.AllQuestions)
            {
                if (q.QuestionId == Id)
                {
                    return q;
                }
                return null;
            }
            return null;
        }

        public int countQuestion()
        {
            this._questionCount = _questionRepository.AllQuestions.Count();

            return _questionCount;
        }
        public ActionResult GetRandomQuestion()
        {
            Random rnd = new Random(this._questionCount);
            int rrNum = rnd.Next(0, 16);
            Question question = this.GetById(rrNum);
            return View();
        }


        public IEnumerable<Choice> GetChoicesById(int id)
        {
            List<Choice> choices = new List<Choice>();
            foreach (Choice c in _choiceRepository.GetChoices)
            {

                if (c.CollectionId == id)
                {
                    choices.Add(c);
                }
            }
            return choices;
        }

        public IActionResult Next(int id)
        {
            Question question = this.GetById(id);
            NextQuestionViewModel nextQuestionViewModel = new NextQuestionViewModel()
            {

            };
            nextQuestionViewModel.Current = question;
            nextQuestionViewModel.Choices = GetChoicesById(id);
            return View(nextQuestionViewModel);
        }


    }
}