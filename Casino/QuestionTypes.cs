using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public static class QuestionTypes
    {
        public enum Types
        {
            [Description("Trivia")]
            Trivia = 1,
            [Description("Reversed Words")]
            ReversedWords = 2,
            [Description("Song in Scene")]
            SongInScene = 3,
            [Description("Song")]
            Song = 4,
            [Description("Flags")]
            Flags = 5
        }
    }

}
