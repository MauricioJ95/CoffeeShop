function isValidEmail(email) {
    if (/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/.test(email)) {
        return (true);
    }
    return (false);
}

function onFormSubmit() {
    var emailAddress = document.getElementById('email').value;

    if (!isValidEmail(emailAddress)) {
        alert("You have entered an invalid email address!");
        return false;
    }

    return true;
}