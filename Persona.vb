Public Class Persona

    'Miembros de Clase
    'Variables de Clase
    Private nombres As String
    Private numId As String
    Private telefono As String
    Private email As String

    Public Sub New(ByVal nom As String, ByVal nId As String, ByVal tel As String, ByVal e As String)
        'Constructor de la Clase
        nombres = nom
        numId = nId
        telefono = tel
        email = e
    End Sub

    Public ReadOnly Property Nombres_Persona As String
        Get
            Return nombres
        End Get
    End Property

    Public ReadOnly Property NumIdentificacion_Persona As String
        Get
            Return numId
        End Get
    End Property

    Public ReadOnly Property telefono_Persona As String
        Get
            Return telefono
        End Get
    End Property

    Public ReadOnly Property email_Persona As String
        Get
            Return email
        End Get
    End Property

    Public Overrides Function ToString() As String 'Se sobrescribe o personaliza el metodo ToString()
        Return nombres & " " & numId & " " & telefono & " " & email
    End Function

End Class
