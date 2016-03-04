﻿using System;
using System.Collections;
using System.Xml.Serialization;
using Urbbox.AutoCAD.ProtentionBuilder.Building.Variations;
using Urbbox.AutoCAD.ProtentionBuilder.ViewModels;

namespace Urbbox.AutoCAD.ProtentionBuilder.Building
{
    [Serializable]
    public class Part : ModelBase, IEqualityComparer
    {
        private string _referenceName;
        public string ReferenceName {
            get { return _referenceName; }
            set { _referenceName = value; OnPropertyChanged(); }
        }

        private float _width;
        public float Width {
            get { return _width; }
            set { _width = value; OnPropertyChanged(); }
        }

        private float _height;
        public float Height {
            get { return _height; }
            set { _height = value; OnPropertyChanged(); }
        }

        private PivotPoint _pivotPoint;
        public PivotPoint PivotPoint {
            get { return _pivotPoint; }
            set { _pivotPoint = value; OnPropertyChanged(); }
        }

        private UsageType _usageType;
        public UsageType UsageType {
            get { return _usageType; }
            set { _usageType = value; OnPropertyChanged(); }
        }

        private string _layer;
        public string Layer {
            get { return _layer; }
            set { _layer = value; OnPropertyChanged(); }
        }

        private string _name;
        [XmlAttribute]
        public string Name {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }

        private int _modulation;
        [XmlAttribute]
        public int Modulation {
            get { return _modulation; }
            set { _modulation = value; OnPropertyChanged(); }
        }

        public Part() { }

        public Part(string name, string referenceName)
        {
            Name = name;
            ReferenceName = referenceName;
        }

        bool IEqualityComparer.Equals(object x, object y)
        {
            return ((Part)x).ReferenceName == ((Part)y).ReferenceName;
        }

        int IEqualityComparer.GetHashCode(object obj)
        {  
            return ((Part) obj).ReferenceName.GetHashCode();
        }
    }
}