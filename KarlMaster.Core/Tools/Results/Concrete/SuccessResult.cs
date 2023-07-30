using KarlMaster.Core.Tools.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Core.Tools.Results.Concrete
{
    public class SuccessResult : Result , IResult
    {
        public SuccessResult(string message) : base(true,message)
        {
        }
        public SuccessResult() : base(true)
        {
        }
    }
}
