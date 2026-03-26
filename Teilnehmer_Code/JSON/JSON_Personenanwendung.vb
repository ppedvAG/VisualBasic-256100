Imports System.IO
Imports Newtonsoft.Json

Public Class JSON_Personenanwendung
    Private Sub NeuButton_Click(sender As Object, e As EventArgs) Handles NeuButton.Click
        Personenliste.Items.Add(CreateNewPerson())

    End Sub

    Private Sub LöschenButton_Click(sender As Object, e As EventArgs) Handles LöschenButton.Click
        DeletePerson(Personenliste.SelectedItem)

    End Sub

    Private Sub SpeichernButton_Click(sender As Object, e As EventArgs) Handles SpeichernButton.Click
        SavePeople(Personenliste.Items)

    End Sub

    Private Sub LadenButton_Click(sender As Object, e As EventArgs) Handles LadenButton.Click
        Personenliste.Items.Clear()
        For Each person In LoadPeople()
            Personenliste.Items.Add(person)
        Next

    End Sub

    Private generator As Random = New Random()

    Private Function CreateNewPerson() As PersonJSON
        Dim name As String = String.Empty

        Select Case generator.Next(1, 5)
            Case 1
                name = "Anna Nass"
            Case 2
                name = "Rainer Zufall"
            Case 3
                name = "Gerda Johanna"
            Case 4
                name = "Hugo Hasenfuss"
        End Select

        Dim geburtsdatum As DateTime = New DateTime(
            generator.Next(1920, 1999),
            generator.Next(1, 13),
            generator.Next(1, 29)
     )

        Return New PersonJSON(name, generator.Next(120, 195), geburtsdatum)

    End Function

    Private Sub DeletePerson(person As PersonJSON)
        Personenliste.Items.Remove(person)
    End Sub

    Private Sub SavePeople(liste As IList)
        Dim writer As StreamWriter

        Try
            writer = New StreamWriter("Personenliste.txt")
            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            For Each person In liste
                Dim personAsString As String = JsonConvert.SerializeObject(person, settings)
                writer.WriteLine(personAsString)
            Next

            MessageBox.Show("Speichern erfolgreich")


        Catch ex As Exception
            MessageBox.Show("Speichern fehlgeschlagen")

        Finally
            writer?.Close()
        End Try

    End Sub

    Private Function LoadPeople() As List(Of PersonJSON)
        Dim personenliste As List(Of PersonJSON) = New List(Of PersonJSON)
        Dim reader As StreamReader

        Try
            reader = New StreamReader("Personenliste.txt")

            Dim settings As JsonSerializerSettings = New JsonSerializerSettings()
            settings.TypeNameHandling = TypeNameHandling.Objects

            While Not reader.EndOfStream
                personenliste.Add(
                    JsonConvert.DeserializeObject(Of PersonJSON)(reader.ReadLine(), settings)
                    )
            End While

            MessageBox.Show("Laden erfolgreich")

        Catch ex As Exception

            MessageBox.Show("Laden fehlgeschlagen")

        Finally
            reader?.Close()

        End Try

        Return personenliste

    End Function

End Class
