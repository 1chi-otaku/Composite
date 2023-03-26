using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Component Office = new Composite("Office", 6000);
            //1

            Component Reception = new Composite("Reception", 1000);
            Component Magazines = new Leaf("20 magazines 'PC WORLD'", 20);
            Reception.Add(Magazines);
            Component Sofa = new Leaf("Sofa", 50);
            Component Secretary_table = new Composite("Secretaty Table", 65.99);
            Component Office_stuff = new Leaf("Office stuff", 18.95);
            Component PC = new Composite("PC", 499.89);
            Component HDD = new Leaf("HDD 8 TB", 80);
            PC.Add(HDD);
            Secretary_table.Add(Office_stuff);
            Secretary_table.Add(PC);
            Component Cooler = new Leaf("Cooler", 28.99);

            Reception.Add(Secretary_table);
            Reception.Add(Cooler);
            Reception.Add(Sofa);

            //2
            Component Audience_1 = new Composite("Audience 1", 1000);
            Component Board = new Leaf("Board", 100);
            Component Tables = new Leaf("10 Tables", 110);
            Component Mathematicians_posters = new Leaf("Mathematicians posters", 20);

            Component Teacher_table = new Composite("Teacher table", 180);
            Teacher_table.Add(new Leaf("PC", 199.99));
            Audience_1.Add(Board);
            Audience_1.Add(Teacher_table);
            Audience_1.Add(Tables);
            Audience_1.Add(Mathematicians_posters);

            //3
            Component Audience_2 = new Composite("Audience 2", 1000);
            Component Tables_2 = new Composite("Tables", 200);
            Tables_2.Add(new Leaf("10 black tables", 100));
            Tables_2.Add(new Leaf("10 round tables", 100));
            Audience_2.Add(new Leaf("Board", 85.99));
            Audience_2.Add(new Leaf("Sofa", 25.99));
            Audience_2.Add(Tables_2);

            //4
            Component PC_audience = new Composite("PC Audience", 2000);
            Component PC_tables = new Composite("10 PC tables", 400);
            Component PC_ = new Composite("10 PC", 399.99);
            PC_.Add(new Leaf("CPU 2.2 GHZ", 80));
            PC_.Add(new Leaf("HDD 80 GB", 20));
            PC_.Add(new Leaf("RAM 1024 MB", 100));
            PC_tables.Add(PC_);
            PC_audience.Add(PC_tables);
            PC_audience.Add(new Leaf("10 sockets", 85.99));

            //5
            Component Dining_room = new Composite("Dining Room", 1500);
            Dining_room.Add(new Leaf("Coffe automat", 300));
            Dining_room.Add(new Leaf("Freezed", 100));
            Dining_room.Add(new Leaf("Wash basin", 200));
            Component Dining_table = new Composite("Table", 200);
            Dining_table.Add(new Leaf("4 Сhairs", 300));
            Dining_room.Add(Dining_table);

            Office.Add(Reception);
            Office.Add(Audience_1);
            Office.Add(Audience_2);
            Office.Add(PC_audience);
            Office.Add(Dining_room);
            Office.Display(1);

        }
    }
}
