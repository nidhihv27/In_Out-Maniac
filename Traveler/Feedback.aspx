    <%@ Page Title="" Language="C#" MasterPageFile="~/Traveler.Master" AutoEventWireup="true" CodeBehind="Feedback.aspx.cs" Inherits="Traveler.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        #textarea1 {
            width: 490px;
            height: 129px;
            margin-left: 112px;
        }
        #Submit1 {
            margin-left: 398px;
        }
    </style>
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <p><center>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<b><i> Please add your comments below</i></b>:&nbsp;
 </center></p>  <center><textarea id="textarea1" runat="server" ></textarea></center>


   <center> </center>
<p id="p1" runat="server" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; <input id="Submit1" type="submit" value="Submit" OnClick="submit.aspx" runat="server" />
</asp:Content>
