// Interface for a card (can be implemented by both SpellCard and MonsterCard)
public class Card
{
    int Damage { get; }
    ElementType Element { get; }
    string Name { get; }
}

// Enum to represent element types of a card
public enum ElementType
{
    Fire,
    Water,
    Earth,
    // Add more elements as needed
}
