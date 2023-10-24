namespace CalculationAreaLib
{
    public class Circle : Figure
    {
        private readonly double _radius;

        /// <summary>
        /// Конструктор создания экземпляра круга
        /// </summary>
        /// <param name="radius">Передаваемое значение радиуса круга</param>
        public Circle(double radius)
        {
            _radius = radius;
        }

        /// <summary>
        /// Метод получения площади круга по радиусу
        /// </summary>
        /// <returns>Значение площади круга</returns>
        public override double GetArea() 
        {
            if( _radius <= 0 ) 
            {
                throw new ArgumentException("Радиус должен быть положительным числом.");
            }
            return Math.PI * _radius * _radius; 
        }
    }
}