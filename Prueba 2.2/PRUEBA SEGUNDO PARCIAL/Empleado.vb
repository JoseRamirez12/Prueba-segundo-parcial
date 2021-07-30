Public Class Empleado
    Inherits Persona
    ' Atributos
    Public TipoContrato As String
    Public Sueldo As Double
    'propiedades
    Public Property TC As String
        Get
            Return TipoContrato
        End Get
        Set(value As String)
            TipoContrato = value
        End Set
    End Property
    Public Property S As Double
        Get
            Return Sueldo
        End Get
        Set(value As Double)
            Sueldo = value
        End Set
    End Property
    ' Operaciones
    Public Sub CalcularElSueldo(sueldobase As Double)
        If (Me.TipoContrato = "NUEVO") Then
            Me.Sueldo = sueldobase + 400
        ElseIf (Me.TipoContrato = "ANTIGUO") Then
            Me.Sueldo = sueldobase + 750
        Else
            Me.Sueldo = 0
        End If
    End Sub
End Class
