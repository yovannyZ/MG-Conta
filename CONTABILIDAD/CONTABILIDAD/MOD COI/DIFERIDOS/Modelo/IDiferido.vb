Public Class IDiferido

    Private _feAño As String
    Private _feMes As String
    Private _codDoc As String
    Private _nroDoc As String
    Private _codPer As String
    Private _fechaDoc As Date
    Private _codCuenta As String
    Private _glosa As String
    Private _fechaVigenciaDel As Date
    Private _fechaVigenciaAl As Date
    Private _fechaIniOpe As Date
    Private _importe As Decimal
    Private _nroCuotas As Integer
    Private _nroCuotasTran As Integer
    Private _codAux As String
    Private _codComp As String
    Private _nroComp As String
    Private _impAcumulado As Decimal
    Private _impInicalAño As Decimal

    Public Property FeAño() As String
        Get
            Return (_feAño)
        End Get
        Set(ByVal value As String)
            _feAño = value
        End Set
    End Property

    Public Property FeMes() As String
        Get
            Return (_feMes)
        End Get
        Set(ByVal value As String)
            _feMes = value
        End Set
    End Property

    Public Property CodDoc() As String
        Get
            Return (_codDoc)
        End Get
        Set(ByVal value As String)
            _codDoc = value
        End Set
    End Property

    Public Property NroDoc() As String
        Get
            Return (_nroDoc)
        End Get
        Set(ByVal value As String)
            _nroDoc = value
        End Set
    End Property

    Public Property CodPer() As String
        Get
            Return (_codPer)
        End Get
        Set(ByVal value As String)
            _codPer = value
        End Set
    End Property

    Public Property FechaDoc() As Date
        Get
            Return (_fechaDoc)
        End Get
        Set(ByVal value As Date)
            _fechaDoc = value
        End Set
    End Property

    Public Property CodCuenta() As String
        Get
            Return (_codCuenta)
        End Get
        Set(ByVal value As String)
            _codCuenta = value
        End Set
    End Property

    Public Property Glosa() As String
        Get
            Return (_glosa)
        End Get
        Set(ByVal value As String)
            _glosa = value
        End Set
    End Property

    Public Property FechaVigenciaDel() As Date
        Get
            Return (_fechaVigenciaDel)
        End Get
        Set(ByVal value As Date)
            _fechaVigenciaDel = value
        End Set
    End Property

    Public Property FechaVigenciaAl() As Date
        Get
            Return (_fechaVigenciaAl)
        End Get
        Set(ByVal value As Date)
            _fechaVigenciaAl = value
        End Set
    End Property

    Public Property FechaIniOpe() As Date
        Get
            Return (_fechaIniOpe)
        End Get
        Set(ByVal value As Date)
            _fechaIniOpe = value
        End Set
    End Property

    Public Property Importe() As Decimal
        Get
            Return (_importe)
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property

    Public Property NroCuotas() As Integer
        Get
            Return (_nroCuotas)
        End Get
        Set(ByVal value As Integer)
            _nroCuotas = value
        End Set
    End Property

    Public Property NroCuotasTran() As Integer
        Get
            Return (_nroCuotasTran)
        End Get
        Set(ByVal value As Integer)
            _nroCuotasTran = value
        End Set
    End Property

    Public Property CodAux() As String
        Get
            Return (_codAux)
        End Get
        Set(ByVal value As String)
            _codAux = value
        End Set
    End Property

    Public Property CodComp() As String
        Get
            Return (_codComp)
        End Get
        Set(ByVal value As String)
            _codComp = value
        End Set
    End Property

    Public Property NroComp() As String
        Get
            Return (_nroComp)
        End Get
        Set(ByVal value As String)
            _nroComp = value
        End Set
    End Property

    Public Property ImpAcumulado() As Decimal
        Get
            Return (_impAcumulado)
        End Get
        Set(ByVal value As Decimal)
            _impAcumulado = value
        End Set
    End Property

    Public Property ImpInicalAño() As Decimal
        Get
            Return (_impInicalAño)
        End Get
        Set(ByVal value As Decimal)
            _impInicalAño = value
        End Set
    End Property


End Class
