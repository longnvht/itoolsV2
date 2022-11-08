using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IAssessorRepository
    {
        void AddAssessor(Assessor assessor);
        void UpdateAssessor(Assessor assessor);
        void DeleteAssessor(Assessor assessor);
        Assessor GetAssessor(string strUserName, string strPassword);
        string GetRoleName(int iAssessorId);
        int GetById(string strUserName, string strPassword);
        IEnumerable<Assessor> GetAllAssessor();
        IEnumerable<Assessor> GetByValue(); // Search
    }
}
