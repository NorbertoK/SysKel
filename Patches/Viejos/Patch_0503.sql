CREATE Function dbo.Redondeo(@Val Decimal(32,16))
Returns Decimal(32,2)
AS
Begin
    Return Case When Abs(@Val - Round(@Val, 2, 1)) * Power(10, 2+1) = 5
                Then Round(@Val, 2, 1)
                Else Round(@Val, 2)
                End
End