// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function toggleSidebar() {

    const sidebar = document.getElementById("sidebar");

    sidebar.classList.toggle("active");

}

function toggleMenuUser() {

    const menuUser = document.getElementById("home-user-menu");
    const arrowUser = document.getElementById("user-arrow");

    menuUser.classList.toggle("user-active");
    arrowUser.classList.toggle("arrow-rotate");

}