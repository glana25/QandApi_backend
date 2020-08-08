using System;
using System.Collections.Generic;

namespace QqndAApi.Data
{
    public partial class Questions
    {
        public Questions()
        {
            Answers = new HashSet<Answers>();
        }

        public int Id { get; set; }
        public string Text { get; set; }
        public int UserId { get; set; }
        public DateTime DateCreated { get; set; }
        public string Title { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<Answers> Answers { get; set; }
    }
}
