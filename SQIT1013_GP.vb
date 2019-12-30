Public Class Form1
    Private Sub Table1BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Table1BindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Table1BindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.WaterDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'WaterDataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.WaterDataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.MovePrevious()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.AddNew()
        Table1TableAdapter.Update(WaterDataSet)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource.MoveNext()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            Table1BindingSource.EndEdit()
            TableAdapterManager.UpdateAll(WaterDataSet)
            MessageBox.Show("Data has been recorded")
        Catch Ex As Exception
            MessageBox.Show("An error occured! Please try again.")
        End Try

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Table1BindingSource.RemoveCurrent()
        Table1TableAdapter.Update(WaterDataSet)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Form2.Show()

    End Sub
End Class