<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TeachersHomePage.aspx.cs" Inherits="TeachersHomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        body {
            font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
        }

        header {
            height: 30px;
            margin-top: -1%;
        }

        header h5 {
            text-align: center;
            color: white;
            background-color: #359ada;
            vertical-align: middle;
            line-height: 2;
        }

        .active {
            background-color: rgba(129, 124, 124, 0.452);
        }

        nav ul {
            list-style-type: none;
            margin: 0;
            padding: 0% 2% 0% 2%;
            overflow: hidden;
            background-color: black;
        }

        nav li {
            float: right;
        }

        nav li a {
            display: block;
            color: white;
            text-align: center;
            padding: 14px 16px;
            text-decoration: none;
        }

        nav li a:hover {
            background-color: rgba(129, 124, 124, 0.452);
        }

        .float-left {
            float: left;
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

        #customers tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        #customers tr:hover {
            background-color: #ddd;
        }

        #customers th {
            padding-top: 12px;
            padding-bottom: 12px;
            text-align: left;
            background-color: #359ada;
            color: white;
        }

        * {
            box-sizing: border-box
        }

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

        .c1 {
            width: 90%;
            background-color: #04AA6D;
        }

        .c2 {
            width: 80%;
            background-color: #2196F3;
        }

        .c3 {
            width: 65%;
            background-color: #f44336;
        }

        .c4 {
            width: 60%;
            background-color: #808080;
        }

        .c5 {
            width: 60%;
            background-color: #359ad9;
        }

        .c6 {
            width: 69%;
            background-color: #f44350;
        }

        .c7 {
            width: 78%;
            background-color: #359ada;
        }
        .auto-style1 {
            width: 1634px;
            height: 53px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <h5>Teacher name:
                <asp:Label ID="LabelMessage" runat="server" Text=""></asp:Label>
            </h5>
        </header>
        
        <nav>
    <ul class="auto-style1">
        <li class="float-left">
            <asp:LinkButton ID="TeacherProfileButton" runat="server" OnClick="TeacherProfile_Click">
                <asp:Label ID="TeacherProfileLabel" runat="server" Text="Teacher Profile"></asp:Label>
            </asp:LinkButton>
        </li>

        <li>
            <asp:LinkButton ID="SignOutButton" runat="server" OnClick="SignOut_Click">
                <asp:Label ID="SignOutLabel" runat="server" Text="Sign Out"></asp:Label>
            </asp:LinkButton>
        </li>

        <li>
            <asp:LinkButton ID="MarksDistributionButton" runat="server" OnClick="MarksDistribution_Click">
                <asp:Label ID="MarksDistributionLabel" runat="server" Text="Marks Distribution"></asp:Label>
            </asp:LinkButton>
        </li>

        <li>
            <asp:LinkButton ID="AttendanceButton" runat="server" OnClick="Attendance_Click">
                <asp:Label ID="AttendanceLabel" runat="server" Text="Attendance"></asp:Label>
            </asp:LinkButton>
        </li>

        <li>
            <asp:LinkButton ID="UploadMarksButton" runat="server" OnClick="UploadMarks_Click">
                <asp:Label ID="UploadMarksLabel" runat="server" Text="Upload marks"></asp:Label>
            </asp:LinkButton>
        </li>

        <li>
            <asp:LinkButton ID="GenerateGradesButton" runat="server" OnClick="GenerateGrades_Click">
                <asp:Label ID="GenerateGradesLabel" runat="server" Text="Generate Grades"></asp:Label>
            </asp:LinkButton>
        </li>

        <li>
            <asp:LinkButton ID="GenerateReportsButton" runat="server" OnClick="GenerateReports_Click">
                <asp:Label ID="GenerateReportsLabel" runat="server" Text="Generate Reports"></asp:Label>
            </asp:LinkButton>
        </li>

         <li>
            <asp:LinkButton ID="NewUploadButton1" runat="server" OnClick="NewUpload_Click">
                <asp:Label ID="NewUpload" runat="server" Text=" NewUpload"></asp:Label>
            </asp:LinkButton>
        </li>


    </ul>
</nav>



        <table id="customers">
    <tr>
        <th colspan="2">Teachers Information</th>
    </tr>
    <tr>
        <td><b>Teacher ID:</b></td>
        <td><asp:Label ID="TeacherIDLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Name:</b></td>
        <td><asp:Label ID="TeacherNameLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Email:</b></td>
        <td><asp:Label ID="TeacherEmailLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Specialization:</b></td>
        <td><asp:Label ID="SpecializationLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Foreign Key:</b></td>
        <td><asp:Label ID="ForeignKeyLabel" runat="server"></asp:Label></td>
    </tr>
</table>


        <table id="customers">
    <tr>
        <th colspan="2">Personal Information</th>
    </tr>
    <tr>
        <td><b>Name:</b></td>
        <td><asp:Label ID="NameLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Date of Birth:</b></td>
        <td><asp:Label ID="DOBLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Blood Group:</b></td>
        <td><asp:Label ID="BloodGroupLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Gender:</b></td>
        <td><asp:Label ID="GenderLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>CNIC:</b></td>
        <td><asp:Label ID="CNICLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Nationality:</b></td>
        <td><asp:Label ID="NationalityLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Email:</b></td>
        <td><asp:Label ID="EmailLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Mobile:</b></td>
        <td><asp:Label ID="MobileLabel" runat="server"></asp:Label></td>
    </tr>
</table>






        <table id="customers">
    <tr>
        <th colspan="3">Contact Information</th>
    </tr>
    <tr>
        <td><b>Current Address:</b></td>
        <td><asp:Label ID="CurrentAddressLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Current Phone:</b></td>
        <td><asp:Label ID="CurrentPhoneLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Current Postal Code:</b></td>
        <td><asp:Label ID="CurrentPostalCodeLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Current City:</b></td>
        <td><asp:Label ID="CurrentCityLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Current Country:</b></td>
        <td><asp:Label ID="CurrentCountryLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Permanent Address:</b></td>
        <td><asp:Label ID="PermanentAddressLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Permanent Phone:</b></td>
        <td><asp:Label ID="PermanentPhoneLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Permanent Postal Code:</b></td>
        <td><asp:Label ID="PermanentPostalCodeLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Permanent City:</b></td>
        <td><asp:Label ID="PermanentCityLabel" runat="server"></asp:Label></td>
    </tr>
    <tr>
        <td><b>Permanent Country:</b></td>
        <td><asp:Label ID="PermanentCountryLabel" runat="server"></asp:Label></td>
    </tr>
</table>







         <table id="customers">
            <tr>
                <th colspan="2">Family Information</th>
            </tr>
            <tr>
                <td><b>Mother's Name:</b></td>
                <td><asp:Label ID="MotherNameLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td><b>Mother's CNIC:</b></td>
                <td><asp:Label ID="MotherCNICLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td><b>Father's Name:</b></td>
                <td><asp:Label ID="FatherNameLabel" runat="server"></asp:Label></td>
            </tr>
            <tr>
                <td><b>Father's CNIC:</b></td>
                <td><asp:Label ID="FatherCNICLabel" runat="server"></asp:Label></td>
            </tr>
        </table>



        </form>

    </body>

</html>
