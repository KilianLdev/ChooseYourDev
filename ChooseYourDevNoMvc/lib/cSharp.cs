using System;
using System.Collections.Generic;

namespace lib {
    public class cSharp : Languages {
        public cSharp () {
            this.LanguageName = "C#";
            this.Editor = "Microsoft";
            this.IdeNames.Add("VSCode");
            this.IdeNames.Add("Visual Studio Community");
        }
    }
}