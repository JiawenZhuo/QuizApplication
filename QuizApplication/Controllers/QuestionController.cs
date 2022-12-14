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
    public class QuestionController : Controller {
        private readonly IQuestionRepository _questionRepository;
        private readonly IChoiceRepository _choiceRepository;
        private int _questionCount;

        public QuestionController(IQuestionRepository questionRepository, IChoiceRepository choiceRepository)
        {
            this._questionRepository = questionRepository;
            this._choiceRepository = choiceRepository;
        }
        public ViewResult List1()
        {
            QuestionViewModel questionViewModel = new QuestionViewModel()
            {

            };
            questionViewModel.Questions = _questionRepository.AllQuestions;
            questionViewModel.Choices = _choiceRepository.GetChoices;
            questionViewModel.Heading = "Welcome, take a quiz";

            //var question = questionViewModel.Questions.ToList().SingleOrDefault(x => x.QuestionId == id);


            return View(questionViewModel);

        }
        public Question GetById(int Id) {

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
        public ActionResult List()
        {
            QuestionViewModel questionViewModel = new QuestionViewModel()
            {

            };
            questionViewModel.Questions = _questionRepository.AllQuestions;
            questionViewModel.Choices = _choiceRepository.GetChoices;
            questionViewModel.Heading = "Welcome, take a quiz";

            Random rnd = new Random(this._questionCount);
            int rrNum = rnd.Next(1, _questionCount+1);
            Question question = this.GetById(rrNum);
            questionViewModel.Current = question;
            List<Question> list = new List<Question>();
            questionViewModel.CurrentChoices =GetChoicesById(rrNum);


            return View(questionViewModel);

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

