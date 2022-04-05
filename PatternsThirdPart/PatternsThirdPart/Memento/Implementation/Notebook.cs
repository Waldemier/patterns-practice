using System.Collections.Generic;
using System.Linq;

namespace PatternsThirdPart.Memento.Implementation
{
    public class Notebook
    {
        protected List<NotebookMemento> History { get; } 
        protected class NotebookMemento : Memento
        {
            private readonly string _note;
            public NotebookMemento(string note)
            {
                _note = note;
            }

            public override string GetState()
            {
                return _note;
            }
        }

        public Notebook()
        {
            History = new List<NotebookMemento>();
        }

        public virtual void Save(string note)
        {
            History.Add(new NotebookMemento(note));
        }

        public virtual void Restore()
        {
            if(History.Count > 0)
            {
                var memento = History.Last();
                History.Remove(memento);
            }
        }

        public virtual void ShowHistory()
        {
            foreach(var memento in History)
            {
                System.Console.WriteLine(memento.GetState());
            }
        }
    }
}
