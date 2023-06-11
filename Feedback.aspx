<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Feedback" %>

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

     .auto-style1 {
         height: 49px;
     }
     .auto-style2 {
         height: 57px;
     }

  </style>
</head>
<body>
    <form id="form1" runat="server">
         <!-- Navigation bar-->
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
                </ul>
        </nav>
        

        <div>
        <ul class="auto-style2">
            <li class="float-left"> <a href="C:\Users\Haris\Desktop\flex_web\html\marks.html">
                <b>Feedback-</b> <span>DB lab</span></a> </li>    
            <li> <a href="C:\Users\Haris\Desktop\flex_web\html\course7_marks.html">CS100</a> </li>
            <li > <a href="C:\Users\Haris\Desktop\flex_web\html\course6_marks.html">MG200</a> </li>
            <li> <a href="C:\Users\Haris\Desktop\flex_web\html\course5_marks.html">ENG11</a> </li>
            <li> <a href="C:\Users\Haris\Desktop\flex_web\html\course4_marks.html">ISL12</a> </li>
            <li> <a href="C:\Users\Haris\Desktop\flex_web\html\course3_marks.html">CS123</a> </li>
            <li> <a href="C:\Users\Haris\Desktop\flex_web\html\course2_marks.html">CD127</a> </li>
            <li> <a href="C:\Users\Haris\Desktop\flex_web\html\marks.html" class="active">DS200</a> </li>  
        </ul>
        <form>
       <div class = "main">
        <label for="date"><b>Date</b></label>
        <input type="date" class="input-field"> <br>
        <label for="full-name"><b>Teacher's Name:</b></label>
        <input type="text" id="first-name" name="first-name" placeholder="First name" class="input-field2">
        <input type="text" id="last-name" name="last-name" placeholder="Last name" class="input-field2">

        <label for="full-name"><b>Subject</b></label>
        <input type="subject" class="input-field">


        <label for="full-name"><b>Schedule</b></label>
        <input type="Schedule" class="input-field">


        <label for="full-name"><b>Room Number</b></label>
        <input type="Number" class="input-field">


        <label for="full-name"><b>School year</b></label>
        <input type="year" class="input-field">

        <p>After filling the form please press the submit button.</p>
           <ol>
            <li class="float-left">Poor</li><br>
            <li class="float-left">Below Average</li><br>
            <li class="float-left">Average</li><br>
            <li class="float-left">Good</li><br>
            <li class="float-left">Excellent</li>       
        </ol>
    </div>
<div><br></div>
<table id="customers">
  <tr>
  <th colspan="6">Appearance and Personal Presentation</th>
  </tr>
  <tr>
        <th></th>
    <th>1</th>
    <th>2</th>
    <th>3</th>
    <th>4</th>
    <th>5</th>
  </tr>
  <tr>
        <td>Teacher attends class in a well presentable manner</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher shows enthusiasm when teaching in class</td>
             <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher shows initiative and flexibility in teaching</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>  </tr>
  <tr>
        <td>Teacher is well articulated and shows full knowledge of the subject in teaching</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher speaks loud and clear enough to be heard by the whole class</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
</table>


<table id="customers">
  <tr>
    <th colspan="6">Professional Practices</th>
  </tr>
  <tr>
        <th></th>
    <th>1</th>
    <th>2</th>
    <th>3</th>
    <th>4</th>
    <th>5</th>
  </tr>
  <tr>
        <td>Teacher shows professionalism in class</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher shows commitment to teaching the class</td>
             <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher encourages students to engage in class discussions and ask questions</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>  </tr>
  <tr>
        <td>Teacher handles criticisms and suggestions professionally</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher comes to class on time</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
<tr>
        <td>Teacher ends class on time</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
</table>

<table id="customers">
  <tr>
  <th colspan="6">Teaching Methods</th>
  </tr>
  <tr>
        <th></th>
    <th>1</th>
    <th>2</th>
    <th>3</th>
    <th>4</th>
    <th>5</th>
  </tr>
  <tr>
        <td>Teacher shows well rounded knowledge over the subject matter</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher has organized the lesson conducive for easy understanding of students</td>
             <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher shows dynamism and enthusiasm</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>  </tr>
  <tr>
        <td>Teacher stimulates the critical thinking of students</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher handles the class environment conducive for learning</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
</table>



<table id="customers">
  <tr>
  <th colspan="6">Disposition Towards Students</th>
  </tr>
  <tr>
        <th></th>
    <th>1</th>
    <th>2</th>
    <th>3</th>
    <th>4</th>
    <th>5</th>
  </tr>
  <tr>
        <td>Teacher believes that students can learn from the class</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher shows equal respect to various cultural backgrounds, individuals, religion, and race</td>
             <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
  <tr>
        <td>Teacher finds the students strengths as basis for growth and weaknesses for opportunities for improvement</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>  </tr>
  <tr>
        <td>Teacher understands the weakness of a student and helps in the student's improvemen</td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
            <td><label><input type="radio" name="question0" value="A" ></label></td>
  </tr>
</table>
<h3>Comments</h3>
<textarea></textarea>

        <a href=""><button class="login">Submit</button></a>

    </form>
</body>
</html>

    </form>
</body>
</html>
