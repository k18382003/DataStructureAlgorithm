
using System;

namespace DataStructure_Algorithm.Array
{
    internal class MyArray
    {
        public int _length { get; set; }
        private object[] data;
        // Making Array class
        public MyArray()
        {
            this._length = 0;
            this.data = new object[this._length];
        }
        // Create Access function
        public object get(int index)
        {
            try
            {
                return this.data[index];
            }
            catch (Exception)
            {

                Console.WriteLine("Can't access the element!");
                return null;
            }
        }
        // Create Add function
        public void Add(object value)
        {
            
            _length++;
            var newData = new object[this._length];
            for (int i = 0; i < data.Length; i++)
            {
                newData[i] = this.data[i];
            }
            newData[this._length - 1] = value;
            this.data = newData;
        }
        //Create Insert function
        public void Insert(int index, object value)
        {
            try
            {
                if (index == data.Length)
                {
                    this.Add(value);
                }
                else
                {
                    _length++;
                    var newData = new object[this._length];
                    for (int i = 0; i < data.Length;i++)
                    {

                        if (i == index)
                        {
                            newData[i] = value;
                            newData[i + 1] = this.data[i];
                        }
                        else if (i < index)
                        {
                            newData[i] = this.data[i];
                        }
                        else
                        {
                            newData[i + 1] = this.data[i];
                        }
                    }
                    
                    this.data = newData;
                   
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Can't insert element." + e.Message);
            }
        }
    }
}
