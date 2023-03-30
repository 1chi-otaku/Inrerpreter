using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inrerpreter
{

    abstract class IteratorAggregate : IEnumerable
    {
        // Возвращает Iterator или другой IteratorAggregate для реализующего
        // объекта.
        public abstract IEnumerator GetEnumerator();
    }

    class AttractionCollection : IteratorAggregate
    {
        List<string> _attractions = new List<string>();

        public List<string> getItems()
        {
            return _attractions;
        }

        public void AddItem(string item)
        {
            this._attractions.Add(item);
        }

        public override IEnumerator GetEnumerator()
        {
            return new GuidTour(this);
        }
    }


};
