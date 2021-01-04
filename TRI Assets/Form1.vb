Public Class Form1
    Private Sub AssetTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AssetTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRIAssets)

    End Sub

    Private Sub AssetTableBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles AssetTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AssetTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TRIAssets)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TRIAssets.AssetTable' table. You can move, or remove it, as needed.
        Me.AssetTableTableAdapter.Fill(Me.TRIAssets.AssetTable)

        If First_NameTextBox.Text = Nothing Then
            Try
                AssetTableBindingSource.AddNew()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Me.Validate()
            Me.AssetTableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.TRIAssets)
            MessageBox.Show("The form has been added!")
            AssetTableBindingSource.AddNew()
            First_NameTextBox.Select()
        Catch ex As Exception
            MessageBox.Show("There was an error adding to the form please fill in more information")



        End Try
    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click

    End Sub

    Private Sub btnNEW_Click(sender As Object, e As EventArgs) Handles btnNEW.Click

        Try
            AssetTableBindingSource.AddNew()
            First_NameTextBox.Select()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Select Case MsgBox("Are you sure you want to delete asset?", MsgBoxStyle.YesNo, "Are you sure?")
            Case MsgBoxResult.Yes
                Try
                    AssetTableBindingSource.RemoveCurrent()

                Catch ex As Exception
                    MessageBox.Show(ex.Message)

                End Try
            Case MsgBoxResult.No
                'nothing'
        End Select
    End Sub

    Private Sub RamListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RamListBox.SelectedIndexChanged

    End Sub
End Class
