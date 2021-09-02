using System;

namespace manhattan_distance
{
	internal class MessarumentService
	{
		internal object ManhattanDistance(Point point1, Point point2)
		{
			var columns = point1.CountColumns(point2);
			var rows = point1.CountRow(point2);
			return columns + rows;
		}
	}
}