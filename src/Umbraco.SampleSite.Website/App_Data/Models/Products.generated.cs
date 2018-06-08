//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.8.100
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Products</summary>
	[PublishedContentModel("products")]
	public partial class Products : PublishedContentModel, IContentBase, INavigationBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "products";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Products(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Products, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Default Currency: This is just used to prefix pricing
		///</summary>
		[ImplementPropertyType("defaultCurrency")]
		public string DefaultCurrency
		{
			get { return this.GetPropertyValue<string>("defaultCurrency"); }
		}

		///<summary>
		/// Featured Products
		///</summary>
		[ImplementPropertyType("featuredProducts")]
		public IEnumerable<IPublishedContent> FeaturedProducts
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("featuredProducts"); }
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public Newtonsoft.Json.Linq.JToken BodyText
		{
			get { return Umbraco.Web.PublishedContentModels.ContentBase.GetBodyText(this); }
		}

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.ContentBase.GetPageTitle(this); }
		}

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is consired optional since most modern search engines don't use this anymore
		///</summary>
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords
		{
			get { return Umbraco.Web.PublishedContentModels.NavigationBase.GetKeywords(this); }
		}

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.NavigationBase.GetSeoMetaDescription(this); }
		}

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide
		{
			get { return Umbraco.Web.PublishedContentModels.NavigationBase.GetUmbracoNavihide(this); }
		}
	}
}
