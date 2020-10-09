// <auto-generated />
// Built from: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Fhir.R4.Serialization;

namespace Fhir.R4.Models
{
  /// <summary>
  /// The populations that make up the population group, one for each type of population appropriate for the measure.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReportGroupPopulation>))]
  public class MeasureReportGroupPopulation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The type of the population.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The number of members of the population.
    /// </summary>
    public int? Count { get; set; }
    /// <summary>
    /// This element refers to a List of subject level MeasureReport resources, one for each subject in this population.
    /// </summary>
    public Reference SubjectResults { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Count != null)
      {
        writer.WriteNumber("count", (int)Count!);
      }

      if (SubjectResults != null)
      {
        writer.WritePropertyName("subjectResults");
        SubjectResults.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "count":
          Count = reader.GetInt32();
          break;

        case "subjectResults":
          SubjectResults = new Fhir.R4.Models.Reference();
          SubjectResults.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// A stratifier component value.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReportGroupStratifierStratumComponent>))]
  public class MeasureReportGroupStratifierStratumComponent : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The code for the stratum component value.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The stratum component value.
    /// </summary>
    public CodeableConcept Value { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Value != null)
      {
        writer.WritePropertyName("value");
        Value.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "value":
          Value = new Fhir.R4.Models.CodeableConcept();
          Value.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// The populations that make up the stratum, one for each type of population appropriate to the measure.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReportGroupStratifierStratumPopulation>))]
  public class MeasureReportGroupStratifierStratumPopulation : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The type of the population.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The number of members of the population in this stratum.
    /// </summary>
    public int? Count { get; set; }
    /// <summary>
    /// This element refers to a List of subject level MeasureReport resources, one for each subject in this population in this stratum.
    /// </summary>
    public Reference SubjectResults { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if (Count != null)
      {
        writer.WriteNumber("count", (int)Count!);
      }

      if (SubjectResults != null)
      {
        writer.WritePropertyName("subjectResults");
        SubjectResults.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "count":
          Count = reader.GetInt32();
          break;

        case "subjectResults":
          SubjectResults = new Fhir.R4.Models.Reference();
          SubjectResults.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// This element contains the results for a single stratum within the stratifier. For example, when stratifying on administrative gender, there will be four strata, one for each possible gender value.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReportGroupStratifierStratum>))]
  public class MeasureReportGroupStratifierStratum : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// A stratifier component value.
    /// </summary>
    public List<MeasureReportGroupStratifierStratumComponent> Component { get; set; }
    /// <summary>
    /// The measure score for this stratum, calculated as appropriate for the measure type and scoring method, and based on only the members of this stratum.
    /// </summary>
    public Quantity MeasureScore { get; set; }
    /// <summary>
    /// The populations that make up the stratum, one for each type of population appropriate to the measure.
    /// </summary>
    public List<MeasureReportGroupStratifierStratumPopulation> Population { get; set; }
    /// <summary>
    /// The value for this stratum, expressed as a CodeableConcept. When defining stratifiers on complex values, the value must be rendered such that the value for each stratum within the stratifier is unique.
    /// </summary>
    public CodeableConcept Value { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Value != null)
      {
        writer.WritePropertyName("value");
        Value.SerializeJson(writer, options);
      }

      if ((Component != null) && (Component.Count != 0))
      {
        writer.WritePropertyName("component");
        writer.WriteStartArray();

        foreach (MeasureReportGroupStratifierStratumComponent valComponent in Component)
        {
          valComponent.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Population != null) && (Population.Count != 0))
      {
        writer.WritePropertyName("population");
        writer.WriteStartArray();

        foreach (MeasureReportGroupStratifierStratumPopulation valPopulation in Population)
        {
          valPopulation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (MeasureScore != null)
      {
        writer.WritePropertyName("measureScore");
        MeasureScore.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "component":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Component = new List<MeasureReportGroupStratifierStratumComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MeasureReportGroupStratifierStratumComponent objComponent = new Fhir.R4.Models.MeasureReportGroupStratifierStratumComponent();
            objComponent.DeserializeJson(ref reader, options);
            Component.Add(objComponent);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Component.Count == 0)
          {
            Component = null;
          }

          break;

        case "measureScore":
          MeasureScore = new Fhir.R4.Models.Quantity();
          MeasureScore.DeserializeJson(ref reader, options);
          break;

        case "population":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Population = new List<MeasureReportGroupStratifierStratumPopulation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MeasureReportGroupStratifierStratumPopulation objPopulation = new Fhir.R4.Models.MeasureReportGroupStratifierStratumPopulation();
            objPopulation.DeserializeJson(ref reader, options);
            Population.Add(objPopulation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Population.Count == 0)
          {
            Population = null;
          }

          break;

        case "value":
          Value = new Fhir.R4.Models.CodeableConcept();
          Value.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// When a measure includes multiple stratifiers, there will be a stratifier group for each stratifier defined by the measure.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReportGroupStratifier>))]
  public class MeasureReportGroupStratifier : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The meaning of this stratifier, as defined in the measure definition.
    /// </summary>
    public List<CodeableConcept> Code { get; set; }
    /// <summary>
    /// This element contains the results for a single stratum within the stratifier. For example, when stratifying on administrative gender, there will be four strata, one for each possible gender value.
    /// </summary>
    public List<MeasureReportGroupStratifierStratum> Stratum { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if ((Code != null) && (Code.Count != 0))
      {
        writer.WritePropertyName("code");
        writer.WriteStartArray();

        foreach (CodeableConcept valCode in Code)
        {
          valCode.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((Stratum != null) && (Stratum.Count != 0))
      {
        writer.WritePropertyName("stratum");
        writer.WriteStartArray();

        foreach (MeasureReportGroupStratifierStratum valStratum in Stratum)
        {
          valStratum.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Code = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.CodeableConcept objCode = new Fhir.R4.Models.CodeableConcept();
            objCode.DeserializeJson(ref reader, options);
            Code.Add(objCode);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Code.Count == 0)
          {
            Code = null;
          }

          break;

        case "stratum":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Stratum = new List<MeasureReportGroupStratifierStratum>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MeasureReportGroupStratifierStratum objStratum = new Fhir.R4.Models.MeasureReportGroupStratifierStratum();
            objStratum.DeserializeJson(ref reader, options);
            Stratum.Add(objStratum);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Stratum.Count == 0)
          {
            Stratum = null;
          }

          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// The results of the calculation, one for each population group in the measure.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReportGroup>))]
  public class MeasureReportGroup : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The meaning of the population group as defined in the measure definition.
    /// </summary>
    public CodeableConcept Code { get; set; }
    /// <summary>
    /// The measure score for this population group, calculated as appropriate for the measure type and scoring method, and based on the contents of the populations defined in the group.
    /// </summary>
    public Quantity MeasureScore { get; set; }
    /// <summary>
    /// The populations that make up the population group, one for each type of population appropriate for the measure.
    /// </summary>
    public List<MeasureReportGroupPopulation> Population { get; set; }
    /// <summary>
    /// When a measure includes multiple stratifiers, there will be a stratifier group for each stratifier defined by the measure.
    /// </summary>
    public List<MeasureReportGroupStratifier> Stratifier { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      ((Fhir.R4.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (Code != null)
      {
        writer.WritePropertyName("code");
        Code.SerializeJson(writer, options);
      }

      if ((Population != null) && (Population.Count != 0))
      {
        writer.WritePropertyName("population");
        writer.WriteStartArray();

        foreach (MeasureReportGroupPopulation valPopulation in Population)
        {
          valPopulation.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (MeasureScore != null)
      {
        writer.WritePropertyName("measureScore");
        MeasureScore.SerializeJson(writer, options);
      }

      if ((Stratifier != null) && (Stratifier.Count != 0))
      {
        writer.WritePropertyName("stratifier");
        writer.WriteStartArray();

        foreach (MeasureReportGroupStratifier valStratifier in Stratifier)
        {
          valStratifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "code":
          Code = new Fhir.R4.Models.CodeableConcept();
          Code.DeserializeJson(ref reader, options);
          break;

        case "measureScore":
          MeasureScore = new Fhir.R4.Models.Quantity();
          MeasureScore.DeserializeJson(ref reader, options);
          break;

        case "population":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Population = new List<MeasureReportGroupPopulation>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MeasureReportGroupPopulation objPopulation = new Fhir.R4.Models.MeasureReportGroupPopulation();
            objPopulation.DeserializeJson(ref reader, options);
            Population.Add(objPopulation);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Population.Count == 0)
          {
            Population = null;
          }

          break;

        case "stratifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Stratifier = new List<MeasureReportGroupStratifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MeasureReportGroupStratifier objStratifier = new Fhir.R4.Models.MeasureReportGroupStratifier();
            objStratifier.DeserializeJson(ref reader, options);
            Stratifier.Add(objStratifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Stratifier.Count == 0)
          {
            Stratifier = null;
          }

          break;

        default:
          ((Fhir.R4.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// The MeasureReport resource contains the results of the calculation of a measure; and optionally a reference to the resources involved in that calculation.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MeasureReport>))]
  public class MeasureReport : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "MeasureReport";
    /// <summary>
    /// The date this measure report was generated.
    /// </summary>
    public string Date { get; set; }
    /// <summary>
    /// Extension container element for Date
    /// </summary>
    public Element _Date { get; set; }
    /// <summary>
    /// A reference to a Bundle containing the Resources that were used in the calculation of this measure.
    /// </summary>
    public List<Reference> EvaluatedResource { get; set; }
    /// <summary>
    /// The results of the calculation, one for each population group in the measure.
    /// </summary>
    public List<MeasureReportGroup> Group { get; set; }
    /// <summary>
    /// Typically, this is used for identifiers that can go in an HL7 V3 II data type - e.g. to identify this {{title}} outside of FHIR, where the logical URL is not possible to use.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// This element is typically defined by the measure, but reproduced here to ensure the measure score can be interpreted. The element is labeled as a modifier because it changes the interpretation of the reported measure score.
    /// </summary>
    public CodeableConcept ImprovementNotation { get; set; }
    /// <summary>
    /// A reference to the Measure that was calculated to produce this report.
    /// </summary>
    public string Measure { get; set; }
    /// <summary>
    /// Extension container element for Measure
    /// </summary>
    public Element _Measure { get; set; }
    /// <summary>
    /// The reporting period for which the report was calculated.
    /// </summary>
    public Period Period { get; set; }
    /// <summary>
    /// The individual, location, or organization that is reporting the data.
    /// </summary>
    public Reference Reporter { get; set; }
    /// <summary>
    /// This element is labeled as a modifier because the status contains codes that mark the resource as not currently valid.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// Optional subject identifying the individual or individuals the report is for.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Data-collection reports are used only to communicate data-of-interest for a measure. They do not necessarily include all the data for a particular subject or population, but they may.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }

      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((Fhir.R4.Models.DomainResource)this).SerializeJson(writer, options, false);

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Measure))
      {
        writer.WriteString("measure", (string)Measure!);
      }

      if (_Measure != null)
      {
        writer.WritePropertyName("_measure");
        _Measure.SerializeJson(writer, options);
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Date))
      {
        writer.WriteString("date", (string)Date!);
      }

      if (_Date != null)
      {
        writer.WritePropertyName("_date");
        _Date.SerializeJson(writer, options);
      }

      if (Reporter != null)
      {
        writer.WritePropertyName("reporter");
        Reporter.SerializeJson(writer, options);
      }

      if (Period != null)
      {
        writer.WritePropertyName("period");
        Period.SerializeJson(writer, options);
      }

      if (ImprovementNotation != null)
      {
        writer.WritePropertyName("improvementNotation");
        ImprovementNotation.SerializeJson(writer, options);
      }

      if ((Group != null) && (Group.Count != 0))
      {
        writer.WritePropertyName("group");
        writer.WriteStartArray();

        foreach (MeasureReportGroup valGroup in Group)
        {
          valGroup.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if ((EvaluatedResource != null) && (EvaluatedResource.Count != 0))
      {
        writer.WritePropertyName("evaluatedResource");
        writer.WriteStartArray();

        foreach (Reference valEvaluatedResource in EvaluatedResource)
        {
          valEvaluatedResource.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "date":
          Date = reader.GetString();
          break;

        case "_date":
          _Date = new Fhir.R4.Models.Element();
          _Date.DeserializeJson(ref reader, options);
          break;

        case "evaluatedResource":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          EvaluatedResource = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objEvaluatedResource = new Fhir.R4.Models.Reference();
            objEvaluatedResource.DeserializeJson(ref reader, options);
            EvaluatedResource.Add(objEvaluatedResource);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (EvaluatedResource.Count == 0)
          {
            EvaluatedResource = null;
          }

          break;

        case "group":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Group = new List<MeasureReportGroup>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MeasureReportGroup objGroup = new Fhir.R4.Models.MeasureReportGroup();
            objGroup.DeserializeJson(ref reader, options);
            Group.Add(objGroup);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Group.Count == 0)
          {
            Group = null;
          }

          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Identifier objIdentifier = new Fhir.R4.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "improvementNotation":
          ImprovementNotation = new Fhir.R4.Models.CodeableConcept();
          ImprovementNotation.DeserializeJson(ref reader, options);
          break;

        case "measure":
          Measure = reader.GetString();
          break;

        case "_measure":
          _Measure = new Fhir.R4.Models.Element();
          _Measure.DeserializeJson(ref reader, options);
          break;

        case "period":
          Period = new Fhir.R4.Models.Period();
          Period.DeserializeJson(ref reader, options);
          break;

        case "reporter":
          Reporter = new Fhir.R4.Models.Reference();
          Reporter.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new Fhir.R4.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new Fhir.R4.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new Fhir.R4.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((Fhir.R4.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
}
