using System;

namespace Exercise_14_Explicit_Interface_Members
{
    public class Box : IEnglishDimensions, IMetricDimensions
    {
        float IEnglishDimensions.Length()
        {
            return 30.0f;
        }

        float IEnglishDimensions.Width()
        {
            return 20.0f;
        }

        float IMetricDimensions.Length()
        {
            return 76.2f;
        }

        float IMetricDimensions.Width()
        {
            return 50.8f;
        }
    }
}
