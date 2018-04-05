﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

#pragma warning disable 1591 // suppress XML summary warnings 

//
// Generated for FHIR v3.2.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Immunization evaluation information
    /// </summary>
    [FhirType("ImmunizationEvaluation", IsResource=true)]
    [DataContract]
    public partial class ImmunizationEvaluation : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ImmunizationEvaluation; } }
        [NotMapped]
        public override string TypeName { get { return "ImmunizationEvaluation"; } }
        
        /// <summary>
        /// The value set to instantiate this attribute should be drawn from a terminologically robust code system that consists of or contains concepts to support describing the current status of the evaluation for vaccine administration event.
        /// (url: http://hl7.org/fhir/ValueSet/immunization-evaluation-status)
        /// </summary>
        [FhirEnumeration("ImmunizationEvaluationStatusCodes")]
        public enum ImmunizationEvaluationStatusCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("completed", "http://hl7.org/fhir/medication-admin-status"), Description("Completed")]
            Completed,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/medication-admin-status)
            /// </summary>
            [EnumLiteral("entered-in-error", "http://hl7.org/fhir/medication-admin-status"), Description("Entered in Error")]
            EnteredInError,
        }

        /// <summary>
        /// Business identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// completed | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes> _StatusElement;
        
        /// <summary>
        /// completed | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Who this evaluation is for
        /// </summary>
        [FhirElement("patient", InSummary=true, Order=110)]
        [CLSCompliant(false)]
		[References("Patient")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Patient
        {
            get { return _Patient; }
            set { _Patient = value; OnPropertyChanged("Patient"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Patient;
        
        /// <summary>
        /// Date evaluation was performed
        /// </summary>
        [FhirElement("date", Order=120)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _DateElement;
        
        /// <summary>
        /// Date evaluation was performed
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (value == null)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Who is responsible for publishing the recommendations
        /// </summary>
        [FhirElement("authority", Order=130)]
        [CLSCompliant(false)]
		[References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Authority
        {
            get { return _Authority; }
            set { _Authority = value; OnPropertyChanged("Authority"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Authority;
        
        /// <summary>
        /// Evaluation target disease
        /// </summary>
        [FhirElement("targetDisease", InSummary=true, Order=140)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> TargetDisease
        {
            get { if(_TargetDisease==null) _TargetDisease = new List<Hl7.Fhir.Model.CodeableConcept>(); return _TargetDisease; }
            set { _TargetDisease = value; OnPropertyChanged("TargetDisease"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _TargetDisease;
        
        /// <summary>
        /// Immunization being evaluated
        /// </summary>
        [FhirElement("immunizationEvent", InSummary=true, Order=150)]
        [CLSCompliant(false)]
		[References("Immunization")]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference ImmunizationEvent
        {
            get { return _ImmunizationEvent; }
            set { _ImmunizationEvent = value; OnPropertyChanged("ImmunizationEvent"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _ImmunizationEvent;
        
        /// <summary>
        /// Status of the dose relative to published recommendations
        /// </summary>
        [FhirElement("doseStatus", InSummary=true, Order=160)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept DoseStatus
        {
            get { return _DoseStatus; }
            set { _DoseStatus = value; OnPropertyChanged("DoseStatus"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _DoseStatus;
        
        /// <summary>
        /// Reason for the dose status
        /// </summary>
        [FhirElement("doseStatusReason", Order=170)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> DoseStatusReason
        {
            get { if(_DoseStatusReason==null) _DoseStatusReason = new List<Hl7.Fhir.Model.CodeableConcept>(); return _DoseStatusReason; }
            set { _DoseStatusReason = value; OnPropertyChanged("DoseStatusReason"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _DoseStatusReason;
        
        /// <summary>
        /// Evaluation notes
        /// </summary>
        [FhirElement("description", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Evaluation notes
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Name of vaccine series
        /// </summary>
        [FhirElement("series", Order=190)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString SeriesElement
        {
            get { return _SeriesElement; }
            set { _SeriesElement = value; OnPropertyChanged("SeriesElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _SeriesElement;
        
        /// <summary>
        /// Name of vaccine series
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Series
        {
            get { return SeriesElement != null ? SeriesElement.Value : null; }
            set
            {
                if (value == null)
                  SeriesElement = null; 
                else
                  SeriesElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Series");
            }
        }
        
        /// <summary>
        /// Dose number within series
        /// </summary>
        [FhirElement("doseNumber", Order=200)]
        [DataMember]
        public Hl7.Fhir.Model.PositiveInt DoseNumberElement
        {
            get { return _DoseNumberElement; }
            set { _DoseNumberElement = value; OnPropertyChanged("DoseNumberElement"); }
        }
        
        private Hl7.Fhir.Model.PositiveInt _DoseNumberElement;
        
        /// <summary>
        /// Dose number within series
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? DoseNumber
        {
            get { return DoseNumberElement != null ? DoseNumberElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  DoseNumberElement = null; 
                else
                  DoseNumberElement = new Hl7.Fhir.Model.PositiveInt(value);
                OnPropertyChanged("DoseNumber");
            }
        }
        
        /// <summary>
        /// Recommended number of doses for immunity
        /// </summary>
        [FhirElement("seriesDoses", Order=210)]
        [DataMember]
        public Hl7.Fhir.Model.PositiveInt SeriesDosesElement
        {
            get { return _SeriesDosesElement; }
            set { _SeriesDosesElement = value; OnPropertyChanged("SeriesDosesElement"); }
        }
        
        private Hl7.Fhir.Model.PositiveInt _SeriesDosesElement;
        
        /// <summary>
        /// Recommended number of doses for immunity
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? SeriesDoses
        {
            get { return SeriesDosesElement != null ? SeriesDosesElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  SeriesDosesElement = null; 
                else
                  SeriesDosesElement = new Hl7.Fhir.Model.PositiveInt(value);
                OnPropertyChanged("SeriesDoses");
            }
        }
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ImmunizationEvaluation;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.ImmunizationEvaluation.ImmunizationEvaluationStatusCodes>)StatusElement.DeepCopy();
                if(Patient != null) dest.Patient = (Hl7.Fhir.Model.ResourceReference)Patient.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.FhirDateTime)DateElement.DeepCopy();
                if(Authority != null) dest.Authority = (Hl7.Fhir.Model.ResourceReference)Authority.DeepCopy();
                if(TargetDisease != null) dest.TargetDisease = new List<Hl7.Fhir.Model.CodeableConcept>(TargetDisease.DeepCopy());
                if(ImmunizationEvent != null) dest.ImmunizationEvent = (Hl7.Fhir.Model.ResourceReference)ImmunizationEvent.DeepCopy();
                if(DoseStatus != null) dest.DoseStatus = (Hl7.Fhir.Model.CodeableConcept)DoseStatus.DeepCopy();
                if(DoseStatusReason != null) dest.DoseStatusReason = new List<Hl7.Fhir.Model.CodeableConcept>(DoseStatusReason.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(SeriesElement != null) dest.SeriesElement = (Hl7.Fhir.Model.FhirString)SeriesElement.DeepCopy();
                if(DoseNumberElement != null) dest.DoseNumberElement = (Hl7.Fhir.Model.PositiveInt)DoseNumberElement.DeepCopy();
                if(SeriesDosesElement != null) dest.SeriesDosesElement = (Hl7.Fhir.Model.PositiveInt)SeriesDosesElement.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ImmunizationEvaluation());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ImmunizationEvaluation;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(Patient, otherT.Patient)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Authority, otherT.Authority)) return false;
            if( !DeepComparable.Matches(TargetDisease, otherT.TargetDisease)) return false;
            if( !DeepComparable.Matches(ImmunizationEvent, otherT.ImmunizationEvent)) return false;
            if( !DeepComparable.Matches(DoseStatus, otherT.DoseStatus)) return false;
            if( !DeepComparable.Matches(DoseStatusReason, otherT.DoseStatusReason)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(SeriesElement, otherT.SeriesElement)) return false;
            if( !DeepComparable.Matches(DoseNumberElement, otherT.DoseNumberElement)) return false;
            if( !DeepComparable.Matches(SeriesDosesElement, otherT.SeriesDosesElement)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ImmunizationEvaluation;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(Patient, otherT.Patient)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Authority, otherT.Authority)) return false;
            if( !DeepComparable.IsExactly(TargetDisease, otherT.TargetDisease)) return false;
            if( !DeepComparable.IsExactly(ImmunizationEvent, otherT.ImmunizationEvent)) return false;
            if( !DeepComparable.IsExactly(DoseStatus, otherT.DoseStatus)) return false;
            if( !DeepComparable.IsExactly(DoseStatusReason, otherT.DoseStatusReason)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(SeriesElement, otherT.SeriesElement)) return false;
            if( !DeepComparable.IsExactly(DoseNumberElement, otherT.DoseNumberElement)) return false;
            if( !DeepComparable.IsExactly(SeriesDosesElement, otherT.SeriesDosesElement)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (StatusElement != null) yield return StatusElement;
				if (Patient != null) yield return Patient;
				if (DateElement != null) yield return DateElement;
				if (Authority != null) yield return Authority;
				foreach (var elem in TargetDisease) { if (elem != null) yield return elem; }
				if (ImmunizationEvent != null) yield return ImmunizationEvent;
				if (DoseStatus != null) yield return DoseStatus;
				foreach (var elem in DoseStatusReason) { if (elem != null) yield return elem; }
				if (DescriptionElement != null) yield return DescriptionElement;
				if (SeriesElement != null) yield return SeriesElement;
				if (DoseNumberElement != null) yield return DoseNumberElement;
				if (SeriesDosesElement != null) yield return SeriesDosesElement;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (Patient != null) yield return new ElementValue("patient", false, Patient);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                if (Authority != null) yield return new ElementValue("authority", false, Authority);
                foreach (var elem in TargetDisease) { if (elem != null) yield return new ElementValue("targetDisease", true, elem); }
                if (ImmunizationEvent != null) yield return new ElementValue("immunizationEvent", false, ImmunizationEvent);
                if (DoseStatus != null) yield return new ElementValue("doseStatus", false, DoseStatus);
                foreach (var elem in DoseStatusReason) { if (elem != null) yield return new ElementValue("doseStatusReason", true, elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                if (SeriesElement != null) yield return new ElementValue("series", false, SeriesElement);
                if (DoseNumberElement != null) yield return new ElementValue("doseNumber", false, DoseNumberElement);
                if (SeriesDosesElement != null) yield return new ElementValue("seriesDoses", false, SeriesDosesElement);
            }
        }

    }
    
}