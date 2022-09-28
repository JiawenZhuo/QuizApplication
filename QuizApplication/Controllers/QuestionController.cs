using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using QuizApplication.Models;
using QuizApplication.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace QuizApplication.Controllers
{
    public class QuestionController: Controller { 
        private readonly IQuestionRepository _questionRepository;
        private readonly IChoiceRepository _choiceRepository;

        public QuestionController(IQuestionRepository questionRepository, IChoiceRepository choiceRepository)
        {
            this._questionRepository = questionRepository;
            this._choiceRepository = choiceRepository;
        }
        public ViewResult List()
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
       //ublic Question getById(int Id)
       //
        //  foreach( Question q in _questionRepository.AllQuestions)
       //   {
        //      if(q.QuestionId == Id)
       //       {
                  //return q;
        //      }
         //     return null;
        //  }
        //  return null;
      //}

    }
}

