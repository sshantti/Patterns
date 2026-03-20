using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral.Observer
{
    public interface ICarSubject
    {
        void Attach(ICarObserver observer);
        void Detach(ICarObserver observer);
    }
}
