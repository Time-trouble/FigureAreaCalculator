namespace CalculationAreaLib
{
    public class Triangle : Figure
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        /// <summary>
        /// Конструктор создания экзмпляра треугольника
        /// </summary>
        /// <param name="a">Сторона A</param>
        /// <param name="b">Сторона B</param>
        /// <param name="c">Сторона C</param>
        public Triangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }

        /// <summary>
        /// Метод получения площади треугольника
        /// </summary>
        /// <returns>Значение площади треугольника</returns>
        public override double GetArea()
        {
            if (_a <= 0 || _b <= 0 || _c <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть больше нуля.");
            }

            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            {
                throw new ArgumentException("Треугольника с такими сторонами не может существовать.");
            }

            var perimeter = (_a + _b + _c) / 2;
            var area = Math.Sqrt(perimeter * (perimeter - _a) * (perimeter - _b) * (perimeter - _c));
            
            return area;
        }

        /// <summary>
        /// Метод проверки является ли треугольник прямоугольным 
        /// </summary>
        /// <returns>Ответ является ли треугольник прямоугольным или нет</returns>
        public bool IstRiangleRectangular()
        {
            if(_a <= 0 || _b <= 0 || _c <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть больше нуля.");
            }

            if (_a + _b <= _c || _a + _c <= _b || _b + _c <= _a)
            {
                throw new ArgumentException("Треугольника с такими сторонами не может существовать.");
            }

            var powA = _a * _a;
            var powB = _b * _b;
            var powC = _c * _c;

            return (powA + powB == powC) || 
                   (powA + powC == powB) || 
                   (powB + powC == powA);
        }
    }
}
