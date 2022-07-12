Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Npgsql
Imports NpgsqlTypes

Public Class Payments

    Sub resetFigures() Handles btnClear.Click
        t_AmtCash.Text = 0
        t_AmtPOS.Text = 0
        t_AmtBank.Text = 0
        t_AmtRRN.Text = 0
        l_RRNAmt.Text = l_RRNAmt.Tag
        l_TXNId.Text = l_TXNId.Tag
        btnSelectRRN.Text = btnSelectRRN.Tag
        routineEnd = 0
        CanEnd = False
        SaveInitiated = False

    End Sub

    Private Time__ As String = Nothing
    Protected Overrides Sub OnLoad(e As EventArgs)
        MyBase.OnLoad(e)
        resetFigures()
        Dim hdrTxt As String = ""
        Select Case ThisClient
            Case IsA.Customer
                hdrTxt = "TXNs"
            Case IsA.Supplier
                hdrTxt = "Purchase"
        End Select
        hdrLabel.Text = String.Concat(hdrLabel.Tag, ": ", hdrTxt)
        chkCredit.Checked = False
        l_InvCode.Text = String.Concat("Invoice Code: ", Inv)
        l_CustomerId.Text = String.Concat("Customer Id: ", CustId)
    End Sub
    Dim routineEnd As Integer = 0
    Private CanEnd As Boolean = False
    Private SaveInitiated As Boolean = False
    Sub CreateInvoice()
        If Not CanEnd Then Exit Sub

        Time__ = Date.Now.ToShortTimeString

        Dim fCash As Integer = -1
        Dim fPOS As Integer = -1
        Dim fBank As Integer = -1
        Dim fRRN As Integer = -1

        Dim rCapture As Integer = 0

        Try

            If chkCredit.Checked Then
                AmountPaid = 0
                PayMode = _Is.Credit
                Hide()
                resetFigures()
            Else

                If CDec(t_AmtCash.Text) > 0 Then routineEnd = 3 + routineEnd Else routineEnd = 0 + routineEnd

                If CDec(t_AmtPOS.Text) > 0 Then routineEnd = 5 + routineEnd Else routineEnd = 0 + routineEnd

                If CDec(t_AmtBank.Text) > 0 Then routineEnd = 7 + routineEnd Else routineEnd = 0 + routineEnd

                If CDec(t_AmtRRN.Text) > 0 Then routineEnd = 11 + routineEnd Else routineEnd = 0 + routineEnd

                rCapture = 0

                rCapture = routineEnd

                If getAll() >= _SubTotal Then

                    If rCapture = 3 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        If fCash > 0 Then
                            PayMode = _Is.Cash
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 5 Then
                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        If fPOS > 0 Then
                            PayMode = _Is.POS
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 7 Then
                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        If fBank > 0 Then
                            PayMode = _Is.Bank
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 11 Then
                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fRRN > 0 Then
                            PayMode = _Is.RRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 8 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        If fCash > 0 And fPOS > 0 Then
                            PayMode = _Is.CashPOS
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 10 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        If fCash > 0 And fBank > 0 Then
                            PayMode = _Is.CashBank
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 12 Then
                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        If fPOS > 0 And fBank > 0 Then
                            PayMode = _Is.POSBank
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 14 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fCash > 0 And fRRN > 0 Then
                            PayMode = _Is.CashRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 16 Then
                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fPOS > 0 And fRRN > 0 Then
                            PayMode = _Is.POSRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 18 Then
                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fBank > 0 And fRRN > 0 Then
                            PayMode = _Is.BankRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 19 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fCash > 0 And fPOS > 0 And fRRN > 0 Then
                            PayMode = _Is.CashPOSRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 21 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fCash > 0 And fBank > 0 And fRRN > 0 Then
                            PayMode = _Is.CashBankRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 23 Then
                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fPOS > 0 And fBank > 0 And fRRN > 0 Then
                            PayMode = _Is.POSBankRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 26 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        fRRN = SaveFigure(CDec(t_AmtRRN.Text), "RRN")

                        If fCash > 0 And fPOS And fBank > 0 And fRRN > 0 Then
                            PayMode = _Is.CashPOSBankRRN
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    ElseIf rCapture = 15 Then
                        fCash = SaveFigure(CDec(t_AmtCash.Text), "Cash")

                        fPOS = SaveFigure(CDec(t_AmtPOS.Text), "POS")

                        fBank = SaveFigure(CDec(t_AmtBank.Text), "Bank")

                        If fCash > 0 And fPOS > 0 And fBank > 0 Then
                            PayMode = _Is.CashPOSBank
                        Else
                            PayMode = _Is.__SadlyNothing___Pity
                        End If
                        AmountPaid = getAll()
                    End If
                ElseIf getAll() < _SubTotal Then
                    AmountPaid = 0
                    PayMode = _Is.__SadlyNothing___Pity
                End If

            End If

            Dim finalR As Decimal
            Try
                finalR = Convert.ToDecimal(l_RRNAmt.Text.Replace("Amt. Due: ", ""))
            Catch ex As Exception
                finalR = 0
            End Try

            Dim Sql As String = ""
            Sql = "UPDATE clInvoiceReturned Set clInvoicePayOut=@clInvoicePayOut " &
                                                                         "WHERE " &
                                                                              "clInvoiceCode='" & RRNInv & "'"
            If Not cTXNs.State = ConnectionState.Open Then cTXNs.Open()
            Dim cm As New NpgsqlCommand
            cm = New NpgsqlCommand(Sql,
                       cTXNs)
            With cm
                .Parameters.Add(New NpgsqlParameter("@clInvoicePayOut", NpgsqlDbType.Bigint)).Value = finalR
                Dim _fsnd As Integer = .ExecuteNonQuery()
                If _fsnd > 0 Then
                    cTXNs.Close()
                End If
            End With

            Dim Result As Object

            Result = String.Concat("Routine Identifier: ", rCapture, vbNewLine,
                                   "Paymode Identifier: ", PayMode, vbNewLine,
                                   fCash, vbNewLine,
                                   fPOS, vbNewLine,
                                   fBank, vbNewLine,
                                   fRRN, vbNewLine)

            write_Log(Result)

            Call payMeans()

            'xQry("DELETE FROM clInvoiceToPay WHERE clAmountExpected IS NULL OR clAmountExpected='' OR clAmountExpected='0'")

            xQry("DELETE FROM clInvoiceToPay WHERE clSessionId IS NULL OR clSessionId='' OR clSessionId='0'", cTXNs)

            Close()

        Catch ex As Exception
            write_Error(ex.Message, Name)
        End Try

    End Sub
    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
    End Sub
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click

        Dim MBR As MsgBoxResult = MsgBox("Save?", MsgBoxStyle.YesNo)

        If Not MBR = MsgBoxResult.Yes Then Exit Sub

        If Not getAll() <= 0 Or chkCredit.CheckState = CheckState.Checked Then CanEnd = True

        CreateInvoice()

    End Sub
    Private Sub _KeyDownClose(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Close()
        ElseIf e.KeyCode = Keys.F2 Then
            btnProceed_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F3 Then
            btnSelectRRN_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.F9 Then
            resetFigures()
        End If

    End Sub

    Function rcpt() As String
        Try
            Dim final As Integer = 100000 + calcVal("clSessionId",
                                  "clInvoiceToPay",
                    CalcMode.GetCount,
                                     cTXNs,
                                        " WHERE clSessionId ILIKE '%R%'")
            rcpt = String.Concat("R" & final)
        Catch ex As Exception
            write_Error("Invoice Generation Error; " & ex.Message)
            MsgBox("Invoice Generation Error; " & ex.Message)
        End Try

    End Function
    Function SaveFigure(AmountExpected As Decimal, PayMethod As String) As Integer
        Dim fSn As Integer = -1

        Dim Sql As String = Nothing

        Sql = "INSERT INTO clInvoiceToPay (clSessionId,clInvoiceCode,clTXNInvoiceCode,clLogInfo," &
                                                              "clAmountExpected,clClient,clPaymentMethod,clStatus) " &
                                                              "VALUES " &
                                                              "(@clSessionId,@clInvoiceCode,@clTXNInvoiceCode,@clLogInfo,@" &
                                                              "clAmountExpected,@clClient,@clPaymentMethod,@clStatus)"
        Dim cmd As New NpgsqlCommand(Sql,
                                       cTXNs)
        Dim tD As DateTime = New DateTime()
        With Date.Now
            tD = New DateTime(.Year, .Month, .Day, .Hour, .Minute, .Second)
        End With
        With cmd

            If Not .Connection.State = ConnectionState.Open Then .Connection.Open()

            .Parameters.Add(New NpgsqlParameter("@clSessionId", NpgsqlDbType.Varchar)).Value = Cashier.sessionId
            .Parameters.Add(New NpgsqlParameter("@clInvoiceCode", NpgsqlDbType.Varchar)).Value = rcpt()
            .Parameters.Add(New NpgsqlParameter("@clTXNInvoiceCode", NpgsqlDbType.Varchar)).Value = String.Concat("R_", Inv)
            .Parameters.Add(New NpgsqlParameter("@clLogInfo", NpgsqlDbType.Timestamp)).Value = tD
            .Parameters.Add(New NpgsqlParameter("@clAmountExpected", NpgsqlDbType.Bigint)).Value = AmountExpected
            .Parameters.Add(New NpgsqlParameter("@clClient", NpgsqlDbType.Varchar)).Value = usr()
            .Parameters.Add(New NpgsqlParameter("@clPaymentMethod", NpgsqlDbType.Varchar)).Value = PayMethod
            .Parameters.Add(New NpgsqlParameter("@clStatus", NpgsqlDbType.Varchar)).Value = PayMethod & IIf(ThisClient = IsA.Customer, " TXNs", " Purchases")

            If Not .Connection.State = ConnectionState.Open Then .Connection.Open()

            fSn = .ExecuteNonQuery()

            SaveFigure = fSn

            .Connection.Close()

        End With

        'If Not ctxns.state = ConnectionState.Closed Then cTXNs.Close()

    End Function

    Function getAll() As Decimal
        getAll = CDec(t_AmtCash.Text) + CDec(t_AmtPOS.Text) + CDec(t_AmtBank.Text) + CDec(t_AmtRRN.Text)
    End Function
    Private Sub t_AmtCash_TextChanged(sender As Object, e As EventArgs) Handles t_AmtCash.TextChanged
        Try
            If CDec(t_AmtCash.Text) >= _SubTotal Then
                t_AmtPOS.Text = t_AmtPOS.Tag
                t_AmtBank.Text = t_AmtBank.Tag
                t_AmtRRN.Text = t_AmtRRN.Tag
            End If

            Dim ifff = _SubTotal - getAll()

            ChangeAmount = IIf((ifff) < 0, -1 * ifff, ifff)

            l_Balance.Text = FormatNumber(ChangeAmount, 2)
        Catch ex As Exception
            ChangeAmount = 0
            t_AmtCash.Text = t_AmtCash.Tag
        End Try

    End Sub
    Private Ttl As Decimal = 0
    Private Sub t_AmtPOS_TextChanged(sender As Object, e As EventArgs) Handles t_AmtPOS.TextChanged
        Try

            l_TXNId.Text = IIf(CDec(t_AmtPOS.Text) <= 0, l_TXNId.Tag, "TXN ID: " & SerialId())

            If CDec(t_AmtPOS.Text) >= _SubTotal Then
                t_AmtPOS.Text = _SubTotal
                t_AmtCash.Text = t_AmtCash.Tag
                t_AmtBank.Text = t_AmtBank.Tag
                t_AmtRRN.Text = t_AmtRRN.Tag
            End If
            Ttl = _SubTotal - getAll()
            l_Balance.Text = FormatNumber(Ttl, 2)
        Catch ex As Exception
            t_AmtPOS.Text = t_AmtPOS.Tag
        End Try

    End Sub
    Private Sub t_AmtBank_TextChanged(sender As Object, e As EventArgs) Handles t_AmtBank.TextChanged
        Try
            If CDec(t_AmtBank.Text) >= _SubTotal Then
                t_AmtBank.Text = _SubTotal
                t_AmtCash.Text = t_AmtCash.Tag
                t_AmtPOS.Text = t_AmtPOS.Tag
                t_AmtRRN.Text = t_AmtRRN.Tag
            End If
            Ttl = _SubTotal - getAll()
            l_Balance.Text = FormatNumber(Ttl, 2)
        Catch ex As Exception
            t_AmtBank.Text = t_AmtBank.Tag
        End Try

    End Sub

    Private Sub t_Amtrrn_TextChanged(sender As Object, e As EventArgs) Handles t_AmtRRN.TextChanged
        Try
            If CDec(t_AmtRRN.Text) >= _SubTotal Then
                t_AmtRRN.Text = _SubTotal
                t_AmtCash.Text = t_AmtCash.Tag
                t_AmtPOS.Text = t_AmtPOS.Tag
                t_AmtBank.Text = t_AmtBank.Tag
            End If

            Ttl = _SubTotal - getAll()

            l_Balance.Text = FormatNumber(Ttl, 2)

            Dim finalR As Decimal = 0
            finalR = RRNAmt - CDec(t_AmtRRN.Text)
            If finalR < 0 Then
                finalR = 0
            End If
            l_RRNAmt.Text = String.Concat("Amt. Due: ", finalR)

            If CDec(t_AmtRRN.Text) > 0 Then
                If finalR > Ttl Then
                    Dim x As Decimal = finalR - Ttl
                    Dim g As Decimal = CDec(t_AmtRRN.Text)
                    t_AmtRRN.Text = FormatNumber(g - x, 2)
                End If
            End If

        Catch ex As Exception
            t_AmtRRN.Text = t_AmtRRN.Tag
        End Try

    End Sub
    Private RRNInv As String = ""
    Dim RRNAmt As Decimal = 0
    Private Sub btnSelectRRN_Click(sender As Object, e As EventArgs) Handles btnSelectRRN.Click, btnF3.Click

        If ThisBillMode = CurrentlyIs.TXNs Then
            ThisBillMode = CurrentlyIs.TXNsReturns
        ElseIf ThisBillMode = CurrentlyIs.Purchase Then
            ThisBillMode = CurrentlyIs.PurchaseReturns
        End If

        Try
            Dim f As New InvoiceFinder
            With f
                If Not f.Visible Then .ShowDialog()
                RRNInv = Inv
                If RRNInv = "" Then Exit Sub

                Dim tbl As DataTable = xRead("SELECT clInvoicePayOut FROM clInvoiceReturned " &
                                                                    "WHERE clInvoiceCode='" & RRNInv & "'",
                                                          "clInvoiceReturned",
                       cTXNs)
                For Each row As DataRow In tbl.Rows
                    Try
                        RRNAmt = row(0)
                    Catch ex As Exception
                        RRNAmt = 0
                    End Try
                Next

                If RRNAmt <= 0 Then Exit Sub

                btnSelectRRN.Text = String.Concat("Inv: ", sCs(RRNInv))

                l_RRNAmt.Text = String.Concat("Amt. Due: ", FormatNumber(RRNAmt, 2))

            End With
        Catch ex As Exception
            write_Error(ex.Message, Name)
            btnSelectRRN.Text = btnSelectRRN.Tag
            l_RRNAmt.Text = l_RRNAmt.Tag
        Finally

            If ThisBillMode = CurrentlyIs.TXNsReturns Then
                ThisBillMode = CurrentlyIs.TXNs
            ElseIf ThisBillMode = CurrentlyIs.PurchaseReturns Then
                ThisBillMode = CurrentlyIs.Purchase
            End If

        End Try

    End Sub

    Private Sub chkCredit_CheckedChanged(sender As Object, e As EventArgs) Handles chkCredit.CheckedChanged
        resetFigures()

        Dim boolChk As Boolean = Not chkCredit.Checked

        t_AmtBank.Enabled = boolChk
        t_AmtPOS.Enabled = boolChk
        t_AmtCash.Enabled = boolChk
        t_AmtRRN.Enabled = boolChk

        ExactPayBank.Enabled = boolChk
        ExactPayCash.Enabled = boolChk
        ExactPayPOS.Enabled = boolChk
        ExactPayRRN.Enabled = boolChk

    End Sub

    Sub keyTrapNum(sender As Object, e As KeyPressEventArgs) Handles t_AmtCash.KeyPress, t_AmtPOS.KeyPress, t_AmtBank.KeyPress, t_AmtRRN.KeyPress
        Select Case Asc(e.KeyChar)
            Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9, Keys.Back, Keys.Delete, Keys.Back
                Exit Sub
            Case Keys.Enter
                Dim tmp As Decimal
                If Decimal.TryParse(l_Balance.Text, tmp) Then

                    If tmp > 0 Then
                        If t_AmtCash.Focused Then
                            ExactPayCash_Click(Nothing, Nothing)
                        ElseIf t_AmtPOS.Focused Then
                            ExactPayPOS_Click(Nothing, Nothing)
                        ElseIf t_AmtBank.Focused Then
                            ExactPayBank_Click(Nothing, Nothing)
                        ElseIf t_AmtRRN.Focused Then
                            ExactPayRRN_Click(Nothing, Nothing)
                        End If
                    ElseIf tmp <= 0 Then
                        btnProceed_Click(Nothing, Nothing)
                    End If

                End If
            Case Else
                e.Handled = True
        End Select

    End Sub

    Private Sub ExactPayCash_Click(sender As Object, e As EventArgs) Handles ExactPayCash.Click

        If Not CDec(l_Balance.Text) = 0 Then
            Ttl = l_Balance.Text
            t_AmtCash.Text = FormatNumber(Ttl, 2)
        End If
    End Sub
    Private Sub ExactPayPOS_Click(sender As Object, e As EventArgs) Handles ExactPayPOS.Click
        If Not CDec(l_Balance.Text) = 0 Then
            Ttl = l_Balance.Text
            t_AmtPOS.Text = FormatNumber(Ttl, 2)
        End If
    End Sub
    Private Sub ExactPayBank_Click(sender As Object, e As EventArgs) Handles ExactPayBank.Click
        If Not CDec(l_Balance.Text) = 0 Then
            Ttl = l_Balance.Text
            t_AmtBank.Text = FormatNumber(Ttl, 2)
        End If
    End Sub
    Private Sub ExactPayRRN_Click(sender As Object, e As EventArgs) Handles ExactPayRRN.Click
        If Not CDec(RRNAmt) <= 0 Then
            Ttl = RRNAmt
            t_AmtRRN.Text = FormatNumber(Ttl, 2)
        End If
    End Sub

End Class