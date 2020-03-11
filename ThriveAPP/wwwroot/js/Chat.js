"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

//Disable send button until connection is established
document.getElementById("send").disabled = true;

connection.on("ReceiveMessage", function (user, message) {
    var msg = message.replace(/&/g, "&amp;").replace(/</g, "&lt;").replace(/>/g, "&gt;");
    var encodedMsg = user + " says " + msg;
    var div = document.createElement("div");
    div.innerHTML = encodedMsg;
    var messageContainer = document.getElementById("messageContainer");
    messageContainer.scrollTop = messageContainer.scrollHeight;
    messageContainer.appendChild(div);
});

connection.start().then(function () {
    document.getElementById("send").disabled = false;
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