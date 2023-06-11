<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Transcript.aspx.cs" Inherits="Transcript" %>

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
        .heading{
          margin-top: 10px;
          display: flex;
          flex-direction: row;
          justify-content: space-between;
          width:100%;
          font-size: 15px;
          background-color: #359ada;
          color: white;
          padding: 0 14px;
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

         .auto-style1 {
             height: 50px;
         }
         .heading {
             color: blue; 
             font-weight: bold;
         }


  </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <header>
                <h5>Transcript</h5>
        </header>
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
        
                <tr>
                    <td class="heading"><b>Name:</b></td>
                    <td>
                        <asp:Label ID="NameLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="heading"><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Roll no:</b></td>
                    <td>
                        <asp:Label ID="RollNoLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="heading"><b>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Batch:</b></td>
                    <td>
                        <asp:Label ID="BatchLabel" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="heading">&nbsp;<table id="customers">








    <tr>
        <th colspan="4">Summer 2022</th>
        <th>Cr. Att:<span><span></th>
        <th>Cr. Ernd:<span><span></th>
        <th>CGPA:<span><span></th>
        <th>SGPA:<span><span></th>
    </tr>
    <tr>
        <th>Code</th>
        <th>Course Name</th>
        <th>Section</th>
        <th>CrdHrs</th>
        <th>Grade</th>
        <th>Points</th>
        <th>Type</th>
        <th>Remarks</th>
    </tr>
    <asp:Repeater ID="CourseRepeater" runat="server">
        <ItemTemplate>
            <tr>
                <td><b><%# Eval("Code") %></b></td>
                <td><%# Eval("CourseName") %></td>
                <td><%# Eval("Section") %></td>
                <td><%# Eval("CrdHrs") %></td>
                <td><%# Eval("Grade") %></td>
                <td><%# Eval("Points") %></td>
                <td><%# Eval("Type") %></td>
                <td><%# Eval("Remarks") %></td>
            </tr>
        </ItemTemplate>
    </asp:Repeater>
</table>





        </div>
    </form>
</body>
</html>
