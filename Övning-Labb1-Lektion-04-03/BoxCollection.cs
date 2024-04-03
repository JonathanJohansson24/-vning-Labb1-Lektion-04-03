using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_Labb1_Lektion_04_03
{
    internal class BoxCollection : ICollection<Box>
    {

        private List<Box> innerBoxCollection;
        public BoxCollection()
        {
            innerBoxCollection = new List<Box>();
        }
        public int Count { get { return innerBoxCollection.Count; } }

        public bool IsReadOnly { get { return false; } }

        public Box this[int index]
        {
            get { return (Box)innerBoxCollection[index]; }
            set { innerBoxCollection[index] = value;}
        }


        public void Add(Box item)
        {
            if (!Contains(item))
            {
                innerBoxCollection.Add(item);
            }
            else
            {
                Console.WriteLine("The Box is already added");
            }
        }

        public void Clear()
        {
            innerBoxCollection.Clear();
        }
        public bool Contains(Box item, EqualityComparer<Box> box)
        {
            bool found = false;
            foreach (Box b in innerBoxCollection)
            {
                if (box.Equals(b, item))
                {
                    found = true;
                }
            }
            return found;
        }
        public bool Contains(Box item)
        {
            bool found = false;
            foreach (Box b in innerBoxCollection)
            {
                if (b.Equals(item))
                {
                    found = true;
                }
            }
            return found;
        }

        public void CopyTo(Box[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Box> GetEnumerator()
        {
            return new BoxEnumerator(this);
        }

        public bool Remove(Box item)
        {
            bool result = false; 
            for(int i = 0; i < innerBoxCollection.Count; i++)
            {
                Box currentBox = innerBoxCollection[i];
                if(new BoxSameProp().Equals(currentBox, item))
                {
                    innerBoxCollection.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
