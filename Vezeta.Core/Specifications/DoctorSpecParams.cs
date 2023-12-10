using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Core.Specifications
{
    public class DoctorSpecParams
    {
        private const int MaxPageSize = 10;

        private int pageSize = 5;
        public int PageSize
        {
            get { return pageSize; }
            set { pageSize = value > MaxPageSize ? MaxPageSize : value; }
        }

        private string search;
        public string Search
        {
            get { return search; }
            set { search = value.ToLower(); }
        }
        public int PageIndex { get; set; } = 1;
        public string? Sort { get; set; }
        public int? SpecializationId { get; set; }
        public Specialization Specialization { get; set; }
    }
}
