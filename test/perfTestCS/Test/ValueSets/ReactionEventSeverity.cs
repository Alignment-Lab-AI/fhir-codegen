// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Clinical assessment of the severity of a reaction event as a whole, potentially considering multiple different manifestations.
  /// </summary>
  public static class ReactionEventSeverityCodes
  {
    /// <summary>
    /// Causes mild physiological effects.
    /// </summary>
    public static readonly Coding Mild = new Coding
    {
      Code = "mild",
      Display = "Mild",
      System = "http://hl7.org/fhir/reaction-event-severity"
    };
    /// <summary>
    /// Causes moderate physiological effects.
    /// </summary>
    public static readonly Coding Moderate = new Coding
    {
      Code = "moderate",
      Display = "Moderate",
      System = "http://hl7.org/fhir/reaction-event-severity"
    };
    /// <summary>
    /// Causes severe physiological effects.
    /// </summary>
    public static readonly Coding Severe = new Coding
    {
      Code = "severe",
      Display = "Severe",
      System = "http://hl7.org/fhir/reaction-event-severity"
    };
  };
}