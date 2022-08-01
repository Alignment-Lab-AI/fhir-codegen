// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1
  // Option: "NAMESPACE" = "fhirCsR4"

using fhirCsR4.Models;

namespace fhirCsR4.ValueSets
{
  /// <summary>
  /// The quality rating of the subcomponent of a quality of evidence rating.
  /// </summary>
  public static class CertaintySubcomponentRatingCodes
  {
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to be absent.
    /// </summary>
    public static readonly Coding Absent = new Coding
    {
      Code = "absent",
      Display = "absent",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// critical concern.
    /// </summary>
    public static readonly Coding CriticalConcern = new Coding
    {
      Code = "critical-concern",
      Display = "critical concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// reduce quality rating by 1.
    /// </summary>
    public static readonly Coding ReduceRating1 = new Coding
    {
      Code = "downcode1",
      Display = "reduce rating: -1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// reduce quality rating by 2.
    /// </summary>
    public static readonly Coding ReduceRating2 = new Coding
    {
      Code = "downcode2",
      Display = "reduce rating: -2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// reduce quality rating by 3.
    /// </summary>
    public static readonly Coding ReduceRating3 = new Coding
    {
      Code = "downcode3",
      Display = "reduce rating: -3",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// no change to quality rating.
    /// </summary>
    public static readonly Coding NoChangeToRating = new Coding
    {
      Code = "no-change",
      Display = "no change to rating",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// no serious concern.
    /// </summary>
    public static readonly Coding NoSeriousConcern = new Coding
    {
      Code = "no-concern",
      Display = "no serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// possible reason for increasing quality rating was checked and found to bepresent.
    /// </summary>
    public static readonly Coding Present = new Coding
    {
      Code = "present",
      Display = "present",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// serious concern.
    /// </summary>
    public static readonly Coding SeriousConcern = new Coding
    {
      Code = "serious-concern",
      Display = "serious concern",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// increase quality rating by 1.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus1 = new Coding
    {
      Code = "upcode1",
      Display = "increase rating: +1",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };
    /// <summary>
    /// increase quality rating by 2.
    /// </summary>
    public static readonly Coding IncreaseRatingPlus2 = new Coding
    {
      Code = "upcode2",
      Display = "increase rating: +2",
      System = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating"
    };

    /// <summary>
    /// Literal for code: Absent
    /// </summary>
    public const string LiteralAbsent = "absent";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingAbsent
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingAbsent = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#absent";

    /// <summary>
    /// Literal for code: CriticalConcern
    /// </summary>
    public const string LiteralCriticalConcern = "critical-concern";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingCriticalConcern
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingCriticalConcern = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#critical-concern";

    /// <summary>
    /// Literal for code: ReduceRating1
    /// </summary>
    public const string LiteralReduceRating1 = "downcode1";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingReduceRating1
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingReduceRating1 = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#downcode1";

    /// <summary>
    /// Literal for code: ReduceRating2
    /// </summary>
    public const string LiteralReduceRating2 = "downcode2";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingReduceRating2
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingReduceRating2 = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#downcode2";

    /// <summary>
    /// Literal for code: ReduceRating3
    /// </summary>
    public const string LiteralReduceRating3 = "downcode3";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingReduceRating3
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingReduceRating3 = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#downcode3";

    /// <summary>
    /// Literal for code: NoChangeToRating
    /// </summary>
    public const string LiteralNoChangeToRating = "no-change";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingNoChangeToRating
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingNoChangeToRating = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#no-change";

    /// <summary>
    /// Literal for code: NoSeriousConcern
    /// </summary>
    public const string LiteralNoSeriousConcern = "no-concern";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingNoSeriousConcern
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingNoSeriousConcern = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#no-concern";

    /// <summary>
    /// Literal for code: Present
    /// </summary>
    public const string LiteralPresent = "present";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingPresent
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingPresent = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#present";

    /// <summary>
    /// Literal for code: SeriousConcern
    /// </summary>
    public const string LiteralSeriousConcern = "serious-concern";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingSeriousConcern
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingSeriousConcern = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#serious-concern";

    /// <summary>
    /// Literal for code: IncreaseRatingPlus1
    /// </summary>
    public const string LiteralIncreaseRatingPlus1 = "upcode1";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingIncreaseRatingPlus1
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingIncreaseRatingPlus1 = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#upcode1";

    /// <summary>
    /// Literal for code: IncreaseRatingPlus2
    /// </summary>
    public const string LiteralIncreaseRatingPlus2 = "upcode2";

    /// <summary>
    /// Literal for code: CertaintySubcomponentRatingIncreaseRatingPlus2
    /// </summary>
    public const string LiteralCertaintySubcomponentRatingIncreaseRatingPlus2 = "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#upcode2";

    /// <summary>
    /// Dictionary for looking up CertaintySubcomponentRating Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "absent", Absent }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#absent", Absent }, 
      { "critical-concern", CriticalConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#critical-concern", CriticalConcern }, 
      { "downcode1", ReduceRating1 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#downcode1", ReduceRating1 }, 
      { "downcode2", ReduceRating2 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#downcode2", ReduceRating2 }, 
      { "downcode3", ReduceRating3 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#downcode3", ReduceRating3 }, 
      { "no-change", NoChangeToRating }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#no-change", NoChangeToRating }, 
      { "no-concern", NoSeriousConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#no-concern", NoSeriousConcern }, 
      { "present", Present }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#present", Present }, 
      { "serious-concern", SeriousConcern }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#serious-concern", SeriousConcern }, 
      { "upcode1", IncreaseRatingPlus1 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#upcode1", IncreaseRatingPlus1 }, 
      { "upcode2", IncreaseRatingPlus2 }, 
      { "http://terminology.hl7.org/CodeSystem/certainty-subcomponent-rating#upcode2", IncreaseRatingPlus2 }, 
    };
  };
}