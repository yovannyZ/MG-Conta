Public Class IDiferidoSecuencia
    'FE_A�O, FE_MES, COD_DOC, NRO_DOC, COD_PER, A�O_DIF, MES_DIF
    Private _feA�o As String
    Private _feMes As String
    Private _codDoc As String
    Private _nroDoc As String
    Private _codPer As String
    Private _a�oDif As String
    Private _mesDif As String

    Public Property FeA�o() As String
        Get
            Return _feA�o
        End Get
        Set(ByVal value As String)
            _feA�o = value
        End Set
    End Property

    Public Property FeMes() As String
        Get
            Return _feMes
        End Get
        Set(ByVal value As String)
            _feMes = value
        End Set
    End Property

    Public Property CodDoc() As String
        Get
            Return _codDoc
        End Get
        Set(ByVal value As String)
            _codDoc = value
        End Set
    End Property

    Public Property NroDoc() As String
        Get
            Return _nroDoc
        End Get
        Set(ByVal value As String)
            _nroDoc = value
        End Set
    End Property

    Public Property CodPer() As String
        Get
            Return _codPer
        End Get
        Set(ByVal value As String)
            _codPer = value
        End Set
    End Property

    Public Property A�oDis() As String
        Get
            Return _a�oDif
        End Get
        Set(ByVal value As String)
            _a�oDif = value
        End Set
    End Property

    Public Property MesDis() As String
        Get
            Return _mesDif
        End Get
        Set(ByVal value As String)
            _mesDif = value
        End Set
    End Property


End Class
