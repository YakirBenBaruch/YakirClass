using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yakir
{
    public class NodeUnitTest
    {
        public void Run()
        {
            Node <int> Josh = new Node <int> (17);
            Node <string> Kosh = new Node <string> ("Josh");
            Node <Object> Bcm = new Node<object>("Josh");
            Bcm.SetNext(new Node <Object> (17));
        }
    }
}
