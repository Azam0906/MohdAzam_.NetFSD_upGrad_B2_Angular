const body = document.body;
const button = document.getElementById("toggleTheme");

// load saved theme
const savedTheme = localStorage.getItem("theme");
if (savedTheme) {
    body.className = savedTheme;
} else {
    body.className = "light";
}

button.addEventListener("click", function () {
    if (body.classList.contains("light")) {
        body.className = "dark";
        localStorage.setItem("theme", "dark");
    } else {
        body.className = "light";
        localStorage.setItem("theme", "light");
    }
});