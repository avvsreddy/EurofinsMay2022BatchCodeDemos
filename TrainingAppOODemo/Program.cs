using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingAppOODemo
{
    internal class Program
    {
        //public Organization Organization { get; set; } // Has-A
        
        static void Main(string[] args)
        { 
            Organization org = new Organization {Name="Pratian" }; // Uses
            Trainer trainer = new Trainer();
            trainer.Organization = org;

            Trainee t1 = new Trainee();
            Trainee t2 = new Trainee();
            Trainee t3 = new Trainee();
            Trainee t4 = new Trainee();
            Trainee t5 = new Trainee();
            t1.Trainer = trainer;
            t2.Trainer = trainer;
            t3.Trainer = trainer;
            t4.Trainer = trainer;
            t5.Trainer = trainer;
            trainer.Trainees.Add(t1);
            trainer.Trainees.Add(t2);
            trainer.Trainees.Add(t3);
            trainer.Trainees.Add(t4);
            trainer.Trainees.Add(t5);

            Training training = new Training();
            training.Trainer = trainer;
            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);
            training.Trainees.Add(t4);
            training.Trainees.Add(t5);
           
            Course course = new Course();
            training.Course = course;
            course.Trainings.Add(training);

            Module m1 = new Module();
            Module m2 = new Module();
            Module m3 = new Module();
            Module m4 = new Module();
            Module m5 = new Module();
            Module m6 = new Module();
            Module m7 = new Module();

            course.Modules.Add(m1);
            course.Modules.Add(m2);
            course.Modules.Add(m3);
            course.Modules.Add(m4);
            course.Modules.Add(m5);
            course.Modules.Add(m6);
            course.Modules.Add(m7);

            Unit u1 = new Unit {Duration = 2 };
            Unit u2 = new Unit { Duration = 2 };
            m1.Units.Add(u1);
            m1.Units.Add(u2);
            Unit u3 = new Unit { Duration = 2 };
            Unit u4 = new Unit { Duration = 2 };
            m2.Units.Add(u3);
            m2.Units.Add(u4);
            Unit u5 = new Unit { Duration = 2 };
            Unit u6 = new Unit { Duration = 2 };
            m3.Units.Add(u5);
            m3.Units.Add(u6);
            Unit u7 = new Unit { Duration = 2 };
            Unit u8 = new Unit { Duration = 2 };
            m4.Units.Add(u7);
            m4.Units.Add(u8);
            Unit u9 = new Unit { Duration = 2 };
            Unit u10 = new Unit { Duration = 2 };
            m5.Units.Add(u9);
            m5.Units.Add(u10);
            Unit u11 = new Unit { Duration = 2 };
            Unit u12 = new Unit { Duration = 2 };
            m6.Units.Add(u11);
            m6.Units.Add(u12);
            Unit u13 = new Unit { Duration = 2 };
            Unit u14 = new Unit { Duration = 2 };
            m7.Units.Add(u13);
            m7.Units.Add(u14);

            Topic tt1 = new Topic();
            u1.Topics.Add(tt1);
            Topic tt2 = new Topic();
            u2.Topics.Add(tt2);
            Topic tt3 = new Topic();
            u3.Topics.Add(tt3);
            Topic tt4 = new Topic();
            u4.Topics.Add(tt4);
            Topic tt5 = new Topic();
            u5.Topics.Add(tt5);
            Topic tt6 = new Topic();
            u6.Topics.Add(tt6);
            Topic tt7 = new Topic();
            u7.Topics.Add(tt7);
            Topic tt8 = new Topic();
            u8.Topics.Add(tt8);
            Topic tt9 = new Topic();
            u9.Topics.Add(tt9);
            Topic tt10 = new Topic();
            u10.Topics.Add(tt10);
            Topic tt11 = new Topic();
            u11.Topics.Add(tt11);
            Topic tt12 = new Topic();
            u12.Topics.Add(tt12);
            Topic tt13 = new Topic();
            u13.Topics.Add(tt13);
            Topic tt14 = new Topic();
            u14.Topics.Add(tt14);

            Console.WriteLine("The training is organized by");
            Console.WriteLine( training.GetTrainingOrgName());
            Console.WriteLine("Number of Participants");
            Console.WriteLine(training.GetNumberOfTrainees());
            Console.WriteLine("Training Duration");
            Console.WriteLine(training.GetTrainingDurationInHrs());
            
        }
    }

    class Organization
    {
        public string Name { get; set; }
    }

    class Trainer
    {
        public Organization Organization { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public List<Training> Trainings { get; set; } = new List<Training>();
    }

    class Trainee
    {
        public Trainer Trainer { get; set; }

    }
    class Training
    {
        public Trainer Trainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course Course { get; set; }
        public int GetNumberOfTrainees()
        {
            return Trainees.Count;
        }
        public string GetTrainingOrgName()
        {
            return Trainer.Organization.Name;
        }

        public int GetTrainingDurationInHrs()
        {
            int duration = 0;
            // Iterate Modules
            foreach (Module module in Course.Modules)
            {
                // Iterate Units
                foreach (Unit unit in module.Units)
                {
                    duration += unit.Duration;
                }
            }
            return duration;
            

        }

    }
    class Course
    {
        public List<Training> Trainings { get; set; } = new List<Training>();
        public List<Module> Modules { get; set; } = new List<Module>();

    }
    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();
    }

    class Unit
    {
        public int Duration { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {
        public string Name { get; set; }
    }
}
