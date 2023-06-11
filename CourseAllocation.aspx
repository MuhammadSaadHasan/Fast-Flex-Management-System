<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CourseAllocation.aspx.cs" Inherits="CourseAllocation" %>

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
                    margin-top: 10px;
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


                .dropdown {
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
        <div>
                    <nav>
        <ul>

            <li class="float-left">
                   &nbsp;</li>


            <li>
                <asp:LinkButton ID="SignOutButton1" runat="server" OnClick="SignOut_Click">
                    <asp:Label ID="SignoutLabel" runat="server" Text="SignOut"></asp:Label>
                </asp:LinkButton>
            </li>


             <li>
                <asp:LinkButton ID="CoursesOffered" runat="server" OnClick="CoursesOffered_Click">
                    <asp:Label ID="CoursesOfferedLabel" runat="server" Text="Courses Offered"></asp:Label>
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="SectionButton1" runat="server" OnClick="Section_Click">
                    <asp:Label ID="SectionLabel" runat="server" Text="Section"></asp:Label>
                </asp:LinkButton>
            </li>
             <li class="auto-style1">
                <asp:LinkButton ID="CourseAllocationButton1" runat="server" OnClick="CourseAllocation_Click">
                    <asp:Label ID="CourseAllocationLabel" runat="server" Text="CourseAllocation"></asp:Label>
                </asp:LinkButton>
            </li>
           <li>
                <asp:LinkButton ID="ManageStudentsButton1" runat="server" OnClick="ManageStudents_Click">
                    <asp:Label ID="ManageStudentsLabel" runat="server" Text="ManageStudents"></asp:Label>
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="ManageFacultyButton1" runat="server" OnClick="ManageFaculty_Click">
                    <asp:Label ID="ManageFacultyLabel1" runat="server" Text="ManageFaculty"></asp:Label>
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="AddStudentButton1" runat="server" OnClick="AddStudent_Click">
                    <asp:Label ID="AddStudentLabel" runat="server" Text="AddStudent"></asp:Label>
                </asp:LinkButton>
            </li>
            <li>
                <asp:LinkButton ID="AddFacultyButton1" runat="server" OnClick="AddFaculty_Click">
                    <asp:Label ID="AddFaculty1" runat="server" Text="AddFaculty"></asp:Label>
                </asp:LinkButton>
            </li>
        </ul>
    </nav>






<table id="customers">
    <tr>
        <th colspan="3">Courses and Assigned Teachers</th>
    </tr>
    <tr>
        <th>Course Name</th>
        <th>Assigned Teacher</th>
    </tr>
    <asp:Repeater ID="CourseRepeater" runat="server">
        <ItemTemplate>
            <tr>
                <td><%# Eval("CourseName") %></td>
                <td><%# Eval("AssignedTeacher") %></td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>





















        </div>
    </form>
</body>
</html>
