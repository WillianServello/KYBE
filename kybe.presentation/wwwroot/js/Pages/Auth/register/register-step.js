let currentStep = 1;
const totalSteps = 3;

function validateCurrentStep() {

    const form = $("form");
    const step = $("#step" + currentStep);

    let valid = true;

    step.find(
        "input, select, textarea"
    ).each(function () {

        if (
            !form.validate()
                .element(this)
        ) {

            valid = false;

        }

    });

    return valid;

}

function nextStep() {

    if (
        !validateCurrentStep()
    ) {
        return;
    }

    if (
        currentStep < totalSteps
    ) {

        currentStep++;

        showStep();

    }

}

function showStep() {

    $(".step")
        .removeClass(
            "active"
        );

    $("#step" + currentStep)
        .addClass(
            "active"
        );

    // último passo

    if (
        currentStep === totalSteps
    ) {

        $("#nextBtn")
            .hide();

        $("#submitBtn")
            .show();

    }
    else {

        $("#nextBtn")
            .show();

        $("#submitBtn")
            .hide();

    }

}

$(document)
    .ready(function () {

        showStep();

    });

$("form").on(
    "submit",
    function (e) {

        if (
            !validateCurrentStep()
        ) {

            e.preventDefault();

            return false;

        }

    });