let currentStep = 1;
const totalSteps = 2;

function validateCurrentStep() {
    const form = $("form");
    const stepLogin = $("#step" + currentStep); // match your HTML IDs

    let valid = true;

    stepLogin.find("input, select, textarea").each(function () {
        if (!form.validate().element(this)) {
            valid = false;
        }
    });

    return valid;
}

function nextStepLogin() {
    if (!validateCurrentStep()) return;

    if (currentStep < totalSteps) {
        currentStep++;
        showStepLogin();
    }
}

function showStepLogin() {
    $(".step-login").removeClass("active");
    $("#step" + currentStep).addClass("active");

    if (currentStep === totalSteps) {
        $("#nextBtn-login").hide();
        $("#submitBtn-login").show();
    } else {
        $("#nextBtn-login").show();
        $("#submitBtn-login").hide();
    }
}

$(document).ready(function () {
    showStepLogin(); // corrected function name
});

$("form").on("submit", function (e) {
    if (!validateCurrentStep()) {
        e.preventDefault();
        return false;
    }
});