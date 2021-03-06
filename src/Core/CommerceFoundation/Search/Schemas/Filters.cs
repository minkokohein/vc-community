﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.0.30319.1.
// 
namespace VirtoCommerce.Foundation.Search.Schemas {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlRootAttribute("browsing", Namespace="", IsNullable=false)]
    public partial class FilteredBrowsing {

        private AttributeFilter[] attributeField;

        private RangeFilter[] attributeRangeField;
        
        private PriceRangeFilter[] priceField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attribute")]
        public AttributeFilter[] Attributes {
            get {
                return this.attributeField;
            }
            set {
                this.attributeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("attributeRange")]
        public RangeFilter[] AttributeRanges {
            get {
                return this.attributeRangeField;
            }
            set {
                this.attributeRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("price")]
        public PriceRangeFilter[] Prices {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AttributeFilter : ISearchFilter {
        
        private AttributeFilterValue[] simpleField;
        
        private string keyField;
        
        private bool localizedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("simple")]
        public AttributeFilterValue[] Values {
            get {
                return this.simpleField;
            }
            set {
                this.simpleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("key")]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("localized")]
        public bool IsLocalized {
            get {
                return this.localizedField;
            }
            set {
                this.localizedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AttributeFilterValue : ISearchFilterValue
    {
        
        private string idField;
        
        private string valueField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("value")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("language")]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PriceRangeFilter : ISearchFilter {
        
        private RangeFilterValue[] rangeField;
        
        private string currencyField;
        
        private bool localizedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("range")]
        public RangeFilterValue[] Values {
            get {
                return this.rangeField;
            }
            set {
                this.rangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("currency")]
        public string Currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
            }
        }

        [System.Xml.Serialization.XmlIgnore()]
        public string Key
        {
            get
            {
                return "price";
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("localized")]
        public bool IsLocalized {
            get {
                return this.localizedField;
            }
            set {
                this.localizedField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RangeFilterValue : ISearchFilterValue
    {
        
        private FilterValueDisplay[] displayField;
        
        private string lowerField;
        
        private string upperField;
        
        private string idField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("display")]
        public FilterValueDisplay[] Displays {
            get {
                return this.displayField;
            }
            set {
                this.displayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("lower")]
        public string Lower {
            get {
                return this.lowerField;
            }
            set {
                this.lowerField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("upper")]
        public string Upper {
            get {
                return this.upperField;
            }
            set {
                this.upperField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("id")]
        public string Id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class FilterValueDisplay {
        
        private string valueField;
        
        private string seoField;
        
        private string languageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public string Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("seo")]
        public string Seo {
            get {
                return this.seoField;
            }
            set {
                this.seoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("language")]
        public string Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RangeFilter : ISearchFilter
    {
        
        private RangeFilterValue[] rangeField;
        
        private string keyField;
        
        private bool localizedField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("range")]
        public RangeFilterValue[] Values {
            get {
                return this.rangeField;
            }
            set {
                this.rangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("key")]
        public string Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("localized")]
        public bool IsLocalized {
            get {
                return this.localizedField;
            }
            set {
                this.localizedField = value;
            }
        }
    }
}
