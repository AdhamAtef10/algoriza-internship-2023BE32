using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vezeta.Core.Entities;

namespace Vezeta.Core.Specifications
{
    public class PatientWithSpecification:BaseSpecifications<Patient>
    {
        public PatientWithSpecification(PatientSpecParams specParams)
           : base(B =>
              (specParams.PageSize == specParams.PageSize && specParams.PageIndex == specParams.PageIndex)
           )
        {
            ApplyPagination(specParams.PageSize * (specParams.PageIndex - 1), specParams.PageSize);

        }
        public PatientWithSpecification(int id) : base(P => P.Id == id)
        {
            Includes.Add(P=>P.DoctorName);
        }
    }
}
