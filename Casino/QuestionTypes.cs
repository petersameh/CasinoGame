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
        public enum Category
        {
            [Description("Trivia")]
            Trivia = 1,
            [Description("Reversed Words")]
            ReversedWords = 2,
            [Description("اغنية المشهد")]
            SongInScene = 3,
            [Description("سمعني صوتك")]
            Song = 4,
            [Description("Flags")]
            Flags = 5,
            [Description("افشات افلام")]
            Jokes = 6,
            [Description("Recognize the sound")]
            Music = 7,
            [Description("مين الفنان")]
            Actors = 8
        }
    }

}
