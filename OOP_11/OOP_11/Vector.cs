﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_11
{
    class Vector
    {

        public const String labName = "Лабороторная работа №11";

        static int VectorCount = 0;
        int status;
        public static int Count { get; private set; } = 0;
        int[] array;
        int Length = 0;
        public readonly string myName = " Храмых Владислав";
        Random rnd = new Random();
        static Vector()
        {
            Count++;
        }
        public Vector()
        {
            array = new int[10];
            Length = 10;
            for (int count = 0; count < Length; count++)
                array[count] = (rnd.Next(-100, 100) / 13);
            VectorCount++;
        }

        public Vector(int size)
        {
            array = new int[size];
            Length = size;
            for (int count = 0; count < Length; count++)
                array[count] = (rnd.Next(-100, 100) / 3);
            VectorCount++;
        }

        public Vector(int Item1, int Item2, int Item3, int Item4, int size)
        {
            array = new int[] { Item1, Item2, Item3, Item4 };
            Length = size;
            VectorCount++;
        }

        public int this[int i]
        {
            get
            {
                if (i < 0 && i > Length)
                {
                    Console.WriteLine("Пpоверьте диапазон элементов массива");
                    status = 101;
                    return 101;
                }
                return this.array[i];
            }
            set
            {
                if (i >= 0 && i <= Length)
                {

                    if (value <= 100 & value > -100)
                        array[i] = value;
                    else
                    {
                        Console.WriteLine("Пpоверьте введённое значение!");
                        status = 201;
                    }
                }
                else
                    Console.WriteLine("Пpоверьте диапазон элементов массива");
                status = 101;
            }
        }

        public void PrintArray()
        {
            for (int count = 0; count < array.Length; count++)
                Console.Write(array[count] + " ");
            Console.WriteLine();
        }

        public int SumArray()
        {
            int sum = 0;
            for (int i = 0; i < this.Length; i++)
                sum += array[i];
            return sum;
        }

        public int MulpiplyArray()
        {
            int Mul = 1;
            for (int i = 0; i < this.Length; i++)
                Mul += array[i];
            return Mul;
        }

        public bool IsNullInArray()
        {
            for (int i = 0; i < this.Length; i++)
            {
                if (array[i] == 0)
                    return true;
            }
            return false;
        }

        public int GetLength() => array.Length;

        public int GetMin()
        {
            return array.Min();
        }
        public static int GetCount()
        {
            return VectorCount;
        }

    }
}
