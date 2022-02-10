Public Class PreAsignacionUnidades_BE
  Private _PNNPRASG As Decimal ' numero de pre-asignacion   	S 10
  Private _PNFPRASG As Date ' fecha de pre-asignacion    	S 8

  Private _PSCCMPN As String = "" ' cod compañia		     	A 2
  Private _PSCDVSN As String = "" ' cod division		     	A 1
  Private _PNCPLNDV As Integer ' cod planta			S 3
  Private _PNCCLNT As Decimal ' cod cliente			S 6			
  Private _PNCLCLOR As Decimal ' cod de localidad origen	S 5	
  Private _PSTDRORI As String = "" ' des direccion de origen	A 40
  Private _PNCLCLDS As Decimal ' cod de localidad destino	S 5
  Private _PSTDRENT As String = "" ' direccion de entrega de mercaderia 	A 100

  Private _PNNRUCTR As Decimal ' num RUC transportista 	A 15
  Private _PSNPLCUN As String = "" ' num de placa unidad		A 6
  Private _PSNPLCAC As String = "" ' num de placa del acoplado	A 6	
  Private _PSCBRCNT As String = "" ' cod brevete del conductor	A 15
  Private _PSCBRCN2 As String = "" ' cod brevete conductor N°2	A 15

  Private _PNNGUITR As Decimal ' num guia transportista	S 10
  Private _PSFGUITR As String ' fecha de guia de transportista S 8
  Private _PNNOPRCN As Decimal ' num operacion			 S 10	
  Private _PNCMEDTR As Integer ' cod de medio de transporte	S 2	
  Private _PSTOBS As String = ""  ' observaciones			A 250

  'Private FLGASG ' flag asignado			A 1

  Public Property PNNPRASG() As Decimal
    Get
      Return _PNNPRASG
    End Get
    Set(ByVal value As Decimal)
      _PNNPRASG = value
    End Set
  End Property

  Public Property PNFPRASG() As Date
    Get
      Return _PNFPRASG
    End Get
    Set(ByVal value As Date)
      _PNFPRASG = value
    End Set
  End Property

  Private _PNFPRASG_INI As Decimal
  Public Property PNFPRASG_INI() As Decimal
    Get
      Return _PNFPRASG_INI
    End Get
    Set(ByVal value As Decimal)
      _PNFPRASG_INI = value
    End Set
  End Property

  Private _PNFPRASG_FIN As Decimal
  Public Property PNFPRASG_FIN() As Decimal
    Get
      Return _PNFPRASG_FIN
    End Get
    Set(ByVal value As Decimal)
      _PNFPRASG_FIN = value
    End Set
  End Property

  Public Property PSCCMPN() As String
    Get
      Return _PSCCMPN
    End Get
    Set(ByVal value As String)
      _PSCCMPN = value
    End Set
  End Property

  Public Property PSCDVSN() As String
    Get
      Return _PSCDVSN
    End Get
    Set(ByVal value As String)
      _PSCDVSN = value
    End Set
  End Property

  Public Property PNCPLNDV() As Integer
    Get
      Return _PNCPLNDV
    End Get
    Set(ByVal value As Integer)
      _PNCPLNDV = value
    End Set
  End Property

  Public Property PNCCLNT() As Decimal
    Get
      Return _PNCCLNT
    End Get
    Set(ByVal value As Decimal)
      _PNCCLNT = value
    End Set
  End Property

  Public Property PNCLCLOR() As Decimal
    Get
      Return _PNCLCLOR
    End Get
    Set(ByVal value As Decimal)
      _PNCLCLOR = value
    End Set
  End Property

  Public Property PSTDRORI() As String
    Get
      Return _PSTDRORI
    End Get
    Set(ByVal value As String)
      _PSTDRORI = value
    End Set
  End Property

  Public Property PNCLCLDS() As Decimal
    Get
      Return _PNCLCLDS
    End Get
    Set(ByVal value As Decimal)
      _PNCLCLDS = value
    End Set
  End Property

  Public Property PSTDRENT() As String
    Get
      Return _PSTDRENT
    End Get
    Set(ByVal value As String)
      _PSTDRENT = value
    End Set
  End Property

  Public Property PNNRUCTR() As Decimal
    Get
      Return _PNNRUCTR
    End Get
    Set(ByVal value As Decimal)
      _PNNRUCTR = value
    End Set
  End Property

  Public Property PSNPLCUN() As String
    Get
      Return _PSNPLCUN
    End Get
    Set(ByVal value As String)
      _PSNPLCUN = value
    End Set
  End Property

  Public Property PSNPLCAC() As String
    Get
      Return _PSNPLCAC
    End Get
    Set(ByVal value As String)
      _PSNPLCAC = value
    End Set
  End Property

  Public Property PSCBRCNT() As String
    Get
      Return _PSCBRCNT
    End Get
    Set(ByVal value As String)
      _PSCBRCNT = value
    End Set
  End Property

  Public Property PSCBRCN2() As String
    Get
      Return _PSCBRCN2
    End Get
    Set(ByVal value As String)
      _PSCBRCN2 = value
    End Set
  End Property

  Public Property PNNGUITR() As Decimal
    Get
      Return _PNNGUITR
    End Get
    Set(ByVal value As Decimal)
      _PNNGUITR = value
    End Set
  End Property

  Public Property PSFGUITR() As String
    Get
      Return _PSFGUITR
    End Get
    Set(ByVal value As String)
      _PSFGUITR = value
    End Set
  End Property

  Public Property PNNOPRCN() As Decimal
    Get
      Return _PNNOPRCN
    End Get
    Set(ByVal value As Decimal)
      _PNNOPRCN = value
    End Set
  End Property

  Public Property PNCMEDTR() As Decimal
    Get
      Return _PNCMEDTR
    End Get
    Set(ByVal value As Decimal)
      _PNCMEDTR = value
    End Set
  End Property

  Public Property PSTOBS() As String
    Get
      Return _PSTOBS
    End Get
    Set(ByVal value As String)
      _PSTOBS = value
    End Set
  End Property

  Private _PSSESTRG As String = "" ' estado			A 1

  Public Property PSSESTRG() As String
    Get
      Return _PSSESTRG
    End Get
    Set(ByVal value As String)
      _PSSESTRG = value
    End Set
  End Property

  Private _PSCUSCRT As String = "" ' cod usuario creador

  Public Property PSCUSCRT() As String
    Get
      Return _PSCUSCRT
    End Get
    Set(ByVal value As String)
      _PSCUSCRT = value
    End Set
  End Property

  Private _PNFCHCRT As Decimal ' fecha de creacion

  Public Property PNFCHCRT() As Decimal
    Get
      Return _PNFCHCRT
    End Get
    Set(ByVal value As Decimal)
      _PNFCHCRT = value
    End Set
  End Property

  Private _PNHRACRT As Decimal ' hora de creacion

  Public Property PNHRACRT() As Decimal
    Get
      Return _PNHRACRT
    End Get
    Set(ByVal value As Decimal)
      _PNHRACRT = value
    End Set
  End Property

  Private _PSNTRMCR As String = "" ' num terminal de creacion

  Public Property PSNTRMCR() As String
    Get
      Return _PSNTRMCR
    End Get
    Set(ByVal value As String)
      _PSNTRMCR = value
    End Set
  End Property


  Private _PSCULUSA As String = "" ' cod usuario actualizacion

  Public Property PSCULUSA() As String
    Get
      Return _PSCULUSA
    End Get
    Set(ByVal value As String)
      _PSCULUSA = value
    End Set
  End Property

  Private _PNFULTAC As Decimal ' fecha de actualizacion

  Public Property PNFULTAC() As Decimal
    Get
      Return _PNFULTAC
    End Get
    Set(ByVal value As Decimal)
      _PNFULTAC = value
    End Set
  End Property

  Private _PNHULTAC As Decimal ' hora de actualizacion

  Public Property PNHULTAC() As Decimal
    Get
      Return _PNHULTAC
    End Get
    Set(ByVal value As Decimal)
      _PNHULTAC = value
    End Set
  End Property

  Private _PSNTRMNL As String = "" ' num de terminal de actualizacion

  Public Property PSNTRMNL() As String
    Get
      Return _PSNTRMNL
    End Get
    Set(ByVal value As String)
      _PSNTRMNL = value
    End Set
  End Property

  Private _PageSize As Integer
  Private _PageCount As Integer
  Private _PageNumber As Integer

  Public Property PageSize() As Integer
    Get
      Return _PageSize
    End Get
    Set(ByVal value As Integer)
      _PageSize = value
    End Set
  End Property

  Public Property PageCount() As Integer
    Get
      Return _PageCount
    End Get
    Set(ByVal value As Integer)
      _PageCount = value
    End Set
  End Property

  Public Property PageNumber() As Integer
    Get
      Return _PageNumber
    End Get
    Set(ByVal value As Integer)
      _PageNumber = value
    End Set
  End Property

  Private _TCMPCL As String
  Public Property TCMPCL() As String
    Get
      Return _TCMPCL
    End Get
    Set(ByVal value As String)
      _TCMPCL = value
    End Set
  End Property

  ' nom transportista
  Private _TCMTRT As String
  Public Property TCMTRT() As String
    Get
      Return _TCMTRT
    End Get
    Set(ByVal value As String)
      _TCMTRT = value
    End Set
  End Property

  'conductor 1
  Private _TNMCMC As String
  Public Property TNMCMC() As String
    Get
      Return _TNMCMC
    End Get
    Set(ByVal value As String)
      _TNMCMC = value
    End Set
  End Property

  'conductor 2
  Private _TNMCMC2 As String
  Public Property TNMCMC2() As String
    Get
      Return _TNMCMC2
    End Get
    Set(ByVal value As String)
      _TNMCMC2 = value
    End Set
  End Property

  'FLAG

  Private _SESASG As String
  Public Property SESASG() As String
    Get
      Return _SESASG
    End Get
    Set(ByVal value As String)
      _SESASG = value
    End Set
  End Property


End Class
