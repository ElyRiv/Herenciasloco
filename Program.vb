Imports System

Module Program

    Public Class Vehiculos

        Public Llantas As Integer
        Public Motor As Integer
        Public HP As Integer
        Public Alerones As String
        Public Auto As String
        Public Avion As String


        Public Sub Aaa()

            Console.WriteLine("Este programa de herencia loco")
            Console.WriteLine("Menciona los cilindros del motor del auto")
            Motor = Console.ReadLine()

        End Sub


        Public Sub Mostrar()

            Console.WriteLine("Ahora vamos a ver que tan top es el motor")
            If Motor >= 6 Then
                Console.WriteLine("Demasiado bestia broee")

            Else
                Console.WriteLine("Un vehiculo ahorrador")

            End If

        End Sub

    End Class

    Public Class Avion

        Inherits Vehiculos

        Public Sub Ajo()

            Console.WriteLine("Introduce la cantidad de cilindros del motor del avion")
            Motor = Console.ReadLine()

        End Sub

        Public Sub mostrarr()

            If Motor >= 8 Then
                Console.WriteLine("Un avion tosco")

            Else
                Console.WriteLine("Un avioncito bro")

            End If

        End Sub

    End Class

    Public Class Lanchita

        Inherits Vehiculos

        Public Sub asa()

            Console.WriteLine("Ingresa los cil de la lanchita")
            Motor = Console.ReadLine()

        End Sub


        Public Sub mott()

            If Motor >= 4 Then
                Console.WriteLine("Lancha loca")
            Else
                Console.WriteLine("Lancha lenta")
            End If
        End Sub



    End Class
    Sub Main(args As String())

        Dim vehiculos1 As New Vehiculos()
        vehiculos1.Aaa()
        vehiculos1.Mostrar()

        Dim avion1 As New Avion()
        avion1.Ajo()
        avion1.mostrarr()

        Dim lancha1 As New Lanchita()
        lancha1.asa()
        lancha1.mott



    End Sub
End Module
