using System;
using System.Collections.Generic;
using PowerDocu.Common;

namespace PowerDocu.AppDocumenter
{
    public class AppEntity
    {
        public string ID;
        public string Name;

        public List<ControlEntity> Controls = new List<ControlEntity>();
        public List<Expression> Properties = new List<Expression>();
        public List<DataSource> DataSources = new List<DataSource>();
        public List<Resource> Resources = new List<Resource>();
        public HashSet<string> GlobalVariables = new HashSet<string>();
        public HashSet<string> ContextVariables = new HashSet<string>();
        public HashSet<string> Collections = new HashSet<string>();
        public AppEntity()
        {
        }
    }

    public class DataSource
    {
        public string Name;
        public string Type;
        public List<Expression> Properties = new List<Expression>();
    }

    public class Resource
    {
        public string Name;
        public string Content;
        public string ResourceKind;
        public List<Expression> Properties = new List<Expression>();
    }
}