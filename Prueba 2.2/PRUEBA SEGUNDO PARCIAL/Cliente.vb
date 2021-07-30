Public Class Cliente
    Inherits Persona
    'ATRIBUTOS
    Private _codigo As String
    Private _categoria As String
    'PROPIEDADES
    Public Property Categoria As String
        Get
            Return _categoria
        End Get
        Set(value As String)
            _categoria = value
        End Set
    End Property
    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property
    'OPERACIONES
    Public Sub generarCodigo()
        If Categoria = "GERENTE" Then
            Me.Codigo = "G" & ApellidoPaterno & " "
        ElseIf Categoria = "CONTADOR" Then
            Me.Codigo = "C" & ApellidoPaterno & " "
        End If
    End Sub

End Class
