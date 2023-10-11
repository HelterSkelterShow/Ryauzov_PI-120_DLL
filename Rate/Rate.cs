using System;

namespace Rate
{
    public class Rates
    {
        /// <summary>
        /// Метод вычисления суммы выплаты для кредита единовременной выплаты
        /// </summary>
        /// <param name="periods">Количество периодов</param>
        /// <param name="value">Сумма кредита</param>
        /// <param name="percent">Процентная ставка, %</param>
        public static decimal SimpleRate(int periods, decimal value, double percent) 
        {
            percent *= 0.01;
            return (value * periods * (Decimal)percent + value);
        }

        /// <summary>
        /// Метод вычисления суммы выплаты кредита со сложными процентами
        /// </summary>
        /// <param name="periods">Количество периодов</param>
        /// <param name="value">Сумма кредита</param>
        /// <param name="percent">Процентная ставка, %</param>
        public static decimal CompoundRate(int periods, decimal value, double percent) 
        {
            return (Decimal)Math.Pow(1 + percent * 0.01, periods) * value;
        }

        /// <summary>
        /// Метод вычисления суммы выплаты кредита по годовой процентной ставке со сложными процентами
        /// </summary>
        /// <param name="periods">Количество периодов</param>
        /// <param name="value">Сумма кредита</param>
        /// <param name="percent">Годовая процентная ставка, %</param>
        /// <param name="times">Количество начислений за период</param>
        public static decimal AnnualRate(int periods, decimal value, double percent, int times)
        {
            return (Decimal)Math.Pow(1 + percent * 0.01/ times, periods) * value;
        }

        /// <summary>
        /// Метод вычисления суммы выплаты для кредита через непрерывно начисляемых процентов
        /// </summary>
        /// <param name="periods">Количество периодов</param>
        /// <param name="value">Сумма кредита</param>
        /// <param name="percent">Процентная ставка, %</param>
        public static Decimal ContiniousRate(int periods, decimal value, double percent)
        {
            return (Decimal)Math.Pow(Math.E, percent * 0.01 * periods) * value;
        }

        /// <summary>
        /// Метод вычисления реальной процентной ставки
        /// </summary>
        /// <param name="nominalRate">Номинальная процентная ставка, %</param>
        /// <param name="expInflation">Ожидаемая инфляция, %</param>
        public static double RealRate(double nominalRate, double expInflation)
        {
            return nominalRate - expInflation;
        }

        /// <summary>
        /// Метод вычисления реальной процентной ставки по формуле Фишера
        /// </summary>
        /// <param name="nominalRate">Номинальная процентная ставка, %</param>
        /// <param name="expInflation">Ожидаемая инфляция, %</param>
        public static double FisherRealRate(double nominalRate, double expInflation)
        {
            return (1 + nominalRate)/(1 + expInflation) - 1;
        }
    }
}
