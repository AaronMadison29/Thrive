"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub")
    .withAutomaticReconnect()
    .build();

//Disable send button until connection is established
document.getElementById("send").disabled = true;
//document.getElementById("sendDirect").disabled = true;
//document.getElementById("sendGroup").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var div = document.createElement("div");
    div.innerHTML = encodedMsg;
    var messageContainer = document.getElementById("messageContainer");
    messageContainer.scrollTop = messageContainer.scrollHeight;
    messageContainer.appendChild(div);
});

//connection.on("DirectMessage", function (senderName, message) {
//    var msg = senderName + ": " + message;

//    var li = document.createElement("li");
//    li.textContent = msg;

//    document.getElementById("dms").appendChild(li);
//});

//connection.on("Connected", function (userName) {

//    var message = `User ${userName} has connected!`;

//    var li = document.createElement("li");
//    li.textContent = message;

//    document.getElementById("users").appendChild(li);
    
//});

//connection.on("Disconnected", function (userName) {

//    var message = `User ${userName} has Left!`;

//    var li = document.createElement("li");
//    li.textContent = message;

//    document.getElementById("users").appendChild(li);

//});

connection.start().then(function () {
    document.getElementById("send").disabled = false;
    //document.getElementById("sendDirect").disabled = false;
    //document.getElementById("sendGroup").disabled = false;
}).catch(function (err) {
    return console.error(err.toString());
});

document.getElementById("send").addEventListener("click", function (event) {
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