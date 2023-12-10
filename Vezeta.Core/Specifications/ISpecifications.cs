using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Core.Specifications
{
    // specification design pattern for make sure to not repet and enhancment in code 
    public interface ISpecifications<T> where T:BaseEntity
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T,object>>> Includes { get; set; }
        public int Skip { get; set; }
        public int Take { get; set; }
        public bool IsPaginationEnable { get; set; }
    }
}
