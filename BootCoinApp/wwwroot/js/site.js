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
var path = window.location.pathname;
var page = path.split("/").pop();

var hoverMenu = 1;
var currMenu = 2;

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

//addCoinImage.addEventListener("click", () => {
//    currMenu = 1;
//    changeToDefault(addCoinButton);
//})

//addCoinText.addEventListener("click", () => {
//    currMenu = 1;
//    changeToDefault(addCoinButton);
//})

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

//addRewardImage.addEventListener("click", () => {
//    console.log("masuk reward img click");
//    currMenu = 2;
//    changeToDefault(addRewardButton);
//})

//addRewardText.addEventListener("click", () => {
//    currMenu = 2;
//    changeToDefault(addRewardButton);
//})

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