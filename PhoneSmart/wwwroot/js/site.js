// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Dropdown One
document.getElementById('dropdown-one').addEventListener('change', function () {
    console.log('You selected: ', event.target.value);

    fetch(`/PhoneModels/CompareViewOne/${event.target.value}`)
        .then(r => r.json())
        .then((phoneforCompareOne) => {

            console.log(phoneforCompareOne)
        })
});
// Dropdown Two
document.getElementById('dropdown-two').addEventListener('change', function () {
    console.log('You selected: ', event.target.value);
});
