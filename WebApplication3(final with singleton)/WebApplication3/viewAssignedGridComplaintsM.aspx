<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="viewAssignedGridComplaintsM.aspx.cs" Inherits="WebApplication3.WebForm13" %>
<%--@ OutputCache Duration="30" VaryByParam="id"--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Assigned Complaints</title>
        <link href="css/viewAssignedGridComplaintsM.css" rel="stylesheet" />

     
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--     <form id="form1" runat="server">--%>
        <div>      

            <center>
         <%--  <asp:Label id="Label1" runat="server"></asp:Label>
           <asp:Label ID="l1" runat="server"></asp:Label>
         --%>
               
              

       <center>
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowEditing="GridView1_RowEditing" OnRowUpdating ="GridView1_RowUpdating" CellPadding="4" ForeColor="#333333" GridLines="Both" >
           
            <AlternatingRowStyle BackColor="White" />
           
            <Columns>  
                <asp:TemplateField HeaderText ="Controls">  
                    <ItemTemplate>  
                       <asp:Button Text="Edit" CssClass="btn" ID="editButton" runat="server" CommandName="Edit" />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:Button Text="Update" CssClass="bn" ID="updateButton" runat="server" CommandName="Update" />
                        <asp:Button Text="Cancel" CssClass="bn" ID="cancelButton" runat="server" CommandName="Cancel" />
                    </EditItemTemplate>  
                </asp:TemplateField>  

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
                 
                <asp:TemplateField HeaderText="Solution Suggested">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_SS" runat="server" Text='<%#Eval("solution_suggested") %>'></asp:Label>  
                    </ItemTemplate>  
                    <EditItemTemplate>  
                        <asp:TextBox ID="txt_SS" runat="server" Text='<%#Eval("solution_suggested") %>'></asp:TextBox>  
                    </EditItemTemplate> 
                 </asp:TemplateField> 

                    <asp:TemplateField HeaderText="Complaint Status">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_CS" runat="server" Text='<%#Eval("complaint_status") %>'></asp:Label>  
                    </ItemTemplate>  
                     <EditItemTemplate>
                        <asp:DropDownList ID="ddl_Status" runat="server">
                           
                            <asp:ListItem Text="Inprogress" Value="Inprogress"></asp:ListItem>
                            <asp:ListItem Text="Resolved" Value="Resolved"></asp:ListItem>
                            
                         </asp:DropDownList>
                    </EditItemTemplate>
  
                    </asp:TemplateField>

                        <asp:TemplateField HeaderText="Complaint Type">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_CT" runat="server" Text='<%#Eval("Complaint_Type") %>'></asp:Label>  
                    </ItemTemplate>  
                     
                </asp:TemplateField>  

                  <asp:TemplateField HeaderText="Resolved Date">  
                    <ItemTemplate>  
                        <asp:Label ID="lbl_Rdate" runat="server" Text='<%#Eval("date_of_resolution") %>'></asp:Label>  
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
      <center><asp:Button ID="btnBack" CssClass="button" Text="Back" runat="server" OnClick="btnBack_Click" /></center>
      </div>
     
<%--</form> --%>

</asp:Content>
