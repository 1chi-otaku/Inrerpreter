using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inrerpreter
{
    abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }

    class GuidTour : Iterator
    {
        private AttractionCollection collection;

        private int position = -1;

        public GuidTour(AttractionCollection collection)
        {
            this.collection = collection;
        }
        public override object Current()
        {
            return this.collection.getItems()[position];
        }
        public override int Key()
        {
            return this.position;
        }
        public override bool MoveNext()
        {
            int updatedPosition = this.position + 1;

            if (updatedPosition >= 0 && updatedPosition < this.collection.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            this.position = 0;
        }
    }

    class VirtualGuideTour : Iterator
    {
        private AttractionCollection collection;

        private int position = -1;

        public VirtualGuideTour(AttractionCollection collection)
        {
            this.collection = collection;
        }
        public override object Current()
        {
            return this.collection.getItems()[position];
        }
        public override int Key()
        {
            return this.position;
        }
        public override bool MoveNext()
        {
            Random random= new Random();
            int updatedPosition = this.position + 1;
            if (Key() + 2 <= this.collection.getItems().Count && random.Next(0,3) == 1) updatedPosition = this.position + 2;

            if (updatedPosition >= 0 && updatedPosition < this.collection.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            this.position = 0;
        }
    }
    class ByFootTour : Iterator
    {
        private AttractionCollection collection;

        private int position = -1;

        public ByFootTour(AttractionCollection collection)
        {
            this.collection = collection;
        }
        public override object Current()
        {
            return this.collection.getItems()[position];
        }
        public override int Key()
        {
            return this.position;
        }
        public override bool MoveNext()
        {
            int updatedPosition = this.position + 1;
            if (Key() + 3 <= this.collection.getItems().Count) updatedPosition = this.position + 3;

            if (updatedPosition >= 0 && updatedPosition < this.collection.getItems().Count)
            {
                this.position = updatedPosition;
                return true;
            }
            else
                return false;
        }

        public override void Reset()
        {
            this.position = 0;
        }
    }
}
