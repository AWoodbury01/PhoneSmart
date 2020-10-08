// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Phone One

// Phone One Image
const PhoneImages = singlePhone => {
    return `<img src="${singlePhone.phoneURL}" class="img-fluid rounded d-flex justify-content-center mx-auto " alt="..." style=" object-fit: fill;">`
}
// Phone One OS
const PhoneOS = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.os}</p>`
}
// Phone One Display Size
const PhoneDisplaySize = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.displaySize}</p>`
}
// Phone One Display Type
const PhoneDisplayType = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.displayType}</p>`
}
// Phone One Refresh Rate
const PhoneRefreshRate = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.refreshRate}</p>`
}
// Phone One Ram
const PhoneRam = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.ram}</p>`
}
// Phone One Battery
const PhoneBattery = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.battery}</p>`
}
// Phone One Wireless Charge
const PhoneWirelessCharge = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.isWirelessCharge}</p>`
}
// Phone One Water Resist
const PhoneWaterResist = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.isWaterResist}</p>`
}
// Phone One Main Cam
const PhoneMain = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.mainCam}</p>`
}
// Phone One Secondary Cam
const PhoneSecondary = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.secondaryCam}</p>`
}
// Phone One Front Cam
const PhoneFront = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.frontCam}</p>`
}
// Phone One Security
const PhoneSecurity = singlePhone => {
    return `<p class="d-flex justify-content-center mx-auto">${singlePhone.security}</p>`
}



// Dropdown One Fetch
document.getElementById('dropdown-one').addEventListener('change', function () {

    fetch(`/PhoneModels/CompareViewOne/${event.target.value}`)
        .then(r => r.json())
        .then((phoneforCompareOne) => {


            // Phone Images
            document.querySelector("#compare-image-one").innerHTML = PhoneImages(phoneforCompareOne);
            // Phone OS
            document.querySelector("#compare-os-one").innerHTML = PhoneOS(phoneforCompareOne);
            // Phone Display Size
            document.querySelector("#compare-display-size-one").innerHTML = PhoneDisplaySize(phoneforCompareOne);
            // Phone Display Type
            document.querySelector("#compare-display-type-one").innerHTML = PhoneDisplayType(phoneforCompareOne);
            // Phone Refresh Rate
            document.querySelector("#compare-refresh-rate-one").innerHTML = PhoneRefreshRate(phoneforCompareOne);
            // Phone Refresh Rate
            document.querySelector("#compare-ram-one").innerHTML = PhoneRam(phoneforCompareOne);
            // Phone Battery
            document.querySelector("#compare-battery-one").innerHTML = PhoneBattery(phoneforCompareOne);
            // Phone Wireless Charge
            document.querySelector("#compare-wireless-charge-one").innerHTML = PhoneWirelessCharge(phoneforCompareOne);
            // Phone Water Resist
            document.querySelector("#compare-water-one").innerHTML = PhoneWaterResist(phoneforCompareOne);
            // Phone Main Cam
            document.querySelector("#compare-main-one").innerHTML = PhoneMain(phoneforCompareOne);
            // Phone Secondary Cam
            document.querySelector("#compare-secondary-one").innerHTML = PhoneSecondary(phoneforCompareOne);
            // Phone Front Cam
            document.querySelector("#compare-front-one").innerHTML = PhoneFront(phoneforCompareOne);
            // Phone Security
            document.querySelector("#compare-security-one").innerHTML = PhoneSecurity(phoneforCompareOne);

        })
});
// Dropdown Two Fetch
document.getElementById('dropdown-two').addEventListener('change', function () {

    fetch(`/PhoneModels/CompareViewOne/${event.target.value}`)
        .then(r => r.json())
        .then((phoneforCompareTwo) => {


            // Phone Images
            document.querySelector("#compare-image-two").innerHTML = PhoneImages(phoneforCompareTwo);
            // Phone OS
            document.querySelector("#compare-os-two").innerHTML = PhoneOS(phoneforCompareTwo);
            // Phone Display Size
            document.querySelector("#compare-display-size-two").innerHTML = PhoneDisplaySize(phoneforCompareTwo);
            // Phone Display Type
            document.querySelector("#compare-display-type-two").innerHTML = PhoneDisplayType(phoneforCompareTwo);
            // Phone Refresh Rate
            document.querySelector("#compare-refresh-rate-two").innerHTML = PhoneRefreshRate(phoneforCompareTwo);
            // Phone Refresh Rate
            document.querySelector("#compare-ram-two").innerHTML = PhoneRam(phoneforCompareTwo);
            // Phone Battery
            document.querySelector("#compare-battery-two").innerHTML = PhoneBattery(phoneforCompareTwo);
            // Phone Wireless Charge
            document.querySelector("#compare-wireless-charge-two").innerHTML = PhoneWirelessCharge(phoneforCompareTwo);
            // Phone Water Resist
            document.querySelector("#compare-water-two").innerHTML = PhoneWaterResist(phoneforCompareTwo);
            // Phone Main Cam
            document.querySelector("#compare-main-two").innerHTML = PhoneMain(phoneforCompareTwo);
            // Phone Secondary Cam
            document.querySelector("#compare-secondary-two").innerHTML = PhoneSecondary(phoneforCompareTwo);
            // Phone Front Cam
            document.querySelector("#compare-front-two").innerHTML = PhoneFront(phoneforCompareTwo);
            // Phone Security
            document.querySelector("#compare-security-two").innerHTML = PhoneSecurity(phoneforCompareTwo);
        })


});
