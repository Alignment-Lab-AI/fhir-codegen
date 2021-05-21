// <auto-generated />
// Built from: hl7.fhir.r5.core version: 4.6.0
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The relationship between concepts.
  /// </summary>
  public static class ConceptMapRelationshipCodes
  {
    /// <summary>
    /// The definitions of the concepts mean the same thing.
    /// </summary>
    public static readonly Coding Equivalent = new Coding
    {
      Code = "equivalent",
      Display = "Equivalent",
      System = "http://hl7.org/fhir/concept-map-relationship"
    };
    /// <summary>
    /// This is an explicit assertion that the target concept is not related to the source concept.
    /// </summary>
    public static readonly Coding NotRelatedTo = new Coding
    {
      Code = "not-related-to",
      Display = "Not Related To",
      System = "http://hl7.org/fhir/concept-map-relationship"
    };
    /// <summary>
    /// The concepts are related to each other, but the exact relationship is not known.
    /// </summary>
    public static readonly Coding RelatedTo = new Coding
    {
      Code = "related-to",
      Display = "Related To",
      System = "http://hl7.org/fhir/concept-map-relationship"
    };
    /// <summary>
    /// The source concept is broader in meaning than the target concept.
    /// </summary>
    public static readonly Coding SourceIsBroaderThanTarget = new Coding
    {
      Code = "source-is-broader-than-target",
      Display = "Source Is Broader Than Target",
      System = "http://hl7.org/fhir/concept-map-relationship"
    };
    /// <summary>
    /// The source concept is narrower in meaning than the target concept.
    /// </summary>
    public static readonly Coding SourceIsNarrowerThanTarget = new Coding
    {
      Code = "source-is-narrower-than-target",
      Display = "Source Is Narrower Than Target",
      System = "http://hl7.org/fhir/concept-map-relationship"
    };
  };
}