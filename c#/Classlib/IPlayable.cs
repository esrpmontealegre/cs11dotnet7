using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Class.Shared;

public interface IPlayable
{
    void Play ();
    void Pause();
    //Default interface implem
    void Stop()
    {
        WriteLine("Default ng Stop");
    }
}




