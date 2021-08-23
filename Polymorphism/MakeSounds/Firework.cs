using System;

namespace MakeSounds
{
    public class Firework: ISound
    {
        public string PlaySound()
        {
            return "whoosh-bang";
        }
    }
}