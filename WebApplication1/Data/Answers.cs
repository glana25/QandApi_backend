using System;
using System.Collections.Generic;

namespace QqndAApi.Data
{
    public partial class Answers
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }
        public int UserId { get; set; }
        public int? QuestionId { get; set; }

        public virtual Questions Question { get; set; }
        public virtual Users User { get; set; }
    }
}
