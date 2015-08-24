////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Fields\SPContentTypeLookupControl.cs
//
// summary:	Implements the sp content type lookup control class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Vlecerf.Com.SPCTLC.Fields
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A sp content type lookup control. </summary>
    ///
    /// <remarks>   Administrator, 24/08/2015. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class SPContentTypeLookupControl : BaseFieldControl
    {
        /// <summary>   Type of the ddl content. </summary>
        DropDownList ddlContentType;

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the name of the default rendering template. </summary>
        ///
        /// <value> A <see cref="T:System.String" /> object that names a rendering template. </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected override string DefaultTemplateName
        {
            get
            {
                return "ddlContentTypeRenderingTemplate";
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// Creates any child controls necessary to render the field, such as a label control, link
        /// control, or text box control.
        /// </summary>
        ///
        /// <remarks>   Administrator, 24/08/2015. </remarks>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        protected override void CreateChildControls()
        {
            base.CreateChildControls();
            ddlContentType = (DropDownList)TemplateContainer.FindControl("ddlContentType");
            if (ControlMode == SPControlMode.New || ControlMode == SPControlMode.Edit)
            {
                SPWeb currentWeb = SPContext.Current.Web;
                var contentTypesList = currentWeb.ContentTypes;
                foreach (SPContentType contentType in contentTypesList)
                {
                    ddlContentType.Items.Add(contentType.Name);
                }
            }
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>
        /// When overridden in a derived class, gets or sets the value of the field in the UI.
        /// </summary>
        ///
        /// <value>
        /// When overridden in a derived class, a <see cref="T:System.Object" /> that represents the
        /// value of the field in the UI. Typically, this is the text of a child control, such as a label
        /// or text box, that actually renders the field.
        /// </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public override object Value
        {
            get
            {
                EnsureChildControls();
                return ddlContentType.SelectedValue;
            }
            set
            {
                this.EnsureChildControls();
                ddlContentType.SelectedValue = (string)ItemFieldValue;
            }
        }
    }
}
