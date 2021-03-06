﻿
namespace ColorManager.Conversion
{
    /// <summary>
    /// A delegate for color conversions
    /// </summary>
    /// <param name="inColor">The pointer to the input color values</param>
    /// <param name="outColor">The pointer to the output color values</param>
    /// <param name="data">The data that is used to perform the conversion</param>
    public unsafe delegate void ConversionDelegate(double* inColor, double* outColor, ConversionData data);
    /// <summary>
    /// A delegate for color conversions with additional data
    /// </summary>
    /// <param name="inColor">The pointer to the input color values</param>
    /// <param name="outColor">The pointer to the output color values</param>
    /// <param name="data">The data that is used to perform the conversion</param>
    /// <param name="additional">Additional data specific to this conversion</param>
    public unsafe delegate void ConversionExDelegate(double* inColor, double* outColor, ConversionData data, double** additional);
    /// <summary>
    /// A delegate to transform values
    /// </summary>
    /// <param name="inValues">The pointer to the input values</param>
    /// <param name="outValues">The pointer to the output values</param>
    public unsafe delegate void TransformToDelegate(double* inValues, double* outValues);
    /// <summary>
    /// A delegate to transform values directly
    /// </summary>
    /// <param name="values">The pointer to the values to transform</param>
    public unsafe delegate void TransformDelegate(double* values);
    /// <summary>
    /// A delegate to check one or more conditions according to some conversion data
    /// </summary>
    /// <param name="data">The data that will be used to perform a conversion</param>
    /// <returns>The result of the condition</returns>
    public delegate bool ConditionDelegate(ConversionData data);
    /// <summary>
    /// A delegate to write IL code according to some conversion data
    /// </summary>
    /// <param name="data">The data that will be used to perform a conversion</param>
    /// <param name="writer">The IL writer with which the conversion code will be written</param>
    public delegate void ILWriterDelegate(ConversionData data, ILWriter writer);
}
