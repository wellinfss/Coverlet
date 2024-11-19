using System.Diagnostics.CodeAnalysis;

[ExcludeFromCodeCoverage]
public class Cliente
{
    public int Id { get; set; }
    public required string Nome { get; set; }
    public required string Email { get; set; }
}
