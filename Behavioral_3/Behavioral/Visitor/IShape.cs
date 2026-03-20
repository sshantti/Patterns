namespace Behavioral.Visitor
{
    public interface IShape
    {
        void Accept(IVisitor visitor);
    }
}