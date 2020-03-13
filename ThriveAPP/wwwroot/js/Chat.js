"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub")
    .build();

//Disable send button until connection is established
//document.getElementById("send").disabled = true;
//document.getElementById("sendDirect").disabled = true;
//document.getElementById("sendGroup").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var encodedMsg = user + " says " + message;
    var div = document.createElement("div");

    div.innerHTML = encodedMsg;
    var messageContainer = document.getElementById("messageContainer");
    messageContainer.scrollTop = messageContainer.scrollHeight;
    messageContainer.appendChild(div);
});

connection.on("UpdateStatus", function (boolResult) {
    var text = "offline";
    if (boolResult == true) {
        text = "online";
        $("#MessageStudentBox").show();
    }
    else {
        $("#MessageStudentBox").hide();
    }

    var messageContainer = document.getElementById("onlineStatus");
    messageContainer.innerHTML = text;
});

connection.on("DirectMessage", function (senderName, message) {
    var msg = senderName + ": " + message;

    var div = document.createElement("div");
    div.innerHTML = msg;

    $("#hiddenSender").val(senderName);

    var messageContainer = document.getElementById("messageStudent");
    messageContainer.scrollTop = messageContainer.scrollHeight;
    messageContainer.appendChild(div);
});

connection.on("connected", function (userEmail) {
    $(`#imageContainer > img[id='${userEmail}']`).css("border","solid 2px green");
    var div = document.createElement("div");
});

connection.on("Disconnected", function (userEmail) {
    $(`#imageContainer > img[id='${userEmail}']`).css('border', 'none');
    var div = document.createElement("div");
});

connection.start().then(function () {
    //document.getElementById("send").disabled = false;
    //document.getElementById("sendDirect").disabled = false;
    //document.getElementById("sendGroup").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.addEventListener("getStatus", function (event) {

    connection.invoke("IsUserLoggedIn", event.userName)
        .catch(function (err) {
            return console.error(err.toString());
        });
    //event.preventDefault();
});

document.addEventListener("sendDirect", function (event) {

    connection.invoke("MessageUser", event.userName, event.message)
        .catch(function (err) {
            return console.error(err.toString());
        });
    //event.preventDefault();
});

document.addEventListener("sendGlobal", function (event) {
    var user = document.getElementById("user").value;
    var message = document.getElementById("messageInputBox").value;
    connection.invoke("SendMessage", user, message).catch(function (err) {
        return console.error(err.toString());
    });
    event.preventDefault();
});


//document.getElementById("sendDirect").addEventListener("click", function (event) {
//    var sendTo = document.getElementById("dmTarget").value;
//    var message = document.getElementById("dmMessage").value;
//    connection.invoke("MessageUser", sendTo, message).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});

//document.getElementById("sendGroup").addEventListener("click", function (event) {
//    var message = document.getElementById("groupMessage").value;
//    var group;
//    connection.invoke("MessageGroup", message, group).catch(function (err) {
//        return console.error(err.toString());
//    });
//    event.preventDefault();
//});