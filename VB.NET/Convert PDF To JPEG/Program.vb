'*******************************************************************************************'
'                                                                                           '
' Download Free Evaluation Version From:     https://bytescout.com/download/web-installer   '
'                                                                                           '
' Also available as Web API! Get free API Key https://app.pdf.co/signup                     '
'                                                                                           '
' Copyright © 2017-2020 ByteScout, Inc. All rights reserved.                                '
' https://www.bytescout.com                                                                 '
' https://www.pdf.co                                                                        '
'*******************************************************************************************'



Imports Bytescout.PDFRenderer


Class Program
    Friend Shared Sub Main(args As String())

        ' Create an instance of Bytescout.PDFRenderer.RasterRenderer object and register it.
        Dim renderer As New RasterRenderer()
        renderer.RegistrationName = "demo"
        renderer.RegistrationKey = "demo"

        ' Load PDF document.
        renderer.LoadDocumentFromFile("multipage.pdf")

        For i As Integer = 0 To renderer.GetPageCount() - 1
            ' Render document page to JPEG image file.
            renderer.Save("image" & i & ".jpg", RasterImageFormat.JPEG, i, 96)
        Next

        ' Cleanup
        renderer.Dispose()

        ' Open the first output file in default image viewer.
        System.Diagnostics.Process.Start("image0.jpg")
    End Sub
End Class
