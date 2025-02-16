﻿using System.Collections.Generic;

namespace GoogleApi.Entities.PlacesNew.AutoComplete.Response;

/// <summary>
/// Prediction results for a Place Autocomplete prediction.
/// </summary>
public class PlacePrediction
{
    /// <summary>
    /// The resource name of the suggested Place. This name can be used in other APIs that accept Place names.
    /// </summary>
    public virtual string Place { get; set; }

    /// <summary>
    /// The unique identifier of the suggested Place. This identifier can be used in other APIs that accept Place IDs.
    /// </summary>
    public virtual string PlaceId { get; set; }

    /// <summary>
    /// Contains the human-readable name for the returned result. For establishment results, this is usually the business name and address.
    /// text is recommended for developers who wish to show a single UI element.
    /// Developers who wish to show two separate, but related, UI elements may want to use structuredFormat instead.
    /// They are two different ways to represent a Place prediction.Users should not try to parse structuredFormat into text or vice versa.
    /// This text may be different from the displayName returned by places.get.
    /// May be in mixed languages if the request input and languageCode are in different languages or if the Place does not have a translation
    /// from the local language to languageCode.
    /// </summary>
    public virtual FormattableText Text { get; set; }

    /// <summary>
    /// A breakdown of the Place prediction into main text containing the name of the Place and secondary text
    /// containing additional disambiguating features (such as a city or region).
    /// structuredFormat is recommended for developers who wish to show two separate, but related, UI elements.
    /// Developers who wish to show a single UI element may want to use text instead.They are two different ways to represent a Place prediction.
    /// Users should not try to parse structuredFormat into text or vice versa.
    /// </summary>
    public virtual StructuredFormat StructuredFormat { get; set; }

    /// <summary>
    /// List of types that apply to this Place from Table A or Table B in
    /// https://developers.google.com/maps/documentation/places/web-service/place-types.
    /// A type is a categorization of a Place.
    /// Places with shared types will share similar characteristics.
    /// </summary>
    public virtual IEnumerable<string> Types { get; set; }

    /// <summary>
    /// The length of the geodesic in meters from origin if origin is specified.
    /// Certain predictions such as routes may not populate this field.
    /// </summary>
    public virtual int DistanceMeters { get; set; }
}