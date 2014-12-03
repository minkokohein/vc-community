﻿using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;
using VirtoCommerce.CatalogModule.Web.Model;
using VirtoCommerce.Foundation.Frameworks.Extensions;
using foundation = VirtoCommerce.Foundation.Importing.Model;

namespace VirtoCommerce.CatalogModule.Web.Converters
{
    public static class ImportJobConverter
    {
        public static ImportJob ToWebModel(this foundation.ImportJob core)
        {
            var retVal = new ImportJob();
            retVal.InjectFrom(core);
            retVal.Id = core.ImportJobId;

            var mappings = new List<MappingItem>();
            foreach (var map in core.PropertiesMap)
            {
                var webMap = new MappingItem();
                webMap.InjectFrom(map);
                webMap.Id = map.MappingItemId;
                webMap.ImportJobId = core.ImportJobId;
                mappings.Add(webMap);
            }

            if (mappings.Any())
            {
                retVal.PropertiesMap = mappings;
            }

            return retVal;
        }

        public static foundation.ImportJob ToFoundation(this ImportJob webEntity)
        {
            var retVal = new foundation.ImportJob();
            retVal.InjectFrom(webEntity);
            retVal.ImportJobId = webEntity.Id;

            if (webEntity.PropertiesMap != null)
            {
                foreach (var map in webEntity.PropertiesMap)
                {
                    var coreMap = new foundation.MappingItem();
                    coreMap.InjectFrom(map);
                    coreMap.MappingItemId = map.Id;
                    coreMap.ImportJobId = webEntity.Id;
                    coreMap.ImportJob = retVal;
                    retVal.PropertiesMap.Add(coreMap);
                }
            }
            return retVal;
        }

        public static void Patch(this foundation.ImportJob source, foundation.ImportJob target)
        {
            if (target == null)
                throw new ArgumentNullException("target");

            //Simple properties patch
            if (source.ColumnDelimiter != null)
                target.ColumnDelimiter = source.ColumnDelimiter;
            // target.EntityImporter = source.EntityImporter;
            // target.CatalogId = source.CatalogId;
            if (source.ImportStep > 0)
                target.ImportStep = source.ImportStep;
            if (source.ImportCount > 0)
                target.ImportCount = source.ImportCount;
            if (source.MaxErrorsCount > 0)
                target.MaxErrorsCount = source.MaxErrorsCount;
            if (source.Name != null)
                target.Name = source.Name;
            if (source.PropertySetId != null)
                target.PropertySetId = source.PropertySetId;
            if (source.StartIndex > 0)
                target.StartIndex = source.StartIndex;
            if (source.TemplatePath != null)
                target.TemplatePath = source.TemplatePath;

            if (!source.PropertiesMap.IsNullCollection())
            {
                source.PropertiesMap.Patch(target.PropertiesMap, new MappingItemComparer(), (srce, trgt) => srce.Patch(trgt));
            }
        }
    }
}
