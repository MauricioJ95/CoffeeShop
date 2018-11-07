function isValidEmail(email) {
    return /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email);
}

function doesPasswordsMatch() {
    var password = document.getElementById('password').value;
    var passwordConfirm = document.getElementById('password-confirm').value;

    return password == passwordConfirm;
}

function isValidPhoneNumber(phone) {

    return /^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$/im.test(phone);
}

function onFormSubmit() {
    var emailAddress = document.getElementById('email').value;
    var phone = document.getElementById('phone').value;

    if (!isValidEmail(emailAddress)) {
        alert("You have entered an invalid email address!");
        return false;
    }

    if (!doesPasswordsMatch()) {
        alert('Passwords do not match');
        return false;
    }

    if (!isValidPhoneNumber(phone)) {
        alert('Please enter a valid phone number');
        return false;
    }

    return true;
}