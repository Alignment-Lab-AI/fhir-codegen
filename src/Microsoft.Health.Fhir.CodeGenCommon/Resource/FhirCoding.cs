﻿// <copyright file="FhirCoding.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using System.Diagnostics.CodeAnalysis;
using Microsoft.Health.Fhir.CodeGenCommon.Models;
using static Microsoft.Health.Fhir.CodeGenCommon.Extensions.LinqExtensions;

namespace Microsoft.Health.Fhir.CodeGenCommon.Resource;

/// <summary>A FHIR coding.</summary>
public record class FhirCoding : ICloneable
{
    private string _systemLocalName = string.Empty;
    private string _system = string.Empty;
    private Dictionary<string, List<object>> _properties = new();
    private HashSet<string> _propertyKeyValueHash = new();

    /// <summary>Initializes a new instance of the <see cref="FhirCoding"/> class.</summary>
    public FhirCoding() { }

    /// <summary>Initializes a new instance of the FhirCoding class.</summary>
    /// <param name="other">The other.</param>
    [SetsRequiredMembers]
    protected FhirCoding(FhirCoding other)
    {
        System = other.System;
        Code = other.Code;
        Display = other.Display;
        Version = other.Version;
        Definition = other.Definition;
        _properties = other._properties.DeepCopy();
        _propertyKeyValueHash = other._propertyKeyValueHash.Select(v => v).ToHashSet();
    }

    /// <summary>Gets the system.</summary>
    /// <value>The system.</value>
    public required string System
    {
        get => _system;
        init
        {
            _system = value;

            if (string.IsNullOrEmpty(_system))
            {
                _systemLocalName = string.Empty;
            }
            else if (_system.StartsWith("http://hl7.org/fhir/", StringComparison.Ordinal))
            {
                string name = _system.Substring(20);
                _systemLocalName = FhirUtils.SanitizeForProperty(name, null);
            }
            else if (_system.StartsWith("http://terminology.hl7.org/CodeSystem/", StringComparison.Ordinal))
            {
                string name = _system.Substring(38);
                _systemLocalName = FhirUtils.SanitizeForProperty(name, null);
            }
        }
    }

    /// <summary>Gets a local name for the system.</summary>
    /// <value>The name of the system.</value>
    public string SystemLocalName => _systemLocalName;

    /// <summary>Gets the code.</summary>
    /// <value>The code.</value>
    public required string Code { get; init; }

    /// <summary>Gets the display.</summary>
    /// <value>The display.</value>
    public string Display { get; init; } = string.Empty;

    /// <summary>Gets the version.</summary>
    /// <value>The version.</value>
    public string Version { get; init; } = string.Empty;

    /// <summary>Gets the definition.</summary>
    /// <value>The definition.</value>
    public string Definition { get; init; } = string.Empty;

    /// <summary>System and code.</summary>
    /// <returns>A string.</returns>
    public string SystemAndCode() => $"{System}#{Code}";

    /// <summary>Code and system.</summary>
    /// <returns>A string.</returns>
    public string CodeAndSystem() => $"{Code} {System}";

    /// <summary>Gets the key.</summary>
    /// <returns>A string.</returns>
    public string Key() => $"{System}#{Code}";

    /// <summary>Convert this object into a string representation.</summary>
    /// <returns>A string that represents this object.</returns>
    public override string ToString()
    {
        string value = string.Empty;

        if (!string.IsNullOrEmpty(_system))
        {
            value = value + _system;
        }

        if (!string.IsNullOrEmpty(Code))
        {
            if (string.IsNullOrEmpty(value))
            {
                value = Code;
            }
            else
            {
                value = value + "#" + Code;
            }
        }

        if (!string.IsNullOrEmpty(Version))
        {
            if (string.IsNullOrEmpty(value))
            {
                value = Version;
            }
            else
            {
                value = value + "|" + Version;
            }
        }

        return value;
    }


    /// <summary>Gets the defined concept properties.</summary>
    public Dictionary<string, List<object>> Properties => _properties;

    /// <summary>Adds a property.</summary>
    /// <param name="code">              The code.</param>
    /// <param name="value">             The value.</param>
    /// <param name="canonicalizedValue">The canonicalized version of the value (for matching).</param>
    public void AddProperty(
        string code,
        object value,
        string canonicalizedValue)
    {
        if (!_properties.ContainsKey(code))
        {
            _properties.Add(code, new());
        }

        _properties[code].Add(value);
        _propertyKeyValueHash.Add(code + ":" + canonicalizedValue);
    }

    /// <summary>Matches properties.</summary>
    /// <param name="propertyHashes">The properties.</param>
    /// <returns>True if matches properties, false if not.</returns>
    public bool MatchesProperties(List<string> propertyHashes)
    {
        if ((propertyHashes == null) || (!propertyHashes.Any()))
        {
            return true;
        }

        if ((_propertyKeyValueHash == null) || (!_propertyKeyValueHash.Any()))
        {
            return false;
        }

        foreach (string hash in propertyHashes)
        {
            if (!_propertyKeyValueHash.Contains(hash))
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>Query if this Concept has a property with the specified value.</summary>
    /// <param name="propertyName"> Name of the property.</param>
    /// <param name="propertyValue">The property value.</param>
    /// <returns>True if this concept matches, false if not.</returns>
    public bool HasProperty(string propertyName, string propertyValue)
    {
        if (_propertyKeyValueHash == null)
        {
            return false;
        }

        string combined = propertyName + ":" + propertyValue;

        return _propertyKeyValueHash.Contains(combined);
    }

    /// <summary>Makes a deep copy of this object.</summary>
    /// <returns>A copy of this object.</returns>
    object ICloneable.Clone() => this with { };
}