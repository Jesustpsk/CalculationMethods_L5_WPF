using System;

namespace CalculationMethods_L5_WPF;

public abstract class Lagrange
{
    private static double[] _xValues;
    private static double[] _yValues;

    public static void Fill(double[] x, double[] y)
    {
        if (x.Length != y.Length) 
            throw new ArgumentException("Количество узлов должно быть одинаковым.");
        _xValues = x;
        _yValues = y;
    }
    /*public static double Interpolate(double x)
    {
        // Проверка на выход за границы узлов
        if (Math.Abs(x) < Math.Abs(_xValues[0]) || Math.Abs(x) > Math.Abs(_xValues[^1]))
            throw new ArgumentException("Точка x находится вне диапазона узлов.");

        // Найти ближайшие узлы
        var i = 0;
        while (i < _xValues.Length && Math.Abs(_xValues[i]) < Math.Abs(x))
            i++;

        // Линейная интерполяция
        var x0 = _xValues[i - 1];
        var x1 = _xValues[i];
        var y0 = _yValues[i - 1];
        var y1 = _yValues[i];

        var interpolatedValue = y0 + ((x - x0) / (x1 - x0)) * (y1 - y0);
        return interpolatedValue;
    }*/
    public static double Interpolate(double x)
    {
        int i = 0;
        // Проверка на выход за границы узлов
        if (x >= 0)
        {
            if (x < _xValues[0] || x > _xValues[^1])
                throw new ArgumentException("Точка x находится вне диапазона узлов.");
            while (i < _xValues.Length && _xValues[i] < x) // Найти ближайшие узлы
                i++;
        }
        else
        {
            if (x > _xValues[0] || x < _xValues[^1])
                throw new ArgumentException("Точка x находится вне диапазона узлов.");
            while (i < _xValues.Length && _xValues[i] >= x) // Найти ближайшие узлы
                i++;
        }

        // Линейная интерполяция
        var x0 = _xValues[i - 1];
        var x1 = _xValues[i];
        var y0 = _yValues[i - 1];
        var y1 = _yValues[i];

        double interpolatedValue = y0 + ((x - x0) / (x1 - x0)) * (y1 - y0);
        return interpolatedValue;
    }
}