Console.WriteLine("Porfavor ingrese el consumo total: ");
decimal consumo1 = Convert.ToDecimal(Console.ReadLine());
decimal descuento = 0;
if (consumo1 <= 100)
{
    descuento = consumo1 * 0.10m;
}
else
{
    descuento = consumo1 * 0.20m;
}
decimal subtotal = consumo1 - descuento;
decimal impuesto = subtotal * 0.18m;
decimal totalAPagar = subtotal + impuesto;
Console.WriteLine($"Total consumido: S/ {consumo1}");
Console.WriteLine($"Descuento aplicado: S/ {descuento}");
Console.WriteLine($"Impuesto del 18%: S/ {impuesto}");
Console.WriteLine($"Subtotal sin impuesto aplicado: S/ {subtotal}");
Console.WriteLine($"Total a pagar: S/ {totalAPagar}");
Console.ReadLine();