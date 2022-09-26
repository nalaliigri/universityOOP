using System;
using System.Collections.Generic;

namespace task2._2
{
    abstract class Worker
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string WorkDay { get {return "Середа"; } set {WorkDay = "Середа" ; } }
        public Worker(string name)
        {
            Name = name;
        }
        public void Call()
        {

        }
        public void WriteCode()
        {

        }
        public void Relax()
        {

        }
        public abstract void FillWorkDay();
    }
    class Developer : Worker
    {
        public Developer(string name) : base(name)
        {
            Position = "Розробник";
        }
        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
    class Manager : Worker
    { 
        public Manager(string name) : base(name)
        {
            Position = "Менеджер";
        }

        private Random _rnd = new Random();
        public override void FillWorkDay()
        {
            int count = _rnd.Next(11);
            for(int i = 0; i <count; i++)
            {
                Call();
            }
            Relax();
            count = _rnd.Next(6);
            for (int i = 0; i <count; i++)
            {
                Call();
            }
        }
    }
    class Team
    { 
        private List<Worker> _workers = new List<Worker>();
        private string _name { get; set; }
        public Team(string name)
        {
            _name = name;
        }

        public void addNewWorker(Worker worker)
        {
            _workers.Add(worker);
        }

        public void Show()
        {
            Console.WriteLine(_name);
            foreach(Worker worker in _workers)
            {
                Console.WriteLine(worker.Name);
            }
        }

        public void ShowDetails()
        {
            Console.WriteLine(_name);
            foreach (Worker worker in _workers)
            {
                Console.WriteLine($"<{worker.Name}> - <{worker.Position}> - <{worker.WorkDay}>");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a team name:");
            string teamName = Console.ReadLine();
            Team team = new Team(teamName);
            string Name1 = Console.ReadLine();
            Developer developer = new Developer(Name1);
            string Name2 = Console.ReadLine();
            Manager manager = new Manager(Name2);
            team.addNewWorker(developer);
            team.addNewWorker(manager);
            Console.WriteLine(" ");
            team.Show();
            Console.WriteLine(" ");
            team.ShowDetails();
        }
    }
}
