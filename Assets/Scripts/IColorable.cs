
public interface IColorable
{
    public ColorType  Color { get; set; }

    public bool CheckSameColor(IColorable otherColorObject);

}

public enum ColorType
{
    RED,
    ORANGE,
    YELLLOW,
    GREEN,
    BLUE

}
    
