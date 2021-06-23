Public Class Form1

    Dim Servicio As New ServiceReference1.WebService1SoapClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Servicio.Listar().Tables(0)
    End Sub

    Private Sub Listaar()
        DataGridView1.DataSource = Servicio.Listar().Tables(0)
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If (txt1.Text = "" Or txt2.Text = "") Then
            MsgBox("Ingrese valores correctos ")
        Else
            Dim aea() As String
            aea = Servicio.Agregar(txt1.Text, txt2.Text)
            lbl2.Text = aea(0).ToString()
            lbl3.Text = aea(1).ToString()
            Listaar()
        End If
    End Sub


    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub

    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim aea() As String
        aea = Servicio.Actualizar(txt1.Text, txt2.Text)
        lbl2.Text = aea(0).ToString()
        lbl3.Text = aea(1).ToString()
        Listaar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim aea() As String
        aea = Servicio.Eliminar(txt1.Text)
        lbl2.Text = aea(0).ToString()
        lbl3.Text = aea(1).ToString()
        Listaar()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            DataGridView1.DataSource = Servicio.Buscar(txt1.Text, txt2.Text).Tables(0)

        Catch ex As Exception
            MessageBox.Show("No se encontraron resultados")
        End Try
    End Sub

    Private Sub txt1_TextChanged(sender As Object, e As EventArgs) Handles txt1.TextChanged

    End Sub

    Private Sub txt2_TextChanged(sender As Object, e As EventArgs) Handles txt2.TextChanged
        SoloLetras(e)
    End Sub
End Class