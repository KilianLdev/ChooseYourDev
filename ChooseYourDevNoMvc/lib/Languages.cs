using System;
using System.Collections.Generic;

namespace lib {
    public abstract class Languages {
        private string languageName;
        private string editor;
        private List<string> ideNames = new List<string>(); 

        public string LanguageName { get; set; }
        public string Editor { get; set; }
        public List<string> IdeNames { 
            get {
                return this.ideNames;
            }
            set {
                this.ideNames = value;
            }
        }
    }
}