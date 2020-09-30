// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// This value set includes sample Consent Action codes.
  /// </summary>
  public static class ConsentActionCodes
  {
    /// <summary>
    /// Retrieval without permitting collection, use or disclosure. e.g., no screen-scraping for collection, use or disclosure (view-only access)
    /// </summary>
    public static readonly Coding Access = new Coding
    {
      Code = "access",
      Display = "Access",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Gather retrieved information for storage
    /// </summary>
    public static readonly Coding Collect = new Coding
    {
      Code = "collect",
      Display = "Collect",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Allow retrieval of a patient's information for the purpose of update or rectify
    /// </summary>
    public static readonly Coding AccessAndCorrect = new Coding
    {
      Code = "correct",
      Display = "Access and Correct",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Transfer retrieved information
    /// </summary>
    public static readonly Coding Disclose = new Coding
    {
      Code = "disclose",
      Display = "Disclose",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
    /// <summary>
    /// Utilize the retrieved information
    /// </summary>
    public static readonly Coding Use = new Coding
    {
      Code = "use",
      Display = "Use",
      System = "http://terminology.hl7.org/CodeSystem/consentaction"
    };
  };
}