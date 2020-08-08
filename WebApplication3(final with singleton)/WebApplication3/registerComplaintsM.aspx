<%@ Page Title="" Language="C#" MasterPageFile="~/HomePage.Master" AutoEventWireup="true" CodeBehind="registerComplaintsM.aspx.cs" Inherits="WebApplication3.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <title>Complaint Type</title>
        <link href="css/registerComplaint.css" rel="stylesheet" />

    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     


      <div id="divHeader">

    </div>
    <div id="divLeft">
       
    </div>
     <div id="divCenter">
         <div>
           
        </div>
    <center>
<%--    <form id="form1" runat="server">--%>
        
    <div>
    <center>
            Id :
      <asp:Label ID="Label1" runat="server"></asp:Label>
     </center>
         <br />
    </div>
    <div>
        <center>
            Type :
        </center>
        <center>
            <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Text="Select Type" Value=""></asp:ListItem>
                <asp:ListItem>DB</asp:ListItem>
                <asp:ListItem>Hardware</asp:ListItem>
                <asp:ListItem>HR</asp:ListItem>                
                <asp:ListItem>Marketing</asp:ListItem>
                <asp:ListItem>Networking</asp:ListItem>
                <asp:ListItem>Software</asp:ListItem>
               
            </asp:DropDownList>
         </center>
          <br />
    </div>
        <div>
         <center>
            Complaint Body :
             
            <asp:TextBox id="TextBox1" TextMode="MultiLine" Height="100" runat="server"></asp:TextBox>
         </center>
             <br />
        </div>
        <div id="divButton">
         <center>
            <asp:Button ID="ButtonSubmit" CssClass="button" runat="server" Text="Submit" OnClientClick="if (!validate()) { return false;};" OnClick="ButtonSubmit_Click"  UseSubmitBehavior="false" />
              <asp:Label ID="Label3" runat="server"></asp:Label>
         </center>
        </div>      
          <script language="javascript" type="text/javascript" >  
              function validate() {
                  var txtInput = document.getElementById('<%=TextBox1.ClientID%>').value;
                  objDDl = document.getElementById('<%=DropDownList1.ClientID%>');
                  var restrictedWords = new Array("kill", "fight", "slap");
                  var error = 0;
                  if (objDDl.options[objDDl.selectedIndex].value == "") {
                      alert("Please select Type");
                      return false;
                  }
                  else if (txtInput.length == 0) {
                      alert('Compalint body cannot be empty!!');
                      return false;
                  }
                  else if (txtInput.length > 100) {
                      alert('Compalint body too long!!');
                      return false;
                  }
                  else {
                   for (var i = 0; i < restrictedWords.length; i++) {

                       var val = restrictedWords[i];
                       if ((txtInput.toLowerCase()).indexOf(val.toString()) > -1) {
                           error = error + 1;
                       }
                   }
                    if (error > 0) {
                    alert(' You have entered inappropriate words, Try doing some other way!!');
                    return false;
                }
                      else {
                          return true;
                    }
                  }
              }
              
    </script>  
        

   </center>
          <div id="divbtn">
     <center><asp:Button ID="btnBack" CssClass="button" Text="Back" runat="server" OnClick="btnBack_Click" /></center>
      </div>

         








<%--    </form>--%>
   </div>
     <div id="divRight">

    </div>
    <div id="divSubFooter">
        
    </div>
</asp:Content>
