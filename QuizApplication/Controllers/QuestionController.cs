using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Models;
using QuizApplication.ViewModels;

namespace QuizApplication.Controllers
{
    public class QuestionController: Controller { 
        private readonly IQuestionRepository _questionRepository;
        private readonly IChoiceRepository _choiceRepository;
        private readonly AppDbContext _context;
        public QuestionController(IQuestionRepository questionRepository, IChoiceRepository choiceRepository, AppDbContext context)
        {
            this._questionRepository = questionRepository;
            this._choiceRepository = choiceRepository;
            this._context = context;
        }
        public ViewResult List()
        {
            QuestionViewModel questionViewModel = new QuestionViewModel()
            {
                
            };
            questionViewModel.Questions = _questionRepository.AllQuestions;
            questionViewModel.Choices = _choiceRepository.GetChoicesByQuestionId;
            questionViewModel.Current = getById(1);
            questionViewModel.Heading = "Welcome, take a quiz";
        
            //var question = questionViewModel.Questions.ToList().SingleOrDefault(x => x.QuestionId == id);
            

            return View(questionViewModel);

        }
        public Question getById(int Id)
        {
            foreach( Question q in _questionRepository.AllQuestions)
            {
                if(q.QuestionId == Id)
                {
                    return q;
                }
                return null;
            }
            return null;
        }
        public ViewResult AllQuestions()
        {
            return 
        }
    }
}

