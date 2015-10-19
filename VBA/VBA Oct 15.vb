Sub Protect()
For Each Worksheet In Worksheets
    Worksheet.Protect Password:="Tim"
Next

End Sub

Sub Unprotect()
   For Each Worksheet In Worksheets
     Worksheet.Unprotect Password:="Tim"
   Next
End Sub

Sub uLck()
    'Dim cell As Range
    'For Each cell In Selection
        If Selection.Interior.Color = 10092543 Then
            Selection.Locked = False
        Else
            Selection.Locked = True
        End If
    'Next cell
End Sub

Sub uLck2()
    Dim cell As Range
    For Each cell In Selection
        If cell.Interior.ColorIndex = 15 Then
            cell.Locked = False
        Else
            cell.Locked = True
        End If
    Next cell

End Sub
Sub addSheets()
    Dim shts As Integer
    shts = InputBox("Number of Sheets to add")
    For i = 1 To shts
        Sheets.Add
    Next i
End Sub

Sub changePolarity()
    Dim cell As Range
    For Each cell In Selection
        cell.Value = cell.Value * -1
    Next cell
End Sub

Sub errorZero()
    Dim cell As Range
    For Each cell In Selection
    If IsError(cell.Value) Then cell.Value = 0
    Next cell
End Sub

Sub cellAbove()
    Dim cell As Range
    For Each cell In Selection
        If cell.Value = "" Then cell.Value = cell.Offset(-1, 0)
    Next cell
End Sub

Sub deleteHyperlink()
    Dim cell As Range
    For Each cell In Selection
        If cell.Hyperlinks.count = 1 Then cell.Hyperlinks.Delete
    Next cell
End Sub
Sub zeroRowHide()
    Dim cell As Range
    For Each cell In Selection
        cell.Activate
        If cell.Value = 0 Then
            ActiveCell.EntireRow.Hidden = True
        End If
    Next cell
End Sub

Sub Collapse()
    Dim sheet As Worksheet
    For Each sheet In Worksheets
        sheet.Outline.ShowLevels RowLevels:=1
    Next sheet
End Sub

Sub Expand()
    Dim sheet As Worksheet
    For Each sheet In Worksheets
        sheet.Outline.ShowLevels RowLevels:=2
    Next sheet
End Sub

Sub absoluteValue()
    Dim cell As Range
    For Each cell In Selection
        cell.Offset(0, 1).Value = Abs(cell.Value)
    Next cell
End Sub

Sub colourmarkDuplicate()
    Dim cell As Range
    For Each cell In Selection
        If cell.Value * -1 = cell.Offset(-1, 0).Value Or cell.Value * -1 = cell.Offset(1, 0).Value Then cell.Interior.ColorIndex = 6
    Next cell
End Sub

Sub colourcellMark()
    Dim cell As Range
    For Each cell In Selection
        If cell.Interior.ColorIndex <> -4142 Then cell.Offset(0, 6).Value = "*"
    Next cell
End Sub

Sub unhideAllRows()
    Dim sheet As Worksheet
    For Each sheet In Worksheets
        sheet.Rows.Hidden = False
    Next sheet
End Sub

Sub unhideAllColumns()
    Dim sheet As Worksheet
    For Each sheet In Worksheets
        sheet.Columns.Hidden = False
    Next sheet
End Sub

Sub unhideCol_Rows()
    Dim sheet As Worksheet
    For Each sheet In Worksheets
        sheet.Rows.Hidden = False
        sheet.Columns.Hidden = False
    Next sheet
End Sub

Sub BudgetFilter()
'
' BudgetFilter Macro
'

'
    Range("A1:D1").Select
    Selection.AutoFilter
    ActiveSheet.Range("$A$1:$D$280").AutoFilter Field:=2, Criteria1:="=*total*" _
        , Operator:=xlAnd
End Sub

Sub addZero()
    Dim cell As Range
    For Each cell In Selection
        If cell.Value = "" Then
            cell.Value = 0
        End If
    Next cell
End Sub


Sub divideBy()
Dim cell As Range
    For Each cell In Selection
        cell.Value = cell.Value / 0.001
    Next cell
End Sub

Sub convertNumber()
Dim cell As Range
    For Each cell In Selection
        cell.Value = Val(cell.Value)
    Next cell
    Selection.NumberFormat = "General"
End Sub

Sub unlockCells()
Dim sh As Worksheet
Dim cell As Range
    For Each sh In Worksheets
        sh.Activate
        Range("A1:CC500").Select
        For Each cell In Selection
            If cell.Interior.ColorIndex = 15 Then
                cell.Locked = False
            Else
                cell.Locked = True
                On Error Resume Next
            End If
        Next cell
    Next sh
End Sub

Sub tabsName()
    For Each Worksheet In Worksheets
            Worksheet.Name = Worksheet.Range("A7:A7")
    Next
End Sub

Sub sheetNames()
For Each sheet In Application.Windows(1).SelectedSheets
    sheet.Name = sheet.Range("A7:A7")
Next sheet
End Sub

Sub sheetCopy()
Dim i As Integer
i = InputBox("Enter the number of copies")
For Copy = 1 To i
    ActiveWorkbook.ActiveSheet.Copy After:=Sheets(1)
Next Copy
End Sub

Sub boldRowDelete()
    Dim cell As Range
    For Each cell In Selection
        cell.Activate
        If cell.Font.Bold <> 0 Then ActiveCell.EntireRow.Delete = 1
    Next cell
End Sub

Sub sameVal()
    Dim cell As Range
    For Each cell In Selection
        If cell.Value = cell.Offset(-1, 0).Value Then cell.Interior.ColorIndex = 6
    Next cell
End Sub

Sub valueHighlight()
Dim cell As Range
Dim Val As Double
Val = InputBox("Enter the value to highlight: ")
    For Each cell In Selection
        If cell.Value = Val Or cell.Value = -Val Then cell.Interior.ColorIndex = 15
    Next cell
End Sub

Sub Contains()
Dim cell As Range
answer = InputBox("What are you looking for")
For Each cell In Selection
    If InStr(1, cell, answer, 1) Then cell.Offset(0, 2) = answer
Next cell
End Sub

Sub Replace()
    Dim cell As Range
    For Each cell In Selection
        If cell.Value = "" Then cell.Value = cell.Offset(0, -2).Value
    Next cell
End Sub

Sub tabsName2()
    For Each Worksheet In Worksheets
        If Worksheet.Name = "Sheet1" Then
            Worksheet.Name = "Main"
        Else
            Worksheet.Name = Worksheet.Range("A7:A7")
        End If
        On Error Resume Next
    Next
End Sub


Sub ValueDuplicate()
    Dim cell As Range
    For Each cell In Selection
        If cell.Offset(1, 0).Value <= 0 Then
            cell.Offset(-1, 0).Value = cell.Value
        End If
    Next
End Sub

Sub Year()
Dim cell As Range
For Each cell In Selection
    If cell.Value >= DateValue("01/04/2001") And cell.Value <= DateValue("31/03/2002") Then
        cell.Offset(0, -1).Value = "2001-02"
    ElseIf cell.Value >= DateValue("01/04/2002") And cell.Value <= DateValue("31/03/2003") Then
        cell.Offset(0, -1).Value = "2002-03"
    ElseIf cell.Value >= DateValue("01/04/2003") And cell.Value <= DateValue("31/03/2004") Then
        cell.Offset(0, -1).Value = "2003-04"
    ElseIf cell.Value >= DateValue("01/04/2004") And cell.Value <= DateValue("31/03/2005") Then
        cell.Offset(0, -1).Value = "2004-05"
    ElseIf cell.Value >= DateValue("01/04/2005") And cell.Value <= DateValue("31/03/2006") Then
        cell.Offset(0, -1).Value = "2005-06"
    ElseIf cell.Value >= DateValue("01/04/2006") And cell.Value <= DateValue("31/03/2007") Then
        cell.Offset(0, -1).Value = "2006-07"
    ElseIf cell.Value >= DateValue("01/04/2007") And cell.Value <= DateValue("31/03/2008") Then
        cell.Offset(0, -1).Value = "2007-08"
    ElseIf cell.Value >= DateValue("01/04/2008") And cell.Value <= DateValue("31/03/2009") Then
        cell.Offset(0, -1).Value = "2008-09"
    ElseIf cell.Value >= DateValue("01/04/2009") And cell.Value <= DateValue("31/03/2010") Then
        cell.Offset(0, -1).Value = "2009-10"
    ElseIf cell.Value >= DateValue("01/04/2010") And cell.Value <= DateValue("31/03/2011") Then
        cell.Offset(0, -1).Value = "2010-11"
    ElseIf cell.Value >= DateValue("01/04/2011") And cell.Value <= DateValue("31/03/2012") Then
        cell.Offset(0, -1).Value = "2011-12"
    ElseIf cell.Value >= DateValue("01/04/2012") And cell.Value <= DateValue("31/03/2013") Then
        cell.Offset(0, -1).Value = "2012-13"
    ElseIf cell.Value >= DateValue("01/04/2013") And cell.Value <= DateValue("31/03/2014") Then
        cell.Offset(0, -1).Value = "2013-14"
    ElseIf cell.Value >= DateValue("01/04/2014") And cell.Value <= DateValue("31/03/2015") Then
        cell.Offset(0, -1).Value = "2014-15"
    Else: cell.Offset(0, -1).Value = "OTHER"
    End If
Next
End Sub

Sub BudgetTab()
    For Each Worksheet In Worksheets
        If Worksheet.Name = "Summary GL codes" Then
            Worksheet.Name = "Summary GL codes"
        ElseIf Worksheet.Name = "Summary Projects" Then
            Worksheet.Name = "Summary Projects"
        ElseIf Worksheet.Name = "Building Works" Then
            Worksheet.Name = "Building Works"
        ElseIf Worksheet.Name = "IT-Digital" Then
            Worksheet.Name = "IT-Digital"
        Else
            Worksheet.Name = Worksheet.Range("K239:K239")
        End If
        On Error Resume Next
    Next
End Sub

Sub UnFreezePane()
For Each sheet In Application.Windows(1).SelectedSheets
    sheet.Activate
    ActiveWindow.FreezePanes = False
Next
End Sub

Sub FreezePane()
For Each sheet In Application.Windows(1).SelectedSheets
    sheet.Activate
    Rows("256:256").Select
    ActiveWindow.FreezePanes = True
Next
End Sub

Sub BoldFont()
Dim cell As Range
For Each cell In Selection
    If cell.Font.Bold = True Then cell.Interior.ColorIndex = 6
Next cell
End Sub

Sub UnhideSheets()

For Each Worksheet In Worksheets
    If Worksheet.Visible = False Then Worksheet.Visible = True
Next Worksheet
End Sub

Sub tabNames()
Dim tabs(3)
'set cell as Range("A1)
Dim cell As Range
Dim i As Integer
Dim count As Integer
i = ActiveWorkbook.Sheets.count
For count = 1 To i
    tabs(count) = ActiveWorkbook.Sheets(count).Name
Next count

Set cell = Range("A1")
cell.Value = "List of Tab Names"
For count = 1 To i
    cell.Offset(count, 0).Value = tabs(count)
Next count

End Sub

Sub rowDelete()
    Dim cell As Range
    For Each cell In Selection
        If cell.Value <> "30ONL" Then
            ActiveCell.EntireRow.Delete
        End If
    Next cell
End Sub

Sub AccountType()
Dim cell As Range
For Each cell In Selection
    If cell.Value <= 4999 Then
        cell.Offset(0, -1).Value = "Bal Sheet"
    ElseIf cell.Value >= 5000 And cell.Value <= 5999 Then
        cell.Offset(0, -1).Value = "Income"
    ElseIf cell.Value >= 6010 And cell.Value <= 6019 Or cell.Value = 6040 Or cell.Value = 6026 Or cell.Value >= 6035 And cell.Value <= 6037 Then
        cell.Offset(0, -1).Value = "Salary"
    ElseIf cell.Value >= 6020 And cell.Value <= 6025 Or cell.Value >= 6031 And cell.Value <= 6034 Or cell.Value >= 6041 And cell.Value <= 7000 Then
        cell.Offset(0, -1) = "Expenditure"
    ElseIf cell.Value = 7001 Then
        cell.Offset(0, -1) = "Contingency"
    Else: cell.Offset(0, -1) = "Other"
    End If
Next
End Sub

Sub ImportTextFile()
    Set myTextFile = Workbooks.Open("S:\FINANCE\Mohammed\CostCentres.txt")
    myTextFile.Sheets(1).Range("A1").CurrentRegion.Copy ThisWorkbook.Sheets(1).Range("B7")
    myTextFile.Close Savechanges:=False
End Sub

Sub OpenText()
    Workbooks.OpenText Filename:="S:\FINANCE\Mohammed\CostCentres.txt", Tab:=True
    
End Sub

Sub datatest()
'
' datatest Macro
'

'
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:=Array(Array( _
        "ODBC;DRIVER=SQL Server;SERVER=VAM-FINREP;UID=msyed;APP=2007 Microsoft Office system;WSID=VAM05168;DATABASE=V&A;Trusted_Connection=Ye" _
        ), Array("s")), Destination:=Range("$A$1")).QueryTable
        .CommandText = Array("SELECT * FROM ""dbo"".""VandA$G_L Entry""")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .SourceConnectionFile = _
        "C:\Program Files\Common Files\ODBC\Data Sources\NAV.dsn"
        .ListObject.DisplayName = "Table_NAV"
        .Refresh BackgroundQuery:=False
    End With
End Sub

Sub NAVOriginator()
'
' NAVOriginator Macro
'

'
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:=Array(Array( _
        "ODBC;DRIVER=SQL Server;SERVER=VAM-FINREP;UID=msyed;APP=2007 Microsoft Office system;WSID=VAM05168;DATABASE=V&A;Trusted_Connection=Ye" _
        ), Array("s")), Destination:=Range("$A$1")).QueryTable
        .CommandText = Array( _
        "SELECT * FROM ""dbo"".""VandA$User Dimension Assignment""")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .SourceConnectionFile = _
        "C:\Program Files\Common Files\ODBC\Data Sources\NAV.dsn"
        .ListObject.DisplayName = "Table_NAV"
        .Refresh BackgroundQuery:=False
    End With
    ActiveSheet.ListObjects("Table_NAV").TableStyle = ""
    ActiveSheet.ListObjects("Table_NAV").Unlist
End Sub

Sub NAVApprover()
'
' NAVApprover Macro
'

'
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:=Array(Array( _
        "ODBC;DRIVER=SQL Server;SERVER=VAM-FINREP;UID=msyed;APP=2007 Microsoft Office system;WSID=VAM05168;DATABASE=V&A;Trusted_Connection=Ye" _
        ), Array("s")), Destination:=Range("$A$1")).QueryTable
        .CommandText = Array( _
        "SELECT * FROM ""dbo"".""VandA$User Job Resp_ Assignment""")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .SourceConnectionFile = _
        "C:\Program Files\Common Files\ODBC\Data Sources\NAV.dsn"
        .ListObject.DisplayName = "Table_NAV"
        .Refresh BackgroundQuery:=False
    End With
    ActiveSheet.ListObjects("Table_NAV").TableStyle = ""
    ActiveSheet.ListObjects("Table_NAV").Unlist
End Sub

Sub NAVReporting()
'
' NAVApprover Macro
'

'
    With ActiveSheet.ListObjects.Add(SourceType:=0, Source:=Array(Array( _
        "ODBC;DRIVER=SQL Server;SERVER=VAM-FINREP;UID=msyed;APP=2007 Microsoft Office system;WSID=VAM05168;DATABASE=V&A;Trusted_Connection=Ye" _
        ), Array("s")), Destination:=Range("$A$1")).QueryTable
        .CommandText = Array( _
        "SELECT * FROM ""dbo"".""VandA$User Dimension Reporting""")
        .RowNumbers = False
        .FillAdjacentFormulas = False
        .PreserveFormatting = True
        .RefreshOnFileOpen = False
        .BackgroundQuery = True
        .RefreshStyle = xlInsertDeleteCells
        .SavePassword = False
        .SaveData = True
        .AdjustColumnWidth = True
        .RefreshPeriod = 0
        .PreserveColumnInfo = True
        .SourceConnectionFile = _
        "C:\Program Files\Common Files\ODBC\Data Sources\NAV.dsn"
        .ListObject.DisplayName = "Table_NAV"
        .Refresh BackgroundQuery:=False
    End With
    ActiveSheet.ListObjects("Table_NAV").TableStyle = ""
    ActiveSheet.ListObjects("Table_NAV").Unlist
End Sub

Sub Format()

' Format Macro
' Macro recorded 26/09/2006 by David
'
'
    Selection.NumberFormat = "_-#,##0_-;""(""#,##0"")"";_-""-""_-"
End Sub


Sub Format00()
'
' Format Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.NumberFormat = "_-#,##0.00_-;""(""#,##0.00"")"";_-""-""_-"
End Sub

Sub Thousands()

'
' Thousands Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.NumberFormat = "_-#,##0,_-;""(""#,##0,"")"";_-""-""_-"
End Sub

Sub Millions()

'
' Millions Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.NumberFormat = "_-#,##0.0,,_-;""(""#,##0.0,,"")"";_-""-""_-"
End Sub

Sub General()

'
' General Macro
' Macro recorded 13/11/2006 by David
'

'
    Selection.NumberFormat = "General"
End Sub
Sub Percent()

'
' Percent Macro
' Macro recorded 13/11/2006 by David
'

'
    Selection.NumberFormat = "_-0%_-;""(""0%"")"";_-""-""_-"
End Sub

Sub Dates()
'
' Dates Macro
' Macro recorded 20/06/2007 by David
'

'
    Selection.NumberFormat = "mmm yy"
End Sub

Sub DDates()
'
' Dates Macro
' Macro recorded 20/06/2007 by David
'

'
    Selection.NumberFormat = "dd mmm yy"
End Sub


Sub Blue()
'
' Blue Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.Font.ColorIndex = 5
End Sub
Sub Black()
'
' Black Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.Font.ColorIndex = 0
End Sub
Sub BlueBulk()
'
' BlueBulk Macro
' Macro recorded 04/01/2008 by David
'

'

    Selection.SpecialCells(xlCellTypeConstants, 1).Select
    Selection.Font.ColorIndex = 5
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 13434879
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    ActiveCell.Offset(0, -1).Range("A1").Select
End Sub
Sub Yellow()
'
' Yellow Macro
' Make the cell yellow shaded
'

'
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 13434879
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
End Sub
Sub Unshade()
'
' Unshade Macro
'

'
    Application.CutCopyMode = False
    With Selection.Interior
        .Pattern = xlNone
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
End Sub
Sub BluenShade()
'
' BluenShade Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.Font.ColorIndex = 5
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 13434879
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With

End Sub
Sub BlacknUnshade()
'
' BlacknUnshade Macro
' Macro recorded 26/09/2006 by David
'

'
    Selection.Font.ColorIndex = 0
    With Selection.Interior
        .Pattern = xlNone
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With

End Sub

Sub PrintTitles()
'
' PrintTitles Macro
' Macro recorded 26/09/2006 by David
'

'
    Dim client As String
    client = InputBox("Enter client Name to add to Top left print header")
    
    
        
    With ActiveSheet.PageSetup
        LeftHeader = client
    End With

End Sub


Sub NewBlueBulk()
'
' NewBlueBulk Macro
'

'
    Selection.SpecialCells(xlCellTypeConstants, 1).Select
    Range("F7").Select
End Sub
Sub Centre()
'
' Centre Macro
'

'
    With Selection
        .HorizontalAlignment = xlCenterAcrossSelection
        .VerticalAlignment = xlBottom
        .WrapText = False
        .Orientation = 0
        .AddIndent = False
        .IndentLevel = 0
        .ShrinkToFit = False
        .ReadingOrder = xlContext
        .MergeCells = False
    End With
End Sub

Sub Bulkblueagain()
'
' Bulkblueagain Macro
'

'
    Selection.SpecialCells(xlCellTypeConstants, 1).Select
    With Selection.Interior
        .Pattern = xlSolid
        .PatternColorIndex = xlAutomatic
        .Color = 13434879
        .TintAndShade = 0
        .PatternTintAndShade = 0
    End With
    With Selection.Font
        .Color = -65536
        .TintAndShade = 0
    End With
    ActiveCell.Offset(0, -1).Range("A1").Select
End Sub


