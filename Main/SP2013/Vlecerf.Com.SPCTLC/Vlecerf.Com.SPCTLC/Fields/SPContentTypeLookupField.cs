////////////////////////////////////////////////////////////////////////////////////////////////////
// file:	Fields\SPContentTypeLookupField.cs
//
// summary:	Implements the sp content type lookup field class
////////////////////////////////////////////////////////////////////////////////////////////////////

using Microsoft.SharePoint;
using Microsoft.SharePoint.WebControls;

namespace Vlecerf.Com.SPCTLC.Fields
{
    ////////////////////////////////////////////////////////////////////////////////////////////////////
    /// <summary>   A sp content type lookup field. </summary>
    ///
    /// <remarks>   Administrator, 24/08/2015. </remarks>
    ////////////////////////////////////////////////////////////////////////////////////////////////////

    class SPContentTypeLookupField : SPFieldChoice
    {
        #region Constructors

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Administrator, 24/08/2015. </remarks>
        ///
        /// <param name="fields">       The fields. </param>
        /// <param name="fieldName">    Name of the field. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public SPContentTypeLookupField(SPFieldCollection fields, string fieldName) : base(fields, fieldName) { }

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Constructor. </summary>
        ///
        /// <remarks>   Administrator, 24/08/2015. </remarks>
        ///
        /// <param name="fields">       The fields. </param>
        /// <param name="typeName">     Name of the type. </param>
        /// <param name="displayName">  Name of the display. </param>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

        public SPContentTypeLookupField(SPFieldCollection fields, string typeName, string displayName) : base(fields, typeName, displayName) { }
        #endregion

        #region Properties

        ////////////////////////////////////////////////////////////////////////////////////////////////////
        /// <summary>   Gets the field type control that is used to render the field. </summary>
        ///
        /// <value>
        /// A <see cref="T:Microsoft.SharePoint.WebControls.BaseFieldControl" /> object that represents
        /// the control.
        /// </value>
        ////////////////////////////////////////////////////////////////////////////////////////////////////

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
