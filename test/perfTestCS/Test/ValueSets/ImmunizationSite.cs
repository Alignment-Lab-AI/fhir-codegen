// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the body site where the vaccination occurred. This value set is provided as a suggestive example.
  /// </summary>
  public static class ImmunizationSiteCodes
  {
    /// <summary>
    /// left arm
    /// </summary>
    public static readonly Coding LeftArm = new Coding
    {
      Code = "LA",
      Display = "left arm",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActSite"
    };
    /// <summary>
    /// right arm
    /// </summary>
    public static readonly Coding RightArm = new Coding
    {
      Code = "RA",
      Display = "right arm",
      System = "http://terminology.hl7.org/CodeSystem/v3-ActSite"
    };
  };
}