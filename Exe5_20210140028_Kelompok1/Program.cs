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


        }
    }
