﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApiGenerator.Models
{
    public class ParameterInfo
    {
        public string ParamName { get; set; }
        public string CleanParamName
        {
            get
            {
                return ParamName.Replace("$", "");
            }
        }
        public string Type { get; set; }
        public string TypeName { get; set; }
        public string Comment { get; set; }

        public bool IsArrayType { get; set; }
        public string ArrayElementType { get; set; }
        public bool Required { get; set; }
        public bool ReadOnly { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
        public string Example { get; set; }
    }
}
