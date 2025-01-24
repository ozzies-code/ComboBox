# Project Title: ComboBox
 
 Este proyecto consiste en agregar los valores en un campo de texto
 a un combobox para luego emplear la propiedad SelectedItem que 
 traera un MsgBox con los datos de los campos de texto.


# Descripcion

 Este proyecto consiste en el desarrollo de una aplicacion que 
 presenta una serie de cammpos en un formulario para ser relle
 nados por el usuario: Nombres, Telefono, Correo y Num Id. 
 Una vez rellenados y al hacer click en el boton Agregar
 se anexa el Num Id del Usuario al Combo Box y al seleccionarlo 
 se activa la propiedad SelectedItem que permitira mostrar a 
 traves de un cuadro de mensaje los datos que fueron rellenados 
 por el usuario en los campos de texto.
 
 # Actualizacion: 23/01/2025
 # Hora: 22:05

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

## Autores

- [@ozzies-code](https://www.github.com/ozzies-code)

## Contribuciones

¡Las contribuciones son siempre bienvenidas!

Consulta `contributing.md` para conocer cómo comenzar.

Por favor, respeta el `código de conducta` de este proyecto.

## Despliegue

Para implementar este proyecto, descargue los archivos del proyecto
del repositorio y el código del proyecto que se encuentra
en el archivo README.md

## 🚀 Acerca de Mi
Soy un apasionado desarrollador fullstack de Venezuela 🇻🇪 y Países Bajos 🇳🇱


🔭 Actualmente estoy trabajando en .NET Framework

🔭 Actualmente estoy trabajando en desarrollo web

🔭 Actualmente estoy trabajando en proyectos de .Console

🔭 Actualmente estoy trabajando en bases de datos .SQL

🌱 Actualmente estoy aprendiendo sobre frameworks, cursos, tutoriales y libros electrónicos

💬 Pregúntame sobre desarrollo de software

📫 Cómo contactarme oswaldojmp.nl@proton.me

👨‍💻 Todos mis proyectos están disponibles en https://developerandtechnologyozziescode.blogspot.com/ (mi sitio web)

📝 Escribo artículos regularmente en Medium.com/Ozzies.Code

    ## 🔗 Links
[![portfolio](https://img.shields.io/badge/my_portfolio-000?style=for-the-badge&logo=ko-fi&logoColor=white)]( https://developerandtechnologyozziescode.blogspot.com)
[![linkedin](https://img.shields.io/badge/linkedin-0A66C2?style=for-the-badge&logo=linkedin&logoColor=white)](www.linkedin.com/in/oswaldo-jesús-marín-pagés-ab4499a4)
[![twitter](https://img.shields.io/badge/twitter-1DA1F2?style=for-the-badge&logo=twitter&logoColor=white)](https://twitter.com/ozzies_code)

## Lecciones Aprendidas

- Manejo del ComboBox
- eventos del ComboBox
- logica de programacion

## image of the Project

![imagen](https://github.com/user-attachments/assets/cc37574e-0501-4e3d-8fea-34222011a24c)

## Soporte

Para soporte, email oswaldojmp.nl@proton.me

## Pila de tecnología

**Plataforma:** Visual studio 2022

**Lenguaje:** Visual Basic.NET

Codigo del Proyecto:

Public Class Form1

    Dim listaPersona As New List(Of Persona) 'Lista de Persona

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        'Valida que los campos no esten vacios
        'Si los campos no estan vacios, crea un objeto de la clase Persona y lo agrega a la lista de Persona
        'Agrega el numero de identificacion de la persona a un ComboBox
        'Limpia los campos de texto
        'Si los campos estan vacios, muestra un mensaje de advertencia


        If txtNombres.Text <> "" And txtnumId.Text <> "" And txtEmail.Text <> "" And txtTelefono.Text <> "" Then

            Dim p As New Persona(txtNombres.Text, txtnumId.Text, txtTelefono.Text, txtEmail.Text)

            listaPersona.Add(p)

            cmbPersonas.Items.Add(txtnumId.Text)

            txtNombres.Clear()
            txtnumId.Clear()
            txtTelefono.Clear()
            txtEmail.Clear()

        Else
            MsgBox("Faltan datos por ingresar")
        End If
    End Sub

    Private Sub cmbPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbPersonas.SelectedIndexChanged

        'obtiene el Id de la persona del Combo box a traves de la propiedad SelectedItem
        'Recorre la lista de Persona y compara el Id de la persona seleccionada en el combo box con el Id de la persona en la lista
        'Si los Id son iguales, muestra los datos de la persona en un mensaje

        Dim numIdPersonas As String = cmbPersonas.SelectedItem.ToString

        For i = 0 To listaPersona.Count - 1 Step 1

            If numIdPersonas.Equals(listaPersona.Item(i).NumIdentificacion_Persona) Then
                MsgBox(listaPersona.Item(i).ToString)

                Exit For
            End If
        Next
    End Sub

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

End Class
