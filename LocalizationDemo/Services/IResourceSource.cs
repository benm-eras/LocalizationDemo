﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Services
{
    public interface IResourceSource
    {
        string Get(string key);
    }

    public class ResourceSource : IResourceSource
    {
        public string Get(string key) => $"[{key}]";
    }
}