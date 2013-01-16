<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="ProyectoSaaSCRM._Default" %>
      
<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
  <script type="text/javascript">
      $(document).ready(function () {
          $('#<%= txtStartDate.ClientID %>').datepicker({ dateFormat: 'dd/mm/yy' });
          $('#<%= txtDueDate.ClientID %>').datepicker({ dateFormat: 'dd/mm/yy' });
          $('#<%= txtCompletionDate.ClientID %>').datepicker({ dateFormat: 'dd/mm/yy' });
      });

      function validate() {

          if (document.getElementById("<%=txtName.ClientID%>").value == "") {
              alert("Name Field can not be blank");
              document.getElementById("<%=txtName.ClientID%>").focus();
              return false;
          }
          if (document.getElementById("<%=txtStartDate.ClientID%>").value == "") {
              alert("Start Date can not be blank");
              document.getElementById("<%=txtStartDate.ClientID%>").focus();
              return false;
          }
          if (document.getElementById("<%=txtDueDate.ClientID%>").value == "") {
              alert("Due Date can not be blank");
              document.getElementById("<%=txtDueDate.ClientID%>").focus();
              return false;
          }

          return true;
      }
  </script>
</asp:Content>
    <asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
        <h2>
             Tasks I have due for today:
        </h2>
        <asp:GridView ID="TasksForTodayGridView" runat="server" Width="270px">
        </asp:GridView>

        <h2>
             Unfinished Tasks:
        </h2>
        <asp:GridView ID="UnfinishedTasksGridView" runat="server" Width="270px">
        </asp:GridView>

        <h2>
             Add a new Task:
        </h2><br />
        <asp:Label ID="Label1"  runat="server" Text="Name:"></asp:Label>
        <asp:TextBox ID="txtName" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
        <asp:Label ID="Label2" runat="server"  Text="Start Date:"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
            <asp:Label ID="Label3" runat="server"  Text="Due Date:"></asp:Label>
        <asp:TextBox ID="txtDueDate" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
            <asp:Label ID="Label4" runat="server"  Text="Completion Date:"></asp:Label>
        <asp:TextBox ID="txtCompletionDate" runat="server" ClientIDMode="Static"></asp:TextBox><br /><br />
         <asp:Label ID="Label5" runat="server"  Text="Comments:"></asp:Label>
        <br />
        <asp:TextBox ID="txtAreaComments" TextMode="MultiLine" runat="server" ClientIDMode="Static" Rows="10" Columns="15" CssClass="textArea"></asp:TextBox><br /><br />
        <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" OnClientClick="return validate();" />
    </asp:Content>