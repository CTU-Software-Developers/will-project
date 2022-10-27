function appear() {
    document.getElementById("textdata").required = true;
    document.getElementById("wrap-popup-window-area").style.display = "block";
}

function disappear() {
    document.getElementById("textdata").required = false;
    document.getElementById("wrap-popup-window-area").style.display = "none";
}