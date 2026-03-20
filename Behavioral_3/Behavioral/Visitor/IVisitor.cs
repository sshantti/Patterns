namespace Behavioral.Visitor
{
    public interface IVisitor
    {
        void Visit(Sphere element);
        void Visit(Parallelepiped element);
        void Visit(Torus element);
        void Visit(Cube element);
    }
}