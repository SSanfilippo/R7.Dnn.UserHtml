﻿<%@ Control Language="C#" AutoEventWireup="false" CodeBehind="EditUserHtml.ascx.cs" Inherits="R7.Dnn.UserHtml.EditUserHtml" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/labelcontrol.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.UI.WebControls" Assembly="DotNetNuke.Web" %>
<%@ Register TagPrefix="dnn" Namespace="DotNetNuke.Web.Client.ClientResourceManagement" Assembly="DotNetNuke.Web.Client" %>
<dnn:DnnCssInclude runat="server" FilePath="~/DesktopModules/R7.Dnn.UserHtml/R7.Dnn.UserHtml/admin.css" />
<div class="dnnForm dnnClear">
    <fieldset>  
        <div class="dnnFormItem">
            <div class="dnnLabel"></div>
            <dnn:TextEditor id="textUserHtml" runat="server" />
        </div>
    </fieldset>
    <ul class="dnnActions dnnClear">
        <li><asp:LinkButton id="buttonUpdate" runat="server" CssClass="dnnPrimaryAction" ResourceKey="cmdUpdate" OnClick="buttonUpdate_Click" CausesValidation="true" /></li>
        <li><asp:LinkButton id="buttonDelete" runat="server" CssClass="dnnSecondaryAction" ResourceKey="cmdDelete" OnClick="buttonDelete_Click" /></li>
        <li><asp:HyperLink id="linkCancel" runat="server" CssClass="dnnSecondaryAction" ResourceKey="cmdCancel" /></li>
    </ul>
    <dnn:Audit id="ctlAudit" runat="server" />
</div>
