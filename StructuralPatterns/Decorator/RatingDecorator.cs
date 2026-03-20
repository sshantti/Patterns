using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    internal class RatingDecorator : BookDecorator
    {
        private readonly int _rating;
        private const int MaxRating = 5;
        public RatingDecorator(IBook book, int rating) : base(book)
        {
            _rating = rating;
        }

        public override string GetInfo() => $"{base.GetInfo()} | Рейтинг: {_rating}/{MaxRating} звезд";
    }

    public class ReadStatusDecorator : BookDecorator
    {
        private readonly bool _isRead;

        public ReadStatusDecorator(IBook book, bool isRead = true) : base(book)
        {
            _isRead = isRead;
        }

        public override string GetInfo()
        {
            string status = _isRead ? "Прочитано" : "Не прочитано";
            return $"{base.GetInfo()} | Статус: {status}";
        }
    }
}
