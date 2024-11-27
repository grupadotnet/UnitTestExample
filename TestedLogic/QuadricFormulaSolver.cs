namespace TestedLogic
{
    public static class QuadricFormulaSolver
    {
        public static IEnumerable<double> Solve(double a, double b, double c)
        {
            List<double> res = new();

            var delta = (b*b) - (4 * a * c);

            if (delta == 0)
            {
                res.Add((-b) / (2 * a));
            }
            else if (delta > 0)
            {
                res.Add((-b - Math.Sqrt(delta)) / (2 * a));
                res.Add((-b + Math.Sqrt(delta)) / (2 * a));
            }

            return res;
        }
    }
}
