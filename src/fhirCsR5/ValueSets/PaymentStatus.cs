// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// This value set includes a sample set of Payment Status codes.
  /// </summary>
  public static class PaymentStatusCodes
  {
    /// <summary>
    /// Cleared
    /// </summary>
    public static readonly Coding Cleared = new Coding
    {
      Code = "cleared",
      Display = "Cleared",
      System = "http://terminology.hl7.org/CodeSystem/paymentstatus"
    };
    /// <summary>
    /// Paid
    /// </summary>
    public static readonly Coding Paid = new Coding
    {
      Code = "paid",
      Display = "Paid",
      System = "http://terminology.hl7.org/CodeSystem/paymentstatus"
    };

    /// <summary>
    /// Literal for code: Cleared
    /// </summary>
    public const string LiteralCleared = "cleared";

    /// <summary>
    /// Literal for code: PaymentstatusCleared
    /// </summary>
    public const string LiteralPaymentstatusCleared = "http://terminology.hl7.org/CodeSystem/paymentstatus#cleared";

    /// <summary>
    /// Literal for code: Paid
    /// </summary>
    public const string LiteralPaid = "paid";

    /// <summary>
    /// Literal for code: PaymentstatusPaid
    /// </summary>
    public const string LiteralPaymentstatusPaid = "http://terminology.hl7.org/CodeSystem/paymentstatus#paid";

    /// <summary>
    /// Dictionary for looking up PaymentStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "cleared", Cleared }, 
      { "http://terminology.hl7.org/CodeSystem/paymentstatus#cleared", Cleared }, 
      { "paid", Paid }, 
      { "http://terminology.hl7.org/CodeSystem/paymentstatus#paid", Paid }, 
    };
  };
}