﻿using ZeroRoo.Apps.Abstractions;
using ZeroRoo.Apps.Abstractions.Features;

namespace ZeroRoo.Apps.Features
{
    public class FeatureInfo : IFeatureInfo
    {
        private readonly string _id;
        private readonly string _name;
        private readonly double _priority;
        private readonly string _category;
        private readonly string _description;
        private readonly IAppInfo _extension;
        private readonly string[] _dependencies;

        public FeatureInfo(
            string id,
            string name,
            double priority,
            string category,
            string description,
            IAppInfo extension,
            string[] dependencies)
        {
            _id = id;
            _name = name;
            _priority = priority;
            _category = category;
            _description = description;
            _extension = extension;
            _dependencies = dependencies;
        }

        public string Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Priority { get { return _priority; } }
        public string Category { get { return _category; } }
        public string Description { get { return _description; } }
        public IAppInfo Extension { get { return _extension; } }
        public string[] Dependencies { get { return _dependencies; } }
    }
}
