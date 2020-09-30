// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set includes smattering of Adjudication Reason codes.
  /// </summary>
  public static class AdjudicationReasonCodes
  {
    /// <summary>
    /// Not covered
    /// </summary>
    public static readonly Coding NotCovered = new Coding
    {
      Code = "ar001",
      Display = "Not covered",
      System = "http://terminology.hl7.org/CodeSystem/adjudication-reason"
    };
    /// <summary>
    /// Plan Limit Reached
    /// </summary>
    public static readonly Coding PlanLimitReached = new Coding
    {
      Code = "ar002",
      Display = "Plan Limit Reached",
      System = "http://terminology.hl7.org/CodeSystem/adjudication-reason"
    };
  };
}