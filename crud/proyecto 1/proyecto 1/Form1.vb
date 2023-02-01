Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Form1
    Dim con As New SqlConnection(My.Settings.crut)
    Dim da As New SqlCommand
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click
        If txt_usuario.Text = "Batres" And txt_contraseña.Text = "123A" Then
            Me.Hide()
            Admin.ShowDialog()
        Else
            If txt_usuario.Text = "Jairo" And txt_contraseña.Text = "123B" Then
                Me.Hide()
                Secretario.ShowDialog()
            Else
                If txt_usuario.Text = "Melvin" And txt_contraseña.Text = "123C" Then
                    Cliente.ShowDialog()
                End If
            End If
            End If
    End Sub
End Class
