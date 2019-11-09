using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLL
{

    class node<T>
    {
        T data;
        node<T> next;
        node<T> prev;

        public node<T> Prev
        {
            get { return prev; }
            set { prev = value; }
        }

        public node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

        public T Data
        {
            get { return data; }
            set { data = value; }
        }

        public node(T _data)
        {
            data = _data;

            next = null;
            prev = null;
        }



    }



    class list<T>
    {
        node<T> start;
        node<T> tail;

        public list()
        {
            start =tail= null;
        }

        public void dis()
        {
            if (start == null)
            {
                Console.WriteLine("list empty");
                return;
            }
            node<T> q = start;

            while (q != null)
            {
                Console.WriteLine(q.Data);
                q = q.Next;
            }

        }
        public void addEnd(T _data)
        {
            node<T> tmp = new node<T>(_data);

            if (start == null)
            {
                start = tmp;
                tail = tmp;
            }

            else
            {
                

                tail.Next = tmp;
                
                tmp.Prev = tail;

                tail = tmp;


            }


        }

        public void addfirst(T _data)
        {
            node<T> tmp = new node<T>(_data);

            if (start == null)
                start =tail= tmp;
            else
            {
                tmp.Next = start;

                start.Prev = tmp;

                start = tmp;
            }


        }

        public void delfirst()
        {
            if (start == null)
            {
                Console.WriteLine("List empty");
            }
            else
            {
                if (start.Next!=null)
                {
                    start.Next.Prev = null;
                }
               
                start = start.Next;
                if (start==null)
                {
                    tail = null;
                }
            }
        }

        public void delLast()
        {
            if (start == null)
            {
                Console.WriteLine("empty");
            }

            else if (start.Next==null)
            {
                start=null;
            }
            else
            {
                node<T> q = start;

                while (q.Next!=null)                {
                    q = q.Next;
                }

                q.Prev.Next = null;
            }
            }
        public void printprev(int t)
        {
            if (start == null)
            {
                Console.WriteLine("list empty");
                return;
            }
            node<T> q = start;

            while (q != null)
            {
                if (q.Data.Equals(t))
                {
                    Console.WriteLine(q.Prev.Data);
                }
                
                q = q.Next;
            }
        }
        public void del(int d)
        {
            node<T> previous=null;
            if (start==null)
            {
                Console.WriteLine("list is empty");
                return;
            }
            if (start.Data.Equals(d))
            {
                if (start.Next!=null)
                {
                    start.Next.Prev = null;
                    start = start.Next;
                    return;


                }
                else
                {
                    start = null;
                    Console.WriteLine("list is now empty");
                    return;
                }


            }
            node<T> current = start;
            while (current.Next!=null&&!current.Data.Equals(d))
            {
                previous = current;
                current = current.Next;

            }
            if (current.Data.Equals(d))
            {
                previous.Next = previous.Next.Next;
                if (previous.Next!=null)
                {
                    previous.Next.Prev = previous;

                }
                else
                {
                    tail = previous;
                }


            }
            else
            {
                Console.WriteLine("not found");

            }
        }
        
        }
    


    class Program
    {
        static void Main(string[] args)
        {

            list<int> l = new list<int>();



            while (true)
            {
                Console.WriteLine("1-add");
                Console.WriteLine("2-display");
                Console.WriteLine("4.Add Beg");
                
                Console.WriteLine("9.Delete First");
                Console.WriteLine("10.Delete ");

                Console.WriteLine("3.Exist");
                Console.WriteLine("enter ur choice :");
                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.WriteLine("enter data :");
                        int d = int.Parse(Console.ReadLine());
                        l.addEnd(d);
                        break;


                    case 2:
                        Console.WriteLine("/////////////////////////");
                        l.dis();
                        Console.WriteLine("//////////////////////////");
                        break;

                    case 3:
                        return;
                       

                    case 4:
                        Console.WriteLine("enter data :");
                        d = int.Parse(Console.ReadLine());
                        l.addfirst(d);
                        break;

                    case 5:
                        Console.WriteLine("enter data :");
                        d = int.Parse(Console.ReadLine());
                        l.printprev(d);

                        break;

                    case 6:
                        Console.WriteLine("enter data :");
                        d = int.Parse(Console.ReadLine());
                        //  l.ser(d);
                        break;

                    case 7:
                        Console.WriteLine("enter old data :");
                        d = int.Parse(Console.ReadLine());

                        Console.WriteLine("enter  new  data :");
                        int newv = int.Parse(Console.ReadLine());
                        // l.update(d, newv);
                        break;
                    case 8:

                        Console.Write("Enter the element : ");
                        int m2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter the position after which this element is inserted : ");
                        int position = Convert.ToInt32(Console.ReadLine());
                        //   l.addafter(m2, position);
                        break;

                    case 9:

                        l.delfirst();
                        break;

                    case 10 :
                        Console.WriteLine("enter ele :");
                        int ed = int.Parse(Console.ReadLine());
                        l.del(ed);
                        break;
                }
            }
        }
    }
}

