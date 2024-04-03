using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Labb1_Lektion_04_03
{
    internal class BoxEnumerator : IEnumerator<Box>
    {
        private BoxCollection _boxes;
        private int currentIndex;
        private Box currentBox;

        public BoxEnumerator(BoxCollection boxes)
        {
            this._boxes = boxes;
            currentIndex = -1;
            currentBox = default(Box);
        }
        public Box Current { get { return currentBox; } }

        object IEnumerator.Current { get {return Current; } }
        public int count
        {
            get { return _boxes.Count; }
        }

        public bool MoveNext()
        {
            if(++currentIndex >= _boxes.Count)
            {
                return false; 
            }
            else
            {
                currentBox = _boxes[currentIndex];
                return true; 
            }
        }

        void IEnumerator.Reset()
        {
            currentIndex = -1;
        }

        public void Dispose()
        {

        }
    }
}
