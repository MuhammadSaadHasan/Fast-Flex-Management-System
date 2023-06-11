<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AttendenceMarking.aspx.cs" Inherits="AttendenceMarking" %>

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

        .auto-style2 {
            height: 50px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
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

            

           
        </ul>
        </div>



            

     





        


        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>



            
        <asp:TextBox ID="dateTextBox" runat="server" TextMode="Date"></asp:TextBox>
<asp:Button ID="submitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
<asp:Label ID="outputLabel" runat="server"></asp:Label>

     

        <br />

<asp:TextBox ID="TextBox1" runat="server" TextMode="Date"></asp:TextBox>
<asp:Button ID="Button1" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
<asp:Label ID="Label1" runat="server"></asp:Label>

<asp:Repeater ID="studentRepeater" runat="server">
    <ItemTemplate>
        <asp:Label ID="studentNameLabel" runat="server" Text='<%# Eval("Name") %>' />
        <asp:CheckBox ID="studentCheckBox" runat="server" />
    </ItemTemplate>
</asp:Repeater>


        


    </form>
</body>
</html>


