using System;

namespace Practise
{
    public interface IDemo
    {
        int Length { get; set; }
        int NumberOfSides { get; set; }

        int CalculatePerimeter();

        int CalculateArea();

    }
}