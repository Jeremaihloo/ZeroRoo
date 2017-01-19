﻿using System;

namespace ZeroRoo.Apps.Abstractions.Features
{
    public class InternalFeatureInfo : IFeatureInfo
    {
        private readonly string _id;
        private readonly string _name;
        private readonly double _priority;
        private readonly string _category;
        private readonly string _description;
        private readonly IAppInfo _extension;
        private readonly string[] _dependencies;

        public InternalFeatureInfo(
            string id,
            IAppInfo extensionInfo)
        {
            _id = id;
            _name = id;
            _priority = 0D;
            _category = null;
            _description = null;
            _extension = extensionInfo;
            _dependencies = new string[0];
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
