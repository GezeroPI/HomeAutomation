using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomations.Models
{
    public interface IConditionRepository
    {
        IQueryable<Condition> Conditions { get; }
        void insertCondition(Condition condition);
    }
}
