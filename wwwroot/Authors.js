document.querySelector("#load-authors-button").addEventListener("click",
    async function () {
    var response = await fetch("authors-list", { method: "GET" });
    var html = await response.text();
    document.querySelector("#list").innerHTML = html;
});