// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Phone One

// Phone One Image
const PhoneImages = singlePhone => {
    return `<img src="${singlePhone.phoneURL}" class="img-fluid rounded d-flex justify-content-center mx-auto " alt="...">`
}

// Dropdown One
document.getElementById('dropdown-one').addEventListener('change', function () {

    fetch(`/PhoneModels/CompareViewOne/${event.target.value}`)
        .then(r => r.json())
        .then((phoneforCompareOne) => {

            console.log(phoneforCompareOne)

            // Phone Images
            document.querySelector("#compare-image-one").innerHTML = PhoneImages(phoneforCompareOne);
        })
});
// Dropdown Two
document.getElementById('dropdown-two').addEventListener('change', function () {

    fetch(`/PhoneModels/CompareViewOne/${event.target.value}`)
        .then(r => r.json())
        .then((phoneforCompareTwo) => {


            // Phone Images
            document.querySelector("#compare-image-two").innerHTML = PhoneImages(phoneforCompareTwo);
        })


});
