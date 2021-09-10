using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public class Gamer
    {
        private State _state;
        public string Name { get; set; }

        public Gamer(string name)
        {
            _state = new GoodState();
            Name = name;
        }

        public void SetState(State state)
        {
            _state = state;
        }

        public void PlayGames()
        {
            _state.ShowPlayState(this);
        }
    }

    public abstract class State
    {
        public abstract void ShowPlayState(Gamer gamer);
    }

    public class GoodState : State
    {
        public override void ShowPlayState(Gamer gamer)
        {
            Console.WriteLine($"{gamer.Name}精力充沛，气沉丹田，霸气外泄，所向无敌");
        }
    }

    public class BadState : State
    {
        public override void ShowPlayState(Gamer gamer)
        {
            Console.WriteLine($"{gamer.Name}头重脚轻，精神涣散，羸弱不堪，手下败将");
        }
    }
}
