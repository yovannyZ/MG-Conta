USE [BD_COI01]
GO
/****** Object:  StoredProcedure [dbo].[VERIFICAR_TRANSF_BAN_COI]    Script Date: 10/31/2011 16:01:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[VERIFICAR_TRANSF_BAN_COI]
(@COD_MP CHAR(3),
@NRO_MP VARCHAR(15),
@COD_BANCO CHAR(4),
@TIPO CHAR(1))
AS
IF @TIPO='I' 
BEGIN
SELECT A.COD_CPTO,B.DESC_CPTO,C.COD_AREA
FROM T_BANCO AS A  --,C.CUENTA_ENLACE 
LEFT JOIN MAESTRO_CONCEPTOS AS B ON A.COD_CPTO=B.COD_CPTO
LEFT JOIN CONCEPTO_CUENTA AS C ON A.COD_CPTO=C.COD_CPTO  
WHERE  
A.STATUS_TRANS='N '  AND 
C.TIPO in ('I','O') AND 
COD_MP=@COD_MP AND 
NRO_MP=@NRO_MP AND 
COD_BANCO=@COD_BANCO AND 
isnull(C.CUENTA_ORIGEN,'')=''   
--and A.COD_CC<>''
------------------
UNION ALL
-------------------
SELECT A.COD_CPTO,B.DESC_CPTO,ISNULL(C.COD_AREA,'Oblig.')FROM T_BANCO AS A  --,C.CUENTA_ENLACE  
LEFT JOIN MAESTRO_CONCEPTOS AS B ON A.COD_CPTO=B.COD_CPTO
LEFT JOIN CONCEPTO_CUENTA AS C ON A.COD_CPTO=C.COD_CPTO  WHERE   A.STATUS_TRANS='N ' AND
COD_MP=@COD_MP AND NRO_MP=@NRO_MP AND COD_BANCO=@COD_BANCO
AND C.TIPO='G' 
AND (ISNULL(C.CUENTA_ORIGEN,'')=''  
OR (ISNULL(C.CUENTA_ORIGEN,'')<>'' AND ISNULL(A.COD_CC,'')=''))
END
IF	@TIPO='E'
BEGIN
SELECT A.COD_CPTO,B.DESC_CPTO,ISNULL(C.COD_AREA,'Oblig.')FROM T_BANCO AS A  --,C.CUENTA_ENLACE  
LEFT JOIN MAESTRO_CONCEPTOS AS B ON A.COD_CPTO=B.COD_CPTO
LEFT JOIN CONCEPTO_CUENTA AS C ON A.COD_CPTO=C.COD_CPTO   WHERE   A.STATUS_TRANS='N ' AND
COD_MP=@COD_MP AND NRO_MP=@NRO_MP AND COD_BANCO=@COD_BANCO
AND C.TIPO IN ('O','I')
AND isnull(C.CUENTA_ORIGEN,'')='' 
--AND isnull(A.COD_CC,'')='' 
UNION ALL
SELECT A.COD_CPTO,B.DESC_CPTO,C.COD_AREA  FROM T_BANCO AS A  --,C.CUENTA_ENLACE  
LEFT JOIN MAESTRO_CONCEPTOS AS B ON A.COD_CPTO=B.COD_CPTO
LEFT JOIN CONCEPTO_CUENTA AS C ON A.COD_CPTO=C.COD_CPTO  WHERE   A.STATUS_TRANS='N ' AND
COD_MP=@COD_MP AND NRO_MP=@NRO_MP AND COD_BANCO=@COD_BANCO
AND C.TIPO='G' 
AND (ISNULL(C.CUENTA_ORIGEN,'')=''  
OR (ISNULL(C.CUENTA_ORIGEN,'')<>'' AND ISNULL(A.COD_CC,'')=''))
END