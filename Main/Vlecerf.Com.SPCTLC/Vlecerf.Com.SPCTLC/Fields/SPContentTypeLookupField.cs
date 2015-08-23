using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vlecerf.Com.SPCTLC.Fields
{
    class SPContentTypeLookupField : SPFieldChoice
    {
        #region Constructors
        public SPContentTypeLookupField(SPFieldCollection fields, string fieldName) : base(fields, fieldName) { }

        public SPContentTypeLookupField(SPFieldCollection fields, string typeName, string displayName) : base(fields, typeName, displayName) { }
        #endregion

        #region Properties
        public override BaseFieldControl FieldRenderingControl
        {
            get
            {
                BaseFieldControl fieldControl = new SPContentTypeLookupControl();
                fieldControl.FieldName = InternalName;
                return fieldControl;
            }
        }
        #endregion
    }
}
