using itools_source.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Models.Interface
{
    public interface IMainRepository
    {
        Task<IEnumerable<MachineModel>> GetCurrentMachineInfo(string hddSerial);
        Task<bool> SyncLocalToHost_ToolsMachineTray(string machineCode, string companyCode);
        Task<bool> SyncLocalToHost_WorkingTransaction(string machineCode, string companyCode);

        Task<bool> SyncHostToLocal_Assessor(string machineCode, string companyCode);
        Task<bool> SyncHostToLocal_RoleAssessor(string machineCode, string companyCode);
        Task<bool> SyncHostToLocal_Machine(string machineCode, string companyCode);
        Task<bool> SyncHostToLocal_Company(string machineCode, string companyCode);
        Task<bool> SyncHostToLocal_CompanyMachine(string machineCode, string companyCode);
        Task<bool> SyncHostToLocal_Tools(string machineCode, string companyCode);
    }

}

//SyncLocalToHost_ToolsMachineTray
//SyncLocalToHost_WorkingTransaction
//
//SyncHostToLocal_Assessor
//SyncHostToLocal_RoleAssessor
//SyncHostToLocal_Machine
//SyncHostToLocal_Company
//SyncHostToLocal_CompanyMachine
//SyncHostToLocal_Tools
