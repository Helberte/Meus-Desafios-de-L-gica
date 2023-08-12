using ALGORITMOS_EM_C_;



Console.WriteLine(Result.kangaroo(0, 3, 4, 2));

return;



#region Exercicios Balta

Exercicios exercicios = new();
exercicios.Questao05();

#endregion

return;

#region Evitando Ifs

IPagamento boleto        = new Boleto(new DateTime(2023, 8, 12));
IPagamento cartaoCredito = new CartaoCredito();

Console.WriteLine($"Cartão de crédito: {cartaoCredito.PodeSerPago()}");
Console.WriteLine($"Boleto: {boleto.PodeSerPago()}");

#endregion

