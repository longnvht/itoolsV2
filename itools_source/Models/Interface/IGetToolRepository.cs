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
        IEnumerable<string> GetJobByNumber(string strJobNumber);
    }
}
