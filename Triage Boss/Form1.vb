Imports System.IO

Public Class frmMain
    Dim dtClient As New DataTable
    Dim dtInsurance As New DataTable

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDT()
    End Sub

    Private Sub CreateDT()
        dtClient.Columns.Add("Name", GetType(String))
        dtClient.Columns.Add("Global", GetType(String))
        dtClient.Columns.Add("TCPC", GetType(String))
        dtClient.Columns.Add("SendOut", GetType(String))
        dtClient.Columns.Add("Other", GetType(String))
        dtInsurance.Columns.Add("Name", GetType(String))
        dtInsurance.Columns.Add("ID", GetType(String))
    End Sub

    Private Sub LoadInsuranceData()
        Dim docPath As String = Path.Combine(My.Application.Info.DirectoryPath, "docs")
        Dim insuranceFile As String = docPath & "\insurance.xml"
        Dim xmlDoc As XDocument = XDocument.Load(insuranceFile)
        Dim xml As XElement = xmlDoc.Root
        Dim xInsurances As IEnumerable(Of XElement) = xml.Elements()

        dtInsurance.Clear()

        Try
            For Each xinsurance In xInsurances
                dtInsurance.Rows.Add(xinsurance.<Name>.Value, xinsurance.<ID>.Value)
            Next
        Catch ex As Exception
            Throw ex.InnerException 'Throw ex
        End Try
    End Sub

    Private Sub LoadClientData()
        Dim docPath As String = Path.Combine(My.Application.Info.DirectoryPath, "docs")
        Dim clientFile As String = docPath & "\client.xml"
        Dim xmlDoc As XDocument = XDocument.Load(clientFile)
        Dim xml As XElement = xmlDoc.Root
        Dim xClients As IEnumerable(Of XElement) = xml.Elements()

        cmbClient.Items.Clear()
        dtClient.Clear()

        Try
            For Each xclient In xClients
                cmbClient.Items.Add(xclient.<Name>.Value)
                dtClient.Rows.Add(xclient.<Name>.Value, xclient.<Global>.Value, xclient.<TCPC>.Value, xclient.<SendOut>.Value, xclient.<Other>.Value)
            Next
        Catch ex As Exception
            Throw ex.InnerException 'Throw ex
        End Try
    End Sub

    Private Sub LoadInsuranceListBox()
        Dim dr As DataRow
        Dim ctrl As Control
        Dim found As Boolean = False

        lvwInsurance.Items.Clear()

        For Each dr In dtInsurance.Rows
            For Each ctrl In Panel1.Controls
                If TypeOf ctrl Is ListView Then
                    For Each item In lvwGlobal.Items
                        If item.text.ToString = dr(0).ToString Then
                            found = True
                            Exit For
                        End If
                    Next
                    For Each item In lvwTCPC.Items
                        If item.text.ToString = dr(0).ToString Then
                            found = True
                            Exit For
                        End If
                    Next
                    For Each item In lvwSendOut.Items
                        If item.text.ToString = dr(0).ToString Then
                            found = True
                            Exit For
                        End If
                    Next
                    For Each item In lvwOther.Items
                        If item.text.ToString = dr(0).ToString Then
                            found = True
                            Exit For
                        End If
                    Next
                End If
            Next
            If found = False Then
                lvwInsurance.Items.Add(dr(0))

            Else
                found = False
            End If
        Next
    End Sub

    Private Sub SaveClientData(sClient As String)
        Dim docPath As String = Path.Combine(My.Application.Info.DirectoryPath, "docs")
        Dim clientFile As String = docPath & "\client.xml"
        Dim xmlDoc As XDocument = XDocument.Load(clientFile)
        Dim xml As XElement = xmlDoc.Root
        Dim xClients As IEnumerable(Of XElement) = xml.Elements()
        Dim drIns As DataRow

        Try
            For Each xclient In xClients
                If sClient = xclient.<Name>.Value Then
                    'Save Global
                    xclient.<Global>.Value = ""
                    Dim listGlobal As List(Of String) = New List(Of String)
                    For Each sIns In lvwGlobal.Items
                        For Each drIns In dtInsurance.Rows
                            If sIns.text.ToString = drIns(0) Then
                                listGlobal.Add(drIns(1))
                            End If
                        Next
                    Next
                    xclient.<Global>.Value = String.Join(",", listGlobal)

                    'Save TCPC
                    xclient.<TCPC>.Value = ""
                    Dim listTCPC As List(Of String) = New List(Of String)
                    For Each sIns In lvwTCPC.Items
                        For Each drIns In dtInsurance.Rows
                            If sIns.text.ToString = drIns(0) Then
                                listTCPC.Add(drIns(1))
                            End If
                        Next
                    Next
                    xclient.<TCPC>.Value = String.Join(",", listTCPC)

                    'Save SendOut
                    xclient.<SendOut>.Value = ""
                    Dim listSendOut As List(Of String) = New List(Of String)
                    For Each sIns In lvwSendOut.Items
                        For Each drIns In dtInsurance.Rows
                            If sIns.text.ToString = drIns(0) Then
                                listSendOut.Add(drIns(1))
                            End If
                        Next
                    Next
                    xclient.<SendOut>.Value = String.Join(",", listSendOut)

                    'Save Other
                    xclient.<Other>.Value = ""
                    Dim listOther As List(Of String) = New List(Of String)
                    For Each sIns In lvwOther.Items
                        For Each drIns In dtInsurance.Rows
                            If sIns.text.ToString = drIns(0) Then
                                listOther.Add(drIns(1))
                            End If
                        Next
                    Next
                    xclient.<Other>.Value = String.Join(",", listOther)

                    xmlDoc.Save(clientFile)
                End If
            Next

            LoadInsuranceListBox()
            LoadClientData()
            cmbClient.SelectedIndex = cmbClient.FindStringExact(cmbClient.Text)
        Catch ex As Exception
            Throw ex.InnerException 'Throw ex
        End Try
    End Sub

    Private Sub txtInsurance_KeyUp(sender As Object, e As KeyEventArgs) Handles txtInsurance.KeyUp
        Dim actual As String

        ' Do nothing for these keys.
        If ((e.KeyCode = Keys.Left) Or
            (e.KeyCode = Keys.Right) Or
            (e.KeyCode = Keys.Up) Or
            (e.KeyCode = Keys.Delete) Or
            (e.KeyCode = Keys.Down) Or
            (e.KeyCode = Keys.PageUp) Or
            (e.KeyCode = Keys.PageDown) Or
            (e.KeyCode = Keys.Home) Or
            (e.KeyCode = Keys.End)) Then
            Return
        End If

        ' Store the actual text that has been typed.
        actual = txtInsurance.Text

        If e.KeyCode = Keys.Back Then
            If Len(actual) < 3 Then
                For Each ins In lvwInsurance.Items
                    If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                        ins.backcolor = SystemColors.Window
                    End If
                Next
                For Each ins In lvwGlobal.Items
                    If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                        ins.backcolor = SystemColors.Window
                    End If
                Next
                For Each ins In lvwTCPC.Items
                    If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                        ins.backcolor = SystemColors.Window
                    End If
                Next
                For Each ins In lvwSendOut.Items
                    If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                        ins.backcolor = SystemColors.Window
                    End If
                Next
                For Each ins In lvwOther.Items
                    If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                        ins.backcolor = SystemColors.Window
                    End If
                Next
            End If
        ElseIf Len(actual) >= 3 Then
            For Each ins In lvwInsurance.Items
                If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                    ins.backcolor = Color.Yellow
                End If
            Next
            For Each ins In lvwGlobal.Items
                If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                    ins.backcolor = Color.Yellow
                End If
            Next
            For Each ins In lvwTCPC.Items
                If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                    ins.backcolor = Color.Yellow
                End If
            Next
            For Each ins In lvwSendOut.Items
                If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                    ins.backcolor = Color.Yellow
                End If
            Next
            For Each ins In lvwOther.Items
                If ins.text.ToString.ToUpper.Contains(actual.ToUpper) Then
                    ins.backcolor = Color.Yellow
                End If
            Next
        End If
    End Sub

#Region "Button"

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadInsuranceData()
        LoadInsuranceListBox()
        LoadClientData()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveClientData(cmbClient.SelectedItem.ToString)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lvwInsurance.Items.Clear()
        lvwGlobal.Items.Clear()
        lvwTCPC.Items.Clear()
        lvwSendOut.Items.Clear()
        lvwOther.Items.Clear()
        cmbClient.ResetText()
        txtInsurance.Text = ""
        LoadInsuranceListBox()
    End Sub
#End Region

#Region "Listview"

    Private Sub ListView_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles lvwInsurance.ItemDrag, lvwGlobal.ItemDrag, lvwTCPC.ItemDrag, lvwSendOut.ItemDrag, lvwOther.ItemDrag
        If sender Is Nothing OrElse Not TypeOf sender Is ListView Then Exit Sub
        With CType(sender, ListView)
            .DoDragDrop(e.Item, DragDropEffects.Move)
        End With
    End Sub
    Private Sub ListView_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwInsurance.DragEnter, lvwGlobal.DragEnter, lvwTCPC.DragEnter, lvwSendOut.DragEnter, lvwOther.DragEnter
        If sender Is Nothing OrElse Not TypeOf sender Is ListView Then Exit Sub
        'If this is a listview item then allow the drag
        If e.Data.GetDataPresent(GetType(ListViewItem)) Then
            e.Effect = DragDropEffects.Move
        End If
    End Sub
    Private Sub ListView_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles lvwInsurance.DragDrop, lvwGlobal.DragDrop, lvwTCPC.DragDrop, lvwSendOut.DragDrop, lvwOther.DragDrop
        If sender Is Nothing OrElse Not TypeOf sender Is ListView Then Exit Sub
        'Remove the item from the current listview and drop it in the new listview
        With CType(sender, ListView)
            If e.Data.GetDataPresent(GetType(ListViewItem)) Then
                Dim draggedItem As ListViewItem = CType(e.Data.GetData(GetType(ListViewItem)), ListViewItem)
                draggedItem.ListView.Items.Remove(draggedItem)
                .Items.Add(draggedItem)
            End If
        End With
    End Sub
    '******
#End Region

#Region "Combo"
    Private Sub cmbClient_KeyUp(sender As Object, e As KeyEventArgs) Handles cmbClient.KeyUp
        Dim index As Integer
        Dim actual As String
        Dim found As String

        ' Do nothing for some keys such as navigation keys.
        If ((e.KeyCode = Keys.Back) Or
            (e.KeyCode = Keys.Left) Or
            (e.KeyCode = Keys.Right) Or
            (e.KeyCode = Keys.Up) Or
            (e.KeyCode = Keys.Delete) Or
            (e.KeyCode = Keys.Down) Or
            (e.KeyCode = Keys.PageUp) Or
            (e.KeyCode = Keys.PageDown) Or
            (e.KeyCode = Keys.Home) Or
            (e.KeyCode = Keys.End)) Then
            Return
        End If

        ' Store the actual text that has been typed.
        actual = cmbClient.Text
        ' Find the first match for the typed value.
        index = cmbClient.FindString(actual)
        ' Get the text of the first match.
        If (index > -1) Then
            found = cmbClient.Items(index).ToString()
            ' Select this item from the list.
            cmbClient.SelectedIndex = index
            ' Select the portion of the text that was automatically added so that additional typing will replace it.
            cmbClient.SelectionStart = actual.Length
            cmbClient.SelectionLength = found.Length
        End If
    End Sub

    Private Sub cmbClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbClient.SelectedIndexChanged
        Dim sName As String = cmbClient.SelectedItem.ToString
        Dim drIns As DataRow
        Dim drClient As DataRow

        lvwInsurance.Items.Clear()
        lvwGlobal.Items.Clear()
        lvwTCPC.Items.Clear()
        lvwSendOut.Items.Clear()
        lvwOther.Items.Clear()
        txtInsurance.Text = ""

        LoadInsuranceData()
        LoadInsuranceListBox()

        For Each drIns In dtInsurance.Rows
            For Each drClient In dtClient.Rows
                If drClient(0).ToString = sName Then
                    Dim sGlobal As String = drClient(1).ToString
                    Dim sTCPC As String = drClient(2).ToString
                    Dim sSendOut As String = drClient(3).ToString
                    Dim sOther As String = drClient(4).ToString
                    Dim sGlobalIns As String() = sGlobal.Split(New Char() {","})
                    Dim sTCPCIns As String() = sTCPC.Split(New Char() {","})
                    Dim sSendOutIns As String() = sSendOut.Split(New Char() {","})
                    Dim sOtherIns As String() = sOther.Split(New Char() {","})
                    For Each ins In sGlobalIns
                        If drIns(1).ToString = ins Then
                            For Each item In lvwInsurance.Items
                                If item.text.ToString = drIns(0).ToString Then
                                    item.Remove()
                                    Exit For
                                End If
                            Next
                            lvwGlobal.Items.Add(drIns(0).ToString)
                        End If
                    Next
                    For Each ins In sTCPCIns
                        If drIns(1).ToString = ins Then
                            For Each item In lvwInsurance.Items
                                If item.text.ToString = drIns(0).ToString Then
                                    item.Remove()
                                    Exit For
                                End If
                            Next
                            lvwTCPC.Items.Add(drIns(0).ToString)
                        End If
                    Next
                    For Each ins In sSendOutIns
                        If drIns(1).ToString = ins Then
                            For Each item In lvwInsurance.Items
                                If item.text.ToString = drIns(0).ToString Then
                                    item.Remove()
                                    Exit For
                                End If
                            Next
                            lvwSendOut.Items.Add(drIns(0).ToString)
                        End If
                    Next
                    For Each ins In sOtherIns
                        If drIns(1).ToString = ins Then
                            For Each item In lvwInsurance.Items
                                If item.text.ToString = drIns(0).ToString Then
                                    item.Remove()
                                    Exit For
                                End If
                            Next
                            lvwOther.Items.Add(drIns(0).ToString)
                        End If
                    Next
                End If
            Next
        Next
    End Sub
#End Region
End Class
