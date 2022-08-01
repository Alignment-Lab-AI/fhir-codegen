// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// This value set includes a sample set of Forms codes.
  /// </summary>
  public static class FormsCodes
  {
    /// <summary>
    /// Example: The #1 form to be used when printing this information.
    /// </summary>
    public static readonly Coding FormNumber1 = new Coding
    {
      Code = "1",
      Display = "Form #1",
      System = "http://terminology.hl7.org/CodeSystem/forms-codes"
    };
    /// <summary>
    /// Example: The #2 form to be used when printing this information.
    /// </summary>
    public static readonly Coding FormNumber1_2 = new Coding
    {
      Code = "2",
      Display = "Form #1",
      System = "http://terminology.hl7.org/CodeSystem/forms-codes"
    };

    /// <summary>
    /// Literal for code: FormNumber1
    /// </summary>
    public const string LiteralFormNumber1 = "1";

    /// <summary>
    /// Literal for code: FormsFormNumber1
    /// </summary>
    public const string LiteralFormsFormNumber1 = "http://terminology.hl7.org/CodeSystem/forms-codes#1";

    /// <summary>
    /// Literal for code: FormNumber1_2
    /// </summary>
    public const string LiteralFormNumber1_2 = "2";

    /// <summary>
    /// Literal for code: FormsFormNumber1_2
    /// </summary>
    public const string LiteralFormsFormNumber1_2 = "http://terminology.hl7.org/CodeSystem/forms-codes#2";

    /// <summary>
    /// Dictionary for looking up Forms Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "1", FormNumber1 }, 
      { "http://terminology.hl7.org/CodeSystem/forms-codes#1", FormNumber1 }, 
      { "2", FormNumber1_2 }, 
      { "http://terminology.hl7.org/CodeSystem/forms-codes#2", FormNumber1_2 }, 
    };
  };
}