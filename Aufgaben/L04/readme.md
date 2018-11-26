# Dokumentation

## To Do's
-  Continue /Pause - Pause und weiter<br>
    Step Over - eine Programmzeile ausführen und dann anhalten<br>
    Step Into - in eine Funktion springen und dort anhalten<br>
    Step Out - aus der aktuellen Funktion springen und dann anhalten<br>
    Restart - Wiederholen / Von Anfang<br>
    Stop - Stop<br>

- Nach 5 mal wird mein Debugging gestoppt


```c#
Person[] personList = new Person[5];
personList[0] = new Person { FirstName = "Beyza ", LastName = "Altintas ", Age = 25 };

verändert zu

Person[] personList = new Person[5];
            personList[0] = new Person { FirstName = "Visual Stuio ", LastName = "Code ", Age = 2016 };
```

Vorteile:
+ Printf-Debugging, kannst du über Consolenausgaben nachschauen, ob das Programm in der richtigen Methode oder if-Bedingung ist.
+ Variablen Ausgabe direkt in der Console

Nachteile: 
+ Mehr Code/Schreibaufwand
+ Die Debugg-Eingaben müssen am Ende wieder gelöscht werden.

Logging: Damit kann meine eine Logg-File anlegen.


