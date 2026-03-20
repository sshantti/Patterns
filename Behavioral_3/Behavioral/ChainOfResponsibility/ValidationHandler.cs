namespace Behavioral.ChainOfResponsibility
{
    public abstract class ValidationHandler
    {
        protected ValidationHandler? NextHandler;

        public ValidationHandler SetNext(ValidationHandler nextHandler)
        {
            NextHandler = nextHandler;
            return nextHandler; // Возвращаем для удобного построения цепочки
        }

        public abstract bool HandleRequest(double value, string parameterName);
    }
}