'Ein INTERFACE ist eine Maske, welche die Signaturen von Properties und Methoden enthält. Diese kann in Klassen
''implementiert werden, welche dann durch das Interface gezwungenen werden die Properties und Methoden ebenfalls
''implementieren. Klassenobjekte können auch immer als Objekte des Interfaces betrachtet werden.
''vgl PKW und Flugzeug für Implementierung
Public Interface IBerädert

    'Ähnlich wie bei abstrakten Methoden werden auch in Interfaces nur die Signaturen der Properties und Methoden
    ''definiert. Die Körper werden dann erst in den implentierenden Klassen hinzugefügt.
    Property AnzahlRäder As Integer

    Sub BaueUnfall()

End Interface
