var element = document.getElementById("viewGalleryButton");
var gallery = document.getElementById("imageContainer");
var componentButtonView = document.getElementById("componentButtons");
var mesContainer = document.getElementById("messageContainer");
var gradeButton = document.getElementById("gradesButton");
var profileButton = document.getElementById("profilesButton");
var gradesContainer = document.getElementById("gradesContainer");

function change(){
	if(element.innerHTML == "Teachers")
	{
		element.innerHTML = "Students";
		gallery.style = "margin-left: 0px;"
		gallery.innerHTML = 
		"<img class='imageInContainer' src='images/StudentHeadshots/exampleStudent.png'>"+
  		"<img class='imageInContainer' src='images/StudentHeadshots/exampleStudentTwo.png'>"+
  		"<img class='imageInContainer' src='images/StudentHeadshots/exampleStudentThree.png'>"+
  		"<img class='imageInContainer' src='images/StudentHeadshots/exampleStudentFour.png'>"+
  		"<img class='imageInContainer' src='images/StudentHeadshots/exampleStudentFive.png'>"+
  		"<img class='imageInContainer' src='images/StudentHeadshots/exampleStudentSix.png'>";
	} 
	else
	{
		element.innerHTML = "Teachers";
		gallery.style = "margin-left: 305px;"
		gallery.innerHTML = 
		"<img class='imageInContainer' src='images/TeacherHeadshots/exampleTeacher.png'>"+
  		"<img class='imageInContainer' src='images/TeacherHeadshots/exampleTeacherTwo.png'>"+
  		"<img class='imageInContainer' src='images/TeacherHeadshots/exampleTeacherThree.png'>";
	} 
}

//function fillTeachers(teachers) {
//	for (index in teachers) {
//		gallery.innerHTML += "<img class='imageInContainer' src='images/TeacherHeadshots/" + "Mike_Terrill" + ".png'>";
//	}
//}
//function fillStudents(students) {
//	for (index in students) {
//		gallery.innerHTML += "<img class='imageInContainer' src='images/StudentHeadshots/" + students[index].Name + ".png'>";
//	}
//}

function gradesModal(){
	gradesContainer.innerHTML = "<h1 style='padding-left: 170px;'>STUDENT NAME HERE<h1>"+
	"<br />"+
	"<br />"+
	"<br />"+
	"<br />"+
	"<br />"+
	"<h2 style='padding-left: 150px;'>MATH: <h2>"+
	"<h2 style='padding-left: 150px;'>HISTORY: <h2>"+
		"<h2 style='padding-left: 150px;'>ENGLISH: <h2>";
	gradesContainer.style.visibility = "visible"
}

function checkSelectedUser(){
	
}