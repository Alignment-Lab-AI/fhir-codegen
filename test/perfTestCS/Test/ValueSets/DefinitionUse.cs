// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using Fhir.R4.Models;

namespace Fhir.R4.ValueSets
{
  /// <summary>
  /// Structure Definition Use Codes / Keywords
  /// </summary>
  public static class DefinitionUseCodes
  {
    /// <summary>
    /// This structure captures an analysis of a domain
    /// </summary>
    public static readonly Coding DomainAnalysisModel = new Coding
    {
      Code = "archetype",
      Display = "Domain Analysis Model",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// This structure is intended to be treated like a FHIR resource (e.g. on the FHIR API)
    /// </summary>
    public static readonly Coding CustomResource = new Coding
    {
      Code = "custom-resource",
      Display = "Custom Resource",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// This structure captures an analysis of a domain
    /// </summary>
    public static readonly Coding DomainAnalysisModel_2 = new Coding
    {
      Code = "dam",
      Display = "Domain Analysis Model",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// This structure is defined as part of the base FHIR Specification
    /// </summary>
    public static readonly Coding FHIRStructure = new Coding
    {
      Code = "fhir-structure",
      Display = "FHIR Structure",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// This structure is a template (n.b: 'template' has many meanings)
    /// </summary>
    public static readonly Coding Template = new Coding
    {
      Code = "template",
      Display = "Template",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
    /// <summary>
    /// This structure represents and existing structure (e.g. CDA, HL7 v2)
    /// </summary>
    public static readonly Coding WireFormat = new Coding
    {
      Code = "wire-format",
      Display = "Wire Format",
      System = "http://terminology.hl7.org/CodeSystem/definition-use"
    };
  };
}