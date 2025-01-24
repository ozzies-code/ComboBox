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
End Class
