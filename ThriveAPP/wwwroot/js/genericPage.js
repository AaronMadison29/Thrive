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

function generateModals() {
	modalContainers.innerHTML =
		"<div class='modal-open'>" +
		"<div class='modal-dialog' role='document'>" +
		"<div class='modal-content'>" +
		"<div class='modal-header'>" +
		"<h5 class='modal-title'>PROFILE</h5>" +
		"<button onclick='closeModal()' type='button' class='close' data-dismiss='modal' aria-label='Close'>" +
		"<span aria-hidden='true'>&times;</span>" +
		"</button>" +
		"</div>" +
		"<div class='modal-body'>" +
		"<h5>GRADES</h5>" +
		"<h3>MATH:    INJECTION</h3>" +
		"<h3>SCIENCE: INJECTION</h3>" +
		"<h3>HISTORY: INJECTION</h3>" +
		"<h5>FAVORITE CLASS</h5>" +
		"<input style='border-radius: 3px;' type='text' placeholder='Favorite Class..'></input>" +
		"<br />" +
		"<br />" +
		"<h5>STUDENT NOTES</h5>" +
		"<textarea rows='4' cols= '50' name='teacherNotes' form='teacherNotesForStudent' placeholder='Notes about student..'></textarea>" +
		"</div>" +
		"<div class='modal-footer'>" +
		"<button type='button' class='btn btn-primary'>Save changes</button>" +
		"<button onclick='closeModal()' type='button' class='btn btn-secondary' data-dismiss='modal'>Close</button>" +
		"</div>" +
		"</div>" +
		"</div>" +
		"</div>";
}

function closeModal() {
	modalContainers.innerHTML = "";
}

function checkSelectedUser(){
	
}