using System;

namespace manhattan_distance
{
	public class ParametersParser
	{
		public Point[] Parse(string commandLine)
		{
			var parameters = commandLine.Split(" ");
			var startColumn = int.Parse(parameters[0].Split(".")[0]);
			var startRow = int.Parse(parameters[0].Split(".")[1]);

			var endColumn = int.Parse(parameters[1].Split(".")[0]);
			var endRow = int.Parse(parameters[1].Split(".")[1]);

			var startPoint = new Point(startColumn, startRow);
			var endPoint = new Point(endColumn, endRow);

			return new Point[] { startPoint, endPoint };
		}
	}
}