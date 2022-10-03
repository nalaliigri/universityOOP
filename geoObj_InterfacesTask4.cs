using System;

namespace geoObjTask4
{
    class Program
    {

        public interface IGeoObject
        {

            string coordinateY { get; set; }
            string coordinateX { get; set; }
            string name { get; set; }
            string description { get; set; }
            virtual void getInfo() { }
        }

        class Mount : IGeoObject
        {
            public string coordinateY { get; set; }
            public string coordinateX { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public double theHighestPoint { get; set; }
            public virtual void getInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Coordinates X Y: {coordinateX}  {coordinateY}");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine($"The highest point: {theHighestPoint} m");

            }

        }

         class River : IGeoObject
        {
            public string coordinateY { get; set; }
            public string coordinateX { get; set; }
            public string name { get; set; }
            public string description { get; set; }
            public string speed { get; set; }
            public double length { get; set; }
            public virtual void getInfo()
            {
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Coordinates X Y: {coordinateX}  {coordinateY}");
                Console.WriteLine($"Description: {description}");
                Console.WriteLine($"Speed: {speed}");
                Console.WriteLine($"Length: {length} m");
            }

        }

        static void Main(string[] args)
        {
            Mount mount = new Mount();
            mount.name = "Everest";
            mount.theHighestPoint = 8.849;
            mount.description = "Mount Everest is a peak in the Himalaya mountain range. It is located between Nepal and Tibet, an autonomous region of China.";
            mount.coordinateX = "27°59′17″";
            mount.coordinateY = "86°55′31″";

            Console.WriteLine("Do you want know more about mount Everest? yes/no");
            Console.ReadLine();
            mount.getInfo();

            River river = new River();
            river.name = "Amazon";
            river.description = "The Amazon River is a freshwater drainage system flowing 4,000 miles from the Andes Mountains to the Atlantic coast of Brazil. It's the second longest river in the world, but also the longest and largest in terms of volume and flow.";
            river.coordinateX = "4°26′25″";
            river.coordinateY = "73°26′50″";
            river.length = 6.992;
            river.speed = "1.5 miles per hour";
            Console.WriteLine("");
            Console.WriteLine("Do you want know more about Amazon river? yes/no");
            Console.ReadLine();
            river.getInfo();

            Console.ReadKey();
        }

    }
}