using System.Collections.Generic;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace Jjg.GtsStats.StatCharts.Components
{
	public class FeatureController //: IPortable, ISearchable, IUpgradeable
	{


		#region Optional Interfaces

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// ExportModule implements the IPortable ExportModule Interface
		/// </summary>
		/// <param name="ModuleID">The Id of the module to be exported</param>
		/// -----------------------------------------------------------------------------
		//public string ExportModule(int ModuleID)
		//{
		//string strXML = "";

		//List<StatChartsInfo> colStatChartss = GetStatChartss(ModuleID);
		//if (colStatChartss.Count != 0)
		//{
		//    strXML += "<StatChartss>";

		//    foreach (StatChartsInfo objStatCharts in colStatChartss)
		//    {
		//        strXML += "<StatCharts>";
		//        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objStatCharts.Content) + "</content>";
		//        strXML += "</StatCharts>";
		//    }
		//    strXML += "</StatChartss>";
		//}

		//return strXML;

		//	throw new System.NotImplementedException("The method or operation is not implemented.");
		//}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// ImportModule implements the IPortable ImportModule Interface
		/// </summary>
		/// <param name="ModuleID">The Id of the module to be imported</param>
		/// <param name="Content">The content to be imported</param>
		/// <param name="Version">The version of the module to be imported</param>
		/// <param name="UserId">The Id of the user performing the import</param>
		/// -----------------------------------------------------------------------------
		//public void ImportModule(int ModuleID, string Content, string Version, int UserID)
		//{
		//XmlNode xmlStatChartss = DotNetNuke.Common.Globals.GetContent(Content, "StatChartss");
		//foreach (XmlNode xmlStatCharts in xmlStatChartss.SelectNodes("StatCharts"))
		//{
		//    StatChartsInfo objStatCharts = new StatChartsInfo();
		//    objStatCharts.ModuleId = ModuleID;
		//    objStatCharts.Content = xmlStatCharts.SelectSingleNode("content").InnerText;
		//    objStatCharts.CreatedByUser = UserID;
		//    AddStatCharts(objStatCharts);
		//}

		//	throw new System.NotImplementedException("The method or operation is not implemented.");
		//}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// GetSearchItems implements the ISearchable Interface
		/// </summary>
		/// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
		/// -----------------------------------------------------------------------------
		//public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
		//{
		//SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

		//List<StatChartsInfo> colStatChartss = GetStatChartss(ModInfo.ModuleID);

		//foreach (StatChartsInfo objStatCharts in colStatChartss)
		//{
		//    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objStatCharts.Content, objStatCharts.CreatedByUser, objStatCharts.CreatedDate, ModInfo.ModuleID, objStatCharts.ItemId.ToString(), objStatCharts.Content, "ItemId=" + objStatCharts.ItemId.ToString());
		//    SearchItemCollection.Add(SearchItem);
		//}

		//return SearchItemCollection;

		//	throw new System.NotImplementedException("The method or operation is not implemented.");
		//}

		/// -----------------------------------------------------------------------------
		/// <summary>
		/// UpgradeModule implements the IUpgradeable Interface
		/// </summary>
		/// <param name="Version">The current version of the module</param>
		/// -----------------------------------------------------------------------------
		//public string UpgradeModule(string Version)
		//{
		//	throw new System.NotImplementedException("The method or operation is not implemented.");
		//}

		#endregion

	}

}
