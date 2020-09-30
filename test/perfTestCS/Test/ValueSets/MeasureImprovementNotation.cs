// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Observation values that indicate what change in a measurement value or score is indicative of an improvement in the measured item or scored issue.
  /// </summary>
  public static class MeasureImprovementNotationCodes
  {
    /// <summary>
    /// Improvement is indicated as a decrease in the score or measurement (e.g. Lower score indicates better quality).
    /// </summary>
    public static readonly Coding DecreasedScoreIndicatesImprovement = new Coding
    {
      Code = "decrease",
      Display = "Decreased score indicates improvement",
      System = "http://terminology.hl7.org/CodeSystem/measure-improvement-notation"
    };
    /// <summary>
    /// Improvement is indicated as an increase in the score or measurement (e.g. Higher score indicates better quality).
    /// </summary>
    public static readonly Coding IncreasedScoreIndicatesImprovement = new Coding
    {
      Code = "increase",
      Display = "Increased score indicates improvement",
      System = "http://terminology.hl7.org/CodeSystem/measure-improvement-notation"
    };
  };
}