Imports System.Data.SqlClient
Imports System.Numerics

Public Class Form1
    Dim connectionString As String = "Server=LAPTOP-0UJEF04J;Initial Catalog=CRUD;Integrated Security=True"

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles BtnInsert.Click
        Try
            'Variable Declaration
            Dim id As Integer = Integer.Parse(TxtId.Text)
            Dim pname As String = TxtItemName.Text
            Dim design As String = TxtDesign.Text
            Dim color As String = TxtColor.Text
            Dim insertdate As DateTime = DateTime.Parse(DateTimesPicker.Text)
            Dim wtype As String = "Not defined"

            If RadioAllowed.Checked Then
                wtype = "Allowed"
            ElseIf RadioNotAllowed.Checked Then
                wtype = "Not Allowed"
            End If

            'Inserting to the database
            Using con As New SqlConnection(connectionString)
                Using command As New SqlCommand("Insert into Product_table Values('" & id & "', '" & pname & "', '" & design & "', '" & color & "','" & insertdate & "', '" & wtype & "')", con)
                    command.Parameters.AddWithValue("@Id", id)
                    command.Parameters.AddWithValue("@ProductName", pname)
                    command.Parameters.AddWithValue("@Design", design)
                    command.Parameters.AddWithValue("@Color", color)
                    command.Parameters.AddWithValue("@InsertDate", insertdate)
                    command.Parameters.AddWithValue("@WarrentyType", wtype)

                    con.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Successfully inserted.")
            LoadDataInGrid()
            Emptyinputs()
        Catch ex As Exception

            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub LoadDataInGrid()
        Try
            Using con As New SqlConnection(connectionString)
                Using command As New SqlCommand("SELECT * FROM Product_table ", con)
                    Dim sda As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    sda.Fill(dt)
                    DataGridView.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
    Public Sub Emptyinputs()
        'To empty textbbox and combobox
        TxtId.Clear()
        TxtItemName.Clear()
        TxtDesign.Clear()
        TxtColor.SelectedIndex = "-1"
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDataInGrid()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        Try
            Dim id As Integer = Integer.Parse(TxtId.Text)
            Dim pname As String = TxtItemName.Text
            Dim design As String = TxtDesign.Text
            Dim color As String = TxtColor.Text
            Dim insertdate As DateTime = DateTime.Parse(DateTimesPicker.Text)
            Dim wtype As String = "Not defined"

            If RadioAllowed.Checked Then
                wtype = "Allowed"
            ElseIf RadioNotAllowed.Checked Then
                wtype = "Not Allowed"
            End If

            Using con As New SqlConnection(connectionString)

                Using command As New SqlCommand("Update Product_table Set [Product Name] = '" & pname & "', Design = '" & design & "', Color = '" & color & "', Date = '" & insertdate & "', Warrenty = '" & wtype & "' where ID = '" & id & "'", con)
                    command.Parameters.AddWithValue("@Id", id)
                    command.Parameters.AddWithValue("@ProductName", pname)
                    command.Parameters.AddWithValue("@Design", design)
                    command.Parameters.AddWithValue("@Color", color)
                    command.Parameters.AddWithValue("@InsertDate", insertdate)
                    command.Parameters.AddWithValue("@WarrentyType", wtype)

                    con.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Updated inserted.")
            LoadDataInGrid()
            Emptyinputs()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadDataInGrid()

    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim id As Integer = Integer.Parse(TxtId.Text)

            Using con As New SqlConnection(connectionString)
                Using command As New SqlCommand("SELECT * FROM Product_table WHERE id = @id", con)
                    command.Parameters.AddWithValue("@Id", id)
                    Dim sda As New SqlDataAdapter(command)
                    Dim dt As New DataTable
                    sda.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        DataGridView.DataSource = dt
                        con.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("Search success.")
                    Else
                        DataGridView.DataSource = Nothing
                        'DataGridView.Rows.Clear()
                        MessageBox.Show("ID not found!")
                    End If
                End Using
            End Using


        Catch ex As Exception
            MessageBox.Show("Incorrect Id format.")
        End Try
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Try
            Dim id As Integer = Integer.Parse(TxtId.Text)

            Using con As New SqlConnection(connectionString)
                Using command As New SqlCommand("DELETE Product_table WHERE id = @id", con)
                    command.Parameters.AddWithValue("@Id", id)

                    con.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Successfully Deleted.")
        Catch ex As Exception
            MessageBox.Show("Unable to Delete.")
        End Try
    End Sub
    Private Sub Emptytable()
        DataGridView.Rows.Clear()
    End Sub
End Class
