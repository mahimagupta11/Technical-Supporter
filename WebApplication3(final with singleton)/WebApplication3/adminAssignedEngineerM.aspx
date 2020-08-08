<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="adminAssignedEngineerM.aspx.cs" Inherits="WebApplication3.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Assign Engineer</title>
    <style>
.button 
{
    background-color: dodgerblue;
    padding: 7px 16px;
    color: black;
    border-radius: 15px;
    text-align: center;
    font-size: 10px;
    font-family: Verdana;
}
.button:hover
{
    background-color:white;
    color:black;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--     <form id="form1" runat="server">--%>
    <div>
         <center>
             <asp:Label ID="l1" runat="server"></asp:Label>
             <asp:Label ID="l2" runat="server"></asp:Label>
             <asp:Label ID="l3" runat="server"></asp:Label>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCommand="GridView1_RowCommand" DataKeyNames="complaint_Id, Complaint_Type"  GridLines="Both" CellPadding="4" ForeColor="#333333"  >
            <AlternatingRowStyle BackColor="White" />
            <Columns>
               <asp:TemplateField HeaderText="Complaint ID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Id" runat="server" Text='<%#Eval("complaint_Id") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Complaint Body">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Body" runat="server" Text='<%#Eval("complaint_body") %>'></asp:Label>  
                    </ItemTemplate>  
                </asp:TemplateField>  
                <asp:TemplateField HeaderText="Submission Date">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Sdate" runat="server" Text='<%#Eval("date_of_submission") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Submitted By Employee">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_SBE" runat="server" Text='<%#Eval("submitted_by") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField>

                 <asp:TemplateField HeaderText="Complaint Type">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_CT" runat="server" Text='<%#Eval("Complaint_Type") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField> 
                 <asp:TemplateField HeaderText="Complaint Status">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_CS" runat="server" Text='<%#Eval("complaint_status") %>'></asp:Label>  
                    </ItemTemplate>  
                    </asp:TemplateField>
                <asp:TemplateField HeaderText="Controls">
                    <ItemTemplate>
                       <asp:Button ID="b1" runat="server" CssClass="button" Text="View All" CommandName="View_All" CommandArgument="<%# Container.DataItemIndex %>"  />
                        <asp:Button ID="b2" runat="server" CssClass="button" Text="View Suggested" CommandName="View_Suggested" CommandArgument="<%# Container.DataItemIndex %>" />
                        <asp:Button ID="b3" runat="server" CssClass="button" Text="View free" CommandName ="View_free" CommandArgument="<%# Container.DataItemIndex %>" />
                    </ItemTemplate>
                </asp:TemplateField>
             

            </Columns>
           
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
            
        </asp:GridView>
             </center>
        <div id="divbtn">
         <center><asp:Button ID="Button1" CssClass="button"  runat="server" OnClick="Button1_Click" Text="Back" /></center>
                  
    </div>
      </div>
          
<%--    </form>--%>
</asp:Content>
