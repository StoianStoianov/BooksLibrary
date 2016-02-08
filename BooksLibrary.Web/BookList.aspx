<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="BooksLibrary.Web.BookList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label runat="server">Search by:</asp:Label>
    <asp:DropDownList runat="server" ID="SearchOptions">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Name</asp:ListItem>
        <asp:ListItem>Page count</asp:ListItem>
        <asp:ListItem>Category</asp:ListItem>
    </asp:DropDownList>
    <asp:TextBox runat="server" ID="SearchTextBox"></asp:TextBox>
    <asp:Button runat="server" Width="107px" Text="Search" ID="SearchBtn" OnClick="SearchBtn_Click"/>
    <asp:GridView runat="server" ID="BooksLibrary"
        ItemType="BooksLibrary.Models.Book"
        DataKeyNames="Id" 
        SelectMethod="BooksLibrary_GetData"         
        AllowPaging="true"       
        AutoGenerateColumns="false">
        <Columns>      
            <asp:ImageField DataImageUrlField="Url" HeaderText="Image" ControlStyle-Width="50" ControlStyle-Height="50"/>     
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="PageCount" HeaderText="Page Count" />
            <asp:BoundField DataField="CreationDate" HeaderText="Creation Date" />   
            <asp:BoundField DataField="Genre.GenreName" HeaderText="Genre" />                                    
        </Columns>
    </asp:GridView>
</asp:Content>
