using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    internal class LargeDataCollection : IDisposable
    {
        private List<string> list = null;
        bool disposed;
        public int Count;
   

        public LargeDataCollection(List<string> list)
        {
            this.list = list;
            
        }
        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                if (disposing)
                {
                    Count = 0;
                }

            }
             Console.WriteLine("Data has been disposed");
             list = null;
             disposed = true;
        }


        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        public void Push(string element)
        {
            list.Add(element);

        }
      public void Read()
        {
            foreach(string i in list)
            {
                Console.WriteLine(i);
            }
        }
        public void Remove(string data)
        {
            list.Remove(data);
        }
        
        public void GetItem(string data)
        {
            if (list.Contains(data))
            {
                Console.WriteLine($"{data} is available in List");
            }
            else
            {
                Console.WriteLine($"{data} is not available in List");
            }

        }
       
         public void GetFileDetails()
         {
             
         }
        ~LargeDataCollection()
        {
            Dispose(false);
        }

    }
    
}
