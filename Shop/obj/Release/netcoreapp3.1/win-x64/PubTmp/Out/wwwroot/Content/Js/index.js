function openUserDropDown() {
    var dropdown = document.getElementById("user-dropdown-main")
    var display = dropdown.style.display
    if (display == "block") {
        dropdown.style.display = "none"
    }
    else {
    dropdown.style.display="block"
    }
}