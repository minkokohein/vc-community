﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Omu.ValueInjecter;
using moduleModel = VirtoCommerce.CatalogModule.Model;
using webModel = VirtoCommerce.CatalogModule.Web.Model;

namespace VirtoCommerce.CatalogModule.Web.Converters
{
	public static class AssociationConverter
	{
		public static webModel.ProductAssociation ToWebModel(this moduleModel.ProductAssociation association)
		{
			var retVal = new webModel.ProductAssociation();
			retVal.InjectFrom(association);
			if (association.AssociatedProduct != null)
			{
				retVal.AssociatedProduct = association.AssociatedProduct.ToWebModel();
			}
			return retVal;
		}

		public static moduleModel.ProductAssociation ToModuleModel(this webModel.ProductAssociation association)
		{
			var retVal = new moduleModel.ProductAssociation();
			retVal.InjectFrom(association);
			if (association.AssociatedProduct != null)
			{
				retVal.AssociatedProduct = association.AssociatedProduct.ToModuleModel();
			}
			return retVal;
		}


	}
}