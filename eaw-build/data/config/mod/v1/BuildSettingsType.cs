﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


//
// This source code was auto-generated by xsd, Version=4.6.1055.0.
//


/// <remarks/>

namespace eaw.build.data.config.mod.v1
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class BuildSettingsType : object, System.ComponentModel.INotifyPropertyChanged
    {
        private LocalisationType localisationField;

        private BundleType[] bundleField;

        /// <remarks/>
        public LocalisationType Localisation
        {
            get { return this.localisationField; }
            set
            {
                this.localisationField = value;
                this.RaisePropertyChanged("Localisation");
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Bundle")]
        public BundleType[] Bundle
        {
            get { return this.bundleField; }
            set
            {
                this.bundleField = value;
                this.RaisePropertyChanged("Bundle");
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}