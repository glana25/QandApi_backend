using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

namespace QqndAApi.Data.Repository
{
    public class DataRepository : IdataRepository
    {
        private readonly QandA2Context _dbContext;
        public DataRepository(QandA2Context qandA2Context)
        {
            _dbContext = qandA2Context;
        }

        public Questions GetQuestionById(int id)
        {
            return _dbContext.Questions.Include(q => q.User)
                                       .FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Questions> GetQuestions()
        {
            return _dbContext.Questions.Include(q => q.User)
                                       .ToList();
        }
    }
}

