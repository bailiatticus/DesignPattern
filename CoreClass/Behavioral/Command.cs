using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class Programer
    {
        public void Developing()
        {
            Console.WriteLine("xxx is doing developing"); 
        }
    }

    public abstract class Command
    {
        protected Programer _programer;

        public Command(Programer programer)
        {
            _programer = programer;
        }

        public abstract void Exec();
    }

    public class RoobotComand : Command
    {
        public RoobotComand(Programer programer) : base(programer) { }

        public override void Exec()
        {
            _programer.Developing();
        }
    }

    public class Productor
    {
        private Command _command;

        public Productor(Command command)
        {
            _command = command;
        }
       
        public void CallDuty()
        {
            _command.Exec();
        }
    }
}
