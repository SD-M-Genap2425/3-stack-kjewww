using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.BrowserHistory
{
    public class Halaman
    {
        public string URL;

        public Halaman(string URL)
        {
            this.URL = URL;
        }
    }

    public class Node
    {
        public Halaman Data;
        public Node Next;

        public Node(Halaman data)
        {
            Data = data;
            Next = null;
        }
    }

    public class HistoryManager
    {
        private Node top;

        public HistoryManager()
        {
            top = null;
        }

        // methods

        public void KunjungiHalaman(string url) // push
        {
            Halaman item = new Halaman(url);
            Node newNode = new(item);

            newNode.Next = top;
            top = newNode;

            Console.WriteLine("Kunjungi Halaman: " + top.Data.URL);
        }

        public string Kembali() // pop
        {
            if (top == null || top.Next == null)
            {
                return "Tidak ada halaman sebelumnya.";
            }

            string prev = top.Next.Data.URL;
            top = top.Next;
            return prev;
        }

        public string LihatHalamanSaatIni() // peek
        {
            return top.Data.URL;
        }

        //public void TampilkanHistory()
        //{
        //    Node current = top;
        //    int i = 1;
        //    while (current != null)
        //    {
        //        Console.WriteLine(i+". "+ current.Data.URL);
        //        current = current.Next;
        //        i++;
        //    }
        //}

        public void TampilkanHistory()
        {
            List<string> history = new List<string>();
            Node current = top;

            while (current != null)
            {
                history.Add(current.Data.URL);
                current = current.Next;
            }

            int n = history.Count - 1;

            while(n >= 0)
            {
                Console.WriteLine(history[n]);
                n--;
            }
        }

    }
}
