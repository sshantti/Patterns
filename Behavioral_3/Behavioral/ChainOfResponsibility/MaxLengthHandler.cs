using System;

namespace Behavioral.ChainOfResponsibility
{
    public class MaxLengthHandler : ValidationHandler
    {
        private readonly double _maxValue;

        public MaxLengthHandler(double maxValue)
        {
            _maxValue = maxValue;
        }

        public override bool HandleRequest(double value, string parameterName)
        {
            if (value > _maxValue)
            {
                Console.WriteLine($"Предупреждение: Параметр '{parameterName}' слишком велик! Лимит: {_maxValue}.");
                return false;
            }

            return NextHandler?.HandleRequest(value, parameterName) ?? true;
        }
    }
}