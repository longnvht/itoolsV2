using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinamiToolUser.Views.Interface
{
    public interface IWorkInfoView
    {
        string WorkCode { get; set; }
        string WorkMachineCode { get; set; }
    }
}
