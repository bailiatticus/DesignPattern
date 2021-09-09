using System;
using System.Collections.Generic;
using System.Text;

namespace CoreClass
{
    public abstract class Mediator
    {
        public Speaker Speaker1 { get; set; }
        public Speaker Speaker2 { get; set; }
        public Speaker Speaker3 { get; set; }
        public abstract void Tanslate(Speaker speaker);
    }

    public class Translator : Mediator
    {
        //public Translator(Speaker speaker1, Speaker speaker2, Speaker speaker3)
        //{
        //    Speaker1 = speaker1;
        //    Speaker2 = speaker2;
        //    Speaker3 = speaker3;
        //}

        public override void Tanslate(Speaker speaker)
        {
            if(speaker is ChineseSpeaker)
            {
                Speaker2.Speaking();
                Speaker3.Speaking();
            }
            if (speaker is NiHonSpeaker)
            {
                Speaker1.Speaking();
                Speaker3.Speaking();
            }
            if (speaker is EnglishSpeaker)
            {
                Speaker1.Speaking();
                Speaker2.Speaking();
            }
        }
    }

    public abstract class Speaker
    {
        private Mediator _mediator;
        public Speaker(Mediator mediator)
        {
            _mediator = mediator;
        }

        public abstract void Speaking();
    }

    public class ChineseSpeaker : Speaker
    {
        public ChineseSpeaker(Mediator mediator) : base(mediator)
        {

        }

        public override void Speaking()
        {
            Console.WriteLine("你好");
        }
    }

    public class NiHonSpeaker : Speaker
    {
        public NiHonSpeaker(Mediator mediator) : base(mediator)
        {

        }

        public override void Speaking()
        {
            Console.WriteLine("こんにちは");
        }
    }

    public class EnglishSpeaker : Speaker
    {
        public EnglishSpeaker(Mediator mediator) : base(mediator)
        {

        }

        public override void Speaking()
        {
            Console.WriteLine("How are you doing~");
        }
    }
}
