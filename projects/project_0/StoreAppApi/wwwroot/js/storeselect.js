var selectedstore = document.getElementsByTagName('label')[0];





function OnSubmitForm() {
    if (document.getElementById('store1').checked == true) {
        alert("You have selected the first answer");
    }
    else if (document.getElementById('store2').checked == true) {
        alert("You have selected the SECOND answer");
    }
    else if (document.getElementById('store3').checked == true) {
        alert("You have selected the THIRD answer");
    }

    return false;
}