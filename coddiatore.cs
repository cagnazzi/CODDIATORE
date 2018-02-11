using System;
using System.Threading;
using System.Speech.Synthesis;

namespace CODDIATORE
{
  class Program
  {
    static void Main(string[] args)
    {
      SpeechSynthesizer synth = new SpeechSynthesizer();
      synth.SetOutputToDefaultAudioDevice();
      Console.WriteLine("CODDIATORE is 4 you with <3");
      while(1)
      {
        synth.Speak("porco dio!");
        Thread.Sleep(500);
      }
    }
  }
}
