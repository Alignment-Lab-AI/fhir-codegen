// <auto-generated />
// Built from: hl7.fhir.r3.core version: 3.0.2
  // Option: "NAMESPACE" = "fhirCsR3"

using fhirCsR3.Models;

namespace fhirCsR3.ValueSets
{
  /// <summary>
  /// This example value set defines a set of codes that can be used to indicate the current state of the animal's reproductive organs.
  /// </summary>
  public static class AnimalGenderstatusCodes
  {
    /// <summary>
    /// The animal's reproductive organs are intact.
    /// </summary>
    public static readonly Coding Intact = new Coding
    {
      Code = "intact",
      Display = "Intact",
      System = "http://hl7.org/fhir/animal-genderstatus"
    };
    /// <summary>
    /// The animal has been sterilized, castrated or otherwise made infertile.
    /// </summary>
    public static readonly Coding Neutered = new Coding
    {
      Code = "neutered",
      Display = "Neutered",
      System = "http://hl7.org/fhir/animal-genderstatus"
    };
    /// <summary>
    /// Unable to determine whether the animal has been neutered.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/animal-genderstatus"
    };

    /// <summary>
    /// Literal for code: Intact
    /// </summary>
    public const string LiteralIntact = "intact";

    /// <summary>
    /// Literal for code: AnimalGenderstatusIntact
    /// </summary>
    public const string LiteralAnimalGenderstatusIntact = "http://hl7.org/fhir/animal-genderstatus#intact";

    /// <summary>
    /// Literal for code: Neutered
    /// </summary>
    public const string LiteralNeutered = "neutered";

    /// <summary>
    /// Literal for code: AnimalGenderstatusNeutered
    /// </summary>
    public const string LiteralAnimalGenderstatusNeutered = "http://hl7.org/fhir/animal-genderstatus#neutered";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: AnimalGenderstatusUnknown
    /// </summary>
    public const string LiteralAnimalGenderstatusUnknown = "http://hl7.org/fhir/animal-genderstatus#unknown";

    /// <summary>
    /// Dictionary for looking up AnimalGenderstatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "intact", Intact }, 
      { "http://hl7.org/fhir/animal-genderstatus#intact", Intact }, 
      { "neutered", Neutered }, 
      { "http://hl7.org/fhir/animal-genderstatus#neutered", Neutered }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/animal-genderstatus#unknown", Unknown }, 
    };
  };
}