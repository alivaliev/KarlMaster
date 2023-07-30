using KarlMaster.Core.Tools.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Core.Tools.Results.Concrete
{
    public class ErrorDataResult<T> : DataResult<T> , IDataResult<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, false, message)
        {
        }
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }
    }
}
