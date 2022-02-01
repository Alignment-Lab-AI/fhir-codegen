// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// Degree of preference of a type of conditioned specimen.
  /// </summary>
  public static class SpecimenContainedPreferenceCodes
  {
    /// <summary>
    /// This type of conditioned specimen is an alternate.
    /// </summary>
    public static readonly Coding Alternate = new Coding
    {
      Code = "alternate",
      Display = "Alternate",
      System = "http://hl7.org/fhir/specimen-contained-preference"
    };
    /// <summary>
    /// This type of contained specimen is preferred to collect this kind of specimen.
    /// </summary>
    public static readonly Coding Preferred = new Coding
    {
      Code = "preferred",
      Display = "Preferred",
      System = "http://hl7.org/fhir/specimen-contained-preference"
    };
  };
}