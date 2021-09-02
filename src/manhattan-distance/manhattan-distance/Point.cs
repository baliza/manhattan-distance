using System;

namespace manhattan_distance
{
	public class Point
	{
		private int _columna;
		private int _row;

		public Point(int columna, int row)
		{
			_columna = columna;
			_row = row;
		}

		public int CountColumns(Point endPoint)
		{
			return Math.Abs(_columna - endPoint._columna);
		}

		public int CountRow(Point endPoint)
		{
			return Math.Abs(_row - endPoint._row);
		}
	}
}