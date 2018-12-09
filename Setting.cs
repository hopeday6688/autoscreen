﻿//-----------------------------------------------------------------------
// <copyright file="Setting.cs" company="Gavin Kendall">
//     Copyright (c) Gavin Kendall. All rights reserved.
// </copyright>
// <author>Gavin Kendall</author>
// <summary>A class representing an application setting.</summary>
//-----------------------------------------------------------------------
namespace AutoScreenCapture
{
    public class Setting
    {
        public Setting()
        {

        }

        public Setting(string key, object value)
        {
            Key = key;
            _value = value;
        }

        public string Key { get; set; }

        private object _value;
        public object Value
        {
            get { return _value; }

            set { _value = value; }
        }
    }
}
