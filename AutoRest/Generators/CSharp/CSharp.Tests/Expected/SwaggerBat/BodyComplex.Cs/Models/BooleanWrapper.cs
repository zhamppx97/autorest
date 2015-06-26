namespace Fixtures.SwaggerBatBodyComplex.Models
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// </summary>
    public partial class BooleanWrapper
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field_true")]
        public bool? FieldTrue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "field_false")]
        public bool? FieldFalse { get; set; }

        /// <summary>
        /// Validate the object. Throws ArgumentException or ArgumentNullException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}