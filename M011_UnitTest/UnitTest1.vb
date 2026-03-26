Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Fahrzeugpark

Namespace UnitTest_Fahrzeugpark

    'UNIT-TESTS sind simple Überprüfungen, mit denen kleine Programmteile über längere Zeit auf ihre korrekte
    ''Funktionalität hin überprüft werden können. Ausgeführt werden diese über das 'Test'-Menü
    <TestClass>
    Public Class UnitTest_PKW

        <TestMethod>
        Sub Beschleunige_ueber_MaxG()

            'Triple A Prinzip Unit Tests
            'Arrange → Test vorbereiten
            'Act → Aktion ausführen
            'Assert → Ergebnis prüfen

            Dim pkw1 = New PKW("BMW", 280, 30000, 5)

            pkw1.StarteMotor()
            pkw1.Beschleunige(pkw1.MaxGeschwindigkeit + 1)

            'Jede TestMethod muss mindestens einen Zugriff auf die Assert-Klasse nehmen, mit deren Methoden die
            ''zu überprüfenden Programmteile getestet werden. Ein Test gilt als erfolgreich, wenn alle Assert-Methoden
            ''in einer TestMethod ein true zurückgeben.
            Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit)

        End Sub

        <TestMethod>
        Sub Bremse_unter_0()

            Dim pkw1 = New PKW("BMW", 280, 30000, 5)

            pkw1.StarteMotor()
            pkw1.Beschleunige(50)
            'Das Minus vor dem pkw1.AktGeschwindigkeit macht es zu einer negativen Zahl
            pkw1.Beschleunige(-pkw1.AktGeschwindigkeit - 1)

            Assert.AreEqual(0, pkw1.AktGeschwindigkeit)

        End Sub

    End Class

End Namespace

