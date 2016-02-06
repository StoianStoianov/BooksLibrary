<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="BooksLibrary.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <asp:FileUpload ID="FileUpload" runat="server" Width="290px" />
<asp:RegularExpressionValidator ID="regexValidator" runat="server"
     ControlToValidate="FileUpload"
     ErrorMessage="Only JPEG images are allowed" 
     ValidationExpression="(.*\.([Jj][Pp][Gg])|.*\.([Jj][Pp][Ee][Gg])$)">
</asp:RegularExpressionValidator>   
    <br />
    <asp:Label ID="TitleLabel" runat="server" Text="Title:"></asp:Label>
    <asp:TextBox ID="TitleTextBox" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="GenreLabel" runat="server" Text="Genre:"></asp:Label>
    <asp:DropDownList ID="GenreDownList" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                  <asp:ListItem Selected="True" Value="Comedy"> Comedy </asp:ListItem>
                  <asp:ListItem Value="Horror"> Horror </asp:ListItem>
                  <asp:ListItem Value="Biography"> Biography </asp:ListItem>
    </asp:DropDownList>
    <br />
    <br />
    <asp:Label ID="PageCountLabel" runat="server" Text="Page count:"></asp:Label>
    <asp:TextBox ID="PageCountTextBox" runat="server" Width="24px"></asp:TextBox>
    <br />
    <br />
     <asp:TextBox ID="ErrorTextBox" runat="server" Visible="False" Width="266px"></asp:TextBox>
   <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Button1_Click" Width="110px"/>       
   

</asp:Content>
