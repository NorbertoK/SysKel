  UPDATE    dbo.TandasDeFacturacion
  SET       Nombre = '1 -10 MENSUAL B'
  WHERE     Nombre = '1 -10 MENSUAL'
  UPDATE    dbo.TandasDeFacturacion
  SET       Nombre = 'FIN DE MES B'
  WHERE     Nombre = 'FIN DE MES'
  UPDATE    dbo.TandasDeFacturacion
  SET       Nombre = 'EVENTUAL B'
  WHERE     Nombre = 'EVENTUAL'
  UPDATE    dbo.TandasDeFacturacion
  SET       Nombre = 'BANCO DE ACCION SOCIAL B'
  WHERE     Nombre = 'BANCO DE ACCION SOCIAL'
  INSERT    dbo.TandasDeFacturacion
            ( Nombre, Marca )
  VALUES    ( '1 -10 MENSUAL A', 1 )
  INSERT    dbo.TandasDeFacturacion
            ( Nombre, Marca )
  VALUES    ( 'FIN DE MES A', 1 )
  INSERT    dbo.TandasDeFacturacion
            ( Nombre, Marca )
  VALUES    ( 'EVENTUAL A', 1 )
  INSERT    dbo.TandasDeFacturacion
            ( Nombre, Marca )
  VALUES    ( 'BANCO DE ACCION SOCIAL B', 1 )
  UPDATE    dbo.FacturasProforma
  SET       idTandaDeFacturacion = 7
  FROM      dbo.FacturasProforma fp
            JOIN dbo.Clientes cli ON fp.idCliente = cli.idCliente
  WHERE     cli.idCategoriaIva = 10
            AND fp.idTandaDeFacturacion = 1
  UPDATE    dbo.FacturasProforma
  SET       idTandaDeFacturacion = 8
  FROM      dbo.FacturasProforma fp
            JOIN dbo.Clientes cli ON fp.idCliente = cli.idCliente
  WHERE     cli.idCategoriaIva = 10
            AND fp.idTandaDeFacturacion = 3
  UPDATE    dbo.FacturasProforma
  SET       idTandaDeFacturacion = 9
  FROM      dbo.FacturasProforma fp
            JOIN dbo.Clientes cli ON fp.idCliente = cli.idCliente
  WHERE     cli.idCategoriaIva = 10
            AND fp.idTandaDeFacturacion = 4
  UPDATE    dbo.FacturasProforma
  SET       idTandaDeFacturacion = 10
  FROM      dbo.FacturasProforma fp
            JOIN dbo.Clientes cli ON fp.idCliente = cli.idCliente
  WHERE     cli.idCategoriaIva = 10
            AND fp.idTandaDeFacturacion = 5