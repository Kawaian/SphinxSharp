using Pocketsphinx;
using System;
using System.IO;

namespace SphinxSharp.Test.Windows
{
    class PInvokeTest
    {
        static void Main(string[] args)
        {
            Config c = Decoder.default_config();
            c.set_string("-hmm", "../../model/en-us/en-us");
            c.set_string("-lm", "../../model/en-us/en-us.lm.bin");
            c.set_string("-dict", "../../model/en-us/cmudict-en-us.dict");
            Decoder d = new Decoder(c);
        }
    }
}
