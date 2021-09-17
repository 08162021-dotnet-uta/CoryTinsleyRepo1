var selectedstore = document.getElementsByTagName('label')[0];





function OnSubmitForm() {
    if (document.getElementById('1').checked == true) {
        LoadCSProducts(1);
    }
    else if (document.getElementById('2').checked == true) {
        LoadPSProducts(2);
    }
    else if (document.getElementById('3').checked == true) {
        LoadMSProducts(3);
    }

    fetch(`../stores/GetAllStores`)
    .then(res => res.json())
    .then(res => {
        console.log(res)
    })
    return false;
}



function LoadCSProducts(i) {
    fetch(`../api/Products/SelectProductByStoreIDAsync`)
        .then(res => res.json())
        .then(res => {
            console.log(res)
        })
}

function LoadPSProducts(i) {

}

function LoadMSProducts(i) {

}