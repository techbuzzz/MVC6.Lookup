﻿using System;
using System.Collections.Generic;

namespace NonFactors.Mvc.Lookup
{
    public abstract class AbstractLookup
    {
        public const String Prefix = "Lookup";
        public const String IdKey = "LookupIdKey";
        public const String AcKey = "LookupAcKey";

        public String DialogTitle { get; protected set; }
        public String LookupUrl { get; protected set; }

        public LookupFilter CurrentFilter { get; set; }
        public LookupColumns Columns { get; protected set; }
        public IList<String> AdditionalFilters { get; protected set; }

        public String DefaultSortColumn { get; protected set; }
        public UInt32 DefaultRecordsPerPage { get; protected set; }
        public LookupSortOrder DefaultSortOrder { get; protected set; }

        protected AbstractLookup()
        {
            String sanitizedName = GetType().Name.Replace(Prefix, "");
            AdditionalFilters = new List<String>();
            CurrentFilter = new LookupFilter();
            Columns = new LookupColumns();
            DialogTitle = sanitizedName;
            DefaultRecordsPerPage = 20;
        }

        public abstract LookupData GetData();
    }
}
