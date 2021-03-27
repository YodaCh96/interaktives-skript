namespace InteractiveScript
{
    // Mit dem Schlüsselwort "class" kann eine neue Klasse definiert werden.
    // Namen von Klassen werden üblicherweise mit einem Grossbuchstaben geschrieben.
    class Pirate
    {
        // Zwischen den Klammern { und } werden die "Member" einer Klasse aufgelistet.

        // Eine "Eigenschaft" besteht aus:
        //  - Zugriffsmodifizierer (public)
        //  - Datentyp (string)
        //  - Name der Eigenschaft (name)
        public string name;

        // Alter des Piraten. Angabe in Jahren.
        public int age;

        // Hut, welcher der Pirat trägt.
        public Hat hat;

        // Liebespartner eines Piraten. Kann auch NULL sein!
        public Pirate partner;

        // Gang, in welcher der Pirat Mitglied ist. Darf NICHT NULL sein.
        public Gang gang;

        // Schiff auf welchem der Pirat durch die Meere kreuzt. Kann auch NULL sein.
        public Ship ship;

        // Waffe, mit welchen der Pirat sich so seine Zeit vertreibt.
        public Weapon[] weapons;

        // Dies ist ein Konstruktor für die Klasse Pirate.
        // Ein Konstruktor besteht aus:
        //  - Zugriffsmodifizierer (public)
        //  - Einem Namen, der gleich ist wie der Name der Klasse
        //  - Parameterliste zwischen den runden Klammern () (optional)
        //  - Inhalt (Body) des Konstruktors mit Programmlogik (Anweisungen)
        public Pirate(string name)
        {
            // Mit dem "this" Schlüsselwort kann das jeweils "aktive Objekt" referenziert werden.
            this.name = name;
        }

        // Konstruktor mit zwei Parametern.
        // Vor der Ausführung dieses Konstruktors, wird ein anderer Konstruktor ausgeführt: this(nameOfPirate)
        // Der andere Konstruktor wird anhand der Parameterliste bestimmt (hier: 1 string-Parameter)
        public Pirate(string nameOfPirate, string colorOfHat) : this(nameOfPirate)
        {
            // Hier kann auf das this Schlüsselwort verzichtet werden.
            // Grund: Es gibt keine lokale Variable und keinen Parameter mit dem gleichen Namen.
            name = "Captain " + nameOfPirate;    // Dies ist nicht mehr notwendig. Grund: Konstruktorenverkettung

            // Mit der Information aus dem Parameter "colorOfHat" wird hier ein neues Objekt vom
            // Typ Hat erzeugt und der Eigenschaft hat des neu erzeugen Piraten zugewiesen.
            Hat hat = new Hat();
            hat.color = colorOfHat;
            this.hat = hat;

            // Inhaltlich genau gleich wie oben - jedoch ohne Verwendung einer lokalen Variable.
            this.hat = new Hat();
            this.hat.color = colorOfHat;
        }

        // Dies ist der Standard-Konstruktor (ohne Parameter).
        // Dieser wird vom Compiler automatisch in jede Klasse eingefügt,
        // welche KEINEN ANDEREN KONSTRUKTOR hat.
        // Einen Standard-Konstruktor können sie mit der Abkürzung ctor (TAB, TAB) erstellen.
        public Pirate() { }
    }

}