namespace StructuralPatterns.Decorator
{
    public class RatingDecorator : BookDecorator
    {
        public RatingDecorator(IBook book) : base(book) { }
        public override string GetInfo() => $"{base.GetInfo()} | Рейтинг: 5 звезд";
    }

    public class ReadStatusDecorator : BookDecorator
    {
        public ReadStatusDecorator(IBook book) : base(book) { }
        public override string GetInfo() => $"{base.GetInfo()} | Статус: Прочитано";
    }
}