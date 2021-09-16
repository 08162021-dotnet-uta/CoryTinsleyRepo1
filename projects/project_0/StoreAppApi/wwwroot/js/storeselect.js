var selectedstore = document.getElementsByTagName('label')[0];





function OnSubmitForm() {
    if (document.getElementById('1').checked == true) {
        alert("You have selected the first answer");
    }
    else if (document.getElementById('2').checked == true) {
        alert("You have selected the SECOND answer");
    }
    else if (document.getElementById('3').checked == true) {
        alert("You have selected the THIRD answer");
    }

    fetch(`../stores/GetAllStores`)
    .then(res => res.json())
    .then(res => {
        console.log(res)
    })
    return false;
}