using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NRP.KlientMvc.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public List<string> Answers { get; set; }
    }
    public class Matrix
    {
        public List<Question> Questions { get; set; }
        public Matrix()
        {
            int id = 0;
            Questions.Add(new Question { Id = ++id, Text = "Abc", Answers = new List<string> { "Tak", "Nie", "Nie wiem" } });
            Questions.Add(new Question { Id = ++id, Text = "Abc", Answers = new List<string> { "Tak", "Nie", "Nie wiem" } });
            Questions.Add(new Question { Id = ++id, Text = "Abc", Answers = new List<string> { "Tak", "Nie", "Nie wiem" } });
            Questions.Add(new Question { Id = ++id, Text = "Abc", Answers = new List<string> { "Tak", "Nie", "Nie wiem" } });
        }
    }
}