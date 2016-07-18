﻿using Connector.CcvShop.Api.Base;
using System;
using System.Collections.Generic;

// This file is generated by the Converttool in the solution Connector.CcvShop.
namespace Connector.CcvShop.Api.Webshops.Settings
{
    public class SettingsResult : ResultBase
    {
        /// <summary>
        /// <summary>
        /// Currency code used in webshop, ISO 4217 Currency Codes
        /// Maxlength: 3
        /// </summary>
        /// <value>EUR</value>
        /// <value>GBP</value>
        /// <value>USD</value>
        /// <value>SEK</value>
        /// <value>RON</value>
        /// <value>DKK</value>
        /// <value>TRY</value>
        /// <value>CHF</value>
        /// <value>SRD</value>
        /// <value>CAD</value>
        public string currency { get; set; }

        /// <summary>
        /// <summary>
        /// Default VAT rate used when creating new products
        /// Minimum: 0
        /// Maximum: 100
        /// </summary>
        public double? default_vat_rat { get; set; }

        /// <summary>
        /// <summary>
        /// Do prices include VAT
        /// </summary>
        public bool? prices_include_vat { get; set; }

        /// <summary>
        /// <summary>
        /// Is the webshop Full SSL. If true, all links should be https://
        /// </summary>
        public bool? full_ssl_webshop { get; set; }

        /// <summary>
        /// <summary>
        /// The current value of one creditpoint in a webshop
        /// </summary>
        public double? creditpoint_value { get; set; }

        /// <summary>
        /// <summary>
        /// Array with available languages of the webshop
        /// Language code. See ISO 639-1 Language Codes.
        /// Minlength: 2
        /// Maxlength: 2
        /// </summary>
        /// <value>nl</value>
        /// <value>en</value>
        /// <value>de</value>
        /// <value>fr</value>
        /// <value>tr</value>
        public List<string> languages { get; set; }

    }
}
