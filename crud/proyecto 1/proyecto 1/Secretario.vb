Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class Secretario
    Dim con As New SqlConnection(My.Settings.crut)
    Dim mensaje, sentencia As String
    Sub EjecutarSQL(ByVal sql As String, ByVal msg As String)
        Try
            Dim cmd As New SqlCommand(sql, con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox(msg)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim da As New SqlDataAdapter("select * from Empresa where usuario = '" + txt_usuario.Text + "'", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.dtgv1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_mostrar_Click(sender As Object, e As EventArgs) Handles btn_mostrar.Click
        Dim da As New SqlDataAdapter("select * from Empresa ", con)
        Dim ds As New DataSet
        da.Fill(ds)
        Me.dtgv1.DataSource = ds.Tables(0)
    End Sub

    Private Sub btn_regresar_Click(sender As Object, e As EventArgs) Handles btn_regresar.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        sentencia = "Update Empresa set usuario ='" + txt_usuario.Text + "',contraseña ='" + txt_contraseña.Text + "',rol = '" + txt_rol.Text + "' where ID = '" + txt_id.Text + "'"
        mensaje = "Datos Actualizados Hasta la proxima"
        EjecutarSQL(sentencia, mensaje)
        Try
            Dim da As New SqlDataAdapter("Select * from Empresa", con)
            Dim ds As New DataSet
            da.Fill(ds)
            Me.dtgv1.DataSource = ds.Tables(0)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class