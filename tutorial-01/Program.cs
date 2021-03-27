using System;

namespace InteractiveScript
{
    class Program
    {
        // Mit der Main-Methode startet jedes C#-Programm.
        static void Main(string[] args)
        {
            // Deklaration einer Variable vom Datentyp "Pirat"
            Pirate jack;

            // Zuweisung eines Wert zur Variable "jack".
            // Ein neues Objekt erzeugen mit: "new" Schlüsselwort und () hinter dem Klassennamen.
            jack = new Pirate();
            jack.name = "Jack";
            jack.age = 21;
            jack.hat = new Hat();
            jack.hat.color = "brown";

            // Ein neues Objekt der gleichen Klasse erzeugen.
            // Deklaration und Initialisierung der Variable "joe" auf der gleichen Zeile.
            Pirate joe = new Pirate();
            joe.name = "Joe";
            joe.age = 17;
            joe.hat = null; // null ist ein spezieller Wert für die Aussage: "Kein Wert"

            Console.WriteLine(jack);    // Gibt den Klassennamen (mit namespace) aus.

            // Zugriff auf eine Eigenschaft des Objekts mit dem Punkt-Operator (.).
            Console.WriteLine(joe.name);
            Console.WriteLine(jack.hat.color);
            // Die übernächste Zeile erzeugt eine NullReferenceException:
            // Zugriff auf einen Wert, der nicht existiert (Wert = null).
            // Console.WriteLine(joe.hat.color);    // Fehler!
        }
    }

}