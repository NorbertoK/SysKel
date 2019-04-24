SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION DatosFiliatorios
    (
     @NumeroDeDocumento VARCHAR(10)
    ,@idAfiliado INT
    )
RETURNS TABLE
AS
RETURN
    ( SELECT    af.NombApel + CASE WHEN af.FechaDeNacimiento IS NULL THEN ''
                                   ELSE ', ' + dbo.edadcompleta(af.FechaDeNacimiento, GETDATE())
                              END + CASE WHEN LEN(dbo.DireccionCompleta(dbo.DireccionRealDelAfiliado(af.idAfiliado))) = 0 THEN ''
                                         ELSE ', ' + dbo.DireccionCompleta(dbo.DireccionRealDelAfiliado(af.idAfiliado))
                                    END Nombre
               ,pp.Iniciales + CASE WHEN ISNULL(af.NumeroAfiliadoPrepago, '') = '' THEN ''
                                    ELSE ' ' + af.NumeroAfiliadoPrepago
                               END Prepago
               ,LEFT(CASE WHEN af.Asma = 1 THEN 'Asma, '
                          ELSE ''
                     END + CASE WHEN af.Diabetes = 1 THEN 'Diabetes, '
                                ELSE ''
                           END + CASE WHEN af.Tabaco = 1 THEN 'Tabaquismo, '
                                      ELSE ''
                                 END + CASE WHEN af.Hipertension = 1 THEN 'Hipertensión, '
                                            ELSE ''
                                       END + CASE WHEN af.Corazon = 1 THEN 'Cardiopatía, '
                                                  ELSE ''
                                             END + CASE WHEN ISNULL(af.Alergia, '') <> '' THEN 'Alergia: ' + af.Alergia + ', '
                                                        ELSE ''
                                                   END + CASE WHEN ISNULL(af.Otros, '') <> '' THEN af.Otros + ', '
                                                              ELSE ''
                                                         END + CASE WHEN ISNULL(lug.Nombre, '') <> '' THEN 'Interna en ' + lug.Nombre + ', '
                                                                    ELSE ''
                                                               END + CASE WHEN ISNULL(MdC.NombApel, '') <> '' THEN 'Médico de Cabecera: ' + MdC.NombApel + ', '
                                                                          ELSE ''
                                                                     END + CASE WHEN ISNULL(oc.Nombre, '') <> '' THEN 'Ocupación: ' + oc.Nombre + ', '
                                                                                ELSE ''
                                                                           END,
                     LEN(CASE WHEN af.Asma = 1 THEN 'Asma, '
                              ELSE ', '
                         END + CASE WHEN af.Diabetes = 1 THEN 'Diabetes, '
                                    ELSE ''
                               END + CASE WHEN af.Tabaco = 1 THEN 'Tabaquismo, '
                                          ELSE ''
                                     END + CASE WHEN af.Hipertension = 1 THEN 'Hipertensión, '
                                                ELSE ''
                                           END + CASE WHEN af.Corazon = 1 THEN 'Cardiopatía, '
                                                      ELSE ''
                                                 END + CASE WHEN ISNULL(af.Alergia, '') <> '' THEN 'Alergia: ' + af.Alergia + ', '
                                                            ELSE ''
                                                       END + CASE WHEN ISNULL(af.Otros, '') <> '' THEN af.Otros + ', '
                                                                  ELSE ''
                                                             END + CASE WHEN ISNULL(lug.Nombre, '') <> '' THEN 'Interna en ' + lug.Nombre + ', '
                                                                        ELSE ''
                                                                   END + CASE WHEN ISNULL(MdC.NombApel, '') <> ''
                                                                              THEN 'Médico de Cabecera: ' + MdC.NombApel + ', '
                                                                              ELSE ''
                                                                         END + CASE WHEN ISNULL(oc.Nombre, '') <> '' THEN 'Ocupación: ' + oc.Nombre + ', '
                                                                                    ELSE ''
                                                                               END)
                     - CASE WHEN LEN(CASE WHEN af.Asma = 1 THEN 'Asma, '
                                          ELSE ''
                                     END + CASE WHEN af.Diabetes = 1 THEN 'Diabetes, '
                                                ELSE ''
                                           END + CASE WHEN af.Tabaco = 1 THEN 'Tabaquismo, '
                                                      ELSE ''
                                                 END + CASE WHEN af.Hipertension = 1 THEN 'Hipertensión, '
                                                            ELSE ''
                                                       END + CASE WHEN af.Corazon = 1 THEN 'Cardiopatía, '
                                                                  ELSE ''
                                                             END + CASE WHEN ISNULL(af.Alergia, '') <> '' THEN 'Alergia: ' + af.Alergia + ', '
                                                                        ELSE ''
                                                                   END + CASE WHEN ISNULL(af.Otros, '') <> '' THEN af.Otros + ', '
                                                                              ELSE ''
                                                                         END + CASE WHEN ISNULL(lug.Nombre, '') <> '' THEN 'Interna en ' + lug.Nombre + ', '
                                                                                    ELSE ''
                                                                               END + CASE WHEN ISNULL(MdC.NombApel, '') <> ''
                                                                                          THEN 'Médico de Cabecera: ' + MdC.NombApel + ', '
                                                                                          ELSE ''
                                                                                     END + CASE WHEN ISNULL(oc.Nombre, '') <> ''
                                                                                                THEN 'Ocupación: ' + oc.Nombre + ', '
                                                                                                ELSE ''
                                                                                           END) = 0 THEN 0
                            ELSE 3
                       END) AS Antecedentes, CASE WHEN af.idAfiliado = @idAfiliado THEN 1 ELSE 0 END Elegido
      FROM      dbo.Afiliados af
      LEFT JOIN dbo.Lugares AS lug ON af.idLugarDeInternacion = lug.idLugar
      LEFT JOIN dbo.Prepagos AS prep ON af.idPrepago = prep.idPrepago
      LEFT JOIN dbo.MedicosDeCabecera AS MdC ON MdC.idMedicoDeCabecera = af.idMedicoDeCabecera
      LEFT JOIN dbo.Ocupaciones AS oc ON oc.idOcupacion = af.idOcupacion
      LEFT JOIN dbo.Prepagos AS pp ON af.idPrepago = pp.idPrepago
      WHERE     af.NumeroDeDocumento = @NumeroDeDocumento
    )
GO
