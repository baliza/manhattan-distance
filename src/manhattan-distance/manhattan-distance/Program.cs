using System;

namespace manhattan_distance
{
	class Program
	{
		static void Main(string[] args)
		{
			var parametersParser = new ParametersParser();
			var messarumentService = new MessarumentService();
			while (true)
			{

				Console.WriteLine(@"Introduce los puntos a calcular con el siguiente formato 
					0.0 3.5
					1.1 0.5");

				var parameters = Console.ReadLine();
				var points = parametersParser.Parse(parameters);
				var result = messarumentService.ManhattanDistance(points[0], points[1]);
				Console.WriteLine(result);
			}
		}
	}
}
