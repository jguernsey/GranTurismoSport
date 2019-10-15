/*
' Copyright (c) 2018 JasonGuernsey.net
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

//using System.Xml;

namespace Jjg.GtsStats.QualifyingTimesM.Components
{

	/// -----------------------------------------------------------------------------
	/// <summary>
	/// The Controller class for QualifyingTimesM
	/// 
	/// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
	/// DotNetNuke will poll this class to find out which Interfaces the class implements. 
	/// 
	/// The IPortable interface is used to import/export content from a DNN module
	/// 
	/// The ISearchable interface is used by DNN to index the content of a module
	/// 
	/// The IUpgradeable interface allows module developers to execute code during the upgrade 
	/// process for a module.
	/// 
	/// Below you will find stubbed out implementations of each, uncomment and populate with your own data
	/// </summary>
	/// -----------------------------------------------------------------------------

	//uncomment the interfaces to add the support.
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

		//List<QualifyingTimesMInfo> colQualifyingTimesMs = GetQualifyingTimesMs(ModuleID);
		//if (colQualifyingTimesMs.Count != 0)
		//{
		//    strXML += "<QualifyingTimesMs>";

		//    foreach (QualifyingTimesMInfo objQualifyingTimesM in colQualifyingTimesMs)
		//    {
		//        strXML += "<QualifyingTimesM>";
		//        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objQualifyingTimesM.Content) + "</content>";
		//        strXML += "</QualifyingTimesM>";
		//    }
		//    strXML += "</QualifyingTimesMs>";
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
		//XmlNode xmlQualifyingTimesMs = DotNetNuke.Common.Globals.GetContent(Content, "QualifyingTimesMs");
		//foreach (XmlNode xmlQualifyingTimesM in xmlQualifyingTimesMs.SelectNodes("QualifyingTimesM"))
		//{
		//    QualifyingTimesMInfo objQualifyingTimesM = new QualifyingTimesMInfo();
		//    objQualifyingTimesM.ModuleId = ModuleID;
		//    objQualifyingTimesM.Content = xmlQualifyingTimesM.SelectSingleNode("content").InnerText;
		//    objQualifyingTimesM.CreatedByUser = UserID;
		//    AddQualifyingTimesM(objQualifyingTimesM);
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

		//List<QualifyingTimesMInfo> colQualifyingTimesMs = GetQualifyingTimesMs(ModInfo.ModuleID);

		//foreach (QualifyingTimesMInfo objQualifyingTimesM in colQualifyingTimesMs)
		//{
		//    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objQualifyingTimesM.Content, objQualifyingTimesM.CreatedByUser, objQualifyingTimesM.CreatedDate, ModInfo.ModuleID, objQualifyingTimesM.ItemId.ToString(), objQualifyingTimesM.Content, "ItemId=" + objQualifyingTimesM.ItemId.ToString());
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
