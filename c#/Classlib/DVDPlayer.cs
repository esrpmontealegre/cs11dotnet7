using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Shared;

public class DVDPlayer : IPlayable
{
    public void Pause()
    {
        WriteLine("DVD player paused");
    }

    public void Play()
    {
        WriteLine("DVD player plays");
    }


}
