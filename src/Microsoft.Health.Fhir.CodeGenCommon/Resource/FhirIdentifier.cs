﻿// <copyright file="FhirIdentifier.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>

using Microsoft.Health.Fhir.CodeGenCommon.Extensions;
using static Microsoft.Health.Fhir.CodeGenCommon.Structural.FhirComplex;

namespace Microsoft.Health.Fhir.CodeGenCommon.Resource;

/// <summary>A FHIR identifier.</summary>
public class FhirIdentifier
{
    private readonly IdentifierUseCodes? _use = null;
    private string _fhirUse = string.Empty;

    public enum IdentifierUseCodes
    {
        /// <summary>
        /// The identifier recommended for display and use in real-world interactions which should be
        /// used when such identifier is different from the "official" identifier.
        /// </summary>
        [FhirLiteral("usual")]
        Usual,

        /// <summary>
        /// The identifier considered to be most trusted for the identification of this item.
        /// Sometimes also known as "primary" and "main". The determination of "official" is subjective
        /// and implementation guides often provide additional guidelines for use.
        /// </summary>
        [FhirLiteral("official")]
        Office,

        /// <summary>A temporary identifier.</summary>
        [FhirLiteral("temp")]
        Temp,

        /// <summary>
        /// An identifier that was assigned in secondary use - it serves to identify the object in a relative
        /// context, but cannot be consistently assigned to the same object again in a different context.
        /// </summary>
        [FhirLiteral("secondary")]
        Secondary,

        /// <summary>
        /// The identifier id no longer considered valid, but may be relevant for search purposes. E.g.
        /// Changes to identifier schemes, account merges, etc.
        /// </summary>
        [FhirLiteral("old")]
        Old,
    }

    /// <summary>Gets the purpose of this identifier.</summary>
    public IdentifierUseCodes? Use => _use;

    /// <summary>Gets or initializes the FHIR purpose of this identifier.</summary>
    public string FhirUse
    {
        get => _fhirUse;
        init
        {
            _fhirUse = value;
            if (_fhirUse.TryFhirEnum(out IdentifierUseCodes v))
            {
                _use = v;
            }
        }
    }

    /// <summary>Gets or initializes the coded description of identifier.</summary>
    public FhirCodeableConcept? TypeCodeable { get; init; } = null;

    /// <summary>Gets or initializes the namespace for the identifier value.</summary>
    public string System { get; init; } = string.Empty;

    /// <summary>Gets or initializes the value that is unique.</summary>
    public string Value { get; init; } = string.Empty;

    /// <summary>Gets or initializes the start of the time period when id is/was valid for use.</summary>
    public string PeriodStart { get; init; } = string.Empty;

    /// <summary>Gets or initializes the end of the time period when id is/was valid for use.</summary>
    public string PeriodEnd { get; init; } = string.Empty;

    /// <summary>Gets or initializes the organization that issued id (may be just text).</summary>
    public FhirReference? Assigner { get; init; } = null;
}
