// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// BiologicallyDerived Product Storage Scale.
  /// </summary>
  public static class ProductStorageScaleCodes
  {
    /// <summary>
    /// Celsius or centigrade temperature scale.
    /// </summary>
    public static readonly Coding Celsius = new Coding
    {
      Code = "celsius",
      Display = "Celsius",
      System = "http://hl7.org/fhir/product-storage-scale"
    };
    /// <summary>
    /// Fahrenheit temperature scale.
    /// </summary>
    public static readonly Coding Fahrenheit = new Coding
    {
      Code = "farenheit",
      Display = "Fahrenheit",
      System = "http://hl7.org/fhir/product-storage-scale"
    };
    /// <summary>
    /// Kelvin absolute thermodynamic temperature scale.
    /// </summary>
    public static readonly Coding Kelvin = new Coding
    {
      Code = "kelvin",
      Display = "Kelvin",
      System = "http://hl7.org/fhir/product-storage-scale"
    };
  };
}