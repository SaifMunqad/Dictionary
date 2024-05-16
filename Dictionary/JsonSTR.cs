using System.Collections.Generic;
namespace Dictionary
{

    public class JsonSTR
        {
            public string Word;
            public string Phonetic;
            public List<PhoneticInfo> Phonetics;
            public string Origin;
            public List<Meaning> Meanings;
        }

        public class PhoneticInfo
        {
            public string Text;
            public string Audio;
        }

        public class Meaning
        {
            public string PartOfSpeech;
            public List<DefinitionInfo> Definitions;
        }

        public class DefinitionInfo
        {
            public string Definition;
            public string Example;
            public List<string> Synonyms;
            public List<string> Antonyms;
        }
    }

