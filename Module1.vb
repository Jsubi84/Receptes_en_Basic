Module Module1
    'Recupero dades de dataset1 i les poso en una taula per poder treballar
    'Diferents rutes per imatges
    Public directoriProjecte As String = My.Application.Info.DirectoryPath & "\db"
    Public directoriXML As String = directoriProjecte & "\arxiu.xml"
    Public rutaImatgeNOk As String = directoriProjecte & "\no_cargado.jpg"

    Public idSeleccio As Integer

    Public taulaReceptes As DataTable
    Public PictureBox() As PictureBox
    Public Label() As Label
    Public ReceptesIng As DataTable

    Public xloc As Integer
    Public yloc As Integer
End Module
