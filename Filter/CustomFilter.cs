﻿using ItemFilterLibrary;
using System.Collections.Generic;

namespace Stashie
{
    public class CustomFilter : BaseFilter
    {
        public string ParentMenuName { get; set; }
        public List<Filter> Filters { get; set; } = new List<Filter>();

        public partial class Filter
        {
            public string FilterName { get; set; }
            public bool? Shifting { get; set; }
            public bool? Affinity { get; set; }
            public string RawQuery { get; set; }
            public ItemQuery CompiledQuery { get; set; }
            public ListIndexNode StashIndexNode { get; set; }
            public bool AllowProcess => StashIndexNode.Index != -1;
        }
    }
}