<%@ Assembly Name="$SharePoint.Project.AssemblyFullName$" %>
<%@ Assembly Name="Microsoft.Web.CommandUI, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>
<%@ Register Tagprefix="SharePoint" Namespace="Microsoft.SharePoint.WebControls" Assembly="Microsoft.SharePoint, Version=15.0.0.0, Culture=neutral, PublicKeyToken=71e9bce111e9429c" %>

<SharePoint:RenderingTemplate ID="ddlContentTypeRenderingTemplate" runat="server">
    <Template>
        <asp:DropDownList ID="ddlContentType" runat="server"></asp:DropDownList>
    </Template>
</SharePoint:RenderingTemplate>