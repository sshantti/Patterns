using System;

namespace Behavioral.ChainOfResponsibility
{
    public class PositiveValueHandler : ValidationHandler
    {
        private const double MinimumAllowedValue = 0.0;
        public override bool HandleRequest(double value, string parameterName)
        {
            if (value <= MinimumAllowedValue)
            {
                Console.WriteLine($"Ошибка: Параметр '{parameterName}' должен быть больше нуля (передано: {value}).");
                return false;
            }

            return NextHandler?.HandleRequest(value, parameterName) ?? true;
        }
    }
}