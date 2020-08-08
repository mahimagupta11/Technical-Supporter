<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="adminViewClosedComplaintsM.aspx.cs" Inherits="WebApplication3.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<title>View Closed Complaints</title>
        <link href="css/ComplaintsAndEngineer.css" rel="stylesheet" />

    
    </asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--     <form id="form1" runat="server">--%>
    <div>
        <center>

        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
       

        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  DataKeyNames="complaint_Id" GridLines="Both" OnRowCommand="OnRowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333">
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
                
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="bSelect" runat="server" CssClass="btn" Text="Delete" CommandName="Select" CommandArgument='<% # Container.DataItemIndex %>' />
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
       

        
        <asp:Button ID="Button1" runat="server" CssClass="button" Text="Back" OnClick="Button1_Click" />
            </center>
    </div>
<%--    </form>--%>
    </asp:Content>

