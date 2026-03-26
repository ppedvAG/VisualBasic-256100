Imports System
Imports Fahrzeugpark

Module Program
    Sub Main(args As String())
        'Dim fz1 As Fahrzeug = New Fahrzeug("Jeep", 200, 60000.0, 190, True)

        'Console.WriteLine(fz1.Name)
        'Console.WriteLine(fz1.maxGeschwindigkeit)
        'Console.WriteLine(fz1.Preis)
        'Console.WriteLine(fz1.aktGeschwindigkeit)
        'Console.WriteLine(fz1.Zustand)



        'fz1.Beschreibemich()
        'fz1.StoppeMotor()
        'fz1.StarteMotor()

        'Dim pkw1 As PKW = New PKW("Jeep", 200, 60000.0, 190, True, 5, 4)

        'Console.WriteLine($"pkw1.BeschreibeMich(): {pkw1.BeschreibeMich()}")
        'Console.WriteLine($"pkw1: : {pkw1}")

        'Dim flugzeug1 As Flugzeug = New Flugzeug("Boing", 800, 6000000.0, 700, True, 2, 3)

        'Console.WriteLine($"flugzeug1.BeschreibeMich(): {flugzeug1.BeschreibeMich()}")
        'Console.WriteLine($"flugzeug1: : {flugzeug1}")

        'Dim schiff1 As Schiff = New Schiff("Swan", 60, 2000000.0, 40, True, 2)

        'Console.WriteLine($"schiff1.BeschreibeMich(): {schiff1.BeschreibeMich()}")
        'Console.WriteLine($"schiff1: : {schiff1}")

        'Fahrzeug.ZeigeAnzahlErstellterFahrzeuge()

        'schiff1.Belade(flugzeug1)
        'schiff1.Entlade()

        'Console.WriteLine(schiff1.BeschreibeMich())


        '-------------------------------------------Listenaufgabe
        Dim pkw1 As PKW = New PKW("Audi", 200, 60000.0, 190, True, 5, 4)
        Dim pkw2 As PKW = New PKW("BMW", 200, 60000.0, 190, True, 5, 4)
        Dim pkw3 As PKW = New PKW("Citroen", 200, 60000.0, 190, True, 5, 4)
        Dim pkw4 As PKW = New PKW("Dacia", 200, 60000.0, 190, True, 5, 4)
        Dim pkw5 As PKW = New PKW("Jaguar", 200, 60000.0, 190, True, 5, 4)
        Dim pkw6 As PKW = New PKW("Mercedes", 200, 60000.0, 190, True, 5, 4)
        Dim pkw7 As PKW = New PKW("Jeep", 200, 60000.0, 190, True, 5, 4)
        Dim pkw8 As PKW = New PKW("Suzuki", 200, 60000.0, 190, True, 5, 4)
        Dim pkw9 As PKW = New PKW("Toyota", 200, 60000.0, 190, True, 5, 4)
        Dim pkw10 As PKW = New PKW("VW", 200, 60000.0, 190, True, 5, 4)

        Dim dict As Dictionary(Of String, PKW) = New Dictionary(Of String, PKW)


        dict.Add("1", pkw1)
        dict.Add("2", pkw2)
        dict.Add("3", pkw3)
        dict.Add("4", pkw4)
        dict.Add("5", pkw5)
        dict.Add("6", pkw6)
        dict.Add("7", pkw7)
        dict.Add("8", pkw8)
        dict.Add("9", pkw9)
        dict.Add("10", pkw10)

        Dim stapel As New Stack(Of PKW)
        For Each zeile In dict
            stapel.Push(zeile.Value)
            Console.WriteLine($"PKW {zeile.Key} mit dem Namen {zeile.Value.Name} wurde hinzugefügt.")
        Next

        Dim warteschlange As New Queue(Of PKW)
        For Each pkw In stapel
            warteschlange.Enqueue(pkw)
            Console.WriteLine($"PKW mit dem Namen {pkw.Name} wurde hinzugefügt.")
        Next

        Dim liste As New List(Of PKW)
        For Each pkw In warteschlange
            liste.Add(pkw)
            Console.WriteLine($"PKW mit den Namen {pkw.Name} wurde hinzugefügt.")

        Next



    End Sub

End Module
