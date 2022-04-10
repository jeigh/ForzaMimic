using System;
using System.Collections.Generic;

namespace ForzaMimic
{
    public interface IForzaMimicDataAccess
    {
        IEnumerable<ForzaMimic.TransferObjects.FieldStudy> RetrieveAllFieldStudies();
        ForzaMimic.TransferObjects.FieldStudy? RetrieveFieldStudiesById(Guid paramFieldStudyId);
    }

}
