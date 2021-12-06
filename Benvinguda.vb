
Public Class Benvinguda

    Public llistacbSelec As Boolean


    Private Sub Benvinguda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Mira que l'arxiu existeixi i el carrega
        DataSet1.Clear()
        CarregarXML()

    End Sub

    Private Sub Benvinguda_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        'Cada cop que tornem a formulari de Benvinguda tornem a carregar el dataset per actualitzar les dades
        DataSet1.Clear()
        CarregarXML()
    End Sub

    Private Sub CarregarXML()
        If My.Computer.FileSystem.FileExists(directoriXML) = True Then
            DataSet1.ReadXml(directoriXML)
        End If
    End Sub


    Private Sub BuscarButton_Click(sender As Object, e As EventArgs) Handles BuscarButton.Click

        ReIniciar()

        'Si es tria totes les receptes carrega totes les imatges de la coleccio
        If cbTriar.Text = "Totes les receptes" Then

            'Recupero dades de dataset1 i les poso en una taula per poder treballar
            taulaReceptes = DataSet1.Tables(0)
            Dim files As Integer = taulaReceptes.Rows.Count - 1

            'Array de picturebox tants com files hi ha
            ReDim PictureBox(files)
            ReDim Label(files)

            For index As Integer = 0 To taulaReceptes.Rows.Count - 1
                'Recuperem dades per fer presentació
                Dim ID As Integer = taulaReceptes.Rows(index).Item(0).ToString
                Dim Titol As String = taulaReceptes.Rows(index).Item(1).ToString
                Dim ruta As String = directoriProjecte & "\" & taulaReceptes.Rows(index).Item(3).ToString

                VisualitzarReceptes(index, ruta, Titol, ID)
            Next


            'Si s'escull Preferits només es mostraran els seleccionat com a preferits
        ElseIf cbTriar.Text = "Preferit" Then

            Dim criteriFiltre As String = "Preferit = true"
            FiltrarRecepta(criteriFiltre)

        ElseIf cbTriar.Text = "Nom recepta" Then
            Dim criteriFiltre As String = "NomRecepta LIKE '%" & cbSeleccio.Text & "%'"
            FiltrarRecepta(criteriFiltre)

        ElseIf cbTriar.Text = "Categoria" Then
            Dim criteriFiltre As String = "Categoria LIKE '%" & cbSeleccio.Text & "%'"
            FiltrarRecepta(criteriFiltre)

        ElseIf cbTriar.Text = "Raccions" Then
            Dim criteriFiltre As String = "Raccions = " & cbSeleccio.Text

            If IsNumeric(cbSeleccio.Text) Then
                FiltrarRecepta(criteriFiltre)
            Else
                MsgBox("Entrar un numero de raccions",, "ERROR ENTRADA DE DADES")
            End If


        ElseIf cbTriar.Text = "Dificultat" Then
            Dim criteriFiltre As String = "Dificultat LIKE '%" & cbSeleccio.Text & "%'"
            FiltrarRecepta(criteriFiltre)

        ElseIf cbTriar.Text = "Ingredients" Then
            Dim criteriFiltre As String = "Ingredients LIKE '" & cbSeleccio.Text & "%'"
            FiltrarIngredients(criteriFiltre)
        End If

    End Sub

    Private Sub CbTriar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTriar.SelectedIndexChanged

        'Reiniciem propietats
        cbSeleccio.Enabled = True
        llistacbSelec = True

        'Seleccio instruccions depenen de la opció
        If cbTriar.Text = "Totes les receptes" Then
            llistacbSelec = False
            CtlcbSeleccio()

        ElseIf cbTriar.Text = "Nom recepta" Then
            CtlcbSeleccio()
            cbSeleccio.Text = "Escriu nom de la recepta"

        ElseIf cbTriar.Text = "Categoria" Then
            CtlcbSeleccio()
            For Each item In EditarRecepta.CategoriaComboBox.Items
                cbSeleccio.Items.Add(item)
            Next
            cbSeleccio.Text = "Seleccioni opció de la llista"

        ElseIf cbTriar.Text = "Raccions" Then
            CtlcbSeleccio()
            cbSeleccio.Text = "Posa el numero de raccions"

        ElseIf cbTriar.Text = "Dificultat" Then
            CtlcbSeleccio()
            For Each item In EditarRecepta.DificultatComboBox.Items
                cbSeleccio.Items.Add(item)
            Next
            cbSeleccio.Text = "Seleccioni opció de la llista"

        ElseIf cbTriar.Text = "Preferit" Then
            llistacbSelec = False
            CtlcbSeleccio()

        ElseIf cbTriar.Text = "Ingredients" Then
            CtlcbSeleccio()
            cbSeleccio.Text = "Escriu l'ingredient que vol"
        ElseIf cbTriar.Text = "Sortir" Then
            End
        End If

    End Sub

    'Agrupar instruccions per al combobox de selecció
    Private Sub CtlcbSeleccio()

        cbSeleccio.Text = ""
        If llistacbSelec = False Then
            cbSeleccio.Enabled = False
        End If
        cbSeleccio.Items.Clear()

    End Sub


    'Event creat en runtime per a click de les picturebox creades en runtime
    Private Sub Picturebox_click(sender As Object, e As EventArgs)
        idSeleccio = CType(sender, PictureBox).Tag
        EditarRecepta.Show()
        Me.Hide()
    End Sub


    'Prohibeix escriure al combo box de triar opció
    Private Sub CbTriar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbTriar.KeyPress
        e.Handled = True
    End Sub

    'Carregar arxiu XML al DataSet
    Private Sub CarregaXML()
        If My.Computer.FileSystem.FileExists(directoriXML) = True Then
            DataSet1.ReadXml(directoriXML)
        End If
    End Sub

    'Reiniciem la visualització i eliminem els picuture box per poder torna-los a carregar amb
    'la nova selecció
    Private Sub ReIniciar()

        'Borrem tots els controls creats en runtime i recarregem
        Try
            For i As Integer = 0 To (PictureBox.Count - 1)
                PictureBox(i).Visible = False
                Label(i).Visible = False
            Next
        Catch e As Exception
            Exit Try
        End Try

        Dim obj As Object
        For Each obj In Me.Controls
            If obj Is PictureBox Then Me.Controls.Remove(obj)
            If obj Is Label Then Me.Controls.Remove(obj)
        Next

        Me.Refresh()

        'Reiniciem a la posició de la primera picturebox
        xloc = 46
        yloc = 110

    End Sub

    'Entra criteri de filtrartge per parametre
    'Extreiem dades de les diferents columnes ja filtrates
    'Visualització de les receptes en el formulari

    Private Sub FiltrarRecepta(filtre As String)

        Dim taulaBuscar As DataRow() = DataSet1.Tables.Item(0).Select(filtre)

        If taulaBuscar.Count <> 0 Then

            'Array de picturebox tants com files hi ha
            Dim files As Integer = taulaBuscar.Count - 1
            ReDim PictureBox(files)
            ReDim Label(files)

            For index As Integer = 0 To taulaBuscar.Count - 1
                'Recuperem dades per fer presentació
                Dim ID As Integer = taulaBuscar(index).Item(0).ToString
                Dim Titol As String = taulaBuscar(index).Item(1).ToString
                Dim ruta As String = directoriProjecte & "\" & taulaBuscar(index).Item(3).ToString

                VisualitzarReceptes(index, ruta, Titol, ID)
            Next
        Else
            MsgBox("No s'ha trobat cap resultat per aquesta busqueda",, "RESULTATS")
        End If

    End Sub


    Private Sub FiltrarIngredients(filtre As String)
        Try
            'Filtratge per ingredient
            Dim taulaBuscar As DataRow() = DataSet1.Tables.Item(1).Select(filtre)
            Dim filtreIng As String

            'Fem una taula buida per posar les receptes amb l'ingredient seleccionat
            ReceptesIng = DataSet1.Tables("Recepta").Clone
            ReceptesIng.Clear()

            If taulaBuscar.Count <> 0 Then

                'Pasem de les files d'ingredients a les files de recepta per mostrar-les
                For Each row In taulaBuscar
                    Dim noRepes As Integer = row.Item("Recepta")
                    Dim ultimaRecepta As Integer

                    If noRepes <> ultimaRecepta Then

                        filtreIng = "IDRecepta = " & row.Item("Recepta")
                        Dim fila As DataRow = DataSet1.Tables.Item("Recepta").Select(filtreIng)(0)
                        ReceptesIng.ImportRow(fila)

                    End If

                    ultimaRecepta = noRepes
                Next

                'Array de picturebox tants com files hi ha
                Dim files As Integer = ReceptesIng.Rows.Count - 1
                ReDim PictureBox(files)
                ReDim Label(files)

                'Extreiem les dades necesaries per la visualització i tractament
                If ReceptesIng.Rows.Count <> 0 Then
                    For index As Integer = 0 To ReceptesIng.Rows.Count - 1
                        'Recuperem dades per fer presentació
                        Dim ID As Integer = ReceptesIng.Rows(index).Item(0).ToString
                        Dim Titol As String = ReceptesIng.Rows(index).Item(1).ToString
                        Dim ruta As String = directoriProjecte & "\" & ReceptesIng.Rows(index).Item(3).ToString

                        VisualitzarReceptes(index, ruta, Titol, ID)
                    Next
                End If

            Else
                MsgBox("No s'ha trobat cap resultat per aquesta busqueda",, "RESULTATS")
            End If

            'Capturar algun error que no es podia controlar
        Catch e As Exception
            MsgBox("Hi ha hagut algun error",, "ERROR")
        End Try
    End Sub


    'Tota la part de creació posicionament i entrada de dades de la presentació 
    'de les receptes 
    Private Sub VisualitzarReceptes(index As Integer, ruta As String, Titol As String, ID As Integer)

        'Ubicació per cada picturebox
        PictureBox(index) = New PictureBox
        Label(index) = New Label

        'Fer matriu de picturesbox per tal que es coloquin en files de 3
        '
        If index <> 0 Then
            If index Mod 3 = 0 Then
                yloc += 250
                xloc = 46
            Else
                xloc += 245
            End If
        End If

        'Formatar els elements creats
        Label(index).Text = Titol.ToUpper
        Label(index).Location = New Point(xloc, yloc - 30)
        Label(index).Size = New System.Drawing.Size(220, 30)
        Label(index).TextAlign = ContentAlignment.MiddleCenter

        PictureBox(index).Tag = ID
        PictureBox(index).Location = New Point(xloc, yloc)
        PictureBox(index).Size = New System.Drawing.Size(220, 220)
        PictureBox(index).SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox(index).BorderStyle = BorderStyle.Fixed3D
        PictureBox(index).Visible = True
        PictureBox(index).SizeMode = PictureBoxSizeMode.StretchImage



        If System.IO.File.Exists(ruta) Then
            PictureBox(index).Image = System.Drawing.Bitmap.FromFile(ruta)
        Else
            Dim imgErr As String = rutaImatgeNOk
            PictureBox(index).Image = System.Drawing.Bitmap.FromFile(imgErr)
        End If

        'S'afegeix tot al formulari i crem els events de les picutrebox
        Me.Controls.Add(PictureBox(index))
        Me.Controls.Add(Label(index))
        AddHandler PictureBox(index).Click, AddressOf Picturebox_click
        Me.Refresh()

    End Sub


    Private Sub CbSeleccio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbSeleccio.KeyPress
        'No permet escriure alla on hi hagi una llista per escollir
        If cbSeleccio.Items.Count <> 0 Then
            e.Handled = True
        End If

    End Sub


    Private Sub cbSeleccio_MouseClick(sender As Object, e As MouseEventArgs) Handles cbSeleccio.MouseClick
        cbSeleccio.Text = ""
    End Sub
End Class



