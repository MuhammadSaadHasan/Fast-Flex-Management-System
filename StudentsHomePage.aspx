﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StudentsHomePage.aspx.cs" Inherits="StudentsHomePage" %>

<!DOCTYPE html>

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
                height: 57px;
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
div ul{
    list-style-type: none;
    margin: 0;
    padding: 0% 2% 0% 2%;
    overflow: hidden;
    background-color: black;
}
div li{
    float: right;
}
div li a{
    display: block;
    color: white;
    text-align: center;
    padding: 14px 16px;
    text-decoration: none;
}
div li a:hover{
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

.container {
  width: 100%;
  background-color: #ddd;
}

.course {
  text-align: right;
  padding-top: 10px;
  padding-bottom: 10px;
  color: white;
}

.c1 {width: 90%; background-color: #04AA6D;}
.c2 {width: 80%; background-color: #2196F3;}
.c3 {width: 65%; background-color: #f44336;}
.c4 {width: 60%; background-color: #808080;}
.c5 {width: 60%; background-color: #359ad9;}
.c6 {width: 69%; background-color: #f44350;}
.c7 {width: 78%; background-color: #359ada;}

            .auto-style1 {
                height: 45px;
            }

            .auto-style4 {
                width: 307px;
            }

    </style>


</head>
<body>
        <form id="form1" runat="server">
        <header>
                <h5>Student name:
                  <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
                </h5> 

        </header>

         <nav>
        <ul>

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


<!-- table1-->
<table id="customers">
  <tr>
    <th colspan="2" class="auto-style1">University Information</th>
  </tr>
  <tr>
    <td class="auto-style4"><b>Roll No:</b></td>
    <td>
                  <asp:Label ID="RollNumberLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Degree:</b></td>
    <td>
                  <asp:Label ID="DegreeLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Batch:</b></td>
    <td>
                  <asp:Label ID="BatchLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Section:</b></td>
    <td>
                  <asp:Label ID="SectionLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Campus:</b></td>
    <td>
                  <asp:Label ID="CampusLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Status:</b></td>
    <td>
                  <asp:Label ID="StatusLabel" runat="server"></asp:Label>
                </td>
  </tr>
</table>

<!-- table 2-->
<table id="customers">
  <tr>
    <th colspan="2">Personal Information</th>
  </tr>
  <tr>
    <td class="auto-style4"><b>Name:</b></td>
    <td>
                  <asp:Label ID="NameLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>DOB:</b></td>
    <td>
                  <asp:Label ID="DateOfBirthLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Blood group:</b></td>
    <td>
                  <asp:Label ID="BloodGroupLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Gender:</b></td>
    <td>
                  <asp:Label ID="GenderLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>CNIC:</b></td>
    <td>
                  <asp:Label ID="CNIClabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Nationality:</b></td>
    <td>
                  <asp:Label ID="NationalityLabel" runat="server"></asp:Label>
                </td>
  </tr>
    <tr>
    <td class="auto-style4"><b>Email:</b></td>
    <td>
                  <asp:Label ID="EmailLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
    <td class="auto-style4"><b>Mobile No:</b></td>
    <td>
                  <asp:Label ID="MobileNoLabel" runat="server"></asp:Label>
                </td>
  </tr> 
</table>

<!-- table 3-->
<table id="customers">
  <tr>
    <th colspan="3">Contact Information</th>
  </tr>
  <tr>
        <th></th>
    <th>Permanent</th>
    <th>Current</th>
  </tr>
  <tr>
        <td><b>Adress:</b></td>
    <td>
                  <asp:Label ID="PerAddressLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="CurrAddressLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
        <td><b>Home Phone:</b></td>
    <td>
                  <asp:Label ID="PerHomePhoneLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="CurrHomePhoneLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
        <td><b>Postal Code:</b></td>
    <td>
                  <asp:Label ID="PerPostalCodeLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="CurrPostalCodeLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
        <td><b>City:</b></td>
    <td>
                  <asp:Label ID="PerCityLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="CurrCityLabel" runat="server"></asp:Label>
                </td>
  </tr>
  <tr>
        <td><b>Country:</b></td>
    <td>
                  <asp:Label ID="PerCountryLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="CurrCountryLabel" runat="server"></asp:Label>
                </td>
  </tr>
</table>


<!-- table 4 graph-->
<table id="customers">
    <tr>
    <th colspan="4">Family Information</th>
  </tr>
  <tr>
    <th><b>Relation</b></th>
    <th><b>Name</b></th>
    <th><b>CNIC</b></th>
  </tr>

  <tr>
    <td>Father</td>
    <td>
                  <asp:Label ID="FatherNameLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="FatherCNIClabel" runat="server"></asp:Label>
                </td>
  </tr>

    <tr>
    <td>Mother</td>
    <td>
                  <asp:Label ID="MotherNameLabel" runat="server"></asp:Label>
                </td>
    <td>
                  <asp:Label ID="MotherCNIClabel" runat="server"></asp:Label>
                </td>
  </tr>



<%--*********THE GRAPHS ARE HER--%>

<%--<!-- table 5-->
<table id="customers">
  <tr>
    <th>Attendence</th>
  </tr>
<tr>
<td>
<p><b>Data Base</b></p>
<div class="container">
  <div class="course c1">90%</div>
</div>
</td>
</tr>

<tr>
        <td>
<p><b>Operating system</b></p>
<div class="container">
  <div class="course c2">80%</div>
</div>
</td>
</tr>

<tr>
        <td>
<p><b>Algorithm</b></p>
<div class="container">
  <div class="course c3">65%</div>
</div>
</td>
</tr>

<tr>
        <td>
<p><b>Numerical</b></p>
<div class="container">
  <div class="course c4">60%</div>
</div>
</td>
</tr>

<tr>
        <td>
<p><b>SDA</b></p>
<div class="container">
  <div class="course c5">60%</div>
</div>
</td>
</tr>

<tr>
        <td>
<p><b>OS lab</b></p>
<div class="container">
  <div class="course c6">69%</div>
</div>
</td>
</tr>

<tr>
        <td>
<p><b>OS lab</b></p>
<div class="container">
  <div class="course c7">78%</div>
</div>
</td>
</tr>
</table>
--%>




     </form>

</body>

</html>
