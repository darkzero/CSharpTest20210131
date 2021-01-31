using System;
using System.Collections.Generic;
using System.Linq;
using Test;

class MainClass
{
    static void Main()
    {
        // keep this function call here
        var a = Circle.create(1.0);

        var b = Triangle.create(new double[] { 2.0, 2.0, 2.0 });

        var c = Triangle.create(new double[] { 2.0, 2.0, 3.0 });

        var d = Triangle.create(new double[] { 3.0, 4.0, 5.0 });

        var e = Quadrilateral.create(new double[] { 3.0, 3.0 });

        var f = Quadrilateral.create(new double[] { 3.0, 5.0 });

        var g = Triangle.create(new double[] { 1.0, 2.0, 1.0 });

        // list
        var list = new SharpList();
        list.addSharp(a);
        list.addSharp(b);
        list.addSharp(c);
        list.addSharp(d);
        list.addSharp(e);
        list.addSharp(f);
        list.addSharp(g);

        // sort
        Console.WriteLine("-- Sort By Perimeter ASC ---");
        list.SortByPerimeter();
        foreach (var sharp in list)
        {
            sharp.PrintInfo();
        }

        Console.WriteLine("-- Sort By Perimeter DESC ---");
        list.SortByPerimeter(desc: true);
        foreach (var sharp in list)
        {
            sharp.PrintInfo();
        }

        Console.WriteLine("-- Sort By SurfaceArea ASC ---");
        list.SortBySurfaceArea();
        foreach (var sharp in list)
        {
            sharp.PrintInfo();
        }

        Console.WriteLine("-- Sort By SurfaceArea DESC ---");
        list.SortBySurfaceArea(desc: true);
        foreach (var sharp in list)
        {
            sharp.PrintInfo();
        }

        // write to json file
        list.saveToFile();
    }
}