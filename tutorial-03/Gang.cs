using System.Linq;

namespace InteractiveScript
{
    class Gang
    {
        private string name;

        private Pirate leader;
        public Pirate[] members;

        // Selber implementierte, write-only Property mit Backing Field
        public Pirate Leader
        {
            set
            {
                // Um Leader einer Gang zu sein, ist die Mitgliedschaft in der Gang erforderlich:
                // value (Wert der Zuweisungs-Operation; designierter Leader)
                // wird nur als Leader eingesetzt, wenn dieser Mitglied der Gang ist.
                if (members.Contains(value))
                {
                    leader = value;
                }
            }
        }

        // Selber implementierte, read-only Property ohne Backing Field
        public int MemberCount
        {
            get => members.Length;
        }

        // Automatisch implemntierte, read-write Property
        public string Territory { get; set; }
    }
}