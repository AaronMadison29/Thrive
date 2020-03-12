var teacherSigninButton = document.getElementById("teacherButton");
var parentSigninButton = document.getElementById("parentButton");
var studentSigninButton = document.getElementById("studentButton");
var registerButton = document.getElementById("registerButton");
var whosSigningIn = "NoOneYet";

teacherSigninButton.onclick = function(){
	whosSigningIn = "teacher";
	var counter = 0; 
	opacity = Number(window.getComputedStyle(teacherSigninButton).getPropertyValue("opacity")); 
	if(opacity>0){
		while(counter < 11){
			opacity = opacity-0.1; 
			teacherSigninButton.style.opacity=opacity; 
			parentSigninButton.style.opacity=opacity; 
			studentSigninButton.style.opacity=opacity; 
			console.log(opacity);
			counter++; 
		}
	}
	teacherSigninButton.src = '';
	parentSigninButton.src = '';
	studentSigninButton.src = '';
	registerButton.src = '';  
	document.body.innerHTML = "<head>"+
  "<link rel='shortcut icon' href='images/favicon.png' />"+
	"<title>Login - Teacher</title>"+
	"<meta charset='utf-8'>"+
	"<link rel='stylesheet' href='css/bootstrap.css'>"+
	"<header>"+
			"<nav class='navbar navbar-expand-lg navbar-light bg-light'>"+
		"<center><a class='center' href='#'><img class='center' style='padding-left: 10px;' src='images/thriveLogo250x100.png'></a></center>"+
  "<div class='collapse navbar-collapse' id='navbarColor03'>"+
  "</div>"+
"</nav>"+
"</header>"+
"</head>"+
"<div>"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
"</div>"+
"<body class='center'>"+
"<center>"+
"<form style='height: 350px; width: 400px;'>"+	
  "<fieldset>"+
    "<img class='topWelcome' src='images/welcomeBackTeacher.png'>"+
    "<div class='form-group'>"+
      "<label for='exampleInputEmail1'><h3>Email address</h3></label>"+
      "<input type='email' class='form-control' id='teacherEmailInput' aria-describedby='emailHelp' placeholder='Enter email'>"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='passwordLabel'><h3>Password</h3></label>"+
      "<input type='password' class='form-control' id='teacherPasswordInput' placeholder='Your Password'>"+
    "</div>"+
    "<button style='border-radius: 15px;' type='submit' class='btn btn-primary'>LOGIN</button>"+
    "</fieldset>"+
  	"</form>"+
  	"<div>"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
  	"</div>"+
  	"<img class='checkPadding' src='images/wrongSelectedUser-Teacher.png'>"+
  	"<img class='homeCircle' onclick='location.reload();' src='images/homeCircle.png'>"+	
"</center>"+
"</body>";
}
parentSigninButton.onclick = function(){
	whosSigningIn = "parent";
	var counter = 0; 
	opacity = Number(window.getComputedStyle(parentSigninButton).getPropertyValue("opacity")); 
	if(opacity>0){
		while(counter < 11){
			opacity = opacity-0.1; 
			teacherSigninButton.style.opacity=opacity; 
			parentSigninButton.style.opacity=opacity; 
			studentSigninButton.style.opacity=opacity; 
			console.log(opacity);
			counter++; 
		}
	}
	teacherSigninButton.src = '';
	parentSigninButton.src = '';
	studentSigninButton.src = '';
	registerButton.src = '';
	document.body.innerHTML = "<head>"+
	"<title>Login - Parent</title>"+
	"<meta charset='utf-8'>"+
	"<link rel='stylesheet' href='css/bootstrap.css'>"+
	"<header>"+
			"<nav class='navbar navbar-expand-lg navbar-light bg-light'>"+
		"<center><a class='center' href='#'><img class='center' style='padding-left: 10px;' src='images/thriveLogo250x100.png'></a></center>"+
  "<div class='collapse navbar-collapse' id='navbarColor03'>"+
  "</div>"+
"</nav>"+
"</header>"+
"</head>"+
"<body class='center'>"+
"<center>"+
"<form style='height: 350px; width: 400px;'>"+	
  "<fieldset>"+
    "<legend><img class='topWelcome' src='images/welcomeBackParent.png'></legend>"+
    "<div class='form-group'>"+
      "<label for='exampleInputEmail1'><h3>Email address</h3></label>"+
      "<input type='email' class='form-control' id='parentEmailInput' aria-describedby='emailHelp' placeholder='Enter email'>"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='passwordLabel'><h3>Password</h3></label>"+
      "<input type='password' class='form-control' id='parentPasswordInput' placeholder='Your Password'>"+
    "</div>"+
    "<button style='border-radius: 15px;' type='submit' class='btn btn-primary'>LOGIN</button>"+
    "</fieldset>"+
  	"</form>"+
  	"<div>"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
  	"</div>"+
  	"<img class='checkPadding' src='images/wrongSelectedUser-Parent.png'>"+
  	"<img class='homeCircle' onclick='location.reload();' src='images/homeCircle.png'>"+	
"</center>"+
"</body>";
}
studentSigninButton.onclick = function(){
	whosSigningIn = "student";
	var counter = 0; 
	opacity = Number(window.getComputedStyle(studentSigninButton).getPropertyValue("opacity")); 
	if(opacity>0){
		while(counter < 11){
			opacity = opacity-0.1; 
			teacherSigninButton.style.opacity=opacity; 
			parentSigninButton.style.opacity=opacity; 
			studentSigninButton.style.opacity=opacity; 
			console.log(opacity);
			counter++; 
		}
	}
	teacherSigninButton.src = '';
	parentSigninButton.src = '';
	studentSigninButton.src = '';
	registerButton.src = '';
	document.body.innerHTML = "<head>"+
  "<link rel='shortcut icon' href='images/favicon.png' />"+
	"<title>Login - Student</title>"+
	"<meta charset='utf-8'>"+
	"<link rel='stylesheet' href='css/bootstrap.css'>"+
	"<header>"+
			"<nav class='navbar navbar-expand-lg navbar-light bg-light'>"+
		"<center><a class='center' href='#'><img class='center' style='padding-left: 10px;' src='images/thriveLogo250x100.png'></a></center>"+
  "<div class='collapse navbar-collapse' id='navbarColor03'>"+
  "</div>"+
"</nav>"+
"</header>"+
"</head>"+
"<body class='center'>"+
"<center>"+
"<form style='height: 350px; width: 400px;'>"+	
  "<fieldset>"+
    "<legend><img class='topWelcome' src='images/welcomeBackStudent.png'></legend>"+
    "<div class='form-group'>"+
      "<label for='exampleInputEmail1'><h3>Email address</h3></label>"+
      "<input type='email' class='form-control' id='studentEmailInput' aria-describedby='emailHelp' placeholder='Enter email'>"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='passwordLabel'><h3>Password</h3></label>"+
      "<input type='password' class='form-control' id='studentPasswordInput' placeholder='Your Password'>"+
    "</div>"+
    "<button style='border-radius: 15px;' type='submit' class='btn btn-primary'>LOGIN</button>"+
    "</fieldset>"+
  	"</form>"+
  	"<div>"+
  	"<br />"+
  	"<br />"+
  	"<br />"+
  	"</div>"+
  	"<img class='checkPadding' src='images/wrongSelectedUser-Student.png'>"+
  	"<img class='homeCircle' onclick='location.reload();' src='images/homeCircle.png'>"+	
"</center>"+
"</body>";
}

function teacherRegistration(){
	document.body.innerHTML = "<link rel='shortcut icon' href='images/favicon.png' />"+
  "<title>Teacher Registration</title>"+
	"<meta charset='utf-8'>"+
	"<link rel='stylesheet' href='css/bootstrap.css'>"+
	"<header>"+
	"<nav class='navbar navbar-expand-lg navbar-light bg-light'>"+
		"<center><a class='center' href='#'><img style='pad' class='center' src='images/thriveLogo250x100.png'></a></center>"+
  "</button>"+
  "<div class='collapse navbar-collapse' id='navbarColor03'>"+
  "</div>"+
"</nav>"+
"</header>"+
"</head>"+
"<body class='fade-in'>"+
"<center>"+
"<form style='height: 350px; width: 400px;'>"+	
  "<fieldset>"+
  "<h3>Welcome to Thrive!</h3>"+
  "<div>"+
  	"<br />"+
  	"<br />"+
  	"</div>"+
    "<div class='form-group'>"+
      "<label for='emailLabel'><h3>Email address</h3></label>"+
      "<input type='email' class='form-control' id='teacherEmailInput' aria-describedby='emailHelp' placeholder='Your Email'>"+
      "<br />"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='teacherPasswordInput'><h3>Password</h3></label>"+
      "<input type='password' class='form-control' id='teacherPasswordInput' placeholder='Password'>"+
    "</div>"+
    "<br />"+
    "<div class='form-group'>"+
      "<label for='teacherRegistrationNumber'><h3>Registration Number</h3></label>"+
      "<input type='number' class='form-control' id='teacherRegistrationNumber' placeholder='Registration Number'>"+
    "</div>"+
    "<br />"+
    "<button style='border-radius: 15px;' type='submit' class='btn btn-primary'>REGISTER</button>"+
    "</form>"+
  "<div style='padding-left: 15px;'>"+
    "<img style='height: 125px; width: 400px;' src='images/wrongSelectedUser-Teacher.png'>"+
    "<img style='height: 220px; width: 225px;' onclick='location.reload();' src='images/homeCircle.png'>"+  
"</div>"+
"</center>"+
"</body>"; 
}

function parentRegistration(){
	document.body.innerHTML = "<link rel='shortcut icon' href='images/favicon.png' />"+
  "<title>Parent Registration</title>"+
  "<meta charset='utf-8'>"+
  "<link rel='stylesheet' href='css/bootstrap.css'>"+
  "<header>"+
  "<nav class='navbar navbar-expand-lg navbar-light bg-light'>"+
    "<center><a class='center' href='#'><img style='pad' class='center' src='images/thriveLogo250x100.png'></a></center>"+
  "</button>"+
  "<div class='collapse navbar-collapse' id='navbarColor03'>"+
  "</div>"+
"</nav>"+
"</header>"+
"</head>"+
"<body class='fade-in'>"+
"<center>"+
"<form style='height: 350px; width: 400px;'>"+  
  "<fieldset>"+
  "<h3>Welcome to Thrive!</h3>"+
  "<div>"+
    "<br />"+
    "<br />"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='emailLabel'><h3>Email address</h3></label>"+
      "<input type='email' class='form-control' id='parentEmailInput' aria-describedby='emailHelp' placeholder='Your Email'>"+
      "<br />"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='parentPasswordInput'><h3>Password</h3></label>"+
      "<input type='password' class='form-control' id='parentPasswordInput' placeholder='Password'>"+
    "</div>"+
    "<br />"+
     "<div class='form-group'>"+
      "<label for='parentRegistrationNumber'><h3>Registration Number</h3></label>"+
      "<input type='number' class='form-control' id='parentRegistrationNumber' placeholder='Registration Number'>"+
    "</div>"+
    "<br />"+
    "<button style='border-radius: 15px;' type='submit' class='btn btn-primary'>REGISTER</button>"+
    "</form>"+
   "<div style='padding-left: 15px;'>"+
    "<img style='height: 125px; width: 400px;' src='images/wrongSelectedUser-Parent.png'>"+
    "<img style='height: 220px; width: 225px;' onclick='location.reload();' src='images/homeCircle.png'>"+  
"</div>"+
"</center>"+
"</body>"; 
}

function studentRegistration(){
	document.body.innerHTML = "<link rel='shortcut icon' href='images/favicon.png' />"+ 
  "<title>Student Registration</title>"+
  "<meta charset='utf-8'>"+
  "<link rel='stylesheet' href='css/bootstrap.css'>"+
  "<header>"+
  "<nav class='navbar navbar-expand-lg navbar-light bg-light'>"+
    "<center><a class='center' href='#'><img style='pad' class='center' src='images/thriveLogo250x100.png'></a></center>"+
  "</button>"+
  "<div class='collapse navbar-collapse' id='navbarColor03'>"+
  "</div>"+
"</nav>"+
"</header>"+
"</head>"+
"<body class='fade-in'>"+
"<center>"+
"<form style='height: 350px; width: 400px;'>"+  
  "<fieldset>"+
  "<h3>Welcome to Thrive!</h3>"+
  "<div>"+
    "<br />"+
    "<br />"+
    "</div>"+
    "<div class='form-group'>"+
      "<label for='emailLabel'><h3>Your Email Address</h3></label>"+
      "<input type='email' class='form-control' id='studentEmailInput' aria-describedby='emailHelp' placeholder='Your Email'>"+
      "<br />"+
    "</div>"+
    "<br />"+
    "<div class='form-group'>"+
      "<label for='exampleInputPassword1'><h3>Password</h3></label>"+
      "<input type='password' class='form-control' id='exampleInputPassword1' placeholder='Password'>"+
    "</div>"+
    "<br />"+
     "<div class='form-group'>"+
      "<label for='studentRegistrationNumber'><h3>Registration Number</h3></label>"+
      "<input type='number' class='form-control' id='studentRegistrationNumber' placeholder='Registration Number'>"+
    "</div>"+
    "<br />"+
    "<button style='border-radius: 15px;' type='submit' class='btn btn-primary'>REGISTER</button>"+
    "</form>"+
   "<div style='padding-left: 15px;'>"+
    "<img style='height: 125px; width: 400px;' src='images/dontRegister.png'>"+
    "<img style='height: 220px; width: 225px;' onclick='location.reload();' src='images/wrongSelectedUser-Student.png'>"+  
"</div>"+
"</center>"+
"</body>"; 
}