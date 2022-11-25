﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itools_source.Models.Interface
{
    public interface IGetToolRepository
    {
        IEnumerable<Job> GetAllJobs();
        Job GetJobs();
        SortedList<string, string> GetJobByJobNumber(string strJobNumber);
        Dictionary<string, Dictionary<string, string>> GetOPByJobPartOPID(string strJobNumber, string strPartID);
        Task<Dictionary<int, string>> GetByToolForOP(int iOPId);
        Task<Dictionary<string, string>> GetModelDescriptionByToolId(int iToolId);
        Task<Dictionary<string, string>> GetMachineTrayByToolCode(string strToolCode, string strMachineCode);
    }
}
