<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourseRegistration.aspx.cs" Inherits="CourseRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
     <style>
    body{
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}
header{
    height: 30px;
    margin-top: -1%;
}
header h5{
    text-align: center;
    color: white;
    background-color: #359ada;
    vertical-align: middle;
    font-size: large;
    line-height: 2;
}
.active{
    background-color: rgba(129, 124, 124, 0.452);
}
nav ul{
    list-style-type: none;
    margin: 0;
    padding: 0% 2% 0% 2%;
    overflow: hidden;
    background-color: black;
}
nav li{
    float: right;
}
nav li a{
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}
nav li a:hover{
    background-color: rgba(129, 124, 124, 0.452);
}
.float-left{
    float:left;
}
#customers {
  font-family: Arial, Helvetica, sans-serif;
  margin-top: 25px;
  border-collapse: collapse;
  width: 100%;
}
#customers td, #customers th {
  border: 1px solid #ddd;

  padding: 8px;
}

#customers tr:nth-child(even){
    background-color: #f2f2f2;
}

#customers tr:hover {background-color: #ddd;}

#customers th {
  padding-top: 12px;
  padding-bottom: 12px;
  text-align: left;
  background-color: #359ada;
  color: white;
}

* {box-sizing: border-box}


select .dropdown {
   color: #359ada;
}
.dropbtn {
    width: 20%;
    padding: 0.5%;
    border-radius: 15px;
    transition: ease 1s;
   color: #359ada;
   border: solid 2px #359ada;
   transition: ease 1s;
    font-size: small;
}
.dropdown:hover .dropbtn { 
    background-color: #359ada;
    color: white;
    z-index: 100;
}
.dropdown-content {
  display: none;
  box-shadow: 0px 8px 16px 0px rgba(0,0,0,0.2);
  z-index: 1;
}

.dropdown-content a {
  color: #359ada;
  padding: 5px;
  text-decoration: none;
  display: block;
  font-size: small;
}

.dropdown-content a:hover {
    border: solid 2px #359ada;
    background-color: white;
    color: #359ada;
    z-index: 100;
}
.login{
  margin-top: 15px;
    padding: 0.5%;
    width: 20%;
    border-radius: 15px;
    color: #359ada;
    border: solid 2px #359ada;
    transition: ease 1s;
    font-size: large;
}
.login:hover{
    background-color: #359ada;
    color: white;
    z-index: 100;
}
.dropdown:hover .dropdown-content {display: block;}

  </style>
</head>
<body>
    <form id="form1" runat="server">
         <!-- Navigation bar-->
        <nav>
                 <ul class="auto-style1">
                    <li class="float-left">
                           <a href="StudentsHomePage.aspx">Student Profile</a>
                    </li>

                    <li>
                        <asp:LinkButton ID="SignOutButton1" runat="server" OnClick="SignOut_Click">
                            <asp:Label ID="SignoutLabel" runat="server" Text="SignOut"></asp:Label>
                        </asp:LinkButton>
                    </li>

                    <li>
                        <asp:LinkButton ID="CouseRegistrationButton1" runat="server" OnClick="CourseRegistration_Click">
                            <asp:Label ID="CourseRegistrationLabel" runat="server" Text="Course Registration"></asp:Label>
                        </asp:LinkButton>
                    </li>

                    <li>
                        <asp:LinkButton ID="AttendanceButton1" runat="server" OnClick="Attendance_Click">
                            <asp:Label ID="AttendanceLabel" runat="server" Text="Attendance"></asp:Label>
                        </asp:LinkButton>
                    </li>

                    <li>
                        <asp:LinkButton ID="MarksButton1" runat="server" OnClick="Marks_Click">
                            <asp:Label ID="MarksLabel" runat="server" Text="Marks"></asp:Label>
                        </asp:LinkButton>
                    </li>

                    <li>
                        <asp:LinkButton ID="TranscriptButton1" runat="server" OnClick="Transcript_Click">
                            <asp:Label ID="TranscriptLabel" runat="server" Text="Transcript"></asp:Label>
                        </asp:LinkButton>
                    </li>

                                 <li>
                <asp:LinkButton ID="FeedBackButton1" runat="server" OnClick="FeedBack_Click">
                    <asp:Label ID="FeedBackLabel" runat="server" Text="FeedBack"></asp:Label>
                </asp:LinkButton>
            </li>
                </ul>
        </nav>
        <header>
                <h5>Course Registration</h5>
        </header>
   

   
<table id="customers">
    <tr>
        <th colspan="6">Courses</th>
    </tr>
    <tr>
        <th>CourseID</th>
        <th>Name</th>
        <th>CreditHours</th>
        <th>Type</th>
        <th>Status</th>
        <th>CheckBox</th>
        <th>DropDown</th>
    </tr>
    <asp:Repeater ID="CoursesRepeater" runat="server" OnItemDataBound="CoursesRepeater_ItemDataBound">
        <ItemTemplate>
            <tr>
                <td><%# Eval("CourseID") %></td>
                <td><%# Eval("Name") %></td>
                <td><%# Eval("CreditHours") %></td>
                <td><%# Eval("TypeOfUser") %></td>
                <td><%# Eval("Status") %></td>
                <td><asp:CheckBox ID="Select" runat="server" /></td>
                <td>
                    <asp:DropDownList ID="Section" runat="server">
                        <asp:ListItem Value="A">A</asp:ListItem>
                        <asp:ListItem Value="B">B</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>

        <br />
        <asp:Button ID="Submit" runat="server" Text="Submit" CssClass="login" OnClick="Submit_Click" />











    </form>
</body>
</html>
