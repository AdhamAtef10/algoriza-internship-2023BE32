using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Core.Specifications
{
    // specification design pattern for make sure to not repet and enhancment in code 
    public class DoctorWithSpecializationSpecification:BaseSpecifications<Doctor>
    {
        // this ctor is used to get all doctors
        public DoctorWithSpecializationSpecification(DoctorSpecParams specParams)
           : base(D =>
               (!string.IsNullOrEmpty(specParams.Search) || D.FirstName.ToLower().Contains(specParams.Search)) &&
               (!specParams.SpecializationId.HasValue || D.DoctorSpecializationId== specParams.SpecializationId.Value)          
           )
        {
            Includes.Add(D=>D.DoctorSpecializations);           
            ApplyPagination(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);
          
        }

        // this ctor is used to get specific Doctor by id 
        public DoctorWithSpecializationSpecification(int id):base(D=>D.Id==id)
        {
            Includes.Add(D => D.DoctorSpecializations);
        }
    }
}
