// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Whether the results by exposure is describing the results for the primary exposure of interest (exposure) or the alternative state (exposureAlternative).
  /// </summary>
  public static class ExposureStateCodes
  {
    /// <summary>
    /// used when the results by exposure is describing the results for the primary exposure of interest.
    /// </summary>
    public static readonly Coding Exposure = new Coding
    {
      Code = "exposure",
      Display = "Exposure",
      System = "http://hl7.org/fhir/exposure-state"
    };
    /// <summary>
    /// used when the results by exposure is describing the results for the alternative exposure state, control state or comparator state.
    /// </summary>
    public static readonly Coding ExposureAlternative = new Coding
    {
      Code = "exposure-alternative",
      Display = "Exposure Alternative",
      System = "http://hl7.org/fhir/exposure-state"
    };
  };
}