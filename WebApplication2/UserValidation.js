function validUserAndPass()
{
    var loginId, password;
    
    loginId = document.getElementById("IdBox").value;
    password = document.getElementById("PassBox").value;
    
    if (loginId == '')
    {
        alert("Please Enter Login Id");
        return false;
    }    
    if (loginId.length > 10 || loginId.length < 6)
    {
        alert("Login ID should be between 6 and 10 characters");
        return false;
    }
    if (password == '')
    {
        alert("Please Enter password");
        return false;
    }
    if (password.length > 15 || password.length < 6)
    {
        alert("Password should be between 6 and 15 characters");
        return false;
    }

    return true;

}

function validate()
{
    var username, password;
    username = document.getElementById("TextBox1").value;
    password = document.getElementById("TextBox2").value;

    if (username == "" || password == "")
    {
        alert("Please enter username/password");
        return false;
    }

    return true;
}


