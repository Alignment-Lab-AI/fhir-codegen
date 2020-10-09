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
  /// The specific medication, food or laboratory test that interacts.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MedicinalProductInteractionInteractant>))]
  public class MedicinalProductInteractionInteractant : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The specific medication, food or laboratory test that interacts.
    /// </summary>
    public Reference ItemReference { get; set; }
    /// <summary>
    /// The specific medication, food or laboratory test that interacts.
    /// </summary>
    public CodeableConcept ItemCodeableConcept { get; set; }
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

      if (ItemReference != null)
      {
        writer.WritePropertyName("itemReference");
        ItemReference.SerializeJson(writer, options);
      }

      if (ItemCodeableConcept != null)
      {
        writer.WritePropertyName("itemCodeableConcept");
        ItemCodeableConcept.SerializeJson(writer, options);
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
        case "itemReference":
          ItemReference = new Fhir.R4.Models.Reference();
          ItemReference.DeserializeJson(ref reader, options);
          break;

        case "itemCodeableConcept":
          ItemCodeableConcept = new Fhir.R4.Models.CodeableConcept();
          ItemCodeableConcept.DeserializeJson(ref reader, options);
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
  /// The interactions of the medicinal product with other medicinal products, or other forms of interactions.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MedicinalProductInteraction>))]
  public class MedicinalProductInteraction : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public string ResourceType => "MedicinalProductInteraction";
    /// <summary>
    /// The interaction described.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Extension container element for Description
    /// </summary>
    public Element _Description { get; set; }
    /// <summary>
    /// The effect of the interaction, for example "reduced gastric absorption of primary medication".
    /// </summary>
    public CodeableConcept Effect { get; set; }
    /// <summary>
    /// The incidence of the interaction, e.g. theoretical, observed.
    /// </summary>
    public CodeableConcept Incidence { get; set; }
    /// <summary>
    /// The specific medication, food or laboratory test that interacts.
    /// </summary>
    public List<MedicinalProductInteractionInteractant> Interactant { get; set; }
    /// <summary>
    /// Actions for managing the interaction.
    /// </summary>
    public CodeableConcept Management { get; set; }
    /// <summary>
    /// The medication for which this is a described interaction.
    /// </summary>
    public List<Reference> Subject { get; set; }
    /// <summary>
    /// The type of the interaction e.g. drug-drug interaction, drug-food interaction, drug-lab test interaction.
    /// </summary>
    public CodeableConcept Type { get; set; }
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

      if ((Subject != null) && (Subject.Count != 0))
      {
        writer.WritePropertyName("subject");
        writer.WriteStartArray();

        foreach (Reference valSubject in Subject)
        {
          valSubject.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Description))
      {
        writer.WriteString("description", (string)Description!);
      }

      if (_Description != null)
      {
        writer.WritePropertyName("_description");
        _Description.SerializeJson(writer, options);
      }

      if ((Interactant != null) && (Interactant.Count != 0))
      {
        writer.WritePropertyName("interactant");
        writer.WriteStartArray();

        foreach (MedicinalProductInteractionInteractant valInteractant in Interactant)
        {
          valInteractant.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Type != null)
      {
        writer.WritePropertyName("type");
        Type.SerializeJson(writer, options);
      }

      if (Effect != null)
      {
        writer.WritePropertyName("effect");
        Effect.SerializeJson(writer, options);
      }

      if (Incidence != null)
      {
        writer.WritePropertyName("incidence");
        Incidence.SerializeJson(writer, options);
      }

      if (Management != null)
      {
        writer.WritePropertyName("management");
        Management.SerializeJson(writer, options);
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
        case "description":
          Description = reader.GetString();
          break;

        case "_description":
          _Description = new Fhir.R4.Models.Element();
          _Description.DeserializeJson(ref reader, options);
          break;

        case "effect":
          Effect = new Fhir.R4.Models.CodeableConcept();
          Effect.DeserializeJson(ref reader, options);
          break;

        case "incidence":
          Incidence = new Fhir.R4.Models.CodeableConcept();
          Incidence.DeserializeJson(ref reader, options);
          break;

        case "interactant":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Interactant = new List<MedicinalProductInteractionInteractant>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.MedicinalProductInteractionInteractant objInteractant = new Fhir.R4.Models.MedicinalProductInteractionInteractant();
            objInteractant.DeserializeJson(ref reader, options);
            Interactant.Add(objInteractant);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Interactant.Count == 0)
          {
            Interactant = null;
          }

          break;

        case "management":
          Management = new Fhir.R4.Models.CodeableConcept();
          Management.DeserializeJson(ref reader, options);
          break;

        case "subject":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Subject = new List<Reference>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Fhir.R4.Models.Reference objSubject = new Fhir.R4.Models.Reference();
            objSubject.DeserializeJson(ref reader, options);
            Subject.Add(objSubject);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Subject.Count == 0)
          {
            Subject = null;
          }

          break;

        case "type":
          Type = new Fhir.R4.Models.CodeableConcept();
          Type.DeserializeJson(ref reader, options);
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
