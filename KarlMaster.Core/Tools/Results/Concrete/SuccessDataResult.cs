using KarlMaster.Core.Tools.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlMaster.Core.Tools.Results.Concrete
{
    public class SuccessDataResult<T> : DataResult<T> , IDataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data,true, message)
        {
        }
        public SuccessDataResult(T data) : base(data,true)
        {
        }
    }
}
