using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ubiety.Dns.Core;

namespace QqndAApi.Data.Repository
{
    public interface IdataRepository
    {
        IEnumerable<Questions> GetQuestions();
        Questions GetQuestionById(int id);
    }
}
