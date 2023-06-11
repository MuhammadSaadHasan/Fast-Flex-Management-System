<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFaculty.aspx.cs" Inherits="AddFaculty" %>

<!DOCTYPE html>
<html>
<head>
  <title>flex Student home</title>
  <style>
    body{
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
}
header{
    height: 30px;
    margin-top: -1%;
}
header h5 {
    text-align: center;
    color: white;
    background-color: black;
    vertical-align: middle;
    font-size: large;
    line-height: 2;
}

header h5 a{
    text-align: center;
    color: white;
    background-color: black;
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
    margin-top: 10px;
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
* {box-sizing: border-box}

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
.main{
    height: 300px;
    margin: 1% 1% 1% 35%;
    font-size: large;
    color:#359ada;
}
.input-field{
    font-size: large;
    height: 40px;
    width: 50%;
    border: none;
    color:#359ada;
    border-bottom: 2px solid #359ada;
    border-radius: 10px;
    outline: none;
}
.input-field2{
  font-size: large;
    height: 40px;
    width: 25%;
    border: none;
    color:#359ada;
    border-bottom: 2px solid #359ada;
    border-radius: 10px;
    outline: none;
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
    label {
      display: block;
      margin-bottom: 5px;
    }
    input[type="text"] {

      font-size: large;
    height: 40px;
    width: 25%;
    border: none;
    color:#359ada;
    border-bottom: 2px solid #359ada;
    border-radius: 10px;
    outline: none;
    }
    input[type="text"]::placeholder {
      color: #aaa;
      font-style: italic;
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

textarea {
  width: 100%;
  height: 150px;
  padding: 12px 20px;
  box-sizing: border-box;
  border: 2px solid #ccc;
  border-radius: 4px;
  background-color: #f8f8f8;
  font-size: 16px;
  resize: none;
}
h3{
  color: #359ada;
}

  </style>
</head>


    <body>
    <form id="form2" runat="server">
        <div>
            <header>
              <h5>  
                <a href="C:\Users\Haris\Desktop\flex_web\html\admin_home.html" >Admin Menu</a>
              </h5>
        </header>
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

         <nav>

    </nav>
        <header>
                <h5>Add Teacher</h5>
        </header>

 



<div class="main">
    <asp:Label ID="LabelUserName" runat="server" Text="Username:" />
    <asp:TextBox ID="TextBoxUserName" runat="server" CssClass="input-field2" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelPassword" runat="server" Text="Password:" />
<asp:TextBox ID="TextBoxPassword" runat="server" CssClass="input-field2" TextMode="Password" />
<br />

  

    <asp:Label ID="LabelTeacherId" runat="server" Text="Teacher ID:" />
    <asp:TextBox ID="TextBoxTeacherId" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelSubject" runat="server" Text="Specialization:" />
    <asp:TextBox ID="TextBoxSubject" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelEmail" runat="server" Text="Email:" />
    <asp:TextBox ID="TextBoxEmail" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelCurrentAddress" runat="server" Text="Current Address:" />
    <asp:TextBox ID="TextBoxCurrentAddress" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelCurrentPhone" runat="server" Text="Current Phone:" />
    <asp:TextBox ID="TextBoxCurrentPhone" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelCurrentPostalCode" runat="server" Text="Current Postal Code:" />
    <asp:TextBox ID="TextBoxCurrentPostalCode" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelCurrentCity" runat="server" Text="Current City:" />
    <asp:TextBox ID="TextBoxCurrentCity" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelCurrentCountry" runat="server" Text="Current Country:" />
    <asp:TextBox ID="TextBoxCurrentCountry" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelPermanentAddress" runat="server" Text="Permanent Address:" />
    <asp:TextBox ID="TextBoxPermanentAddress" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelPermanentPhone" runat="server" Text="Permanent Phone:" />
    <asp:TextBox ID="TextBoxPermanentPhone" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelPermanentPostalCode" runat="server" Text="Permanent Postal Code:" />
    <asp:TextBox ID="TextBoxPermanentPostalCode" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelPermanentCity" runat="server" Text="Permanent City:" />
    <asp:TextBox ID="TextBoxPermanentCity" runat="server" CssClass="input-field" TextMode="SingleLine" />
    <br />

    <asp:Label ID="LabelPermanentCountry" runat="server" Text="Permanent Country:" />
    <asp:TextBox ID="TextBoxPermanentCountry" runat="server" CssClass ="input-field" TextMode="SingleLine" />
    <br />

    <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" CssClass="submit-button" />
</div>









</form>
</body>








</html>
