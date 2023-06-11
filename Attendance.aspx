<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Attendance.aspx.cs" Inherits="Attendance" %>

<!DOCTYPE html>
<html>
<head>
<script type="text/javascript" src="https://www.gstatic.com/charts/loader.js"></script>
	<title>Student Attendance</title>
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
            background-color: #359ada;
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
        div ul{
            list-style-type: none;
            margin-top: 5px;
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
        .active{
            background-color: rgba(129, 124, 124, 0.452);
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
            height: 53px;
        }
        .auto-style2 {
            height: 51px;
        }
	</style>
</head>

<body>
   <form id="form1" runat="server">
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
        </ul>
     </nav>

    <div>
        <ul class="auto-style2">
              <li class="float-left"> <a href="C:\Users\Haris\Desktop\flex_web\html\marks.html">
                <asp:Label ID="CourseNameLabel" runat="server" Text=""></asp:Label>
                </a>&nbsp;</li> 

            <li>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="Course1_Click">
                    <asp:Label ID="Course1Label" runat="server" Text=""></asp:Label>
                </asp:LinkButton>
            </li>

            <li>
                <asp:LinkButton ID="LinkButton2" runat="server" OnClick="Course2_Click">
                    <asp:Label ID="Course2Label" runat="server" Text=""></asp:Label>
                </asp:LinkButton>
            </li>

            <li>
                <asp:LinkButton ID="LinkButton3" runat="server" OnClick="Course3_Click">
                    <asp:Label ID="Course3Label" runat="server" Text=""></asp:Label>
                </asp:LinkButton>
            </li>

             <li>
                <asp:LinkButton ID="LinkButton4" runat="server" OnClick="Course4_Click">
                    <asp:Label ID="Course4Label" runat="server" Text=""></asp:Label>
                </asp:LinkButton>
            </li>

            <li>
                <asp:LinkButton ID="LinkButton5" runat="server" OnClick="Course5_Click">
                    <asp:Label ID="Course5Label" runat="server" Text=""></asp:Label>
                </asp:LinkButton>
            </li>

            <li>
                <asp:LinkButton ID="LinkButton6" runat="server" OnClick="Course6_Click">
                    <asp:Label ID="Course6Label" runat="server" Text=""></asp:Label>
                </asp:LinkButton>
            </li>



        </ul>
     </div>


    <table id="customers">
      <tr>
        <th>Attendance percentage
      </tr>
    <div id="attendance_chart" style="width: 900px; height: 500px;"></div>
    <script type="text/javascript">
        google.charts.load('current', { 'packages': ['corechart'] });
        google.charts.setOnLoadCallback(drawChart);

        function drawChart() {

            var p = <%= PresentNo %>;
            var a = <%= AbsentNo %>;
            var t = <%= TotalClasses %>;

            var data = google.visualization.arrayToDataTable([
                ['Status', 'Percentage'],
                ['Present', (p / t)],
                ['Absent', 1-(p/t)],
            ]);

            var options = {
                title: 'Attendance',
                vAxis: { format: 'percent' }
            };
            var chart = new google.visualization.ColumnChart(document.getElementById('attendance_chart'));

            chart.draw(data, options);
        }
    </script>




     <table id="customers">
      <tr>
        <th>Date</th>
        <th>Duration(Hours)</th>
        <th>Presence status</th>
      </tr>
      <asp:Repeater ID="AttendanceRepeater" runat="server">
        <ItemTemplate> 
          <tr>
            <td><%# Eval("Date") %></td>
            <td><%# Eval("Duration") %></td>
            <td><b><%# Eval("Presence") %></b></td>
          </tr>
        </ItemTemplate>
      </asp:Repeater>
    </table>







</form>
</body>
</html>

