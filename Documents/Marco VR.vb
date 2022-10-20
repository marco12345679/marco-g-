Public Class Form1
    Private Sub btn_Aceptar_Click(sender As Object, e As EventArgs) Handles btn_Aceptar.Click
        Dim usuario As String
        Dim contraseña As Integer
        usuario = txt_Usuario.Text
        contraseña = txt_Contraseña.Text
        If (usuario = "marco") And (contraseña = "123") Then
            Form2.Show()
        Else
            MsgBox(" Usuario o contraseña incorrecta ")
        End If
        txt_Usuario.Text = ""
        txt_Contraseña.Text = ""
    End Sub

    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub
End Class
