Module Properties

    '0, 174, 219
    Enum _AccessMode
        IsDownload
        IsUpload
        IsAbsolutelyNothingYo
    End Enum
    Public _Data As _AccessMode = _AccessMode.IsAbsolutelyNothingYo

    Dim tdt As Date
    Public Property JournalDate As Date
        Get
            Return tdt
        End Get
        Set(ByVal Value As Date)
            tdt = Value
        End Set
    End Property

    Dim uId As String
    Public Property _Id As String
        Get
            Return uId
        End Get
        Set(ByVal Value As String)
            uId = Value
        End Set
    End Property

    Dim _uId As String
    Public Property Id As String
        Get
            Return _uId
        End Get
        Set(ByVal Value As String)
            _uId = Value
        End Set
    End Property

    Dim cd As String
    Public Property Code As String
        Get
            Return cd
        End Get
        Set(ByVal Value As String)
            cd = Value
        End Set
    End Property

    Dim u As String
    Public Property usr As String
        Get
            Return u
        End Get
        Set(ByVal Value As String)
            u = Value
        End Set
    End Property

    Dim fd As String
    Public Property SQLDate As String
        Get
            Return fd
        End Get
        Set(ByVal Value As String)
            fd = Value
        End Set
    End Property

    Dim nV As String
    Public Property Inv As String
        Get
            Return nV
        End Get
        Set(ByVal Value As String)
            nV = Value
        End Set
    End Property

    Dim lNv As String
    Public Property InvL As String
        Get
            Return lNv
        End Get
        Set(ByVal Value As String)
            lNv = Value
        End Set
    End Property

    Dim CI As String
    Public Property CustId As String
        Get
            Return CI
        End Get
        Set(ByVal Value As String)
            CI = Value
        End Set
    End Property

    Enum _Request
        IsGranted
        IsRefused
        __IsInvalid
    End Enum
    Public _Access As _Request = _Request.__IsInvalid

    Enum DetailFrom
        ItemCode
        ItemName
        AbsolutelyNothing__Pity
    End Enum
    Dim AA As DetailFrom = DetailFrom.AbsolutelyNothing__Pity
    Public Property AddAs As DetailFrom
        Get
            Return AA
        End Get
        Set(ByVal Value As DetailFrom)
            AA = Value
        End Set
    End Property

    Enum _Is
        Cash
        POS
        Bank

        RRN

        CashPOS
        CashBank
        POSBank
        CashPOSBank

        CashRRN
        POSRRN
        BankRRN
        CashPOSRRN
        CashBankRRN
        POSBankRRN
        CashPOSBankRRN

        Credit
        __SadlyNothing___Pity
    End Enum
    Dim PM As _Is = _Is.__SadlyNothing___Pity
    Public Property PayMode As _Is
        Get
            Return PM
        End Get
        Set(ByVal Value As _Is)
            PM = Value
        End Set
    End Property

    Dim TP As Decimal
    Public Property TotalPrice As Decimal
        Get
            Return TP
        End Get
        Set(ByVal Value As Decimal)
            TP = Value
        End Set
    End Property
    Dim FST As Decimal
    Public Property FindSubTotal As Decimal
        Get
            Return FST
        End Get
        Set(ByVal Value As Decimal)
            FST = Value
        End Set
    End Property
    Dim Dsc As Decimal
    Public Property Discounts As Decimal
        Get
            Return Dsc
        End Get
        Set(ByVal Value As Decimal)
            Dsc = Value
        End Set
    End Property
    Dim _Dsc As String
    Public Property DiscountString As String
        Get
            Return _Dsc
        End Get
        Set(ByVal Value As String)
            _Dsc = Value
        End Set
    End Property
    Dim WQ As Integer
    Public Property WeighedQuantity As Integer
        Get
            Return WQ
        End Get
        Set(ByVal Value As Integer)
            WQ = Value
        End Set
    End Property
    Dim WP As Decimal
    Public Property WeighedPrice As Decimal
        Get
            Return WP
        End Get
        Set(ByVal Value As Decimal)
            WP = Value
        End Set
    End Property
    Dim ST As Decimal
    Public Property _SubTotal As Decimal
        Get
            Return ST
        End Get
        Set(ByVal Value As Decimal)
            ST = Value
        End Set
    End Property
    Dim AP As Decimal
    Public Property AmountPaid As Decimal
        Get
            Return AP
        End Get
        Set(ByVal Value As Decimal)
            AP = Value
        End Set
    End Property
    Dim Ch As Decimal
    Public Property ChangeAmount As Decimal
        Get
            Return Ch
        End Get
        Set(ByVal Value As Decimal)
            Ch = Value
        End Set
    End Property

    Enum LoginMode
        Startup
        AllowAccess
        AskModifier
        ModifyKey
        __IsEmpty
    End Enum
    Public Mode As LoginMode = LoginMode.__IsEmpty

    Enum ___Is
        _New
        _Old
        _SadlyNothing
    End Enum
    Public _Item As ___Is = ___Is._SadlyNothing

    Enum HereIs
        _New
        _Old
        _Nothing
    End Enum
    Public ThisMerchant As HereIs = HereIs._Nothing

    Public ThisUser As HereIs = HereIs._Nothing

    Enum IsA
        Customer
        Supplier
        nEmptyString
    End Enum
    Public ThisClient As IsA = IsA.nEmptyString

    Enum _AddMode
        IsNew
        IsOld
        __IsNothing
    End Enum
    Public _Company As _AddMode = _AddMode.__IsNothing

    Enum CurrentlyIs
        TXNs
        Purchase
        TXNsOrder
        PurchaseOrder
        TXNsReturns
        PurchaseReturns
        StockTransfer
        TXNsRemittance
        PurchaseRemittance
        Receipts
        _Nothing
    End Enum
    Public TBM As CurrentlyIs
    Public Property ThisBillMode As CurrentlyIs
        Get
            Return TBM
        End Get
        Set(ByVal Value As CurrentlyIs)
            TBM = Value
        End Set
    End Property

    Enum _Status As Integer
        IsActive = 500
        isInActive = 501
        isUselessKinda = 502
    End Enum
    Public ThisReturn As _Status = _Status.isUselessKinda

    Dim CmpInf As String
    Public Property CompanyInfo As String
        Get
            Return CmpInf
        End Get
        Set(ByVal Value As String)
            CmpInf = Value
        End Set
    End Property

    Enum EnterMode
        IsNewEntry
        IsPurchaseOrder
        Is_Absolutely_Nothing
    End Enum
    Public _Purchase As EnterMode = EnterMode.Is_Absolutely_Nothing

    Enum BillMode
        IsNew
        IsOld
        Is_Absolutely_Nothing
    End Enum
    Public ThisCurrent As BillMode = BillMode.Is_Absolutely_Nothing

    Enum StockMode
        IsOpening
        IsClosing
        IsReadReport
        isNoOnesBusiness
    End Enum
    Public TodaysCurrent As StockMode = StockMode.isNoOnesBusiness

    Enum IsIn
        InAppMode
        TXNMode
        upYourAssMode
    End Enum
    Public searchModule As IsIn = IsIn.upYourAssMode

    Public AcctAdmin As Integer = 700
    Public AcctCashier As Integer = 701
    Public AcctManager As Integer = 702

    Enum ShouldBe
        Contracted
        Extended
        LeftAlone
    End Enum
    Public DatePanel As ShouldBe = ShouldBe.LeftAlone

    Enum SearchIs
        Create
        Reports
        _IsAbsolutelyNothing
    End Enum
    Public CurrentItem As SearchIs = SearchIs._IsAbsolutelyNothing

    Public InvoiceIsClosed As Integer = 121
    Public InvoiceIsOpen As Integer = 111

    Public IsApproved As Integer = 101
    Public IsDeclined As Integer = 102

    Public StatusIsOnline As Integer = 201
    Public StatusIsOffline As Integer = 202
    Public StatusIsSuspended As Integer = 203

    Public Enum Location
        IsMain
        IsAnnex
    End Enum

End Module
