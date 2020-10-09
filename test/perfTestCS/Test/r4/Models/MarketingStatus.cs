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
  /// The marketing status describes the date when a medicinal product is actually put on the market or the date as of which it is no longer available.
  /// </summary>
  [JsonConverter(typeof(Fhir.R4.Serialization.JsonStreamComponentConverter<MarketingStatus>))]
  public class MarketingStatus : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The country in which the marketing authorisation has been granted shall be specified It should be specified using the ISO 3166 ‑ 1 alpha-2 code elements.
    /// </summary>
    public CodeableConcept Country { get; set; }
    /// <summary>
    /// The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.
    /// </summary>
    public Period DateRange { get; set; }
    /// <summary>
    /// Where a Medicines Regulatory Agency has granted a marketing authorisation for which specific provisions within a jurisdiction apply, the jurisdiction can be specified using an appropriate controlled terminology The controlled term and the controlled term identifier shall be specified.
    /// </summary>
    public CodeableConcept Jurisdiction { get; set; }
    /// <summary>
    /// The date when the Medicinal Product is placed on the market by the Marketing Authorisation Holder (or where applicable, the manufacturer/distributor) in a country and/or jurisdiction shall be provided A complete date consisting of day, month and year shall be specified using the ISO 8601 date format NOTE “Placed on the market” refers to the release of the Medicinal Product into the distribution chain.
    /// </summary>
    public string RestoreDate { get; set; }
    /// <summary>
    /// Extension container element for RestoreDate
    /// </summary>
    public Element _RestoreDate { get; set; }
    /// <summary>
    /// This attribute provides information on the status of the marketing of the medicinal product See ISO/TS 20443 for more information and examples.
    /// </summary>
    public CodeableConcept Status { get; set; }
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

      if (Country != null)
      {
        writer.WritePropertyName("country");
        Country.SerializeJson(writer, options);
      }

      if (Jurisdiction != null)
      {
        writer.WritePropertyName("jurisdiction");
        Jurisdiction.SerializeJson(writer, options);
      }

      if (Status != null)
      {
        writer.WritePropertyName("status");
        Status.SerializeJson(writer, options);
      }

      if (DateRange != null)
      {
        writer.WritePropertyName("dateRange");
        DateRange.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(RestoreDate))
      {
        writer.WriteString("restoreDate", (string)RestoreDate!);
      }

      if (_RestoreDate != null)
      {
        writer.WritePropertyName("_restoreDate");
        _RestoreDate.SerializeJson(writer, options);
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
        case "country":
          Country = new Fhir.R4.Models.CodeableConcept();
          Country.DeserializeJson(ref reader, options);
          break;

        case "dateRange":
          DateRange = new Fhir.R4.Models.Period();
          DateRange.DeserializeJson(ref reader, options);
          break;

        case "jurisdiction":
          Jurisdiction = new Fhir.R4.Models.CodeableConcept();
          Jurisdiction.DeserializeJson(ref reader, options);
          break;

        case "restoreDate":
          RestoreDate = reader.GetString();
          break;

        case "_restoreDate":
          _RestoreDate = new Fhir.R4.Models.Element();
          _RestoreDate.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = new Fhir.R4.Models.CodeableConcept();
          Status.DeserializeJson(ref reader, options);
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
}
