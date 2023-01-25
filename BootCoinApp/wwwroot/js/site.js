// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
var addCoinButton = document.getElementById("add-coin-button");
var addRewardButton = document.getElementById("add-reward-button");
var logoutButton = document.getElementById("logout-button");
var addCoinText = document.getElementById("add-coin-text");
var addRewardText = document.getElementById("add-reward-text");
var logoutText = document.getElementById("logout-text");
var addCoinImage = document.getElementById("add-coin-img");
var addRewardImage = document.getElementById("add-reward-img");
var multiple = document.getElementById("multiple");

var colCoinPeople = document.getElementsByClassName("col-coin-card-people");

var path = window.location.pathname;
var page = path.split("/").pop();

var hoverMenu = 1;
var currMenu = 2;

var multipleSelected = false;
const peopleSelected = [];
const elementSelected = [];

if (page == "AddCoin") {
    currMenu = 1;
    changeToDefault(addRewardButton);
} else {
    currMenu = 2;
    changeToDefault(addCoinButton);
}

function changeAttribute(choosed, notChoosed, cText, ncText) {
    choosed.style.backgroundColor = "#FCCF00";
    cText.style.color = "black";
    cText.style.fontWeight = "bold";
    notChoosed.style.backgroundColor = "transparent";
    ncText.style.color = "white";
    ncText.style.fontWeight = "400";
}

function changeToDefault(unHovered) {
    let currObjectMenu = ((currMenu == 1) ? addCoinButton : addRewardButton);
    if (unHovered != currObjectMenu) {
        if (currMenu == 1) { //addCoin 
            changeAttribute(addCoinButton, addRewardButton, addCoinText, addRewardText);
            addCoinImage.src = "../assets/add-coin-black.png";
            addRewardImage.src = "../assets/add-reward-white.png";
            hoverMenu = 1;
        } else { //addReward Menu
            changeAttribute(addRewardButton, addCoinButton, addRewardText, addCoinText);
            addCoinImage.src = "../assets/add-coin-white.png";
            addRewardImage.src = "../assets/add-reward-black.png";
            hoverMenu = 2;
        }
    }
}

addCoinButton.addEventListener("mouseover", () => {
    if (hoverMenu == 2) {
        changeAttribute(addCoinButton, addRewardButton, addCoinText, addRewardText);
        addCoinImage.src = "../assets/add-coin-black.png";
        addRewardImage.src = "../assets/add-reward-white.png";
        hoverMenu = 1;
    }
})

addCoinButton.addEventListener("mouseleave", () => {
    changeToDefault(addCoinButton);
})

addRewardButton.addEventListener("mouseover", () => {
    if (hoverMenu == 1) {
        changeAttribute(addRewardButton, addCoinButton, addRewardText, addCoinText);
        addCoinImage.src = "../assets/add-coin-white.png";
        addRewardImage.src = "../assets/add-reward-black.png";
        hoverMenu = 2;
    }
})

addRewardButton.addEventListener("mouseleave", () => {
    changeToDefault(addRewardButton);
})

logoutButton.addEventListener("mouseover", () => {
    logoutButton.style.backgroundColor = "#FCCF00";
    logoutText.style.color = "black";
    logoutText.style.fontWeight = "bold";
})

logoutButton.addEventListener("mouseleave", () => {
    logoutButton.style.backgroundColor = "transparent";
    logoutText.style.color = "white";
    logoutText.style.fontWeight = "400";
})


function multipleChange(){
    if (!multipleSelected) {
        multipleSelected = true;
    } else {
        multipleSelected = false;
    }
}

function changeColCoinAttr(element) {
    let id = element.getAttribute("data-id");
    let len = peopleSelected.length;
    let isExist = false;
    if (multipleSelected) {
        for (let i = 0; i < len; i++) {
            if (peopleSelected[i] == id) {
                isExist = true;
                var index = peopleSelected.indexOf(id);
                peopleSelected.splice(index, 1);

                index = elementSelected.indexOf(element);
                elementSelected.splice(index, 1);
            }
        }
        if (!isExist) {
            element.classList.add("selected-card-people");
            peopleSelected.push(id);
            elementSelected.push(element);
        } else {
            element.classList.remove("selected-card-people");
        }

    } else {
        if (len == 1) {
            if (peopleSelected[0] == id) {

                var index = peopleSelected.indexOf(id);
                peopleSelected.splice(index, 1);

                index = elementSelected.indexOf(element);
                elementSelected.splice(index, 1);

                element.classList.remove("selected-card-people");
            }
        } else {
            element.classList.add("selected-card-people");
            peopleSelected.push(id);
            elementSelected.push(element);
        }
    }
    console.log(peopleSelected);
    console.log(elementSelected);
}

function multipleChange() {
    if (!multipleSelected) {
        multipleSelected = true;
    } else {
        //sisakan 1 selected
        let len = peopleSelected.length;
        for (let i = len; i >= 2; i--) {
                     
            elementSelected[i - 1].classList.remove("selected-card-people");

            elementSelected.pop();
            peopleSelected.pop();

            console.log(peopleSelected);
        }

        multipleSelected = false;
    }
}