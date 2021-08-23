using System;

namespace MakeSounds
{
    public class Radio:ISound
    {
        public string PlaySound()
        {
            return "smooth-radio-voice";
        }
    }
}
