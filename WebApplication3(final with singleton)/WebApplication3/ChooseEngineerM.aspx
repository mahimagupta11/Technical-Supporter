<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="ChooseEngineerM.aspx.cs" Inherits="WebApplication3.WebForm10" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Choose Engineer</title>
       <link href="css/ComplaintsAndEngineer.css" rel="stylesheet" />


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--     <form id="form1" runat="server">--%>
    <div>
        <center>

        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
       

        <br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"  DataKeyNames="emp_id" GridLines="Both" OnRowCommand="OnRowCommand" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CellPadding="4" ForeColor="#333333">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                  <asp:TemplateField HeaderText="Employee ID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_EID" runat="server" Text='<%#Eval("emp_id") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Employee Name">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_SBE" runat="server" Text='<%#Eval("emp_name") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField>

                 <asp:TemplateField HeaderText="Working Department ID">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_SS" runat="server" Text='<%#Eval("working_department") %>'></asp:Label>  
                    </ItemTemplate>  
                 </asp:TemplateField> 
                
                <asp:TemplateField HeaderText="">
                    <ItemTemplate>
                        <asp:Button ID="bSelect" runat="server" CssClass="btn" Text="Choose" CommandName="Select" CommandArgument='<% # Container.DataItemIndex %>' />
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
