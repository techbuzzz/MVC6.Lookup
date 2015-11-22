﻿using System;

namespace NonFactors.Mvc.Lookup
{
    public class LookupColumn
    {
        public String Key { get; protected set; }
        public String Header { get; protected set; }
        public String CssClass { get; protected set; }

        public LookupColumn(String key, String header, String cssClass = "")
        {
            if (key == null)
                throw new ArgumentNullException("key");

            if (header == null)
                throw new ArgumentNullException("header");

            if (cssClass == null)
                throw new ArgumentNullException("cssClass");

            Key = key;
            Header = header;
            CssClass = cssClass;
        }
    }
}
