﻿using Microsoft.Health.Fhir.SpecManager.Manager;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using fhir_2 = Microsoft.Health.Fhir.SpecManager.fhir.v2;
using Microsoft.Health.Fhir.SpecManager.Models;

namespace Microsoft.Health.Fhir.SpecManager.Converters
{
    ///-------------------------------------------------------------------------------------------------
    /// <summary>from v 2.</summary>
    ///
    /// <remarks>Gino Canessa, 2/19/2020.</remarks>
    ///-------------------------------------------------------------------------------------------------

    public class FromV2 : IFhirConverter
    {
        #region Class Variables . . .

        #endregion Class Variables . . .

        #region Instance Variables . . .

        /// <summary>The JSON converter for polymorphic deserialization of this version of FHIR.</summary>
        private JsonConverter _jsonConverter;

        #endregion Instance Variables . . .

        #region Constructors . . .

        public FromV2()
        {
            _jsonConverter = new fhir_2.ResourceConverter();
        }

        #endregion Constructors . . .

        #region Class Interface . . .

        #endregion Class Interface . . .

        #region Instance Interface . . .

        #endregion Instance Interface . . .

        #region Internal Functions . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process the structure definition.</summary>
        ///
        /// <remarks>Gino Canessa, 2/19/2020.</remarks>
        ///
        /// <param name="sd">          The SD.</param>
        /// <param name="simpleTypes"> [in,out] List of types of the simples.</param>
        /// <param name="complexTypes">[in,out] List of types of the complexes.</param>
        /// <param name="resources">   [in,out] The resources.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool ProcessStructureDef(
                                        fhir_2.StructureDefinition sd,
                                        ref Dictionary<string, FhirSimpleType> simpleTypes,
                                        ref Dictionary<string, FhirComplexType> complexTypes,
                                        ref Dictionary<string, FhirResource> resources
                                        )
        {
            try
            {
                // **** ignore retired ****

                if (sd.Status.Equals("retired", StringComparison.Ordinal))
                {
                    return true;
                }

                // **** act depending on kind ****

                switch (sd.Kind)
                {
                    case "datatype":
                        // **** exclude extensions ****

                        if (sd.ConstrainedType == "Extension")
                        {
                            return true;
                        }

                        // **** 4 elements is for a simple type, more is for a complex one ****

                        if (sd.Snapshot.Element.Length > 4)
                        {
                            return ProcessDataTypeComplex(sd, ref complexTypes);
                        }

                        return ProcessDataTypeSimple(sd, ref simpleTypes);
                    //break;

                    case "resource":
                        break;

                    case "logical":
                        // **** ignore logical ****

                        return true;
                        //break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FromV2.ProcessStructureDef <<< failed to process {sd.Id}:\n{ex}\n--------------");
                return false;
            }

            // **** here means success ****

            return true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process a structure definition for a Simple data type.</summary>
        ///
        /// <remarks>Gino Canessa, 2/19/2020.</remarks>
        ///
        /// <param name="sd">         The SD.</param>
        /// <param name="simpleTypes">[in,out] List of types of the simples.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool ProcessDataTypeSimple(
                                            fhir_2.StructureDefinition sd, 
                                            ref Dictionary<string, FhirSimpleType> simpleTypes
                                            )
        {
            try
            {
                // **** create a new Simple Type object ****

                FhirSimpleType simple = new FhirSimpleType()
                {
                    Name = sd.Name,
                    NameCapitalized = Utils.CapitalizeName(sd.Name),
                    StandardStatus = sd.Status,
                    ShortDescription = sd.Description,
                    Definition = sd.Requirements,
                };

                // **** figure out the type ****

                foreach (fhir_2.ElementDefinition element in sd.Snapshot.Element)
                {
                    // **** check for base path having a type or {type}.value ****

                    if ((!element.Path.Contains(".")) ||
                        (element.Path.Equals($"{sd.Name}.value", StringComparison.Ordinal)))
                    {
                        if (TryGetTypeFromElement(sd.Name, element, out string elementType))
                        {
                            // **** set our type ****

                            simple.BaseTypeName = elementType;

                            // **** stop looking ****

                            break;
                        }
                    }
                }

                // **** make sure we have a type ****

                if (string.IsNullOrEmpty(simple.BaseTypeName))
                {
                    Console.WriteLine($"FromV2.ProcessDataTypeSimple <<<" +
                        $" Could not determine base type for {sd.Name}");
                    return false;
                }

                // **** add to our dictionary of simple types ****

                simpleTypes[sd.Name] = simple;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FromV2.ProcessDataTypeSimple <<< failed to process {sd.Id}:\n{ex}\n--------------");
                return false;
            }

            // **** success ****

            return true;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Gets type from element.</summary>
        ///
        /// <remarks>Gino Canessa, 2/20/2020.</remarks>
        ///
        /// <param name="structureName">Name of the structure.</param>
        /// <param name="element">      The element.</param>
        /// <param name="elementType">  [out] Type of the element.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool TryGetTypeFromElement(string structureName, fhir_2.ElementDefinition element, out string elementType)
        {
            // **** check for base definition (self-typed) ****

            if (element.Path.Equals(structureName, StringComparison.Ordinal))
            {
                // **** self-defined ****

                elementType = structureName;

                // **** done searching ****

                return true;
            }

            // **** check for declared type ****

            foreach (fhir_2.ElementDefinitionType edType in element.Type)
            {
                // **** check for a specified type ****

                if (!string.IsNullOrEmpty(edType.Code))
                {
                    // **** use this type ****

                    elementType = edType.Code;

                    // **** done searching ****

                    return true;
                }

                // **** use an extension-defined type ****

                foreach (fhir_2.Extension ext in edType._Code.Extension)
                {
                    if (ext.Url.Equals(FhirVersionInfo.UrlJsonType, StringComparison.Ordinal))
                    {
                        // **** use this type ****

                        elementType = ext.ValueString;

                        // **** stop looking ****

                        return true;
                    }
                }
            }

            // **** check for base derived type ****

            if ((string.IsNullOrEmpty(element.Name)) ||
                (element.Name.Equals(structureName, StringComparison.Ordinal)))
            {
                // **** base type is here ****

                elementType = element.Path;

                // **** done searching ****

                return true;
            }

            // **** no discovered type ****

            elementType = null;
            return false;
        }


        ///-------------------------------------------------------------------------------------------------
        /// <summary>Process a structure definition for a complex data type.</summary>
        ///
        /// <remarks>Gino Canessa, 2/19/2020.</remarks>
        ///
        /// <param name="sd">          The SD.</param>
        /// <param name="complexTypes">[in,out] List of types of the complexes.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        private bool ProcessDataTypeComplex(
                                            fhir_2.StructureDefinition sd, 
                                            ref Dictionary<string, FhirComplexType> complexTypes
                                            )
        {
            try
            {
                // **** create a new Complex Type object ****

                FhirComplexType complex = new FhirComplexType()
                {
                    Name = sd.Name,
                    NameCapitalized = Utils.CapitalizeName(sd.Name),
                    StandardStatus = sd.Status,
                    ShortDescription = sd.Description,
                    Definition = sd.Requirements,
                };

                Dictionary<string, FhirComplexType> subTypes = new Dictionary<string, FhirComplexType>();

                // **** figure out the base type ****

                foreach (fhir_2.ElementDefinition element in sd.Snapshot.Element)
                {
                    // **** check for base path having a type or {type}.value ****

                    if ((!element.Path.Contains(".")) ||
                        (element.Path.Equals($"{sd.Name}.value", StringComparison.Ordinal)))
                    {
                        if (TryGetTypeFromElement(sd.Name, element, out string elementType))
                        {
                            // **** set our type ****

                            complex.BaseTypeName = elementType;

                            // **** stop looking ****

                            break;
                        }
                    }
                }

                // **** make sure we have a type ****

                if (string.IsNullOrEmpty(complex.BaseTypeName))
                {
                    Console.WriteLine($"FromV2.ProcessDataTypeComplex <<<" +
                        $" Could not determine base type for {sd.Name}");
                    return false;
                }

                // **** add the current type definition to our internal dict for sanity ****

                subTypes.Add(sd.Name, complex);

                // **** look for properties on this type ****

                foreach (fhir_2.ElementDefinition element in sd.Snapshot.Element)
                {
                    // **** split the path into component parts ****

                    string[] components = element.Path.Split('.');

                    // **** base definition, already processed ****

                    if (components.Length < 2)
                    {
                        continue;
                    }

                    // **** grab field info we need ****

                    Utils.GetParentAndField(components, out string field, out string parent);

                    string elementType;

                    // **** if we can't find a type, assume Element ****

                    if (!TryGetTypeFromElement(parent, element, out elementType))
                    {
                        elementType = "Element";
                    }

                    // **** check to see if we do NOT have this parent, but do have a definition ****

                    if (!subTypes.ContainsKey(parent))
                    {
                        // **** figure out if we have this parent as a field ****

                        string[] parentComponents = new string[components.Length - 1];
                        Array.Copy(components, 0, parentComponents, 0, components.Length - 1);

                        // **** get parent info ****

                        Utils.GetParentAndField(parentComponents, out string pField, out string pParent);

                        if ((subTypes.ContainsKey(pParent)) &&
                            (subTypes[pParent].Properties.ContainsKey(pField)))
                        {
                            // **** use this type ****

                            FhirComplexType sub = new FhirComplexType()
                            {
                                Name = subTypes[pParent].Properties[pField].Name,
                                NameCapitalized = subTypes[pParent].Properties[pField].NameCapitalized,
                                ShortDescription = subTypes[pParent].Properties[pField].ShortDescription,
                                Definition = subTypes[pParent].Properties[pField].Definition,
                                Comment = subTypes[pParent].Properties[pField].Comment,
                                BaseTypeName = subTypes[pParent].Properties[pField].BaseTypeName,
                            };

                            // **** add this parent to our local dictionary ****

                            subTypes.Add(parent, sub);
                        }
                        else
                        {
                            // **** add a placeholder type ****

                            FhirComplexType sub = new FhirComplexType()
                            {
                                Name = parent,
                                NameCapitalized = Utils.CapitalizeName(parent),
                                ShortDescription = "",
                                Definition = "",
                                Comment = $"Placeholder for {parent}",
                                BaseTypeName = parent,
                                IsPlaceholder = true,
                            };

                            // **** add this parent to our local dictionary ****

                            subTypes.Add(parent, sub);
                        }
                    }

                    // **** add this field to the parent type ****

                    subTypes[parent].Properties.Add(
                        field,
                        new FhirProperty()
                        {
                            Name = field,
                            NameCapitalized = Utils.CapitalizeName(field),
                            ShortDescription = element.Short,
                            Definition = element.Definition,
                            Comment = element.Comment,
                            BaseTypeName = elementType,
                            CardinalityMin = element.Min ?? 0,
                            CardinaltiyMax = Utils.MaxCardinality(element.Max),
                        });

                }

                // **** copy over our definitions ****

                foreach (KeyValuePair<string, FhirComplexType> kvp in subTypes)
                {
                    // **** check for removing a placeholder ****

                    if ((complexTypes.ContainsKey(kvp.Key)) &&
                        (complexTypes[kvp.Key].IsPlaceholder == true))
                    {
                        complexTypes.Remove(kvp.Key);
                    }

                    // **** check for not being present ****

                    if (!complexTypes.ContainsKey(kvp.Key))
                    {
                        complexTypes.Add(kvp.Key, kvp.Value);
                        continue;
                    }

                    // **** check fields ****

                    foreach (KeyValuePair<string, FhirProperty> propKvp in kvp.Value.Properties)
                    {
                        if (!complexTypes[kvp.Key].Properties.ContainsKey(propKvp.Key))
                        {
                            complexTypes[kvp.Key].Properties.Add(propKvp.Key, propKvp.Value);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FromV2.ProcessDataTypeComplex <<< failed to process {sd.Id}:\n{ex}\n--------------");
                return false;
            }
            // **** success ****

            return true;
        }

        #endregion Internal Functions . . .

        #region IFhirConverter . . .

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to parse resource an object from the given string.</summary>
        ///
        /// <remarks>Gino Canessa, 2/19/2020.</remarks>
        ///
        /// <param name="json">The JSON.</param>
        /// <param name="obj"> [out] The object.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        bool IFhirConverter.TryParseResource(string json, out object obj)
        {
            try
            {
                // **** try to parse this JSON into a resource object ****

                obj = JsonConvert.DeserializeObject<fhir_2.Resource>(json, _jsonConverter);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"FromV2.TryParseResource <<< failed to parse:\n{ex}\n------------------------------------");
            }

            // **** failed to parse ****

            obj = null;
            return false;
        }

        ///-------------------------------------------------------------------------------------------------
        /// <summary>Attempts to process resource.</summary>
        ///
        /// <remarks>Gino Canessa, 2/19/2020.</remarks>
        ///
        /// <param name="obj">            [out] The object.</param>
        /// <param name="fhirVersionInfo">[in,out] Information describing the fhir version.</param>
        ///
        /// <returns>True if it succeeds, false if it fails.</returns>
        ///-------------------------------------------------------------------------------------------------

        bool IFhirConverter.TryProcessResource(
                                                object obj,
                                                ref Dictionary<string, FhirSimpleType> simpleTypes,
                                                ref Dictionary<string, FhirComplexType> complexTypes,
                                                ref Dictionary<string, FhirResource> resources
                                                )
        {
            try
            {

            switch (obj)
            {
                case fhir_2.Conformance conformance:
                    // **** ignore for now ****

                    return true;
                //break;

                case fhir_2.NamingSystem namingSystem:
                    // **** ignore for now ****

                    return true;
                //break;

                case fhir_2.OperationDefinition operationDefinition:
                    // **** ignore for now ****

                    return true;
                //break;

                case fhir_2.SearchParameter searchParameter:
                    // **** ignore for now ****

                    return true;
                //break;

                case fhir_2.StructureDefinition structureDefinition:
                    return ProcessStructureDef(
                        structureDefinition,
                        ref simpleTypes,
                        ref complexTypes,
                        ref resources
                        );
                //break;

                case fhir_2.ValueSet valueSet:
                    // **** ignore for now ****

                    return true;
                    //break;
            }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"FromV2.TryProcessResource <<< Failed to process resource:\n{ex}\n--------------");
                return false;
            }

            // **** ignored ****

            return true;
        }

        #endregion IFhirConverter . . .


    }
}
