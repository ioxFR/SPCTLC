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
    class SPContentTypeLookupControl : BaseFieldControl
    {
        DropDownList ddlContentType;

        protected override string DefaultTemplateName
        {
            get
            {
                return "ddlContentTypeRenderingTemplate";
            }
        }

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
