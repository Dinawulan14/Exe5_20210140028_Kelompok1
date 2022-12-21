using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe5_20210140028_Kelompok1
{
    class Node
    {
        public string nama;
        public Node next;
    }
    class queue
    {
        Node Dina, Sari;
        public queue()
        {
            Dina = null;
            Sari = null;
        }
        public void insert()
        {
            string valueread;
            Node newnode = new Node();
            Console.Write("Masukkan Input : ");
            valueread = Console.ReadLine();
            newnode.nama = valueread;
            newnode.next = null;
            if (Dina == null)
            {
                Dina = newnode;
                Sari = newnode;
                return;
            }
            Sari.next = newnode;
            Sari.next = newnode;
        }
        public void delete()
        {
            if (Dina == null)
            {
                Console.WriteLine("Tidak ada data dalam antrian!");
                return;
            }
            Dina = Dina.next;
            if (Dina == null)
                Sari = null;
        }
        public void display()
        {
            if (Dina == null)
            {
                Console.WriteLine("Tidak ada data dalam antrian!");
                return;
            }
            Node display;
            for (display = Dina; display != null; display = display.next)
                Console.WriteLine(display.nama);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            queue qw = new queue();
            char ch;
            while(true)
            {
                try
                {
                    Console.WriteLine("menu");
                    Console.WriteLine("1. Implement insert operation");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.Write("\nEnter your choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter a number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                qw.insert(num);
                            }
                            break;


                    }
                }
            }
        }
    }
}
