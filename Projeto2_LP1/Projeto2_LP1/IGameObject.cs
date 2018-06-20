namespace Projeto2_LP1
{
    /// <summary>
    /// Interface constituida por duas propriedades auto-implementadas. Qualquer 
    /// classe que implementar esta interface, têm a possibilidade de obter o 
    /// respectivo nome e símbolo de cada objecto criado.
    /// </summary>
    interface IGameObject
    {
        string Name { get; set; }
        string Symbol { get; set; }
    }
}