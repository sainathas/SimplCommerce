﻿using SimplCommerce.Infrastructure.Models;

namespace SimplCommerce.Module.Payment.Models
{
    public class PaymentProvider : EntityBase
    {
        public string Name { get; set; }

        public bool IsEnabled { get; set; }

        public string ConfigureUrl { get; set; }

        public string LandingViewComponentName { get; set; }

        /// <summary>
        /// Additional setting for specific provider. Stored as json string.
        /// </summary>
        public string AdditionalSettings { get; set; }

        /// <summary>
        /// The type that 
        /// </summary>
        public string PaymentProviderTypeName { get; set; }
    }
}