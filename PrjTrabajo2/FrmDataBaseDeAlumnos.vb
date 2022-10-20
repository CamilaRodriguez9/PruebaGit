Imports MySql.Data.MySqlClient

Public Class FrmDataBaseDeAlumnos

    Public Vconn As MySqlConnection 'variable que almacena la conexión a la base de datos

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        Try
            'en el try se ejecutan las insrtruciones, si una de ellas da error entonces hace la acción que está en el catch

            'se crea un objeto de tipo ConnectionString
            Dim VconnString As New MySqlConnectionStringBuilder
            VconnString.Server = "localhost"
            VconnString.Database = "northwhind"
            VconnString.UserID = "root"
            VconnString.Password = "root"
            VconnString.IntegratedSecurity = False
            '
            '
            Vconn = New MySqlConnection(VconnString.ToString)
            Vconn.Open()
            MsgBox("Conexión realizada")
        Catch
            MsgBox("Error al conectarse", MsgBoxStyle.Critical)
        End Try


    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Vconn.Dispose()
        'Cierra la conexión con la BD y libera los recursos ultilizados
    End Sub
End Class
