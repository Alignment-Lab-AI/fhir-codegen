// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Telecommunications form for contact point
  /// </summary>
  public static class ContactPointSystemCodes
  {
    /// <summary>
    /// The value is an email address.
    /// </summary>
    public static readonly Coding Email = new Coding
    {
      Code = "email",
      Display = "Email",
      System = "http://hl7.org/fhir/contact-point-system"
    };
    /// <summary>
    /// The value is a fax machine. Use of full international numbers starting with + is recommended to enable automatic dialing support but not required.
    /// </summary>
    public static readonly Coding Fax = new Coding
    {
      Code = "fax",
      Display = "Fax",
      System = "http://hl7.org/fhir/contact-point-system"
    };
    /// <summary>
    /// A contact that is not a phone, fax, or email address. The format of the value SHOULD be a URL. This is intended for various personal contacts including blogs, Twitter, Facebook, etc. Do not use for email addresses. If this is not a URL, then it will require human interpretation.
    /// </summary>
    public static readonly Coding URL = new Coding
    {
      Code = "other",
      Display = "URL",
      System = "http://hl7.org/fhir/contact-point-system"
    };
    /// <summary>
    /// The value is a pager number. These may be local pager numbers that are only usable on a particular pager system.
    /// </summary>
    public static readonly Coding Pager = new Coding
    {
      Code = "pager",
      Display = "Pager",
      System = "http://hl7.org/fhir/contact-point-system"
    };
    /// <summary>
    /// The value is a telephone number used for voice calls. Use of full international numbers starting with + is recommended to enable automatic dialing support but not required.
    /// </summary>
    public static readonly Coding Phone = new Coding
    {
      Code = "phone",
      Display = "Phone",
      System = "http://hl7.org/fhir/contact-point-system"
    };

    /// <summary>
    /// Literal for code: Email
    /// </summary>
    public const string LiteralEmail = "email";

    /// <summary>
    /// Literal for code: ContactPointSystemEmail
    /// </summary>
    public const string LiteralContactPointSystemEmail = "http://hl7.org/fhir/contact-point-system#email";

    /// <summary>
    /// Literal for code: Fax
    /// </summary>
    public const string LiteralFax = "fax";

    /// <summary>
    /// Literal for code: ContactPointSystemFax
    /// </summary>
    public const string LiteralContactPointSystemFax = "http://hl7.org/fhir/contact-point-system#fax";

    /// <summary>
    /// Literal for code: URL
    /// </summary>
    public const string LiteralURL = "other";

    /// <summary>
    /// Literal for code: ContactPointSystemURL
    /// </summary>
    public const string LiteralContactPointSystemURL = "http://hl7.org/fhir/contact-point-system#other";

    /// <summary>
    /// Literal for code: Pager
    /// </summary>
    public const string LiteralPager = "pager";

    /// <summary>
    /// Literal for code: ContactPointSystemPager
    /// </summary>
    public const string LiteralContactPointSystemPager = "http://hl7.org/fhir/contact-point-system#pager";

    /// <summary>
    /// Literal for code: Phone
    /// </summary>
    public const string LiteralPhone = "phone";

    /// <summary>
    /// Literal for code: ContactPointSystemPhone
    /// </summary>
    public const string LiteralContactPointSystemPhone = "http://hl7.org/fhir/contact-point-system#phone";

    /// <summary>
    /// Dictionary for looking up ContactPointSystem Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "email", Email }, 
      { "http://hl7.org/fhir/contact-point-system#email", Email }, 
      { "fax", Fax }, 
      { "http://hl7.org/fhir/contact-point-system#fax", Fax }, 
      { "other", URL }, 
      { "http://hl7.org/fhir/contact-point-system#other", URL }, 
      { "pager", Pager }, 
      { "http://hl7.org/fhir/contact-point-system#pager", Pager }, 
      { "phone", Phone }, 
      { "http://hl7.org/fhir/contact-point-system#phone", Phone }, 
    };
  };
}