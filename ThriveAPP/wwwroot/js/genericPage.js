var element = document.getElementById("viewGalleryButton");
var gallery = document.getElementById("imageContainer");
var componentButtonView = document.getElementById("componentButtons");
var mesContainer = document.getElementById("messageContainer");
var gradeButton = document.getElementById("gradesButton");
var profileButton = document.getElementById("profilesButton");
var gradesContainer = document.getElementById("gradesContainer");
var gradeModal = document.getElementById("gradeModal");

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

function generateModal() {
	gradeModal.style.visibility = "visible";
}

function closeModal() {
	gradeModal.style.visibility = "invisible";
}