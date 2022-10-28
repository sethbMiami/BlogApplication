// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function encodeImageFileAsURL(element) {
    let file = element.files[0];
    let reader = new FileReader();
    reader.onloadend = function () {
        console.log('RESULT: ', reader.result);
        var blogImage = document.getElementById("BlogImage")
        blogImage.value = reader.result;

         
        var preview = document.getElementById("file-ip-1-preview");
        preview.src = reader.result;
            preview.style.display = "block";
    }
    reader.readAsDataURL(file);
}

function showPreview(event, _element) {
    encodeImageFileAsURL(_element);
    //if (event.target.files.length > 0) {
    //    var src = URL.createObjectURL(event.target.files[0]);
    //    var preview = document.getElementById("file-ip-1-preview");
    //    preview.src = src;
    //    preview.style.display = "block";

    
}