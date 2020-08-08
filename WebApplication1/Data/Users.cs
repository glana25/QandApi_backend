using System;
using System.Collections.Generic;

namespace QqndAApi.Data
{
    public partial class Users
    {
        public Users()
        {
            Answers = new HashSet<Answers>();
            Questions = new HashSet<Questions>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Answers> Answers { get; set; }
        public virtual ICollection<Questions> Questions { get; set; }
    }
}
