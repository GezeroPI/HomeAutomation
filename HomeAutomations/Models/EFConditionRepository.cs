using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeAutomations.Models
{
    public class EFConditionRepository : IConditionRepository
    {
        private AppDbContext context;

        public EFConditionRepository(AppDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Condition> Conditions => context.Conditions;

        public void insertCondition(Condition conditions)
        {
            if (conditions != null)
            {
                context.Conditions.Add(conditions);
                context.SaveChanges();
            }

        }
    }
}
