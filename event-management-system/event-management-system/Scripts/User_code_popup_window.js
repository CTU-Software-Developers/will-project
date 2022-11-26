function access_popup() {
    document.getElementById('wrap-popup-window-area').style.display = "block";
    document.getElementById("textdata").required = true;
}

function hide_popup_box() {
    document.getElementById("textdata").required = false;
    document.getElementById("wrap-popup-window-area").style.display = "none";
}