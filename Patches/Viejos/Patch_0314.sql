USE [Datos]
GO
/****** Object:  UserDefinedFunction [dbo].[DatosAfiliadoParaTomaLlamado]    Script Date: 03/23/2014 12:55:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		NK
-- Create date: 
-- Description:	
-- =============================================
ALTER FUNCTION [dbo].[DatosAfiliadoParaTomaLlamado] 
(	
	-- Add the parameters for the function here
	@idAfiliado int
)
RETURNS TABLE 
AS
RETURN 
(
	SELECT
        af.idAfiliado,
		af.ApelNomb AS Nombre,
		af.idTipoDeDocumento,
		af.NumeroDeDocumento,
		af.FechaDeNacimiento AS FechaDeNacimiento,
		af.Sexo AS Sexo,
        af.idPrepago AS idPrepago,
        af.NumeroAfiliadoPrepago AS NumeroAfiliadoPrepago,
		left(CASE WHEN af.Asma=1 THEN 'Asma, '  ELSE '' END +
		     CASE WHEN af.Diabetes=1 THEN 'Diabetes, '  ELSE '' END +
		     CASE WHEN af.Tabaco=1  THEN 'Tabaquismo, '   ELSE ''  END +
		     CASE WHEN af.Hipertension=1  THEN 'Hipertensión, '  ELSE ''  END +
		     CASE WHEN af.Corazon=1 THEN 'Cardiopatía, '  ELSE '' END +
		     CASE WHEN ISNULL(af.Alergia,'')<>'' THEN 'Alergia: '+af.Alergia  + ', '   ELSE ''  END +
		     CASE WHEN ISNULL(af.Otros,'')<>'' THEN af.Otros + ', '  ELSE ''  END +
		     CASE WHEN ISNULL(lug.Nombre,'')<>'' THEN 'Interna en '+lug.Nombre + ', '  ELSE  ''  END +
             CASE WHEN ISNULL(MdC.NombApel,'')<>'' THEN 'Médico de Cabecera: '+MdC.NombApel + ', '  ELSE  ''  END +
             CASE WHEN ISNULL(oc.Nombre,'')<>'' THEN 'Ocupación: '+oc.Nombre + ', '  ELSE  ''  END,
             len(CASE WHEN af.Asma=1 THEN 'Asma, '  ELSE ', ' END +
		         CASE WHEN af.Diabetes=1 THEN 'Diabetes, '  ELSE '' END +
		         CASE WHEN af.Tabaco=1  THEN 'Tabaquismo, '   ELSE ''  END +
		         CASE WHEN af.Hipertension=1  THEN 'Hipertensión, '  ELSE ''  END +
		         CASE WHEN af.Corazon=1 THEN 'Cardiopatía, '  ELSE '' END +
		         CASE WHEN ISNULL(af.Alergia,'')<>'' THEN 'Alergia: '+af.Alergia  + ', '   ELSE ''  END +
		         CASE WHEN ISNULL(af.Otros,'')<>'' THEN af.Otros + ', '  ELSE ''  END +
		         CASE WHEN ISNULL(lug.Nombre,'')<>'' THEN 'Interna en '+lug.Nombre + ', '  ELSE  ''  END +
                 CASE WHEN ISNULL(MdC.NombApel,'')<>'' THEN 'Médico de Cabecera: '+MdC.NombApel + ', '  ELSE  ''  END +
                 CASE WHEN ISNULL(oc.Nombre,'')<>'' THEN 'Ocupación: '+oc.Nombre + ', '  ELSE  ''  END
                )- CASE WHEN LEN(CASE WHEN af.Asma=1 THEN 'Asma, '  ELSE '' END +
		                         CASE WHEN af.Diabetes=1 THEN 'Diabetes, '  ELSE '' END +
		                         CASE WHEN af.Tabaco=1  THEN 'Tabaquismo, '   ELSE ''  END +
		                         CASE WHEN af.Hipertension=1  THEN 'Hipertensión, '  ELSE ''  END +
		                         CASE WHEN af.Corazon=1 THEN 'Cardiopatía, '  ELSE '' END +
		                         CASE WHEN ISNULL(af.Alergia,'')<>'' THEN 'Alergia: '+af.Alergia  + ', '   ELSE ''  END +
		                         CASE WHEN ISNULL(af.Otros,'')<>'' THEN af.Otros + ', '  ELSE ''  END +
		                         CASE WHEN ISNULL(lug.Nombre,'')<>'' THEN 'Interna en '+lug.Nombre + ', '  ELSE  ''  END +
                                 CASE WHEN ISNULL(MdC.NombApel,'')<>'' THEN 'Médico de Cabecera: '+MdC.NombApel + ', '  ELSE  ''  END +
                                 CASE WHEN ISNULL(oc.Nombre,'')<>'' THEN 'Ocupación: '+oc.Nombre + ', '  ELSE  ''  END
                                )=0 THEN 0 ELSE 3 END
            ) AS Antecedentes,
            (
                SELECT  Fecha
                        FROM    dbo.Solicitudes
                        WHERE   idSolicitud =   (   SELECT  min(idSolicitud)
                                                    FROM    dbo.Solicitudes
                                                    WHERE   idAfiliado = @idAfiliado AND
                                                            AltaBajaSusp = 'A'
                                                )
            ) AS FechaAfiliacion
FROM       Afiliados AS af
LEFT JOIN  Lugares AS lug ON af.idLugarDeInternacion = lug.idLugar
LEFT JOIN  Prepagos AS prep ON af.idPrepago = prep.idPrepago
LEFT JOIN  MedicosDeCabecera AS MdC ON MdC.idMedicoDeCabecera = af.idMedicoDeCabecera
LEFT JOIN  Ocupaciones AS oc ON oc.idOcupacion = af.idOcupacion
WHERE af.idAfiliado = @idAfiliado
)
