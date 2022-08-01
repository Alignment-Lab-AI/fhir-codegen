// <auto-generated />
// Built from: hl7.fhir.r5.core version: 5.0.0-snapshot1
  // Option: "NAMESPACE" = "fhirCsR5"

using fhirCsR5.Models;

namespace fhirCsR5.ValueSets
{
  /// <summary>
  /// The operational status of the device.
  /// </summary>
  public static class DeviceOperationalstatusCodes
  {
    /// <summary>
    /// The device is defective or for maintenance and is not available or working.
    /// </summary>
    public static readonly Coding StandBy = new Coding
    {
      Code = "defective",
      Display = "Stand By",
      System = "http://hl7.org/fhir/device-operationalstatus"
    };
    /// <summary>
    /// The device is inactive, switched off, or deactivated.
    /// </summary>
    public static readonly Coding Off = new Coding
    {
      Code = "off",
      Display = "Off",
      System = "http://hl7.org/fhir/device-operationalstatus"
    };
    /// <summary>
    /// The device is working or switched on, i.e. active.
    /// </summary>
    public static readonly Coding On = new Coding
    {
      Code = "on",
      Display = "On",
      System = "http://hl7.org/fhir/device-operationalstatus"
    };
    /// <summary>
    /// The device is in stand-by mode i.e. not actively working but not powered off.
    /// </summary>
    public static readonly Coding StandBy_2 = new Coding
    {
      Code = "standby",
      Display = "Stand By",
      System = "http://hl7.org/fhir/device-operationalstatus"
    };
    /// <summary>
    /// The operational status of the device has not been determined.
    /// </summary>
    public static readonly Coding Unknown = new Coding
    {
      Code = "unknown",
      Display = "Unknown",
      System = "http://hl7.org/fhir/device-operationalstatus"
    };

    /// <summary>
    /// Literal for code: StandBy
    /// </summary>
    public const string LiteralStandBy = "defective";

    /// <summary>
    /// Literal for code: DeviceOperationalstatusStandBy
    /// </summary>
    public const string LiteralDeviceOperationalstatusStandBy = "http://hl7.org/fhir/device-operationalstatus#defective";

    /// <summary>
    /// Literal for code: Off
    /// </summary>
    public const string LiteralOff = "off";

    /// <summary>
    /// Literal for code: DeviceOperationalstatusOff
    /// </summary>
    public const string LiteralDeviceOperationalstatusOff = "http://hl7.org/fhir/device-operationalstatus#off";

    /// <summary>
    /// Literal for code: On
    /// </summary>
    public const string LiteralOn = "on";

    /// <summary>
    /// Literal for code: DeviceOperationalstatusOn
    /// </summary>
    public const string LiteralDeviceOperationalstatusOn = "http://hl7.org/fhir/device-operationalstatus#on";

    /// <summary>
    /// Literal for code: StandBy_2
    /// </summary>
    public const string LiteralStandBy_2 = "standby";

    /// <summary>
    /// Literal for code: DeviceOperationalstatusStandBy_2
    /// </summary>
    public const string LiteralDeviceOperationalstatusStandBy_2 = "http://hl7.org/fhir/device-operationalstatus#standby";

    /// <summary>
    /// Literal for code: Unknown
    /// </summary>
    public const string LiteralUnknown = "unknown";

    /// <summary>
    /// Literal for code: DeviceOperationalstatusUnknown
    /// </summary>
    public const string LiteralDeviceOperationalstatusUnknown = "http://hl7.org/fhir/device-operationalstatus#unknown";

    /// <summary>
    /// Dictionary for looking up DeviceOperationalstatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "defective", StandBy }, 
      { "http://hl7.org/fhir/device-operationalstatus#defective", StandBy }, 
      { "off", Off }, 
      { "http://hl7.org/fhir/device-operationalstatus#off", Off }, 
      { "on", On }, 
      { "http://hl7.org/fhir/device-operationalstatus#on", On }, 
      { "standby", StandBy_2 }, 
      { "http://hl7.org/fhir/device-operationalstatus#standby", StandBy_2 }, 
      { "unknown", Unknown }, 
      { "http://hl7.org/fhir/device-operationalstatus#unknown", Unknown }, 
    };
  };
}