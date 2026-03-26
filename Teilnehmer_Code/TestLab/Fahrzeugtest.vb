Imports Fahrzeugpark
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace TestLab
    <TestClass>
    Public Class Fahrzeugtest
        <TestMethod>
        Sub MotorAN()

            Dim pkw1 = New PKW("Jeep", 200, 60000.0, 190, False, 5, 4)

            pkw1.StarteMotor()

            Assert.IsTrue(pkw1.Zustand)

        End Sub

        <TestMethod>
        Sub MotorAUS()

            Dim pkw1 = New PKW("Jeep", 200, 60000.0, 190, False, 5, 4)

            pkw1.StarteMotor()
            pkw1.StoppeMotor()

            Assert.IsFalse(pkw1.Zustand)

        End Sub

        <TestMethod>
        Sub Beschleunige_ueber_maxG()

            Dim pkw1 = New PKW("Jeep", 200, 60000.0, 190, False, 5, 4)

            pkw1.StarteMotor()
            pkw1.Beschleunige(pkw1.maxGeschwindigkeit + 1)

            Assert.AreEqual(pkw1.maxGeschwindigkeit, pkw1.aktGeschwindigkeit)

        End Sub

        <TestMethod>
        Sub BeschreibeMich()

            Dim pkw1 = New PKW("Jeep", 200, 60000.0, 190, True, 5, 4)
            'Standardmäßig wird ein Double gerundet oder in das kürzeste Format ohne Nachkommastellen konvertiert, wenn keine Formatierung angegeben ist
            'VB.NET macht intern automatische Typkonvertierung (Double → String).
            'Deswegen müssen wir im Test einen Integer Wert angeben. Der Test ist damit nicht falsch 
            Dim zuTestenderString As String = "Das Auto Der Jeep,fährt maximal 200kmh,kostet 60000EURO,fährt aktuell 190kmh,mit gestartetem True Motor. Es hat 5 Türen und 4 Räder."

            Assert.AreEqual(zuTestenderString, pkw1.BeschreibeMich())

        End Sub
    End Class
End Namespace

