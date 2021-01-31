using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Test
{
    public interface ISharp
    {
        string Name { get; }

        double Perimeter { get; }

        double SurfaceArea { get;  }

        void PrintInfo();
    }

    public class Sharp : ISharp, IComparable<Sharp>
    {
        virtual public string Name { get { return "Sharp"; } }

        virtual public double Perimeter
        {
            get
            {
                return 0;
            }
        }

        virtual public double SurfaceArea
        {
            get
            {
                return 0;
            }
        }

        public int CompareTo(Sharp other)
        {
            return this.Perimeter.CompareTo(other.Perimeter);
        }

        public void PrintInfo()
        {
            Console.WriteLine("--------");
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Perimeter: {0}", this.Perimeter);
            Console.WriteLine("SurfaceArea: {0}", this.SurfaceArea);
        }
    }

    public class SharpList : List<Sharp>
    {
        //public List<Sharp> list = new List<Sharp>();

        public void addSharp(Sharp s)
        {
            this.Add(s);
        }

        public void SortByPerimeter(bool desc = false)
        {
            this.Sort(delegate (Sharp x, Sharp y)
            {
                if (desc)
                {
                    return y.Perimeter.CompareTo(x.Perimeter);
                }
                return x.Perimeter.CompareTo(y.Perimeter);
            });
        }

        public void SortBySurfaceArea(bool desc = false)
        {
            this.Sort(delegate (Sharp x, Sharp y)
            {
                if (desc)
                {
                    return y.SurfaceArea.CompareTo(x.SurfaceArea);
                }
                return x.SurfaceArea.CompareTo(y.SurfaceArea);
            });
        }

        public void saveToFile()
        {
            string json = JsonConvert.SerializeObject(this.ToArray());

            //write string to file
            System.IO.File.WriteAllText(@"tempJsonFile.json", json);
        }
    }
}
