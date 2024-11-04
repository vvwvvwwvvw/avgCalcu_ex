 namespace avgCalcu_ex
{
     class Program
    {
        static double Mean(double[] x)
        {
            double mean = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                mean = mean + x[i];
            }
            mean = mean / x.Length;
            return mean;
        }
        static double Variance(double[] x)
        {
            double mean = Mean(x);
            double variance = 0.0;
            for (int i = 0; i < x.Length; i++)
            {
                variance = variance + (mean - x[i]) * (mean - x[i]);
            }
            return variance;
        }
        static void Main(string[] args)
        {
            int N = 0;
            double mean = 0.0;
            double variance = 0.0;
            double sum = 0.0;

            Console.Write("제품 개수를 입력하세요");
            N = int.Parse(Console.ReadLine());
            double[] data = new double[N];
            for (int i = 0; i < N; i++)
            {
                Console.Write("{0}번째 데이터를 입력하세요", i + 1);
                data[i] = double.Parse(Console.ReadLine());
            }
            mean = Mean(data);
            variance = Variance(data);

            Console.WriteLine("제품 길의 평균은 {0,2:F} 입니다", mean);
            Console.WriteLine("제품 길이 분산은 {0,2:F} 입니다", variance);
        }
    }
}
