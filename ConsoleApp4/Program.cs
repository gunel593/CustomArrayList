using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] Array = new int[] { 0, 1, 2, 3, 4, 5 };
            int index = 5;
            int value = 4;
            CustomArrayList customArrayList = new CustomArrayList(Array);

            customArrayList.Insert(index, value);
            for (int i = 0; i < customArrayList.Array.Length; i++)
            {
                Console.WriteLine(customArrayList.Array[i]);
            }
            Console.WriteLine();
            customArrayList.Add(value);
            for (int i = 0; i < customArrayList.Count; i++)
            {
                Console.WriteLine(customArrayList[i]);
            }
            Console.WriteLine();
            customArrayList.Remove(value);
            for (int i = 0; i < customArrayList.Count; i++)
            {
                Console.WriteLine(customArrayList[i]);
            }
            Console.WriteLine();    

            customArrayList.Find(value);
            for (int i = 0; i < customArrayList.Count; i++)
            {
                Console.WriteLine(customArrayList[i]);
            }
            Console.WriteLine($"Count is {customArrayList.Count}");

            Console.WriteLine();
            customArrayList.RemoveAt(index);
            for (int i = 0; i < customArrayList.Count; i++)
            {
                Console.WriteLine(customArrayList[i]);
            }
            Console.WriteLine();
        }


        class CustomArrayList
        {
            public int[] Array { get; set; }

            int count = 0;
            int index = 4;


            public int Count
            {
                get { return count; }

                set { count = value; }
            }

            //public customArrayList()

            public CustomArrayList(int[] array)
            {
                Array = array;
                this.Array = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    this.Array[i] = array[i];
                    count++;
                }
            }
            public int this[int index]
            {
                get { return Array[index]; }

                set { Array[index] = value; }
            }


            public void Add(int a)
            {
                int value = 5;
                if (Array.Length >= index)
                {

                    var newArray = new int[Array.Length * 2];
                    for (int i = 0; i < Array.Length; i++)
                    {
                        newArray[i] = Array[i];
                    }
                    Array = newArray;

                }
                Array[index++] = value;

            }


            public void Remove(int value)
            {

                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] == value)
                    {
                        for (int j = 0; j < Array.Length - 1; j++)
                        {
                            Array[j] = Array[j + 1];
                        }
                        count--;
                        index--;
                    }
                }
            }
            public void RemoveAt(int index)
            {
                try
                {
                    if (index < 0 && count <= index)
                    {
                        throw new Exception("index duzgun verilmemisdir");
                    }

                    for (int i = index; i < count - 1; i++)
                    {
                        Array[i] = Array[i + 1];
                    }
                    count--;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
           
            public void Insert(int index, int value)
            {
                if (Array.Length < index)
                {
                    throw new Exception();
                }
                int[] ints = new int[Array.Length];
                for (int i = 0; i < Array.Length; i++)
                {
                    ints[i] = Array[i];
                }
                ints[index] = value;
                for (int i = index + 1; i < Array.Length; i++)
                {
                    ints[i] = Array[i - 1];
                }
                Array = ints;
            }
            public int FindAt(int index)
            {
                if (index >= 0 && index < count)
                {
                    return Array[index];
                }
                else { return -1; } 
            }
           
            public int  Find(int value)
            {
                for(int i =0; i < Array.Length; i++)
                {
                    if ((Array[i] == value)){
                        return i;
                    }
                }
                return -1;
            }
            public void AddRange(int[] array)
            {
                if (Array.Length >= index)
                {

                    var newArray = new int[Array.Length * 2];
                    for(int i =0; i < Array.Length; i++)
                    {
                        newArray[i] = Array[i];
                    }
                    Array = newArray;
                }
            }

            }
        }
}