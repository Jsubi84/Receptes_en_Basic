
Public Class EditarRecepta
    Private Const V As Boolean = True


    'Afegir nova recepta
    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)
        ReceptaBindingSource.AddNew()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rutaImatge As String = directoriProjecte & "\" & ImatgeTextBox.Text

        'Carrega tot el document XML al dataset1
        If My.Computer.FileSystem.FileExists(directoriXML) = True Then
            DataSet1.ReadXml(directoriXML)
        End If

        'Carrega la primera imatge
        If System.IO.File.Exists(rutaImatge) Then
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(rutaImatge)
        Else
            Dim imgErr As String = rutaImatgeNOk
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(imgErr)
        End If

        'Fixem tamany del formulari
        Me.Size = New System.Drawing.Size(810, 610)

    End Sub

    'Guardar dades modificades
    Private Sub ReceptesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ReceptaBindingNavigatorSaveItem.Click
        Me.Validate()
        ReceptaBindingSource.EndEdit()
        DataSet1.WriteXml(directoriXML)

    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick

        OpenFileDialog1.Filter = "All Files|*.*"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then

            Dim img As String = My.Application.Info.DirectoryPath & "\" & System.IO.Path.GetFileName(OpenFileDialog1.FileName)

            PictureBox1.Image = System.Drawing.Bitmap.FromFile(img)
            ImatgeTextBox.Text = System.IO.Path.GetFileName(OpenFileDialog1.FileName)

        End If
    End Sub

    Private Sub ImageTextBox_TextChanged(sender As Object, e As EventArgs) Handles ImatgeTextBox.TextChanged

        Dim rutaImatge As String = directoriProjecte & "\" & ImatgeTextBox.Text

        If System.IO.File.Exists(rutaImatge) Then
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(rutaImatge)
        Else
            Dim imgErr As String = rutaImatgeNOk
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(imgErr)

        End If
    End Sub

    Private Sub SortirButton_Click(sender As Object, e As EventArgs) Handles SortirButton.Click
        If BindingNavigatorMovePreviousItem.Visible = True Then
            Dim Msg, Style, Title, Resposta
            Msg = "Estas segur que vols sortir sense grabar?"    ' Missatge
            Style = vbYesNo + vbInformation + vbDefaultButton2    ' botons
            Title = "GUARDAR INFORMACIÓ"    ' Titol

            Resposta = MsgBox(Msg, Style, Title)
            If Resposta = vbYes Then    ' Si 
                Me.Hide()
                Benvinguda.Show()
            End If
        Else
            Me.Hide()
            Benvinguda.Show()
        End If

    End Sub

    Private Sub EditarRecepta_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        ReceptaBindingSource.Position = idSeleccio - 1

        InhabilitarFormulari()
    End Sub

    Private Sub DificultatComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DificultatComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub CategoriaComboBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CategoriaComboBox.KeyPress
        e.Handled = True
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click


        If BindingNavigatorMovePreviousItem.Visible = True Then

            Dim Msg, Style, Title, Resposta
            Msg = "Sortir del mode edició sense guardar?"    ' Missatge
            Style = vbYesNo + vbInformation + vbDefaultButton2    ' botons
            Title = "GUARDAR INFORMACIÓ"    ' Titol

            Resposta = MsgBox(Msg, Style, Title)
            If Resposta = vbYes Then    ' Si 
                InhabilitarFormulari()
            End If

        Else

            BindingNavigatorMovePreviousItem.Visible = True
            BindingNavigatorMoveNextItem.Visible = True
            BindingNavigatorMoveLastItem.Visible = True
            BindingNavigatorMoveFirstItem.Visible = True
            BindingNavigatorSeparator.Visible = True
            BindingNavigatorSeparator1.Visible = True
            BindingNavigatorSeparator2.Visible = True
            BindingNavigatorPositionItem.Visible = True
            BindingNavigatorCountItem.Visible = True
            BindingNavigatorAddNewItem.Visible = True
            BindingNavigatorDeleteItem.Visible = True
            ReceptaBindingNavigatorSaveItem.Visible = True

            PreferitCheckBox.Enabled = True
            NomReceptaTextBox.Enabled = True
            NomReceptaTextBox.BorderStyle = BorderStyle.Fixed3D

            CategoriaComboBox.Enabled = True
            DificultatComboBox.Enabled = True
            RaccionsTextBox.Enabled = True
            ElaboracióTextBox.Enabled = True
            IngredientDataGridView.Enabled = True
            PictureBox1.Enabled = True

        End If
    End Sub


    Private Sub InhabilitarFormulari()
        BindingNavigatorMovePreviousItem.Visible = False
        BindingNavigatorMoveNextItem.Visible = False
        BindingNavigatorMoveLastItem.Visible = False
        BindingNavigatorMoveFirstItem.Visible = False
        BindingNavigatorSeparator.Visible = False
        BindingNavigatorSeparator1.Visible = False
        BindingNavigatorSeparator2.Visible = False
        BindingNavigatorPositionItem.Visible = False
        BindingNavigatorCountItem.Visible = False
        BindingNavigatorAddNewItem.Visible = False
        BindingNavigatorDeleteItem.Visible = False
        ReceptaBindingNavigatorSaveItem.Visible = False

        PreferitCheckBox.Enabled = False
        NomReceptaTextBox.Enabled = False
        NomReceptaTextBox.BorderStyle = BorderStyle.None

        CategoriaComboBox.Enabled = False
        DificultatComboBox.Enabled = False
        RaccionsTextBox.Enabled = False
        ElaboracióTextBox.Enabled = False
        IngredientDataGridView.Enabled = False
        PictureBox1.Enabled = False
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click

        Dim Msg, Style, Title, Resposta
        Msg = "Estas segur que vols borrar la recepta?"    ' Missatge
        Style = vbYesNo + vbCritical + vbDefaultButton2    ' botons
        Title = "ALERTA"    ' Titol

        Resposta = MsgBox(Msg, Style, Title)
        If Resposta = vbYes Then    ' Si 
            Me.Validate()
            ReceptaBindingSource.RemoveCurrent()
            DataSet1.WriteXml(directoriXML)
        Else    ' User chose No.
            MsgBox("No s'ha borrat la recepta", vbInformation, "INFORMACIO")
        End If

    End Sub
End Class

