function validateEmail() {
    "use strict";
    var regex, email, validationResult;
    regex = /^([0-9a-zA-Z]([\-_\\.]*[0-9a-zA-Z]+)*)@([0-9a-zA-Z]([\-_\\.]*[0-9a-zA-Z]+)*)[\\.]([a-zA-Z]{2,9})$/;
    email = document.getElementById('email-field').value;
    validationResult = document.getElementById('validation-result');

    validationResult.innerText = email;

    if (regex.test(email)) {
        validationResult.style.backgroundColor = '#90ee90';
    } else {
        validationResult.style.backgroundColor = '#ff0000';
    }
}

var validateButton = document.getElementById('validate-button');
validateButton.addEventListener('click', validateEmail, false);